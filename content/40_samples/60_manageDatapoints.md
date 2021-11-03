# Manage datapoints and subscriptions

```
NOTE:
Sample are written in C# and uses nuget package RestSharp for convenience.
baseUrl for local access : http://<ipaddress>
baseUrl for cloud access : https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/gateway/<edgeid>
```


## How to read a DataPoint ?

This sample shows how to read a single datapoint instance value  from openBOS&reg;.


To read the value from a specific DataPoint use the route<br/>
`GET : {{baseUrl}}/api/v1/ontology/datapointinstance/livedata`


As a parameter you give an array of the datapoint unique identifier to be read

```csharp
    // Read a specific datapoint instance, result will be DatapointInstanceValueDTO[]
    var readResponse = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/datapointinstance/livedata?id={dpid1}&id={dpid2}")).Data;
```

Result value will be an array of read result DatapointInstanceValueDTO[]
```json
  [  
    {
      "id": "unique identifier of the datapoint",
      "value": "the value of the datapoint",
      "quality": "quality of the datapoint (none / good / bad)",
      "innerError": "error occured while reading a datapoint",
      "timeStamp": "date time of when datapoint has been read"
    }
  ]
```

## How to write a DataPoint value?

This sample will show how to write a value on a specific datapoint.

A datapoint is uniquely identified by its unique id.
To write a value to a specific DataPoint use the route<br/>
`POST : /api/v1/ontology/datapointinstance/livedata`<br/>
As a parameter you give an array of DatapointInstanceWriteDTO[] containing the value that will be written for each DataPoint.

A single DatapointInstanceWriteDTO item would look as follow:
```json
  {
    "id": "unique identifier of the datapoint",
    "value": "value to be written"
  }
```

 Example:
```json
[
  {
    "id": "d64e237c-3caf-4703-885b-8f5c5ec6b1f9",
    "value": 25
  }
]
```

```csharp
    var writeRequest = new RestRequest($"{baseUrl}/api/v1/ontology/datapointinstance/livedata", Method.POST, DataFormat.Json);
    List<dynamic> writeBody = new List<dynamic>
    {
        new
        {
            id = {dataPointInstanceId},
            value = 20
        }
    };
    writeRequest.AddJsonBody(writeBody);
    var writeResponse = client.Execute<dynamic>(writeRequest).Data; // result of type DatapointInstanceWriteResultDTO[]
```

The result value will be an array of DatapointInstanceWriteResultDTO.
```json
[
  {
    "id": "unique identifier of the datapoint",
    "errorCode": "error code of the write operation",
    "innerError": "error occured while reading a datapoint",
  }
]
```

## How do I subscribe to any datapoint value change?

This sample explains how to create a subscription to be notified of value change on a specific datapoint.
The sample uses SignalR technology.

Using local access on the Building edge.

```csharp

    // Define callback where the value event will arrive
    Action<JsonElement> receiveNotificationHandler = (JsonElement data) =>
    {
      // Output the datapoint value change
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
    // Keep in memory the connection id of the channel taht will be used to identify where subscription must relay the event
    string connectionId = await connection.InvokeAsync<string>("ConnectionId");

    // Subscribe to specific datapoint instance value
    var subRequest = new RestRequest($"{baseUrl}/api/datapointsubscription", Method.POST, DataFormat.Json);
    dynamic subBody =
        new
        {
            keepAllChanges = true, // all changes
            minSendTime = 0, // minimum time between sending event
            maxSendTime = 0, // maximum time between sending event
            connectionId = connectionId, // connectionId retrieved after the connection is build
            items = new List<dynamic>  // List of datapoint instances subscribed
            {
                new
                {
                    datapointInstanceId = "{datapoint-instance-id}",
                    scanRate = 1000,
                    deadband = 0
                }
            },
        };
    subRequest.AddJsonBody(subBody);
    var subscriptionResponse = client.Execute<dynamic>(subRequest);

    // Value change event will be relayed in the callback method when a value will change

```


When using access from cloud:

```csharp

  // Define callback where the value event will arrive
  Action<JsonElement> receiveNotificationHandler = (JsonElement data) =>
  {
    // Output the datapoint value change
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

    var subRequest = new RestRequest($"{baseUrl}/api/datapointsubscription", Method.POST, DataFormat.Json);
    // Subscribe to specific datapoint instance value
    subRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json; charset=utf-8"; };
    dynamic subBody =
        new
        {
            keepAllChanges = true, // all changes
            minSendTime = 0, // minimum time between sending event
            maxSendTime = 0, // maximum time between sending event
            connectionId = connectionId, // connectionId retrieved after the connection is build
            items = new List<dynamic>  // List of datapoint instances subscribed
            {
                new
                {
                    datapointInstanceId = "{datapoint-instance-id}",
                    scanRate = 1000,
                    deadband = 0
                }
            },
        };
    subRequest.AddJsonBody(subBody);
    var subscriptionResponse = client.Execute<dynamic>(subRequest);

    // Value change event will be relayed in the callback method when a value will change
```