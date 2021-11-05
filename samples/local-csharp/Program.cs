using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using RestSharp;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Diagnostics;

namespace CSHttpClientSample
{
    public class NotificationDTO
    {

        public NotificationDTO(string notificationIdentifier)
        {
            this.NotificationIdentifier = notificationIdentifier;
        }

        private NotificationDTO()
        {
        }

        /// <summary>
        /// Identifier of the subscription.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Tags copied from the subscription definition.
        /// </summary>
        public string[] Tags { get; set; }

        /// <summary>
        /// Subscription service identifier
        /// </summary>
        public string NotificationIdentifier { get; set; }
    }

    static class Program
    {
        static string bearerToken = "";
        static string baseUrl = "";
        static string password = "";
        static string login = "";
        static void Main(string[] args)
        {
            if ( args.Contains("-?")){
                System.Console.WriteLine("Exemple:");
                System.Console.WriteLine("      csharp-tutorial http://abcdef -l Admin -p adminpassword");
                Console.ReadKey();
                return;
            }

            if ( args!=null&& args?.Length>0 ){
                baseUrl = args[0];
                for (int i = 1; i < args.Length; i++)
                {
                    if ( args[i].ToUpper() == "-P")                
                        password = args.Length>=i+1?args[i+1]:"";
                    else if ( args[i].ToUpper() == "-L")
                        login = args.Length>=i+1?args[i+1]:"";
                }
            }

            if ( string.IsNullOrEmpty(baseUrl)) {
                System.Console.WriteLine("Missing baseUrl");
                return;
            }
            if ( string.IsNullOrEmpty(login)) {
                System.Console.WriteLine("Missing Login");
                return;
            }
            if ( string.IsNullOrEmpty(password)) {
                System.Console.WriteLine("Missing Password");
                return;
            }

            Task.Run(() =>
            {
                AsyncMain();
            });

            Console.ReadKey();
        }

        private static RestSharp.RestClient GetRestSharpClient()
        {
            var client = new RestSharp.RestClient();

            Dictionary<string, string> body = new Dictionary<string, string>
            {
                ["login"] = login,
                ["password"] = password
            };

            var request = new RestRequest($"{baseUrl}/api/authentication", Method.POST, DataFormat.Json);
            request.AddJsonBody(body);
            var response = client.Execute<dynamic>(request);
            var jObject = JObject.Parse(response.Content);
            bearerToken = jObject["access_token"].Value<string>();
            client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
            return client;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        static void AsyncMain()
        {
            var client = GetRestSharpClient();

            string dataPointInstanceId=null;

            var test = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/subscription")).Data;


            #region TrendInstance
            {
                Console.WriteLine("Reading TrendInstance");

                dynamic trendInstancesFromCore = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/trend")).Data;
                dynamic trendInstances = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/trend/advanced")).Data;

                Debug.Assert(((IEnumerable<dynamic>)trendInstancesFromCore).Count() == ((IEnumerable<dynamic>)trendInstances).Count());

                foreach (var trendInstance in trendInstances)
                {
                    string id = trendInstance["id"];
                    dataPointInstanceId = trendInstance["datapointId"];
                    Console.WriteLine($"Trend instance : {id}");
                    dynamic trendValuesObject =
                        client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/trend/{id}/values?trendPeriodType=RealTime")).Data;
                    IEnumerable<dynamic> trendValues = trendValuesObject["values"];

                    Console.WriteLine($"Values count : {trendValues.Count()}");
                    foreach (dynamic value in trendValues)
                    {
                        Console.WriteLine($"{value["timeStamp"]}:{value["value"]}");
                    }
                    break;
                }
            }
            #endregion

            if (!string.IsNullOrEmpty(dataPointInstanceId))
                SubscriptionTestLocal.Run(baseUrl, bearerToken, dataPointInstanceId);

            #region LiveAlarms
            {
                Console.WriteLine("Reading current alarms");

                dynamic liveAlarms = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/livealarms")).Data;

                foreach (var liveAlarm in liveAlarms)
                {
                    Console.WriteLine($"Timestamp : {liveAlarm["timeStamp"]}");
                    Console.WriteLine($"DataPointName : {liveAlarm["dataPointName"]}");
                    Console.WriteLine($"AlarmInstanceName : {liveAlarm["alarmInstanceName"]}");
                    Console.WriteLine($"Active: {liveAlarm["active"]}");
                    Console.WriteLine($"Closed: {liveAlarm["closed"]}");
                    Console.WriteLine($"Acked : {liveAlarm["acked"]}");
                }
            }
            #endregion

            var response = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/property"));
            {
                // Get the list of assets 
                Console.WriteLine("Assets");
                IRestResponse fbtResp = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/functionalblocktemplate"));
                dynamic functionalBlockTemplates = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/functionalblocktemplate")).Data;
                foreach (var fbTemplate in functionalBlockTemplates)
                {
                    Console.WriteLine(fbTemplate["name"]);
                    dynamic assets = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/functionalblock?filter=TemplateId = \"{fbTemplate["id"]}\"")).Data;
                    foreach (var asset in assets)
                    {
                        Console.WriteLine(asset["name"] ?? string.Empty);
                    }
                }
            }

            #region Spaces
            {
                dynamic spaces = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/space")).Data;
                foreach (dynamic space in spaces)
                {
                    List<dynamic> matchingDps = new List<dynamic>();
                    var spaceDetail = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/zone/{space["id"]}")).Data;
                    foreach (var fb in spaceDetail["functionalBlocks"])
                    {
                        var functionalBlock = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/functionalBlock/{fb["functionalBlockId"]}")).Data;
                        var dp = ((List<dynamic>)functionalBlock["datapoints"]).FirstOrDefault<dynamic>(dd => dd["tags"].Contains("$$point:hvac:fanspeed_0to10v"));
                        if (dp != null)
                        {
                            matchingDps.Add(new { id = dp["id"], value = 100 });
                        }
                    }
                    var writeRequest = new RestRequest($"{baseUrl}/api/datapointinstance/livedata", Method.POST, DataFormat.Json);
                    writeRequest.AddJsonBody(matchingDps);
                    var writeResponse = client.Execute<dynamic>(writeRequest).Data;
                }
            }
            #endregion

            #region Users
            {
                // Collect users with role owner
                dynamic owners = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/user?type=Owner")).Data;

                if (owners.Count > 0)
                {
                    // To display the rights available for a user. Read the user detail. And ask for its AccessRights
                    dynamic userDetail = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/user/{owners[0]["id"]}")).Data;

                    Console.WriteLine("Details for : " + userDetail["name"]);
                    Console.WriteLine("AccessRights are : " + userDetail["accessRights"]);

                    // Display user Roles
                    void DisplayRole(string roleId)
                    {
                        if (string.IsNullOrEmpty(roleId)) return;
                        dynamic roleDetail = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/role/{roleId}")).Data;
                        Console.WriteLine("Role Name : " + roleDetail["name"]);
                        DisplayRole(roleDetail["parentId"]);
                    }

                    foreach (var role in userDetail["roleIds"])
                    {
                        DisplayRole(role);
                    }
                }

            }
            #endregion

            #region Core
            static IEnumerable<dynamic> BuildTree(IEnumerable<dynamic> collection, string root_id = "")
            {
                var list = collection.Where(c => (string.IsNullOrEmpty(root_id) && c["parentIds"].Count == 0) || c["parentIds"].Contains(root_id)).ToList();
                var results = new List<dynamic>();
                foreach (var c in list)
                {
                    results.Add(new
                    {
                        Item = c,
                        Children = BuildTree(collection, c["id"])
                    });
                }
                return results;
            }

            var zones = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/zone/hierarchy")).Data;
            var tree = BuildTree(zones);

            #endregion

            #region Ontology
            {
                response = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/property"));

                Console.WriteLine("Reading property details");
                Console.WriteLine("address1 :" + response.Data["address1"]?.ToString());
                Console.WriteLine("address2 :" + response.Data["address2"]?.ToString());
                Console.WriteLine("gpsLat :" + response.Data["gpsLat"]?.ToString());
                Console.WriteLine("gpsLon :" + response.Data["gpsLon"]?.ToString());

                Console.WriteLine("Reading list of building inside the property");
                var buildings = client.Execute<dynamic>(new RestRequest($"{baseUrl}/{response.Data["buildings"]}"));

                Console.WriteLine($"Buildings count : {buildings.Data.Count}");
                foreach (dynamic building in buildings.Data)
                {
                    Console.WriteLine(building["name"]);

                    var detailledBuilding = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/building/{building["id"]}")).Data;

                    Console.WriteLine("Reading list of facade within the first building");
                    var facades = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/structure?typeStructure=facade&filter=underzone \"{detailledBuilding["id"]}\""));
                    Console.WriteLine($"Facades count : {facades.Data?.Count}");
                    if (facades.Data != null)
                    {
                        foreach (dynamic facade in facades.Data)
                        {
                            Console.WriteLine("Facade name:" + facade["name"]);
                        }
                    }

                    var structuresResponse = client.Execute<dynamic>(new RestRequest($"{baseUrl}/{detailledBuilding["structures"]}"));
                    Console.WriteLine($"Structures count : {structuresResponse.Data?.Count}");

                    if (structuresResponse.Data != null)
                    {
                        IEnumerable<dynamic> structures = structuresResponse.Data;
                        foreach (dynamic structure in structures)
                        {
                            Console.WriteLine("Structure name:" + structure["name"]);
                        }

                        Console.WriteLine($"Facades count : {structures.Where(onestructure => onestructure["tags"].Contains("$$structure:facade")).Count()}");
                        Console.WriteLine($"Floors count : {structures.Where(onestructure => onestructure["tags"].Contains("$$structure:floor")).Count()}");
                        foreach (var floor in structures.Where(onestructure => onestructure["tags"].Contains("$$structure:floor")))
                        {
                            var floorDetail = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/structure/{floor["id"]}")).Data;
                            var spaces = client.Execute<dynamic>(new RestRequest($"{baseUrl}/{floorDetail["spaceChildren"]}")).Data;

                            var mapView = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/mapview?zoneId={floor["id"]}")).Data;
                            if (mapView != null)
                            {
                                var mapViewGraphics = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/mapview/{mapView[0]["id"]}/graphics")).Data;
                                Console.WriteLine($"Number of graphical items : {mapViewGraphics?.Count}");
                            }

                            Console.WriteLine($"Spaces count : {spaces?.Count}");
                        }
                    }

                }
            }
            #endregion

            #region Core
            {
                Console.WriteLine("Using core objects");

                dynamic buildings = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/zone?filter=Tags contains \"$$building\"")).Data;
                foreach (var building in buildings)
                {
                    Console.WriteLine($"Building name : {building["name"]}");
                    IEnumerable<dynamic> floors = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/zone?filter=underzone \"{building["id"]}\" and Tags contains \"$$structure:floor\"")).Data;
                    Console.WriteLine($"Floors count : {floors.Count()}");
                    foreach (dynamic floor in floors)
                    {
                        var spaces = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/core/zone?filter=underzone \"{floor["id"]}\" and Tags contains \"$space:\"")).Data;
                        Console.WriteLine($"Spaces count : {spaces?.Count}");
                    }
                }
            }
            #endregion

            Console.WriteLine("\n\nHit ENTER to exit...");
        }
    }

}
