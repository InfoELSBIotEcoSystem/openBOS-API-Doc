# Tags for building spaces


| Tag | Space name | Description | Array JSon Name | Where it can be used | Properties |
| :---  | :---  | :---  | :---  | :---  | :---  |
| bos:property | Site | Identifies a structural space as site | ##structuralSpaces | ZoneInstance | bos:info:address:address1<br/>bos:info:address:address2<br/>bos:info:address:town<br/>bos:info:address:country<br/>bos:info:GPSlat<br/>bos:info:GPSlon<br/>bos:info:surface_gross<br/>bos:info:people<br/>bos:site:type:xxxx<br/>bos:structure:usage:xxxx |
| bos:building | Building | Identifies a structural space as building | ##structuralSpaces | ZoneInstance | bos:info:surface_gross<br/>bos:info:surface_net<br/>bos:info:people<br/>bos:structure:usage:xxxx|
| bos:structure:floor | Floor | Identifies a structural space as floor | ##structuralSpaces | ZoneInstance | bos:info:surface_gross<br/>bos:info:surface_net<br/>bos:info:people<br/>bos:structure:usage:xxxx<br/>bos:info:level|
| bos:structure:roof | Roof | Identifies a structural space as roof | ##structuralSpaces | ZoneInstance | bos:info:surface_gross<br/>bos:info:surface_net<br/>bos:info:people<br/>bos:structure:usage:xxxx<br/>bos:info:level|
| bos:structure:facade | Facade | Identifies a structural space as façade | ##structuralSpaces | ZoneInstance | bos:info:surface_gross<br/>bos:structure:usage:xxxx|
| bos:structure:ground | Ground | Identifies a structural space as ground | ##structuralSpaces | ZoneInstance | bos:info:surface_gross<br/>bos:info:surface_net<br/>bos:info:people<br/>bos:structure:usage:xxxx<br/>bos:info:level=0|
| bos:structure:basement | Basement | Identifies a structural space as basement | ##structuralSpaces | ZoneInstance | bos:info:surface_gross<br/>bos:info:surface_net<br/>bos:info:people<br/>bos:structure:usage:xxxx<br/>bos:info:level|
| bos:structure:parking | Parking | Identifies a structural space as parking | ##structuralSpaces | ZoneInstance | bos:info:surface_gross<br/>bos:info:surface_net<br/>bos:structure:usage:xxxx<br/>bos:info:level|
| bos:structure:exterior | Exterior | Identifies a structural space as exterior | ##structuralSpaces | ZoneInstance | bos:info:surface_gross<br/>bos:info:surface_net<br/>bos:info:people<br/>bos:structure:usage:xxxx<br/>bos:info:level|
| bos:space:area:lobby | Lobby | Identifies a space as an area of type lobby | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:entrance | Entrance | Identifies a space as an area of type entrance | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:commercial_area | Commercial<br/>Area | Identifies a space as a commercial area such as a retail space | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:dining_area | Dining<br/>Area | Identifies a space as a dining area | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:atrium | Atrium | Identifies a space as an atrium usually <br/>involving skylight and generous glazing areas | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:coworking | Coworking | Identifies a space as a coworking area | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:waiting_hall | Waiting<br/>hall | Identifies a space as a waiting area,<br/> like in a railway station, airport or bus station | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:warehouse | Warehouse | Identifies a space as a warehouse area | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:library | Library | Identifies a space as a library used to store <br/>papers, documents, books, films etc. | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:reception | Reception | Identifies a space as a reception | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:area:worship | Worship<br/>area | Identifies a space as a place of worship for <br/>devotion, prayer or meditation, small services and counseling services|
| bos:space:area:lounge | Lounge | Identifies a space as a lounge for relaxing or waiting|
| bos:space:room:office | Office | Identifies a space as a room of type office | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:room:meeting_room | Meeting<br/>Room | Identifies a space as a room of type meeting room | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:room:hotel_room | Hotel<br/>Room | Identifies a space as a room of type hotel room | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:room:bathroom | Bathroom | Identifies a space as a bathroom for residential areas, <br/>which may include a toilet |   |   ||
| bos:space:room:restroom | Restroom | Identifies a space as a restroom for commercial areas, <br/>providing toilets and lavatories | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:room:kitchen | Kitchen | Identifies a space as a room of type kitchen | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:room:laundry | Laundry | Identifies a space as a room of type laundry room |   |   |   |
| bos:space:room:locker | Locker | Identifies a space as a room of type locker room |   |   ||
| bos:space:room:class | Classroom | Identifies a space as a room of type classroom |   |   ||
| bos:space:room:controlroom | Controlroom | Identifies a space as a room of type controlroom |   |   ||
| bos:space:room:courtroom | Courtroom | Identifies a space as a room of type courtroom |   |   | |
| bos:space:room:cloakroom | Cloakroom | Identifies a space as a room of type cloakroom |   |   | |
| bos:space:room:cloakroom | Showroom | Identifies a space as a showroom |   |   ||
| bos:space:room:waiting_room | Waiting<br/>room | Identifies a space as a waiting room like in a doctor's office |   |   ||
| bos:space:room:storage | Storage | Identifies a space as a general storage space for merchandise,<br/> materials, equipment or paper with no particular HVAC needs |   |   | |
| bos:space:exterior:terrace | Terrace | Identifies a space as an exterior of type terrace | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor |   |   |
| bos:space:exterior:garden | Garden | Identifies a space as an exterior of type garden | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor |   |   | |
| bos:space:exterior:forecourt | Forecourt | Identifies a space as an exterior of type forecourt | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor |   |   | |
| bos:space:exterior:patio | Patio | Identifies a space as an exterior of type patio | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor |   |   | |
| bos:space:exterior:courtyard | Courtyard | Identifies a space as an exterior of type<br/> courtyard | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor |   |   |
| bos:space:space:parking | Parking<br/>Standard | Identifies a space as a parking of type<br/> standard parking | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor |   |   | |
| bos:space:parking:parking_standard | Parking<br/>Standard | Identifies a space as a parking of type <br/>standard parking | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor |   |   | |
| bos:space:parking:parking_EV | Parking for<br/>Electrical Vehicles | Identifies a space as a parking of type<br/> parking for electrical vehicles | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:parking:parking_disabled | Parking<br/>Disabled | Identifies a space as a parking of type <br/>parking for disabled people | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor|
| bos:space:circulation:corridor | Corridor | Identifies a space as a circulation of type corridor | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor||
| bos:space:circulation:staircase | Staircase | Identifies a space as a circulation of type staircase | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor ||
| bos:space:circulation:hallway | Hallway | Identifies a space as a circulation of type hallway | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor ||
| bos:space:circulation:exit_passage | Exit<br/>Passage | Identifies a space as a circulation of type exit passage | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:circulation:elevator | Elevator | Identifies a space as a circulation of type elevator | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:circulation:walkway | Walkway | Identifies a space as a circulation of type walway | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:circulation:escalator | Escalator | Identifies a space as a circulation of type escalator | ##physicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:technical:electrical_cabinet | Electrical<br/>Cabinet | Identifies a technical space as an electrical cabinet | ##technicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:technical:IT_bay | IT Bay | Identifies a technical space as an IT bay | ##technicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:technical:technical_room | Technical<br/>Room | Identifies a technical space as a technical room | ##technicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:technical:technical_area | Technical<br/>Area | Identifies a technical space as a technical area | ##technicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:technical:dry_riser | Dry<br/>Riser | Identifies a technical space as a dry riser | ##technicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:technical:cables_raceway | Cables<br/>Raceway | Identifies a technical space as a cables raceway | ##technicalSpaces | ZoneInstance | bos:info:indoor_outdoor | |
| bos:space:technical:server_room | Server<br/>room | Identifies a technical space as server room |   |   |   |
| bos:space:technical:data_room | Data<br/>room | Identifies a technical space as data room |   |   |  |
| bos:space:technical:electrical_room | Electrical<br/>room | Identifies a technical space as electrical room |   |   | |
| bos:space:technical:electrical_room | Mechanical<br/>room | Identifies a technical space as mechanical room |   |   | |
