# Check property

```
NOTE:
Sample are written in C# and uses nuget package RestSharp for convenience.
baseUrl for local access : http://<ipaddress>
baseUrl for cloud access : `https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/gateway/<edgeid>`
```

## How to get information on the property?

This sample shows how to read information from the property defined in the project.
The resource path to be used to get property information is:
`GET {{baseUrl}}/api/v1/ontology/property**` <br/>
It returns the detailed information of the property (PropertyDTO).

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

    // Read detail information on the property
    var resp = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/property")); // Result object is PropertyDTO

    Console.WriteLine("address1 :" + resp.Data["address1"]?.ToString());
    Console.WriteLine("address2 :" + resp.Data["address2"]?.ToString());
    Console.WriteLine("gpsLat :" + resp.Data["gpsLat"]?.ToString());
    Console.WriteLine("gpsLon :" + resp.Data["gpsLon"]?.ToString());

```

Truncated result of the detailed property information PropertyDTO:
```json
 {
  "id": "d64e237c-3caf-4703-885b-8f5c5ec6b1f9",
  "templateId": "PROPERTYTEMPLATE",
  "type": "Physical",
  "address1": "ADDRESS_OF_THE_PROPERTY",
  "address2": "ADDRESS_OF_THE_PROPERTY",
  "town": "CITY",
  "country": "COUNTRY",
  "surfaceGross": SURFACE (INCLUDING WALLS), //-- square feet 
  "surfaceNet": SURFACE (NET), //-- feet squared
  "people": AVERAGE_NUMBER_OF_PEOPLE_ON_SITE, //-- square feet 
  "image": PROPERTY_IMAGE,
  "gpsLat": LATITUDE,
  "gpsLon": LONGDITUDE,
  "buildings": "api/v1/ontology/zone/children/d64e237c-3caf-4703-885b-8f5c5ec6b1f9?childrenType=Building",//further API calls to use for getting the buildings of the property
}
```

### How to get buildings available in a property?

This sample shows how to get the list of buildings that are part of the property in the project and display their names.

List of buildings can be found, via reading first the detailled information from a property:<br/>
`GET : {{baseUrl}}/api/v1/ontology/property` <br/>
It returns the detailed information of the property. From that result use the field "buildings" (looks like: api/v1/ontology/zone/children/[PROPERTY_ID]?childrenType=Building) and make a subsequent call to this URL in order to get the list of building attached to the property.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

    var resp = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/property"));
    Console.WriteLine("Reading list of building inside the property");
    var buildings = client.Execute<dynamic>(new RestRequest($"{baseUrl}/{response.Data["buildings"]}")); // ZoneInstanceInfoDTO[]
    Console.WriteLine($"Buildings count : {buildings.Data.Count}");
    foreach (dynamic item in buildings.Data)
    {
        Console.WriteLine(item["name"]);
        var building = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/building/{item["id"]}")).Data; // BuildingDTO
    }
```

### How to get how many structures, fa&ccedil;ades, roofs are there in my building?

This sample shows for each building how to get the number of items for different type of structures (fa&ccedil;ade, floor, roof) available in the building.

Using  API endpoints of the ontology, the concept is to request all structures that are under the building and filter on tags for the correct structure type "fa&ccedil;ade", "floor", "roof".<br/>
*Note:* A list of available tags for the structure is given in the chapter "References".

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // ...
    dynamic building = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/building/{mybuildingid}")).Data; // BuildingDTO

    // Use sub-property building["structures"] as a next route to query for subfaçades
    var structuresResponse = client.Execute<dynamic>(new RestRequest($"{baseUrl}/{building["structures"]}")); // ZoneInstanceInfoDTO[]

    Console.WriteLine($"Structures count : {structuresResponse.Data?.Count}");
    if (structuresResponse.Data != null)
    {
        IEnumerable<dynamic> structures = structuresResponse.Data;

        Console.WriteLine($"Facades count : {structures.Where(onestructure => onestructure["tags"].Contains("bos:structure:facade")).Count()}");
        Console.WriteLine($"Floors count : {structures.Where(onestructure => onestructure["tags"].Contains("bos:structure:floor")).Count()}");
        Console.WriteLine($"Roofs count : {structures.Where(onestructure => onestructure["tags"].Contains("bos:structure:roof")).Count()}");
    }
```

Using the core routes, the concept is to query the buildings by finding all zones which have the "building" tag.
Then, for each building, query the structures with correct tags that are "underzone" the zone building.
It uses the parameter "filter" with syntax:
  filter=underzone "zoneid" and tags contains "searchedtag"

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // ...
    dynamic buildings = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=Tags contains \"bos:building\"")).Data; // ZoneInstanceInfoDTO[]
    foreach (var building in buildings)
    {
        Console.WriteLine($"Building name : {building["name"]}");
        dynamic facades = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=underzone \"{building["id"]}\" and Tags contains \"bos:structure:facade\"")).Data; // ZoneInstanceInfoDTO[]
        Console.WriteLine($"Facades count : {facades?.Count}");
        dynamic floors = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=underzone \"{building["id"]}\" and Tags contains \"bos:structure:floor\"")).Data; // ZoneInstanceInfoDTO[]
        Console.WriteLine($"Floors count : {floors?.Count}");
        dynamic roofs = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=underzone \"{building["id"]}\" and Tags contains \"bos:structure:roof\"")).Data; // ZoneInstanceInfoDTO[]
        Console.WriteLine($"Roofs count : {roofs?.Count}");
    }

```

### How do I get the floors and their spaces?

This sample reads the floors of the project and collects the list of spaces of a floor.
The sample starts with a well-known buildingid that represents the unique identifier of the building you want to explore.

Using API endpoints of the ontology, the concept is to request the list of structures that are under a building using the sub api path present in the BuildingDTO object.
Then query for the structure type "fa&ccedil;ade", "floor", "roof".

*Note:* A list of available tags is given in the chapter "References".

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // Get detail of Building
    dynamic building = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/building/{mybuildingid}")).Data; // BuildingDTO

    // Use parameter "structures" from BuildingDTO to make next call having the structures of the building
    IEnumerable<dynamic> structures = (IEnumerable<dynamic>)client.Execute<dynamic>(new RestRequest($"{baseUrl}/{building["structures"]}")).Data;

    // filter on floors only
    dynamic floors = structures.Where(onestructure => onestructure["tags"].Contains("bos:structure:floor"));
    foreach(dynamic floor in floors)
    {
      var floorDetail = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/structure/{floor["id"]}")).Data; // StructureDTO

      // Use parameter "spaceChildren" from BuildingDTO to make next call having the structures of the building
      var spaces = client.Execute<dynamic>(new RestRequest($"{baseUrl}/{floorDetail["spaceChildren"]}")).Data;
      Console.WriteLine($"Spaces count : {spaces?.Count}");
    }
```

Using the core routes the concept is to get all floors below a specific building and search for zones with tags ""bos:space" that are below each floor.
```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // Get building zone
    dynamic building = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone/{mybuildingid}")).Data; // ZoneDTO
    // Find floors that are under the building using tag bos:structure:floor
    dynamic floors = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=underzone \"{mybuildingid}\" and Tags contains \"bos:structure:floor\"")).Data; // ZoneInfoDTO[]
    foreach(dynamic floor in floors)
    {
      // Find space that are under the floor using tag bos:space:
      var spaces = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=underzone \"{floor["id"]}\" and Tags contains \"$space:\"")).Data; // ZoneInfoDTO[]
      Console.WriteLine($"Spaces count : {spaces?.Count}");
    }
```

### How do I read the complete hierarchy of my building in one call?

This sample shows how to get the list of zones that are available in the property in a single call and generates a memory tree out of it.
The first call will collect all the zones that are present in the project /api/v1/core/zone/hierarchy.

The BuildTree method will create a tree structure with:

	{
  		Item: --> The current zone
  		Children: --> The list of children zones of the current zone
	}

```csharp
  // Method used to generate a tree structure from a list of zones
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

  // Resulting tree of element containing { Zone, Children }
  // the tags in ZoneInfoDTO[] can then be used to categorise the different type of zone
  var tree = BuildTree(zones);
```

### How do I get the graphical representation of a floor?

This sample reads the graphical representation (mapview) of a floor with its space children and functional blocks.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // ...
    var mapView = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/mapview/{myfloorid}")).Data;
    var mapViewGraphics = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/mapview?zoneId={mapView["id"]}")).Data;
    Console.WriteLine($"Number of graphical items : {mapViewGraphics?.Count}");

    // Each graphical item then has the coordinates where it must be displayed
    // Possible type of mapview items are MapViewElementFBDTO, MapViewElementImageDTO, MapViewElementZoneDTO, MapViewElementTextDTO
```
