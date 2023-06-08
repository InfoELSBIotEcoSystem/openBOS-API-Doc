# Manage property

```
NOTE:
Sample are written in C# and uses nuget package RestSharp for convenience.
baseUrl for local access : http://<ipaddress>
baseUrl for cloud access : `https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/gateway/<edgeid>`
```

## Postman link

You can find other samples in the Postman collection
[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/14996509-f2ab8b96-9c38-4825-ab6f-7022e954deda?action=collection%2Ffork&collection-url=entityId%3D14996509-f2ab8b96-9c38-4825-ab6f-7022e954deda%26entityType%3Dcollection%26workspaceId%3Dea90c3d1-21af-4177-8e72-f21b5ed12326)

## How to get information on the property?

The sample reads the information from the property by calling `GET /api/v1/ontology/property` with a result of type [`PropertyDTO`](../60_references/30_schemas.md#schemapropertydto).

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

    // Read detail information on the property
    var resp = client.Execute<JsonObject>(new RestRequest($"{baseUrl}/api/v1/ontology/property")); // Result object is PropertyDTO

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

The sample reads the property detail as [`PropertyDTO`](../60_references/30_schemas.md#schemapropertydto) by calling `GET /api/v1/ontology/property`. Then reads the URI  for getting list of buildings from [`PropertyDTO`](../60_references/30_schemas.md#schemapropertydto).buildings which retrieves ([`ZoneInstanceInfoDTO[]`](../60_references/30_schemas.md#schemazoneinstanceinfodto)).

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

    var property = client.Execute<JsonObject>(new RestRequest($"{baseUrl}/api/v1/ontology/property")).Data;
    Console.WriteLine("Reading list of building inside the property");
    var buildings = client.Execute<List<JsonObject>>(new RestRequest($"{baseUrl}/{property["buildings"]}")).Data; // ZoneInstanceInfoDTO[]
    Console.WriteLine($"Buildings count : {buildings.Count}");
    foreach (JsonObject item in buildings)
    {
        Console.WriteLine(item["name"]);
        var building = client.Execute<JsonObject>(new RestRequest($"{baseUrl}/api/v1/ontology/building/{item["id"]}")).Data; // BuildingDTO
    }
```

### How to get how many structures, facades, roofs are there in my building?

The sample shows for each building how to get the number of items for different type of structures (facade, floor, roof) available in the building.

The sample reads a building detail ([`BuildingDTO`](../60_references/30_schemas.md#schemabuildingdto)) using `GET /api/v1/ontology/building/{mybuildingid}`, generates a call to get structures by using URI stored in [`BuildingDTO`](../60_references/30_schemas.md#schemabuildingdto).structures that gives a list of type ([`ZoneInstanceInfoDTO[]`](../60_references/30_schemas.md#schemazoneinstanceinfodto)).

We then count on this list of structures theone that matches facade, floor or roof:
  - Number of facade : items having tag `bos:structure:facade`
  - Number of floors : items having tag `bos:structure:floor`
  - Number of roofs : items having tag `bos:structure:roof`

Using  API endpoints of the ontology, the concept is to request all structures that are under the building and filter on tags for the correct structure type "facade", "floor", "roof".<br/>
*Note:* A list of available tags for the structure is given in the chapter "References".

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // ...
    dynamic buildingResp = client.Execute(new RestRequest($"{baseUrl}/api/v1/ontology/building/{mybuildingid}")); // BuildingDTO
    dynamic building = JObject.Parse(buildingResp.Content!);

    // Use sub-property building["structures"] as a next route to query for subfaçades
    var structuresResponse = client.Execute(new RestRequest($"{baseUrl}/{building["structures"]}")); // ZoneInstanceInfoDTO[]
    var structures = JsonConvert.DeserializeObject<List<dynamic>>(structuresResponse.Content!);

    if (structures != null)
    {
        Console.WriteLine($"Facades count : {structures.Where(onestructure => (onestructure["tags"]).ToObject<List<string>>().Contains("bos:structure:facade")).Count()}");
        Console.WriteLine($"Floors count : {structures.Where(onestructure => (onestructure["tags"]).ToObject<List<string>>().Contains("bos:structure:floor")).Count()}");
        Console.WriteLine($"Roofs count : {structures.Where(onestructure => (onestructure["tags"]).ToObject<List<string>>().Contains("bos:structure:roof")).Count()}");
    }
```

### How to get how many structures, facades, roofs are there in my building using only zone concept ?

Using the core zone concept routes, the concept is to query the buildings by finding all zones which have the "building" tag.
Then, for each building, query the structures with correct tags that are "underzone" the zone building.
It uses the parameter "filter" with syntax:
  filter=underzone "zoneid" and tags contains "searchedtag"

The sample reads list of zone ([`ZoneInstanceInfoDTO[]`](../60_references/30_schemas.md#schemazoneinstanceinfodto)) having a `bos:building` tag using `GET /api/v1/ontology/zone?filter=(filter)`. For each building, query the zones ([`ZoneInstanceInfoDTO[]`](../60_references/30_schemas.md#schemazoneinstanceinfodto)) that are "under" that building and contains the correct tag using `GET /api/v1/ontology/zone?filter=underzone "buildingid" and Tags contains "my tag"`:
  - for facade : items having tag `bos:structure:facade`
  - for floors : items having tag `bos:structure:floor`
  - for roofs : items having tag `bos:structure:roof`

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

The sample starts with a well-known mybuildingid and reads the floors then for each their spaces.

The sample reads building detail of type ([`BuildingDTO`](../60_references/30_schemas.md#schemabuildingdto)) using `GET /api/v1/ontology/building/{mybuildingid}`, makes the next call to have the list of structures ([`ZoneInstanceInfoDTO[]`](../60_references/30_schemas.md#schemazoneinstanceinfodto)) under the building using URI available at [`BuildingDTO`](../60_references/30_schemas.md#schemabuildingdto).structures .

From the list of structures it takes only the floors by filtering on tag `bos:structure:floor` and for each floor ([`StructureDTO`](../60_references/30_schemas.md#schemastructuredto)) reads its detail using `GET /api/v1/ontology/structure/{id}`.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    {
        // Get detail of Building
        dynamic building = client.Execute<JsonObject>(new RestRequest($"{baseUrl}/api/v1/ontology/building/{mybuildingid}")).Data; // BuildingDTO

        // Use parameter "structures" from BuildingDTO to make next call having the structures of the building
        var structures = client.Execute<List<JsonObject>>(new RestRequest($"{baseUrl}/{building["structures"]}")).Data;
        // filter on floors only
        dynamic floors = structures.Where(onestructure => (onestructure["tags"].AsArray()).Select(a=>(string)a).ToList().Contains("bos:structure:floor"));
        foreach (dynamic floor in floors)
        {
            var floorDetail = client.Execute<JsonObject>(new RestRequest($"{baseUrl}/api/v1/ontology/structure/{floor["id"]}")).Data; // StructureDTO

            // Use parameter "spaceChildren" from BuildingDTO to make next call having the structures of the building
            var spaces = client.Execute<JsonArray>(new RestRequest($"{baseUrl}/{floorDetail["spaceChildren"]}")).Data;
            Console.WriteLine($"Spaces count : {spaces?.Count}");
        }
    }
```

### How do I get the floors and their spaces using zone concept ?
Using the core routes the concept is to get all floors below a specific building and search for zones with tags "bos:space" that are below each floor.

The sample starts with a well-known mybuildingid and reads the floors then for each their spaces.

The sample reads building detail using `GET /api/v1/ontology/zone/{mybuildingid}` that retrieves [`BuildingDTO`](../60_references/30_schemas.md#schemabuildingdto), makes the next call to have the list of structures ([`ZoneInstanceInfoDTO[]`](../60_references/30_schemas.md#schemazoneinstanceinfodto)) under the building using `GET /api/v1/ontology/zone?filter=underzone "mybuildingid" and Tags contains "bos:structure:floor"`.
From the floors the sample gets the children spaces using `GET /api/v1/ontology/zone?filter=underzone "myfloorid" and Tags contains "bos:space"`.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // Get building zone
    dynamic building = client.Execute<JsonObject>(new RestRequest($"{baseUrl}/api/v1/ontology/zone/{mybuildingid}")).Data; // ZoneDTO
                                                                                                                        // Find floors that are under the building using tag bos:structure:floor
    dynamic floors = client.Execute<List<JsonObject>>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=underzone \"{mybuildingid}\" and Tags contains \"bos:structure:floor\"")).Data; // ZoneInfoDTO[]
    foreach (dynamic floor in floors)
    {
        string url = $"{baseUrl}/api/v1/ontology/zone?filter=underzone \"{floor["id"]}\" and Tags contains \"space:\"";
        // Find space that are under the floor using tag bos:space:
        var spaces = client.Execute<List<JsonObject>>(new RestRequest(url)).Data; // ZoneInfoDTO[]
        Console.WriteLine($"Spaces count : {spaces?.Count}");
    }
```

### How do I read the complete hierarchy of my building in one call?

This sample shows how to get the list of zones that are available in the property in a single call and generates a memory tree out of it.

The first call will collect all the zones that are present in the project `GET /api/v1/core/zone/hierarchy` with result of type ([ZoneInstanceHierarchyDTO[]](../60_references/30_schemas.md#schemazoneinstancehierarchydto)).

The BuildTree method will create a tree structure with:

	{
  		Item: --> The current zone
  		Children: --> The list of children zones of the current zone
	}

```csharp
    // Method used to generate a tree structure from a list of zones
    static IEnumerable<dynamic> BuildTree(IEnumerable<dynamic> collection, string root_id = "")
    {
        var list = new List<dynamic>();

        foreach (JsonObject item in collection)
        {
            if (string.IsNullOrEmpty(root_id) && item["parentIds"].AsArray().Count == 0) { list.Add(item); continue; }
            if (item["parentIds"].AsArray().Select(a => (string)a).ToList().Contains(root_id)) { list.Add(item); continue; }
        }
        var results = new List<dynamic>();
        foreach (var c in list)
        {
            results.Add(new
            {
                Item = c,
                Children = BuildTree(collection, (string)c["id"])
            });
        }
        return results;
    }
    var zones = client.Execute<List<JsonObject>>(new RestRequest($"{baseUrl}/api/v1/core/zone/hierarchy")).Data;

    // Resulting tree of element containing { Zone, Children }
    // the tags in ZoneInfoDTO[] can then be used to categorise the different type of zone
    var tree = BuildTree(zones);
```

### How do I get the graphical representation of a floor?

This sample reads the graphical representation (mapview graphics) of a floor with its space children and functional blocks.
The sample gets the detail of a mapview by calling `GET /api/v1/ontology/mapview?zoneId=<zoneId>` which returns ([MapViewDTO[]](../60_references/30_schemas.md#schemamapviewdto)) of a specific zone identifier `mygroundid`.

Then it reads the graphical representation of it using `GET {baseUrl}/api/v1/ontology/mapview/{mapView[0]["id"]}/graphics` which returns [MapViewElementBaseDTO[]](../60_references/30_schemas.md#schemamapviewelementbasedto) where each item can be [MapViewElementFBDTO[]](../60_references/30_schemas.md#schemamapviewelementfbdto) or [MapViewElementZoneDTO[]](../60_references/30_schemas.md#schemamapviewelementzonedto) or [MapViewElementTextDTO[]](../60_references/30_schemas.md#schemamapviewelementtextdto) or [MapViewElementImageDTO[]](../60_references/30_schemas.md#schemamapviewelementimagedto).

Coordinates system:
 - the coordinates of the mapview are expressed in an orthonormal basis with fractional coordinates { x: [0,1], y: [0,1] }
 - the origin (0;0) is at left top 
 - the value 1 is bound to the larger extend (width or height). For example, for a landscape map with aspect ratio 4:3, on y, the bottom boundary will be 3/4.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // ...
    var mapView = client.Execute<List<JsonObject>>(new RestRequest($"{baseUrl}/api/v1/ontology/mapview?zoneId={mygroundid}")).Data;
    var mapViewGraphics = client.Execute<List<JsonObject>>(new RestRequest($"{baseUrl}/api/v1/ontology/mapview/{mapView[0]["id"]}/graphics")).Data;
    Console.WriteLine($"Number of graphical items : {mapViewGraphics?.Count}");

    // Each graphical item then has the coordinates where it must be displayed
    // Possible type of mapview items are MapViewElementFBDTO, MapViewElementImageDTO, MapViewElementZoneDTO, MapViewElementTextDTO
```
