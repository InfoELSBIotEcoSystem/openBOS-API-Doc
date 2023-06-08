# Manage schedulers

```
NOTE:
Sample are written in C# and uses nuget package RestSharp for convenience.
baseUrl for local access : `http://<ipaddress>`
baseUrl for cloud access : `https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/gateway/<edgeid>`
```
## Postman link

You can find other samples in the Postman collection
[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/14996509-f2ab8b96-9c38-4825-ab6f-7022e954deda?action=collection%2Ffork&collection-url=entityId%3D14996509-f2ab8b96-9c38-4825-ab6f-7022e954deda%26entityType%3Dcollection%26workspaceId%3Dea90c3d1-21af-4177-8e72-f21b5ed12326)


## How to get the list of all schedulers configured for a specific zone ? 

The sample retrieves the schedule that are configured to be executed on a specific zone.
It calls `GET /api/v1/ontology/schedule/inzone/{id}` which returns [ScheduleInstanceInfoDTO[]](../60_references/30_schemas.md#schemascheduleinstanceinfodto).

```csharp
    // Read the schedules that are active for a zone
    var subRequest = new RestRequest($"{baseUrl}/api/v1/ontology/schedule/inzone/{zoneId}");
    var schedules = client.Execute<JsonArray>(subRequest).Data;
```

## How to change the timetable of a schedule? 
Scheduler trigger ACTIONS on TIMETABLES. 

The sample reads detail of a schedule using `GET /api/v1/ontology/schedule/{id}` which returns [ScheduleInstanceDTO](../60_references/30_schemas.md#schemascheduleinstancedto). It displays the list of available actions ([ActionDTO](../60_references/30_schemas.md#schemaactiondto)) defined for the schedule.
Finally it configures the execution of a specific action at 07:00 in the morning only the wednesday using the [ScheduleDateEntryDayOfWeekDTO](../60_references/30_schemas.md#schemascheduledateentrydayofweekdto) model and updating new timetable through `PUT /api/v1/ontology/schedule/{id}/timetable`.

```csharp
    // Read detail of Schedule (ScheduleInstanceDTO)
    var subRequest = new RestRequest($"{baseUrl}/api/v1/ontology/schedule/{scheduleId}", Method.Get);
    var detail = client.Execute<JsonObject>(subRequest).Data;

    // List possible actions on scheduler and displays their name
    string firstAction="";
    foreach ( JsonObject item in (JsonArray)detail["configurationActions"])
    {
        if ( string.IsNullOrEmpty(firstAction))
        {
            firstAction = (string)item["id"];
        } 
        await Console.Out.WriteLineAsync((string)item["name"]);
    }

    // Find the entry for ANY wednesday
    JsonObject wednesday = (JsonObject)((JsonArray)detail["timetable"]["weeklyTimeTable"]).Where(
        x=> ((string)x["dtoType"]) == "DayOfWeek" && 
            ((int)x["dayOfWeek"]) == 3).First();

    // Set an action for 07:00
    var newAction = new JsonObject();
    newAction["configurationActionId"] = firstAction;
    newAction["timestamp"] = 420; // 420 minutes from 00:00 = 07:00 in the morning
    wednesday["times"] = new JsonArray()
    {
        newAction
    };
    // Update the timetable of the scheduler
    subRequest = new RestRequest($"{baseUrl}/api/v1/ontology/schedule/{scheduleId}/timetable", Method.Put);
    subRequest.AddBody(detail["timetable"]);

    var result = client.Execute<JsonObject>(subRequest);
```

## How to create an exception? 
Scheduler may have exception certain days. They are predefined for a week for example but there may be days that are different: national day, vacation, …..  

The sample reads detail of a schedule using `GET /api/v1/ontology/schedule/{id}` which returns [ScheduleInstanceDTO](../60_references/30_schemas.md#schemascheduleinstancedto). It displays the list of available actions ([ActionDTO](../60_references/30_schemas.md#schemaactiondto)) defined for the schedule.
Finally it configures a new exception for the 1st of may every year using the [ScheduleDateEntryExceptionDTO](../60_references/30_schemas.md#schemascheduledateentryexceptiondto) model and updating the new timetable through `PUT /api/v1/ontology/schedule/{id}/timetable`.


```csharp
    var subRequest = new RestRequest($"{baseUrl}/api/v1/ontology/schedule/{scheduleId}", Method.Get);
    var detail = client.Execute<JsonObject>(subRequest).Data;

    string firstAction = "";
    foreach (JsonObject item in (JsonArray)detail["configurationActions"])
    {
        if (string.IsNullOrEmpty(firstAction))
        {
            firstAction = (string)item["id"];
        }
        await Console.Out.WriteLineAsync((string)item["name"]);
    }

    JsonArray exceptions = (JsonArray)detail["timetable"]["exceptions"];

    // Create a new exception of type ScheduleDateEntryExceptionDTO
    var newException = new JsonObject();
    newException["dtoType"] = "Exception";
    newException["type"] = "SingleDate";

    newException["name"] = "A new exception";

    // Sets active the 1st of may every year
    var startDate = new JsonObject();
    startDate["day"] = 1;
    startDate["month"] = 5;

    newException["start"] = startDate;

    var newAction = new JsonObject();
    newAction["configurationActionId"] = firstAction;
    newAction["timestamp"] = 420; // 420 minutes from 00:00 = 07:00 in the morning
    newException["times"] = new JsonArray() { newAction };
    exceptions.Add(newException);

    subRequest = new RestRequest($"{baseUrl}/api/v1/ontology/schedule/{scheduleId}/timetable", Method.Put);
    subRequest.AddBody(detail["timetable"]);

    // Update the timetable
    var result = client.Execute<JsonObject>(subRequest);

```

## Possible type of exceptions

Possible exception type are :
 - SingleDate
 - RangeDate
 - WeekOfMonth

The format of a SingleDate will be of type [ScheduleDateEntryExceptionDTO](../60_references/30_schemas.md#schemascheduledateentryexceptiondto) with type set to "SingleDate". Json format is as follow:

```json
{
    "dtoType": "Exception",
    "type": "SingleDate",
    "id": "new_xxxx",
    "name": "New Exception",
    "priority": 2,
    "start": {
        "dayOfWeek": null,  // If omitted means any dayOfWeek (0-6 0 is sunday)
        "day": 10,          // If omitted means any day  (1-31; 32 : last day of month)
        "month": 2,         // If omitted means any month (1-12 ; 13 : odd months; 14 : even months)
        "year": 2023       // If omitted means any year
    },
    "times": [
        {
            "id": "new_xxx",
            "configurationActionId": "{id_of_action_to_perform}",
            "timestamp": 720 // In minutes from 00:00
        }
    ]
}
```

The format of a RangeDate will be of type [ScheduleDateEntryExceptionDTO](../60_references/30_schemas.md#schemascheduledateentryexceptiondto) with type set to "RangeDate". Json format is as follow:

```json
{
    "dtoType": "Exception",
    "type": "RangeDate",
    "id": "xxxxx",
    "name": "A new exception",
    "priority": 2,
    "start": {
        "dayOfWeek": null,  // If omitted means any dayOfWeek (0-6 0 is sunday)
        "day": 10,          // If omitted means any day  (1-31; 32 : last day of month)
        "month": 2,         // If omitted means any month (1-12 ; 13 : odd months; 14 : even months)
        "year": 2023       // If omitted means any year
    },
    "end": {
        "dayOfWeek": null,  // If omitted means any dayOfWeek (0-6 0 is sunday)
        "day": 10,          // If omitted means any day  (1-31; 32 : last day of month)
        "month": 1,         // If omitted means any month (1-12 ; 13 : odd months; 14 : even months)
        "year": 2023       // If omitted means any year
    },
    "times": [
        {
            "id": "new_xxx",
            "configurationActionId": "{id_of_action_to_perform}",
            "timestamp": 720 // In minutes from 00:00
        }
    ]
}
```

The format of a WeekOfMonth will be of type [ScheduleDateEntryExceptionDTO](../60_references/30_schemas.md#schemascheduledateentryexceptiondto) with type set to "WeekOfMonth". Json format is as follow:

```json
{
    "dtoType": "Exception",
    "type": "WeekOfMonth",
    "id": "xxxxx",
    "name": "A new exception",
    "priority": 2,
    "start": {
        "day": 10,          // If omitted means any day  (1-31; 32 : last day of month)
        "month": 2,         // If omitted means any month (1-12 ; 13 : odd months; 14 : even months)
        "year": 2023,       // If omitted means any year
        "weekOfMonth": 6    // If omitted means any week (1-5 xxth week; 6 : odd weeks; 7: even weeks)
    },
    "times": [
        {
            "id": "new_xxx",
            "configurationActionId": "{id_of_action_to_perform}",
            "timestamp": 720 // In minutes from 00:00
        }
    ]
}
```

