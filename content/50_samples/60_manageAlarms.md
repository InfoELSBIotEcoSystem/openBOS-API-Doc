# Manage alarms

## Postman link

You can find other samples in the Postman collection
[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/14996509-f2ab8b96-9c38-4825-ab6f-7022e954deda?action=collection%2Ffork&collection-url=entityId%3D14996509-f2ab8b96-9c38-4825-ab6f-7022e954deda%26entityType%3Dcollection%26workspaceId%3Dea90c3d1-21af-4177-8e72-f21b5ed12326)

## Reading alarms that are currently active

This example reads the complete of alarm active in the property by calling `GET /api/v1/ontology/livealarms`
which returns the list of alarms with format [AlarmHistoricDTO[]](../60_references/30_schemas.md#schemaalarmhistoricdto)

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

    Console.WriteLine("Reading current alarms");
    dynamic liveAlarms = client.Execute<JsonArray>(new RestRequest($"{baseUrl}/api/v1/ontology/livealarms")).Data;

    foreach (var liveAlarm in liveAlarms)
    {
        Console.WriteLine($"Timestamp : {liveAlarm["timeStamp"]}");
        Console.WriteLine($"DataPointName : {liveAlarm["dataPointName"]}");
        Console.WriteLine($"AlarmInstanceName : {liveAlarm["alarmInstanceName"]}");
        Console.WriteLine($"Active: {liveAlarm["active"]}");
        Console.WriteLine($"Closed: {liveAlarm["closed"]}");
        Console.WriteLine($"Acked : {liveAlarm["acked"]}");
    }
```

## Reading alarms that are currently active in a specific zone instance

This sample reads the list of floors by calling `GET /api/v1/ontology/zone?filter=Tags contains bos:structure:floor` that retrieves [ZoneInstanceInfoDTO[]](../60_references/30_schemas.md#schemazoneinstanceinfodto), for each floor sample reads the alarm that are active directly attached to the floor by calling `GET /api/v1/ontology/livealarms/zone/{id}` which returns [AlarmHistoricDTO[]](../60_references/30_schemas.md#schemaalarmhistoricdto)

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

    dynamic floors = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/zone?filter=Tags contains \"bos:structure:floor\"")).Data;

    Console.WriteLine("Reading current alarms active floor by floor");
    foreach (var floor in floors){
        dynamic liveAlarms = client.Execute<JsonArray>(new RestRequest($"{baseUrl}/api/v1/ontology/livealarms/zone/{floor["id"]}")).Data;

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
```


## How to subscribe to live alarms ?

This sample explains how to create a subscription to be notified of alarm change on the complete property. The sample uses SignalR technology.

### Using local access on the Building edge.
To subscribe to alarm you must create a SignalR hub connection, creates an alarm subscription using `POST /api/v1/ontology/alarm/subscription` and passing [LiveAlarmSubscriptionDTO](../60_references/30_schemas.md#schemalivealarmsubscriptiondto) that will contain a list of unique identifiers of alarms to be subscribed to.

```csharp

    // Define callback where the alarms event will arrive
    Action<JsonElement> receiveNotificationHandler = (JsonElement data) =>
    {
      // Output the alarm change
      Console.WriteLine(data);
    };

    // Initialize the SignalR hub connection between the client application and the openBOS&reg;
    var url = "{baseUrl}/subscription/";
    var connection = new HubConnectionBuilder()
        .WithUrl(url, options =>
        {
            options.AccessTokenProvider = () => Task.FromResult(bearerToken);
        })
        .WithAutomaticReconnect()
        .AddNewtonsoftJsonProtocol()
        .Build();

    // Attach the previous defined callback to the reception of the signalr event
    connection.On<JsonElement>("Notification", receiveNotificationHandler);

    // Starts notification channel
    await connection.StartAsync();

    // Keep in memory the connection id of the channel that will be used to identify where subscription must relay the event
    string connectionId = await connection.InvokeAsync<string>("ConnectionId");

    // Subscribe to alarm change
    var subRequest = new RestRequest($"{baseUrl}/api/v1/ontology/alarm/subscription", Method.POST, DataFormat.Json);

    // LiveAlarmSubscriptionDTO
    dynamic subBody =
        new
        {
            connectionId = connectionId, // connectionId retrieved after the connection is build
            alarmInstanceIds = new [
                // my alarm instance ids
            ]
        };
    subRequest.AddJsonBody(subBody);
    var subscriptionResponse = client.Execute<dynamic>(subRequest);

    // Value change event will be relayed in the callback method when a new alarm state will change

```


### When using access from cloud:

To subscribe to alarm you must create a SignalR hub connection, creates an alarm subscription using `POST /api/v1/ontology/alarm/subscription` and passing [LiveAlarmSubscriptionDTO](../60_references/30_schemas.md#schemalivealarmsubscriptiondto) that will contain a list of unique identifiers of alarms to be subscribed to.

The difference with the local approach is the URL used to establish the SignalR HubConnection.

```csharp

  // Define callback where the value event will arrive
  Action<JsonElement> receiveNotificationHandler = (JsonElement data) =>
  {
    // Output the alarm change
    Console.WriteLine(data);
  };

  var deviceid = "<mybuildingedgedeviceid>";

    // Initialize the SignalR hub connection between the client application and the openBOS&reg;
  var url = $"https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/events?device={deviceid}";
  var connection = new HubConnectionBuilder()
      .WithUrl(url, options =>
      {
          options.AccessTokenProvider = () => Task.FromResult(bearerToken);
      })
      .WithAutomaticReconnect()
      .Build();

    // Attach the previous defined callback to the reception of the signalr event
    connection.On(deviceid, receiveNotificationHandler);
    // Starts notification channel
    await connection.StartAsync();
    // Keep in memory the connection id of the channel that will be used to identify where subscription must relay the event
    string connectionId = connection.ConnectionId;

    var subRequest = new RestRequest($"{baseUrl}/api/v1/ontology/alarm/subscription", Method.Post);
    // Subscribe to alarm change
    subRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json; charset=utf-8"; };

    // LiveAlarmSubscriptionDTO
    dynamic subBody =
        new
        {
            connectionId = connectionId, // connectionId retrieved after the connection is build
            alarmInstanceIds = new [
                // my alarm instance ids
            ]
        };
    subRequest.AddBody(subBody);
    var subscriptionResponse = client.Execute<dynamic>(subRequest);

    // Alarm event will be relayed in the callback method when aa alarm state will change
```

## How to create an alarm instance ?

Here is an example on to create an alarm that will trigger when the fieldbus value is higher than 1.

To create the alarm you use `POST {baseUrl}/api/v1/ontology/alarm` and pass an [AlarmInstanceCreationDTO](../60_references/30_schemas.md#schemaalarminstancecreationdto) object that will contain the type of alarm and the identification of the datapoint ([DatapointIdentifierDTO](../60_references/30_schemas.md#schemadatapointidentifierdto)) on which the alarm will be created.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

    // Create an alarm instance using AlarmInstanceCreationDTO
    var subRequest = new RestRequest($"{baseUrl}/api/v1/ontology/alarm", Method.Post);
            dynamic subBody =
                new
                {
                    frequency = 300000, // polling frequency
                    datapoint = new
                    {
                        // An object representing the datapoint identifier that will be used for the alarm
                    },
                    deadband = 0,  // Value deadband
                    hysteresis = 0, // Alarm hysteresis
                    needAcknowledge = false,// Indicates whether the alarm needs to be acknowledged to disappear
                    triggers = new dynamic[] { // Indicates the algorithm that will trigger the alarm
                    new {
                        name= "", // Name of the trigger
                        severity= "High", // Severity of the alarm 
                        type= "AlarmTriggerValueDTO", 
                        description= "This is my alarm message",
                        threshold= "1"
                    }
                }
                };
    subRequest.AddBody(subBody);
    var subscriptionResponse = client.Execute<JsonObject>(subRequest);

```

## How to update an alarm instance ?

To update an alarm instance you use `PUT /api/v1/ontology/alarm/{alarmId}` and passes the updated object of type [AlarmInstanceDTO](../60_references/30_schemas.md#schemaalarminstancedto) which is previously retrieved from `GET /api/v1/ontology/alarm/{alarmId}`.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

    var subRequest = new RestRequest($"{baseUrl}/api/v1/core/alarm{alarmId}", Method.Get);
    // Retrieve AlarmInstanceDTO
    var alarmDetail = client.Execute<JsonObject>(subRequest).Data;
    alarmDetail["triggers"][0]["threshold"] = 10;
    var subRequest = new RestRequest($"{baseUrl}/api/v1/core/alarm/{alarmId}", Method.Put);
    // Send AlarmInstanceDTO
    subRequest.AddBody(alarmDetail);
    var subscriptionResponse = client.Execute<JsonObject>(subRequest);

```

## List of possible triggers

### AlarmTriggerDigitalOFFDTO
Object is as follow [AlarmTriggerDigitalOFFDTO](../60_references/30_schemas.md#schemaalarmtriggerdigitaloffdto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggerdigitaloffdto", 
        "description"= "This is my alarm message"
    }
```

### AlarmTriggerDigitalONDTO
Object is as follow [AlarmTriggerDigitalONDTO](../60_references/30_schemas.md#schemaalarmtriggerdigitalondto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggerdigitalondto", 
        "description"= "This is my alarm message"
    }
```

### AlarmTriggerHiDTO

Object is as follow [AlarmTriggerHiDTO](../60_references/30_schemas.md#schemaalarmtriggerhidto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggerhidto", 
        "description"= "This is my alarm message",
        "threshold"= "1" // Hi level that triggers alarm
    }
```

### AlarmTriggerHiHiDTO
Object is as follow [AlarmTriggerHiHiDTO](../60_references/30_schemas.md#schemaalarmtriggerhihidto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggerhihidto", 
        "description"= "This is my alarm message",
        "threshold"= "1" // HiHi level that triggers alarm
    }
```

### AlarmTriggerLoDTO
Object is as follow [AlarmTriggerLoDTO](../60_references/30_schemas.md#schemaalarmtriggerlodto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggerlodto", 
        "description"= "This is my alarm message",
        "threshold"= "1" // Low level that triggers alarm
    }
```

### AlarmTriggerLoLoDTO
Object is as follow [AlarmTriggerLoLoDTO](../60_references/30_schemas.md#schemaalarmtriggerlolodto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggerlolodto", 
        "description"= "This is my alarm message",
        "threshold"= "1" // LoLo level that triggers alarm
    }
```

### AlarmTriggerNetworkDTO
Object is as follow [AlarmTriggerNetworkDTO](../60_references/30_schemas.md#schemaalarmtriggernetworkdto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggernotvaluedto", 
        "description"= "This is my alarm message"
    }
```

### AlarmTriggerNotValueDTO
Object is as follow [AlarmTriggerNotValueDTO](../60_references/30_schemas.md#schemaalarmtriggernotvaluedto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggernotvaluedto", 
        "description"= "This is my alarm message",
        "threshold"= "1" // If fieldbus value is not equal to this value then an alarm is raised
    }
```
### AlarmTriggerInBandDTO
Object is as follow [AlarmTriggerInBandDTO](../60_references/30_schemas.md#schemaalarmtriggerinbanddto)
```json
    {
        "index"= 1 or 2, // You can create 2 triggers with inband
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggeroutofbanddto", 
        "description"= "This is my alarm message",
        "thresholdLower"= "1", // If fieldbus value greater than this value and lower than thresholdUpper then alarm is raised
        "thresholdUpper"= "10", 
    }
```

### AlarmTriggerOutOfBandDTO
Object is as follow [AlarmTriggerOutOfBandDTO](../60_references/30_schemas.md#schemaalarmtriggeroutofbanddto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggeroutofbanddto", 
        "description"= "This is my alarm message",
        "thresholdLower"= "1", // If fieldbus value lower than this value or upper than thresholdUpper then alarm is raised
        "thresholdUpper"= "10", 
    }
```

### AlarmTriggerValueDTO
Object is as follow [AlarmTriggerValueDTO](../60_references/30_schemas.md#schemaalarmtriggervaluedto)
```json
    {
        "name"= "", // Name of the trigger
        "severity"= "High", // Severity of the alarm 
        "type"= "alarmtriggervaluedto", 
        "description"= "This is my alarm message",
        "threshold"= "1"  // If fieldbus value equals this value then an alarm is raised
    }
```

