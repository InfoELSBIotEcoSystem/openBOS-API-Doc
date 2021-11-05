using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CSHttpClientSample
{
    class SubscriptionTestLocal
    {
        static public async void Run(string baseUrl, string bearerToken, string dataPointInstanceId)
        {
            Console.WriteLine("Start subscription tests");
            var client = new RestSharp.RestClient();

            client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

            Action<System.Text.Json.JsonElement> receiveNotificationHandler = (System.Text.Json.JsonElement data) =>
            {
                Console.WriteLine(data);
            };
            var url = $"{baseUrl}/api/v1/core/subscription/";
            var connection = new HubConnectionBuilder()
                .WithUrl(url, options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(bearerToken);
                })
                .WithAutomaticReconnect()
                .Build();

            connection.On("Notification", receiveNotificationHandler);

            await connection.StartAsync();
            string connectionId = connection.ConnectionId;
            {
                var request = new RestRequest($"{baseUrl}/api/datapointinstance/livedata?id={dataPointInstanceId}");
                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json; charset=utf-8"; };
                IRestResponse<dynamic> readResponse = client.Execute<dynamic>(request);
                var readResponseData = readResponse.Data;
            }
            {
                var writeRequest = new RestRequest($"{baseUrl}/api/datapointinstance/livedata", Method.POST, DataFormat.Json);
                List<dynamic> writeBody = new List<dynamic>
            {
                new
                {
                    id = dataPointInstanceId,
                    value = 20
                }
            };
                writeRequest.AddJsonBody(writeBody);
                var writeResponse = client.Execute<dynamic>(writeRequest).Data;
            }

            var subRequest = new RestRequest($"{baseUrl}/api/datapointsubscription", Method.POST, DataFormat.Json);
            subRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json; charset=utf-8"; };
            dynamic subBody =
                new
                {
                    keepAllChanges = true,
                    minSendTime = 0,
                    maxSendTime = 0,
                    connectionId = connectionId,
                    items = new List<dynamic>
                    {
                        new
                        {
                            datapointInstanceId = dataPointInstanceId,
                            scanRate = 1000,
                            deadband = 0
                        }
                    },
                };
            subRequest.AddJsonBody(subBody);
            var subscriptionResponse = client.Execute<dynamic>(subRequest);
            await Task.Delay(10000);

            Console.WriteLine("\n\nHit ENTER to exit the subscription test...");
            Console.ReadKey();
        }

    }
}
