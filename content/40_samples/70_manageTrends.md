# Manage trend values on datapoint

```
NOTE:
Sample are written in C# and uses nuget package RestSharp for convenience.
baseUrl for local access : `http://<ipaddress>`
baseUrl for cloud access : `https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/gateway/<edgeid>`
```

## How to read trend values stored for a DataPoint?

This sample shows how to read trend values from openBOS&reg;.

To read trend values use the route<br/>
`GET : {{baseUrl}}/api/v1/ontology/trend/{id}/values`

"id", is the unique identifier is the trend instance id linked to the datapoint.

```csharp
    // Read a trend instance values result will be TrendValuesResultDTO
    var readResponse = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/trend/{id}/values?trendPeriodType=RealTime")).Data;
```

Result value will be an array of read result TrendValuesResultDTO[]
```json
{ 
  "downSamplingId": "unique identifier of the down sampling that has generated the values",
  "values":[
    {
      "value": "the value of the datapoint",
      "quality": "quality of the datapoint (none / good / bad)",
      "timeStamp": "date time of when datapoint has been read",
      "min": "minimum value on the period (meaningful only if trendPeriodType <> RealTime)",
      "max": "maximum value on the period (meaningful only if trendPeriodType <> RealTime)",
      "totalPoints": "Number of values that has been collected on the period (meaningful only if trendPeriodType <> RealTime)"
    }
  ]
}
```

## How to filter the trend value query on specific date time ?
To indicate a filter query on the date you can specify the from/to argument.
Unique identifier is the trend instance id linked to the datapoint.

```csharp
    // Read a trend instance values result will be TrendValuesResultDTO
    var readResponse = client.Execute<dynamic>(new RestRequest($"{baseUrl}/trend/{id}/values?trendPeriodType=RealTime&from=2021-07-05T13%3A48%3A02.933%2B00%3A00&to=2021-07-05T14%3A08%3A02.933%2B00%3A00")).Data;
```

from / to arguments are DateTime + offset format: <year>-<month>-<day>T<hour>:<minute>:<second>.<msec><timezone>
Example of supported format is : 2021-07-05T13:48:02.933+00:00
