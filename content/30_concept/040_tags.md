# Tags: a core concept to understand

openBOS&reg; is a building ontology. Every element is tagged and auto describing for the application to understand the object to be manipulated. We are indeed offering a global tagging system for the whole objects of the ontology: building types, building usage, space type, asset type, datapoints type and units,...
openBOS&reg; is organized internally with tags. The ontology is based on that complete information model that describes the information and contextualizes it. This mechanism is based on standard tags that may be used for interoperability between applications. Basic objects are the same and they are contextualized with a list of tags you may access via an API endpoints per object.
It is important to understand and study the tag mechanism. The standard tags of openBOS&reg; start with "bos:". Then followed by the Family and subfamily. ALL object is tagged and can be retrieved by its TAG so basically its function and usage.

Example: a floor object is basically a space object in the structure family being a floor=> tag is "bos:space:structure:floor".

We have TAGS family for structure of a building


|  |   |   |  |  |   |
|--|-|--|--|--|---|
|  | |  |  |  |   |
|Space|	Structure|	|	Building, Floor, roof, facade, ground, basement, paring, exterior|
|Space|	Physical space	|Area	|Lobby, Entrance, Commercial Area, Dining Area, Atrium	Coworking, Waiting hall, Warehouse, Library	Reception, Worship area, Lounge
|Space|	Physical space	|Room	|Office, Meeting Room, Hotel Room, Bathroom, Restroom, Kitchen, Laundry, Locker, Classroom, Controlroom, Courtroom, Cloakroom, Showroom, Waiting room, Storage
|Space|	Physical space	|Exterior|	Terrace, Garden, Forecourt, Patio, Courtyard|
|Space|	Physical space	|Parking|	Parking Standard, Parking for Electrical Vehicles, Parking Disabled|
|Space|	Physical space	|Circulation|	Corridor, Staircase, Hallway, Exit Passage, Elevator, Walkway, Escalator|
|Space|	Technical space	|	| Electrical Cabinet, IT Bay, Technical Room, Technical Area, Dry Riser, Cables Raceway, Server room, Data room, Electrical room, Mechanical room|

But also for type and usage

|  |   |   |
|--|-|--|
|site|	Type|	Residential, Commercial with partial occupation, Commercial with continuous occupation, Industrial, Storage, Mercantil, Other |
|	|Usage| 	Bar, Cabins & Cottage, Casino, Cinema, College, Fire Station, Government, Hotel & Motel, Industry, Leisure, Library, Mall, Medical Nursing Home, Medical Laboratory & Research, Military, Mixed Usage, Museum, Office, Parking, Pharmacy, Police Station, Religious, Retail, Restaurant, School, Stadium, Transport, University, Warehouse, Wholesale|

In that documentation, the list of associated standard TAGS are available at the end of the description.

IMPORTANT: You may add your own tags and use the tag management and filtering engine to handle your information.

The parameters of objects may also be enriched via tags. 
