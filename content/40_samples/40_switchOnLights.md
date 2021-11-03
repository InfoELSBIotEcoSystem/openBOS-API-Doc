# Switch on all lights of a specific office in a building

```
NOTE:
Sample are written in C# and uses nuget package RestSharp for convenience.
baseUrl for local access : http://<ipaddress>
baseUrl for cloud access : `https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/gateway/<edgeid>`
```

## How to find a zone by name?

This example shows how to find a specific zone instance in the project by simply searching by its name.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // Find a zone instance by name within the project
    dynamic zoneInstance = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=Name contains \"John Doe\"")).Data; // ZoneInstanceDTO
    Console.WriteLine(zoneInstance[0]["id"]);

```

## How to pilot the lamps of a specific office?

This sample shows how you get the list of functional blocks inside a specific zone and write the value "off" for each datapoint of type light on/off.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // ...
    List<dynamic> matchingDps = new List<dynamic>();
    // Get usage of the id of the zone you want to pilot
    var spaceDetail = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone/{space["id"]}")).Data;
    foreach (var fb in spaceDetail["functionalBlocks"])
    {
      // Read detail information of a functionalblock with its datapoints
      var functionalBlock = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/functionalblock/{fb["functionalBlockId"]}")).Data;
      // Filter the list of datapoints with a valid light on off model
      var dp = ((List<dynamic>)functionalBlock["datapoints"]).FirstOrDefault<dynamic>(dd => dd["tags"].Contains("bos:point:light:on_off"));
      if ( dp != null)
      {
        // Add new value to write
        matchingDps.Add(new { id = dp["id"], value = "Off" });
      }
    }

    // Generate the write operation on all lamps of the office
    var writeRequest = new RestRequest($"{baseUrl}/api/datapointinstance/livedata", Method.POST, DataFormat.Json);
    writeRequest.AddJsonBody(matchingDps);
    var writeResponse = client.Execute<dynamic>(writeRequest).Data;
```

## How to retrieve all the assets of the template "light on/off"?

This example will search through the list of asset templates if there is one that  matches the light dimming model.
From this light dimming model the example will collect all the asset instances that are linked to this specific template.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // ...
    // Get the one with correct light on/off tag from the list of assets 
    dynamic assetTemplate = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/functionalblocktemplate?filter=Tags contains \"bos:function:comfort:light:on_off\"")).Data;
    Console.WriteLine(assetTemplate[0]["name"]);

    // Using the asset template id get all the asset instances matching this template
    dynamic assets = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/functionalblock?filter=TemplateId = \"{assetTemplate[0]["id"]}\"")).Data;
    foreach (var asset in assets)
    {
        Console.WriteLine(asset["name"]??string.Empty);
    }
```
