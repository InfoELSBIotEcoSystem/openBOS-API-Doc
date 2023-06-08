# Switch on all lights of a specific office in a building

```
NOTE:
Sample are written in C# and uses nuget package RestSharp for convenience.
baseUrl for local access : http://<ipaddress>
baseUrl for cloud access : `https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/gateway/<edgeid>`
```

## Postman link

You can find other samples in the Postman collection
[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/14996509-f2ab8b96-9c38-4825-ab6f-7022e954deda?action=collection%2Ffork&collection-url=entityId%3D14996509-f2ab8b96-9c38-4825-ab6f-7022e954deda%26entityType%3Dcollection%26workspaceId%3Dea90c3d1-21af-4177-8e72-f21b5ed12326)

## How to find a zone by name?

This example shows how to find a specific zone instance in the project by simply searching by its name.

The sample gets the list of zone by calling `GET /api/v1/ontology/zone?filter=Name contains "searched name"` which retrieves zoneInstance result is of type [`ZoneInstanceInfoDTO[]`](../60_references/30_schemas.md#schemazoneinstanceinfodto)
```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // Find a zone instance by name within the project
    dynamic zoneInstance = client.Execute<JsonArray>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=Name contains \"John Doe\"")).Data; // ZoneInstanceDTO
    Console.WriteLine(zoneInstance[0]["id"]);

```

## How to pilot the lamps of a specific office?

This sample shows how you get the list of functional blocks inside a specific zone and write the value "off" for each datapoint of type light on/off.

The sample retrieved functional block instances ([`FunctionalBlockInstanceDTO[]`](../60_references/30_schemas.md#schemafunctionalblockinstancedto)) from a space by calling `GET /api/v1/ontology/zone/{spaceId}`, reads detail of each functional block by calling `GET /api/v1/ontology/functionalblock/{fbid}`.
The sample then reads [`FunctionalBlockInstanceDTO[]`](../60_references/30_schemas.md#schemafunctionalblockinstancedto).datapoints to filter datapoint with tag equals to "bos:point:light:on_off".
Finaly writes the value by calling `POST /api/datapointinstance/livedata` with [DatapointInstanceWriteDTO](../60_references/30_schemas.md#schemadatapointinstancewritedto) containing datapoint identifier and value to be written.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // ...
    // Get usage of the id of the zone you want to pilot
    var spaceDetail = client.Execute<JsonObject>(new RestRequest($"{baseUrl}/api/v1/ontology/zone/{space["id"]}")).Data;
    foreach (var fb in spaceDetail["functionalBlocks"].AsArray())
    {
        // Read detail information of a functionalblock with its datapoints
        var functionalBlock = client.Execute<JsonObject>(new RestRequest($"{baseUrl}/api/v1/ontology/functionalblock/{fb["functionalBlockId"]}")).Data;
        // Filter the list of datapoints with a valid light on off model
        var dp = functionalBlock["datapoints"].AsArray().FirstOrDefault(dd => dd["tags"].AsArray().Select(a => (string)a).ToList().Contains("bos:point:light:on_off"));
        if (dp != null)
        {
            // Add new value to write
            matchingDps.Add(new { id = dp["id"], value = "Off" });
        }
    }

    // Generate the write operation on all lamps of the office
    var writeRequest = new RestRequest($"{baseUrl}/api/datapointinstance/livedata", Method.Post);
    writeRequest.AddBody(matchingDps);
    var writeResponse = client.Execute<dynamic>(writeRequest).Data;
```

## How to retrieve all the assets of the template "light on/off"?

The sample searches asset templates of light on-off model by calling `GET /api/v1/ontology/functionalblocktemplate?filter=Tags contains "bos:function:comfort:light:on_off"` retrieving  ([`FunctionalBlockTemplateInfoDTO[]`](../60_references/30_schemas.md#schemafunctionalblocktemplateinfodto)).
and lists the asset instances ([`FunctionalBlockInstanceInfoDTO[]`](../60_references/30_schemas.md#schemafunctionalblockinstanceinfodto)) that are linked to this specific template by calling `GET /api/v1/ontology/functionalblock?filter=TemplateId = "templateId"`.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");
    // ...
    // Get the one with correct light on/off tag from the list of assets 
    dynamic assetTemplate = client.Execute<List<JsonObject>>(
      new RestRequest($"{baseUrl}/api/v1/ontology/functionalblocktemplate?filter=Tags contains \"bos:function:comfort:light:on_off\"")).Data;
    Console.WriteLine(assetTemplate[0]["name"]);

    // Using the asset template id get all the asset instances matching this template
    dynamic assets = client.Execute<List<JsonObject>>(new RestRequest($"{baseUrl}/api/v1/ontology/functionalblock?filter=TemplateId = \"{assetTemplate[0]["id"]}\"")).Data;
    foreach (var asset in assets)
    {
        Console.WriteLine(asset["name"]??string.Empty);
    }
```
