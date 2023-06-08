# Advanced filtering

## Available endpoints
Filtering query mechanism is available for some GET endpoints. Find the list below:

|Endpoint|Description|Paging|Filtering|InZone|HasTemplate|
|-|-|-|-|-|-|
|api/v1/ontology/role| List of user roles |x|x|||
|api/v1/ontology/zonetemplate| List of area/space/zone templates |x|x|||
|api/v1/ontology/zone| List of area/space/zone instances |x|x|x|x|
|api/v1/ontology/functionalblocktemplate| List of functional block template |x|x||x|
|api/v1/ontology/functionalblock| List of functional block instances |x|x|x|x|
|api/v1/ontology/trendtemplate| List of trend templates |x||||
|api/v1/ontology/trend| List of trend instances |x|x|||
|api/v1/ontology/alarmtemplate| List of alarm templates |x||||
|api/v1/ontology/alarm| List of alarm instances |x||||

# How to use paging ?

The paging system uses 2 parameters called `offset` and `limit`.
The parameters can be part of the query or can be put in the header with same name.

By default if no value is set for limit then the openBOS will try to return everything in one call.

When using paging, to loop and obtain for example the complete list of zones you will apply the following:

- 1st call : GET `api/v1/ontology/zone`?limit=100&offset=0
- 2nd call : GET `api/v1/ontology/zone`?limit=100&offset=100
- ...

until no more returned items or returned element if less than `limit`.

# How to filter ?

## Basic example
Example filtering the zone that contains a string "My name".
`api/v1/ontology/zone`?filter=Name contains "My name"

Example filtering the zone that contains a string "My name" or "Other name".
`api/v1/ontology/zone`?filter=(Name contains "My name") OR (Name contains "Other name") 

## Available object property to filter on

In the current version the filtering mechanism is available for properties :
 - Id
 - Name
 - Template
 - Tags

## Available filtering operators
### Logical operators:
|Operator|Description|
|-|-|
|AND|Logical AND. ie : condition = condition 'and' condition|
|OR|Logical OR. ie : condition = condition 'or' condition|

### Binary operator:
|Operator|Description|
|-|-|
|!|Not operator|

### Standard operators:
|Operator|Description|
|-|-|
|=|Equals|
|<>|NotEquals|
|>|Greater than |
|>=|Greater or equal than |
|<|Less than |
|<=|Less or equal than |
|startswith|Property string starts with |
|contains| Contains. available for string and list|
|notcontains|Not contains. available for string and list|

NOTE: When operator "contains" or "notcontains" are used on the property Tags the search will look inside each tag in the list and apply contain operator for each tag individually.
Example : for a query `Tags contains "bos:structure` will return all items that will have at least 1 tag that contains `"bos:structure"`

### Special operators
|Operator|Description|
|-|-|
|hastemplate|Indicates whether the object inherit from a specific template. Possible usage for these operators are : ("<testedId>" or "name:<testedName>")|
|inzone|Indicates whether an fb or a zone belongs to another zone. |

