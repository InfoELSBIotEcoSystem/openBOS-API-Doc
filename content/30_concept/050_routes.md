# Basic rules for API endpoints and DTOs

The openBOS&reg; API follows very simple rules:  
openBOS&reg; gives access to datapoints you may read and/or write. A datapoint may be a field or computed datapoint from a sensor/actuator (DATAPOINT) with a live 
value or may be a parameter of an object (PROPERTYDATAPOINT) with a database value.  

openBOS&reg; offers endpoints to access a collection of entities and endpoints to access a single entity. 
The endpoints targeting a collection will retrieve a list of entities and for each the minimal payload of each entity.
On the other hand, the endpoints targeting a single entity will retrieve the full payload of the entity.

In the reference documentation, you are able to distinguish minimal payload from full payload by the name of the schema object definition retrieved. 
If the schema object name definition ends with "InfoDTO", then the retrieved data will be of minimal payload type.
