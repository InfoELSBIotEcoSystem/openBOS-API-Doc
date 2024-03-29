# ASSET management

## General information
In each ZONE (area or space) there are ASSETS (lamps, button fan, coil, ...) . These ASSETS may belong to one or several 
zones and/or spaces and/or structures, ...

Ex: my lamp above my head belongs to Building 1, floor 4, tenant ABB, John’s office, …. 

Then there are several possible routes: either browse the structure and find the zones and the asset, or browse the collection of asset and find the Zone and Spaces

## Ontology mapping

![Building Assets](../../assets/openbos-documentation/static/images/diagram_asset.png "Building Assets")

## Predefined tags

openBOS is full of semantics and each asset belongs to a family and sub family.

| Family                                           | Sub family                              | Specific                                                                                                                                  |
|-----------------------------------------------|-----------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------|
|                                               |                                         |                                                                                                                                              |
|HVAC|Central|Boiler, Furnace, Chiller Water Cooled, Chiller Air Cooled, Cooling Tower, Rooftop Unit, Variable Refrigerant Flow, Computer Room Air Conditioning, Exchanger, Heat Pump, Air Handling Unit, Computer Room Air Handling |
|HVAC|Terminal|Fan Coil Unit - 2 Pipes, Fan Coil Unit - 2 Pipes with Changeover, Fan Coil Unit - 4 Pipes, Variable Air Volume, Variable Air Volume - Dual Duct, Constant Air Volume, Radiator - Water, Radiator - Electrical, Chilled Beam, Radiant Ceiling, Radiant Floor, Radiant Wall, Split, Packaged Terminal Air Conditioning |
|Comfort|Shutters|Shutters Up/down, Shutters with 3 Adjustable Levels, Shutters with 5 Adjustable Levels, Shutters with 10 Adjustable Levels |
|Comfort|Blinds|Blinds Up/Down, Blinds Left/Right, Blinds with 3 Adjustable Levels, Blinds with 5 Adjustable Levels, Blinds with 10 Adjustable Levels |
|Comfort|Lighting|Light On/Off, Light Dimming, Light Dimming with RGB, Staircase Lighting |
|Sensors||Brightness Sensor, Presence Sensor, CO2 Sensor, VOC Sensor, Multi-sensor, People Counting Sensor, Temperature Sensor, Window Contact Sensor, Door Contact Sensor, Humidity Sensor, Wind Sensor, Rain Sensor, Dew Sensor, Pressure Sensor, Sound Sensor, Water Leak Sensor, UV Sensor |
|Power & Metering|Metering|Electricity, Water, Gas, District Heat, Oil, Thermal Energy, Photovoltaic, Solar Thermal, Windmill, Geothermal, Bioenergy, Steam, Flow|
|Power & Metering|Distribution|Main Circuit Breaker |
|Fire & Safety||Emergency Lighting, Lighting Protection |
|Parking & EV-I||EV Charging Point, Parking Space |
|Elevators||Elevator, Escalator, Moving Walk |

Below you may find a common list of tags which we  recommend you to use on each asset. This will allow you to easily get the highest benefit of available data by using our API: 

| Tag                                           | Asset name                              | Description                                                                                                                                  |
|-----------------------------------------------|-----------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------|
|                                               |                                         |                                                                                                                                              |
| bos:function:hvac:central:boiler                | Boiler                                  | Device generating warm water/steam used in heating applications                                                                              |
| bos:function:hvac:central:furnace               | Furnace                                 | Device generating warm air used in heating applications                                                                                      |
| bos:function:hvac:central:chiller_water         | Chiller Water Cooled                    | Device generating chilled liquid used in air conditioning applications, typically located in the basement and associated to cooling tower(s) |
| bos:function:hvac:central:chiller_air           | Chiller Air Cooled                      | Device generating chilled liquid used in air conditioning applications, typically located on the roof or outside                             |
| bos:function:hvac:central:cooling_tower         | Cooling Tower                           | Device used for heat rejection for disposing of waste/unwanted heat from a water cooled chiller                                              |
| bos:function:hvac:central:rtu                   | Rooftop Unit                            | Device which is a self-contained unit, usually installed on the roof, that provides both heat and air conditioning for spaces                |
| bos:function:hvac:central:vrf                   | Variable refrigerant flow               | Device which is a large-scale ductless HVAC system for multiple indoor units                                                                 |
| bos:function:hvac:central:crac                  | Computer Room Air Conditioning          | Device that monitors and maintains the temperature, air distribution and humidity in a network room or data center                           |
| bos:function:hvac:central:exchanger             | Exchanger                               | Device that transfers thermal energy from one medium to another, usually used in assistance of additional equipment                          |
| bos:function:hvac:central:heat_pump             | Heat Pump                               | Device that can provide both heat and cooling                                                                                                |
| bos:function:hvac:central:ahu                   | Air Handling Unit                       | Device used to regulate and circulate air as part of a heating, ventilating and air-conditioning system                                      |
| bos:function:hvac:central:crac                  | Computer Room Air Handling              | Device that monitors and maintains the temperature, air distribution and humidity in a network room or data center                           |
| bos:function:hvac:terminal:fcu_2p               | Fan Coil Unit - 2 Pipes                 | Device consisting of a fan and a heat exchanger (coil) supplied with hot water                                                               |
| bos:function:hvac:terminal:fcu_2p_changeover    | Fan Coil Unit - 2 Pipes with Changeover | Device consisting of a fan and a heat exchanger (coil) supplied with hot or cold water alternatively via the same piping                     |
| bos:function:hvac:terminal:fcu_4p               | Fan Coil Unit - 4 Pipes                 | Device consisting of a fan and 2 heat exchangers (coils) each supplied with hot or cold water via independent piping                         |
| bos:function:hvac:terminal:vav                  | Variable Air Volume                     | Variable Air Volume system supplied with a single ducted air supply for which the flow is locally adjusted                                   |
| bos:function:hvac:terminal:vav_dualduct         | Variable Air Volume - Dual Duct         | Variable Air Volume system supplied with both warm air and cold air separately ducted and mixed locally                                      |
| bos:function:hvac:terminal:cav                  | Constant Air Volume                     | Device supplied with constant air flow and which temperature is regulated by the air handling unit                                           |
| bos:function:hvac:terminal:radiator_water       | Radiator - Water                        | Radiator supplied by hot water circulating through the building, regulated via a thermostatic valve                                          |
| bos:function:hvac:terminal:radiator_elec        | Radiator - Electrical                   | Electric radiator plugged into the mains electricity to provide a local source of heat                                                       |
| bos:function:hvac:terminal:chilled_beam         | Chilled beam                            | Appliance designed to heat and cool large spaces, through which pipes of water circulate                                                     |
| bos:function:hvac:terminal:radiant_ceiling      | Radiant ceiling                         | Radiant panel located in the ceiling providing thermal radiation for either heating or cooling                                               |
| bos:function:hvac:terminal:radiant_floor        | Radiant floor                           | Radiant panel located in the floor providing thermal radiation for either heating or cooling                                                 |
| bos:function:hvac:terminal:radiant_wall         | Radiant wall                            | Radiant panel located in a wall providing thermal radiation for either heating or cooling                                                    |
| bos:function:hvac:terminal:split                | Split                                   | Split unit is composed of both an indoor unit and an outdoor unit, providing heating or cooling                                              |
| bos:function:hvac:terminal:ptac                 | Packaged Terminal Air Conditioning      | Self-contained heating and air conditioning system, usually mounted on a wall or a window                                                    |
| bos:function:comfort:shutters:updown            | Shutters Up/down                        | Shutters (interior or exterior, fitted to the window frame) management with up/down and stop command                                         |
| bos:function:comfort:shutters:3_levels          | Shutters with 3 adjustable level        | Shutters (interior or exterior, fitted to the window frame) management with 3 positions : up/mid/down                                        |
| bos:function:comfort:shutters:5_levels          | Shutters with 5 adjustable level        | Shutters (interior or exterior, fitted to the window frame)  management with 5 positions : up/75%/50%/25%/down                               |
| bos:function:comfort:shutters:10_levels         | Shutters with 10 adjustable level       | Shutters (interior or exterior, fitted to the window frame) management with 10 positions : up/90%/80%...20%/10%/down                         |
| bos:function:comfort:blinds:updown              | Blinds Up/down                          | Blinds (interior, not fitted to the window frame) management with up/down and stop command                                                   |
| bos:function:comfort:blinds:leftright           | Blinds Left/Right                       | Blinds (interior, not fitted to the window frame) management with left/right and stop command                                                |
| bos:function:comfort:blinds:3_levels            | Blinds with 3 adjustable level          | Blinds (interior, not fitted to the window frame) management with 3 positions : up/mid/down                                                  |
| bos:function:comfort:blinds:5_levels            | Blinds with 5 adjustable level          | Blinds (interior, not fitted to the window frame) management with 5 positions : up/75%/50%/25%/down                                          |
| bos:function:comfort:blinds:10_levels           | Blinds with 10 adjustable level         | Blinds (interior, not fitted to the window frame) management with 10 positions : up/90%/80%...20%/10%/down                                   |
| bos:function:comfort:light:on_off               | Light On/Off                            |                                                                                                                                              |
| bos:function:comfort:light:dimming              | Light Dimming                           |                                                                                                                                              |
| bos:function:comfort:light:dimming              | Light Dimming with RGB                  |                                                                                                                                              |
| bos:function:comfort:light:staircase            | Staircase                               |                                                                                                                                              |
| bos:function:sensor:brightness                  | Brightness                              |                                                                                                                                              |
| bos:function:sensor:presence                    | Presence                                |                                                                                                                                              |
| bos:function:sensor:co2                         | CO2                                     |                                                                                                                                              |
| bos:function:sensor:voc                         | VOC                                     |                                                                                                                                              |
| bos:function:sensor:multisensor                 | Multi-sensor                            |                                                                                                                                              |
| bos:function:sensor:people_count                | People counting                         |                                                                                                                                              |
| bos:function:sensor:temperature                 | Temperature                             |                                                                                                                                              |
| bos:function:sensor:contact_window              | Window contact                          |                                                                                                                                              |
| bos:function:sensor:contact_door                | Door contact                            |                                                                                                                                              |
| bos:function:sensor:humidity                    | Humidity                                |                                                                                                                                              |
| bos:function:sensor:wind                        | Wind                                    |                                                                                                                                              |
| bos:function:sensor:rain                        | Rain                                    |                                                                                                                                              |
| bos:function:sensor:dew                         | Dew                                     |                                                                                                                                              |
| bos:function:sensor:pressure                    | Pressure                                |                                                                                                                                              |
| bos:function:sensor:sound                       | Sound                                   |                                                                                                                                              |
| bos:function:sensor:water_leak                  | Water leak                              |                                                                                                                                              |
| bos:function:sensor:uv                          | UV                                      |                                                                                                                                              |
| bos:function:power:meter:electricity            | Electricity                             |                                                                                                                                              |
| bos:function:power:meter:water                  | Water                                   |                                                                                                                                              |
| bos:function:power:meter:gas                    | Gas                                     |                                                                                                                                              |
| bos:function:power:meter:district_heat          | District heat                           |                                                                                                                                              |
| bos:function:power:meter:oil                    | Oil                                     |                                                                                                                                              |
| bos:function:power:meter:photovoltaic           | Photovoltaic                            |                                                                                                                                              |
| bos:function:power:meter:solar_thermal          | Solar thermal                           |                                                                                                                                              |
| bos:function:power:meter:windmill               | Windmill                                |                                                                                                                                              |
| bos:function:power:meter:geothermal             | Geothermal                              |                                                                                                                                              |
| bos:function:power:meter:bioenergy              | Bioenergy                               |                                                                                                                                              |
| bos:function:power:distrib:main_circuit_breaker | Main Circuit Breaker                    |                                                                                                                                              |
| bos:function:safety:emergency_light             | Emergency Lighting                      |                                                                                                                                              |
| bos:function:safety:lightning_protection        | Lighting protection                     |                                                                                                                                              |
| bos:function:parking:ev_charging_point          | EV Charging point                       |                                                                                                                                              |
| bos:function:parking:space                      | Parking space                           |                                                                                                                                              |
| bos:function:elevator:elevator                  | Elevator                                |                                                                                                                                              |
| bos:function:elevator:escalator                 | Escalator                               |                                                                                                                                              |
| bos:function:elevator:moving_walk               | Moving walk                             |
