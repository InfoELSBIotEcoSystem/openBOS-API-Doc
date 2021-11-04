# Limitations and constraints

## Limitations for using API endpoints

You basically have no limitation in the API endpoints we are offering in this document. You may access the complete ontology (properties, spaces, zones, assets, users, datapoints, maps ...).
The purpose of the API is to be able to develop apps on  top of a configured system. If you would like to go one step ahead and configure a Building edge, then please [contact us](mailto:it.el.electrification.digital@abb.com).

## Limitations for HTTP requests

The API is configured with the following throttling limitations. In case an application registration or signed-in user reaches the below mentioned limits, the API responds with an HTTP Error Code 429 with a maximum retry-after value of 300&nbsp;seconds.
-	on user level: 750 requests per 300 seconds per user (to allow bursty traffic)
-	on client-ID level: 10.000 requests per application id and hour

If the limit is exceeded, the API responds with Error Code 429 and retry-after period of 300 seconds.