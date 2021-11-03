# Datapoints management 

Datapoints are the basic information that may be read and/or written. There are basically two kinds of datapoints:

- Field datapoints: These are data points collecting data from real physical automation  or IoT devices named in the ontology  DatapointInstance. 
Example: Lamp state (Is a lamp on or off).

- Parameters: These are datapoints used as properties and parameters of objects. They are stored inside the database and named in the ontology 
PropertyDatapointinstance. Example: the GPS coordinates of the building.

These datapoints may be associated with a device (Example: force or read a value on a physical device), 
zones (Example: force a zone to be occupied) , structure (Example: force a floor to be lit), assets (Example: read state of a lamp), ...

All datapoints may come from a template.

![Data Points](/assets/openbos-documentation/static/images/Datapoint_hierarchy.png "Data Points")

![Legend](/assets/openbos-documentation/static/images/Structure_legend.png "Legend")


Please find below a common list of datapoint types:

| Tag  | Category  | Sub- Category | Datapoint name (display) | Description  |
|--|-|-|--|--|
|  | | | Custom | Custom datapoint – Warning! Custom datapoints <br/>don’t permit standardized representation used, for instance, <br/>to develop and use over the top Apps. |
| bos:point:<br/>alarm:default_NC | Alarm | | Default NC | Used to provide a feedback on a default - <br/>normally closed|
| bos:point:<br/>alarm:default_NO | Alarm | | Default NO | Used to provide a feedback on a default - <br/>normally opened  |
| bos:point:<br/>alarm:fault  | Alarm | | Fault  | Used to provide a feedback on a fault|
| bos:point:<br/>alarm:fire | Alarm | | Fire | Used to report the state of a fire alarm system|
| bos:point:<br/>alarm:on_off | Alarm | | On/Off | Used as a device output to report a boolean alarm<br/> state|
| bos:point:<br/>datetime:day | Date & Time | Date  | Day  | Used to provide a day of the week (1=Monday to 7=Sunday)|
| bos:point:<br/>datetime:month | Date & Time | Date  | Month  | Used to provide a day of the month (1=January to <br/>12=December)  |
| bos:point:<br/>datetime:year  | Date & Time | Date  | Year | Used to provide a year   |
| bos:point:<br/>datetime:season  | Date & Time | Season  | Season | Used to provide a season as plain text   |
| bos:point:<br/>datetime:heat_season_start | Date & Time | Season  | Heating Season - Start | Used to provide the date at which the heating season <br/>starts and where heating equipment is turned on  |
| bos:point:<br/>datetime:heat_season_end | Date & Time | Season  | Heating Season - End | Used to provide the date at which the heating season <br/>ends and where heating equipment is turned off |
| bos:point:<br/>datetime:cool_season_start | Date & Time | Season  | Cooling Season - Start | Used to provide the date at which the cooling season <br/>starts and where cooling equipment is turned on  |
| bos:point:<br/>datetime:cool_season_end | Date & Time | Season  | Cooling Season - End | Used to provide the date at which the cooling season <br/>ends and where cooling equipment is turned off |
| bos:point:<br/>datetime:hours | Date & Time | Time  | Time - Hours | Used to provide the hours of the day in a 24h format   |
| bos:point:<br/>datetime:minutes | Date & Time | Time  | Time - Minutes | Used to provide the minutes of the hour  |
| bos:point:<br/>datetime:seconds | Date & Time | Time  | Seconds  | Used to provide the seconds of the minute  |
| bos:point:<br/>datetime:time _elapsed | Date & Time | Time  | Time - Elapsed | Used ot provide the time elapsed since the previous event  |
| bos:point:<br/>datetime:timestamp | Date & Time | Time  | Timestamp  | Used to provide the timestamp of a particular event  |
| bos:point:<br/>datetime:timezone  | Date & Time | Time  | Timezone | Used to provide a time zone   |
| bos:point:<br/>datetime:delay | Date & Time | Time  | Delay  | Used to provide a delay  |
| bos:point:<br/>datetime:hold_time | Date & Time | Time  | Hold time  | Usually used with  a motion sensor, it represents how <br/>long a controller remains in a given state |
| bos:point:<br/>electricity:dry_contact  | Electricity | | Dry contact  | Used to communicate with electrical contacts such as <br/>breakers, switches, etc.  |
| bos:point:<br/>plug:managed plug  | Electricity | | Managed plug | Used to provide the state of a managed electrical plug (On/Off)  |
| bos:point:<br/>electricity:current_angle  | Electricity | Current | Angle  | Used to provide the instantaneous current phase angle  |
| bos:point:<br/>electricity:current_harmonics  | Electricity | Current | Harmonic | Used to provide the harmonics distortion rate (THD) of the<br/> current |
| bos:point:<br/>electricity:current  | Electricity | Current | Current  | Used to provide amperage measurement   |
| bos:point:<br/>electricity:resistance | Electricity | Current | Resistance | Used to provide the resistance of an electrical circuit  |
| bos:point:<br/>electricity:frequency  | Electricity | Current | Frequency  | Used for defining how many times one cycle of the waveform <br/>is repeated per second  |
| bos:point:<br/>electricity:power_load | Electricity | Power | Load | Used for measure of electrical energy consumed, per unit of <br/>time, by an electric circuit |
| bos:point:<br/>electricity:power_reactive | Electricity | Power | Reactive Power | Used for the resultant power of an AC circuit when the current <br/>waveform is out of phase with the waveform of the voltage |
| bos:point:<br/>electricity:power_factor | Electricity | Power | Power factor | Used for the angle between the apparent power (U*I) vector and <br/>the active power component, described as phase displacement |
| bos:point:<br/>electricity:power_active | Electricity | Power | Active Power | Used for the power which is consumed or utilised in an AC Circuit  |
| bos:point:<br/>electricity:power_apparent | Electricity | Power | Apparent Power | Used for the combination of reactive power and active power.<br/> It is the product of a circuit’s voltage and current  |
| bos:point:<br/>electricity:power_angle  | Electricity | Power | Power Angle  | Used to provide the instantaneous power phase angle  |
| bos:point:<br/>electricity:voltage_harmonics  | Electricity | Voltage | Harmonic | Used to provide the harmonic distortion rate (THD) of the voltage  |
| bos:point:<br/>electricity:voltage  | Electricity | Voltage | Voltage  | Used to provide voltage measurement  |
| bos:point:<br/>electricity:voltage_angle  | Electricity | Voltage | Angle  | Used to provide the instantaneous voltage phase angle  |
| bos:point:<br/>hvac:coil_preheat_elec_power | HVAC  | Coil  | Preheating coil - Elec Power | Used to provide the percentage of usage of an electrical coil <br/>for preheating |
| bos:point:<br/>hvac:coil_preheat_elec_status  | HVAC  | Coil  | Preheating coil - Elec Status  | Used to provide the status of an electrical coil for preheating  |
| bos:point:<br/>hvac:coil_reheat_elec_power  | HVAC  | Coil  | Reheating coil - Elec Power  | Used to provide the percentage of usage of an electrical coil <br/>for reheating  |
| bos:point:<br/>hvac:coil_reheat_elec_status | HVAC  | Coil  | Reheating coil - Elec Status | Used to provide the status of an electrical coil for reheating   |
| bos:point:<br/>hvac:coil_water  | HVAC  | Coil  | Heating/Cooling Coil - Water | Used to provide the percentage of usage of a water coil used <br/>either for heating or cooling with a changeover |
| bos:point:<br/>hvac:coil_cool_water | HVAC  | Coil  | Cooling coil - Water | Used to provide the percentage of usage of a cooling water coil  |
| bos:point:<br/>hvac:coil_heat_water | HVAC  | Coil  | Heating coil - Water | Used to provide the percentage of usage of a heating water coil  |
| bos:point:<br/>hvac:damper mode | HVAC  | Equipment | Damper - Mode  | Used to provide damper mode (fresh air, supply, extract)   |
| bos:point:<br/>hvac:damper_position | HVAC  | Equipment | Damper - Position  | Used to provide the actual position of the damper based on the <br/>damper feedback |
| bos:point:<br/>hvac:damper_response | HVAC  | Equipment | Damper - Response  | Used to provide the multiplier (in %) applied to the calculated <br/>damper movement, used to adjust the reaction speed of the damper |
| bos:point:<br/>hvac:damper_speed  | HVAC  | Equipment | Damper - Speed | Used to provide the time that the damper takes to go from the fully <br/>closed position to the fully open position or vice-versa |
| bos:point:<br/>hvac:damper_rotation | HVAC  | Equipment | Damper - Rotation  | Used to provide the direction (clockwise or counter clockwise) <br/>in which the actuator rotates to open the damper  |
| bos:point:<br/>hvac:damper_3states  | HVAC  | Equipment | Damper - 3 states  | Used to provide the opening state of a damper over 4 positions <br/>(Closed/Mid/Full or Auto) |
| bos:point:<br/>hvac:damper_4states  | HVAC  | Equipment | Damper - 4 states  | Used to provide the opening state of a damper over 4 positions <br/>(Closed/33/66/100 or Auto)  |
| bos:point:<br/>hvac:evaporator_state  | HVAC  | Equipment | Evaporator State | Used to provide if the evaporator is running or not (on/off)   |
| bos:point:<br/>hvac:evaporator_status | HVAC  | Equipment | Evaporator Status  | Used to provide condition status of the evaporator when running  |
| bos:point:<br/>hvac:filter state  | HVAC  | Equipment | Filter state | Used to provide the state of a filter (dirty/clean)  |
| bos:point:<br/>hvac:pump_speed  | HVAC  | Equipment | Pump Speed | Used to provide the speed mode of the pump   |
| bos:point:<br/>hvac:pump_mode | HVAC  | Equipment | Pump Mode  | Used to provide the control mode of the pump   |
| bos:point:<br/>hvac:change_over | HVAC  | Equipment | Changeover | Used to provide the functioning mode (heating/cooling/auto) of a <br/>single coil equipment |
| bos:point:<br/>hvac:defrost | HVAC  | Equipment | Defrost  | Used to provide information about frost protection mode for a <br/>technical equipment  |
| bos:point:<br/>hvac:mode  | HVAC  | Equipment | HVAC Mode  | Used to provide if the equipment is in cooling/heating (Auto/Manu) |
| bos:point:<br/>hvac:status  | HVAC  | Equipment | HVAC Status  | Used to provide the HVAC status (auto, comfort, eco…)  |
| bos:point:<br/>hvac:motor_state | HVAC  | Equipment | Motor State  | Used to provide information about the state of a mechanical motor; <br/>whether pump, fan, or other |
| bos:point:<br/>hvac:on_off  | HVAC  | Equipment | On/Off | Used to provide the On/Off status of an HVAC equipment   |
| bos:point:<br/>hvac:override  | HVAC  | Equipment | Override | Used for provide if the equipment is running nominally or forced externally  |
| bos:point:<br/>hvac:btu | HVAC  | Equipment | BTU  | Used to provide the thermal energy   |
| bos:point:<br/>hvac:pump_speed  | HVAC  | Equipment | Pump Speed | Used to provide the speed of a pump  |
| bos:point:<br/>hvac:evaporator_drain  | HVAC  | Equipment | Evaporator Drain | Used to provide the quantity of water drained out, or released <br/>from, of an evaporator  |
| bos:point:<br/>hvac:fresh_air_req_bool  | HVAC  | Equipment | Fresh Air Request Boolean  | Used to request supply of fresh air via a boolean value  |
| bos:point:<br/>hvac:fresh_air_req_weight  | HVAC  | Equipment | Fresh Air Request Weight | Used to request supply of fresh air via a weighted value   |
| bos:point:<br/>hvac:co2_control | HVAC  | Equipment | CO2 Control Status | Used to provide if CO2 control is active or not  |
| bos:point:<br/>hvac:fanspeed_3speed | HVAC  | Fan | Fan Speed - 3 Speeds | Used to provide the speed of a 3 speeds fan (Off/S1/S2/S3 or Auto) |
| bos:point:<br/>hvac:fanspeed_percent  | HVAC  | Fan | Fan Speed - Percent  | Used to provide the speed of a 0-10v fan, ranging from 0% to 100%  |
| bos:point:<br/>hvac:fan_start_stop  | HVAC  | Fan | Start/Stop | Used to provide the start/stop status of the fan   |
| bos:point:<br/>hvac:air_flow  | HVAC  | Flow  | Air Flow Volume  | Used to provide the volume of an air flow  |
| bos:point:<br/>hvac:air_flow_in | HVAC  | Flow  | Air Flow Volume - Intake | Used to provide the volume of an intake air flow   |
| bos:point:<br/>hvac:air_flow_out  | HVAC  | Flow  | Air Flow Volume - Supply | Used to provide the volume of a supply air flow  |
| bos:point:<br/>hvac:water_flow  | HVAC  | Flow  | Water Flow Volume  | Used to provide the volume of a water flow   |
| bos:point:<br/>hvac:air_flow_setpoint | HVAC  | Flow  | Air Flow Set Point | Used to provide the set point of an air flow volume  |
| bos:point:<br/>hvac:air_flow_setpoint_cool  | HVAC  | Flow  | Air Flow Set Point - Cooling | Used to provide the set point of an air flow volume in cooling mode  |
| bos:point:<br/>hvac:air_flow_setpoint_heat  | HVAC  | Flow  | Air Flow Set Point - Heating | Used to provide the set point of an air flow volume in heating mode  |
| bos:point:<br/>hvac:air_flow_setpoint_vent  | HVAC  | Flow  | Air Flow Set Point - Ventilation | Used to provide the set point of an air flow volume in ventilation mode  |
| bos:point:<br/>hvac:air_flow_setpoint_occ | HVAC  | Flow  | Air Flow Set Point - Occupied  | Used to provide the set point of an air flow volume when occupied  |
| bos:point:<br/>hvac:air_flow_setpoint_unocc | HVAC  | Flow  | Air Flow Set Point - Unoccupied  | Used to provide the set point of an air flow volume when unoccupied  |
| bos:point:<br/>hvac:air_flow_setpoint_stdby | HVAC  | Flow  | Air Flow Set Point - Standby | Used to provide the set point of an air flow volume when in standby  |
| bos:point:<br/>hvac:air_flow_setpoint_min | HVAC  | Flow  | Air Flow Set Point - Minimum | Used to provide the minimum air flow set point   |
| bos:point:<br/>hvac:air_flow_setpoint_max | HVAC  | Flow  | Air Flow Set Point - Maximum | Used to provide the maximum air flow set point   |
| bos:point:<br/>hvac:valve_2way  | HVAC  | Valve | 2-way Actuator | Used to provide opening status of a 2-way regulation valve   |
| bos:point:<br/>hvac:valve_2way_cool | HVAC  | Valve | 2-way Actuator Cooling | Used to provide opening status of a 2-way regulation valve for <br/>cooling applications  |
| bos:point:<br/>hvac:valve_2way_heat | HVAC  | Valve | 2-way Actuator Heating | Used to provide opening status of a 2-way regulation valve for <br/>heating applications  |
| bos:point:<br/>hvac:valve_3way_cool | HVAC  | Valve | 3-way Actuator Cooling | Used to provide opening status of a 3-way regulation valve for <br/>cooling applications  |
| bos:point:<br/>hvac:valve_3way_heat | HVAC  | Valve | 3-way Actuator Heating | Used to provide opening status of a 3-way regulation valve for <br/>heating applications  |
| bos:point:<br/>hvac:valve_6way  | HVAC  | Valve | 6-way Actuator | Used to provide opening status of a 6-way regulation valve for <br/>heating & cooling applications  |
| bos:point:<br/>light:auto_manu  | Light | | Auto/Manu  | Used to provide the lighting regulation mode, automatic or manually done |
| bos:point:<br/>light:on_off | Light | | On/Off | Used to provide an On/Off state of a light   |
| bos:point:<br/>light:bounce time  | Light | | Bounce time  | Used to provide the bounce time between the On/Off states  |
| bos:point:<br/>light:brightness | Light | | Brightness | Used to provide the brightness level of a space  |
| bos:point:<br/>light:dimming  | Light | | Dimming  | Used to provide a dimming state (brightness level) of a light  |
| bos:point:<br/>light:warmth | Light | | Warmth | Used to provide the lighting temperature (Warm White/Cold White) |
| bos:point:<br/>measure:co2  | Measure | Air | CO2 Level  | Used to provide measure of CO2 levels  |
| bos:point:<br/>measure:co2_setpoint | Measure | Air | CO2 Set Point  | Used to provide target set point for CO2 level   |
| bos:point:<br/>measure:voc  | Measure | Air | VOC Level  | Used to provide measure of Volatile organic compounds (VOCs) levels  |
| bos:point:<br/>measure:voc_setpoint | Measure | Air | VOC Set Point  | Used to provide target set point for Volatile organic compounds (VOCs) |
| bos:point:<br/>measure:smoke  | Measure | Air | Smoke  | Used to provide measure of smoke levels  |
| bos:point:<br/>measure:dew_point  | Measure | Air | Dew Point  | Used to provide the dew point of a space   |
| bos:point:<br/>measure:battery_level  | Measure | Battery | Battery level  | Used to provide the charge level of a battery  |
| bos:point:<br/>measure:battery_volt | Measure | Battery | Battery voltage  | Used to provide the voltage of a battery   |
| bos:point:<br/>measure:contact_door | Measure | Contact | Door | Used to provide the open/close status of a door  |
| bos:point:<br/>measure:contact_window | Measure | Contact | Window | Used to provide the open/close status of a door  |
| bos:point:<br/>measure:run_hours  | Measure | Equipment | Run Hours  | Used to provide the quantity of functioning hours  |
| bos:point:<br/>measure:humidity_absolute  | Measure | Humidity  | Absolute | Used to provide absolute humidity measure of water vapor (moisture)<br/> in the air, regardless of temperature  |
| bos:point:<br/>measure:humidity_relative  | Measure | Humidity  | Relative | Used to provide relative humidity, being the ratio of the current <br/>absolute humidity to the highest possible absolute humidity  |
| bos:point:<br/>measure:leak_water_detect  | Measure | Leak  | Water leak - Detection | Used to provide the status of detection of a liquid leak   |
| bos:point:<br/>measure:leak_water_qty | Measure | Leak  | Water leak - Quantity  | Used to provide the quantity of a liquid leak  |
| bos:point:<br/>measure:leak_air_detect  | Measure | Leak  | Air leak - Detection | Used to provide the status of detection of an air leak   |
| bos:point:<br/>measure:leak_air_qty | Measure | Leak  | Air leak - Quantity  | Used to provide the quantity of an air leak  |
| bos:point:<br/>measure:uv | Measure | Light | UV | Used to provide an UV (ultra-violets) radiation measure  |
| bos:point:<br/>measure:luminosity | Measure | Light | Luminosity Intensity | Used to provide the intensity of luminosity, being luminous power <br/>per unit solid angle |
| bos:point:<br/>measure:sound_intensity  | Measure | Sound | Sound Intensity  | Used to report the intensity of a sound in decibels  |
| bos:point:<br/>measure:people_count | Measure | Occupancy | People Counted | Used to provide the quantity of people currently present in a space  |
| bos:point:<br/>measure:occupancy_status | Measure | Occupancy | Occupancy Status | Used to provide the occupancy status of <br/>a space (occupied, inoccupied, standby…) |
| bos:point:<br/>measure:detection  | Measure | Occupancy | Presence Detection | Used to provide the status of presence of a space, ex. from a PIR  |
| bos:point:<br/>measure:pressure_airflow | Measure | Pressure  | Air Flow Pressure  | Used to provide a pressure level of an air flow  |
| bos:point:<br/>measure:pressure_equipment | Measure | Pressure  | Equipment Pressure | Used to provide a pressure level of a technical equipment (delta <br/>measured between 2 points)  |
| bos:point:<br/>measure:pressure_room  | Measure | Pressure  | Room Pressure  | Used to provide a pressure level within a room or a space  |
| bos:point:<br/>measure:pressure_water | Measure | Pressure  | Water Flow Pressure  | Used to provide a pressure level of a water flow   |
| bos:point:<br/>measure:pressure_duct  | Measure | Pressure  | Duct Pressure  | Used to provide a pressure level within a duct   |
| bos:point:<br/>measure:wind | Measure | Weather | Wind | Used to report the wind speed measured by a weather station  |
| bos:point:<br/>measure:rain | Measure | Weather | Rain | Used to report the rain quantity measured by a weather station   |
| bos:point:<br/>metering:electricity | Metering  | Consumption | Electricity  | Used to provide amount of electricity consumed   |
| bos:point:<br/>metering:gas | Metering  | Consumption | Gas  | Used to provide amount of gas consumed   |
| bos:point:<br/>metering:water | Metering  | Consumption | Water  | Used to provide amount of water consumed   |
| bos:point:<br/>metering:steam | Metering  | Consumption | Steam  | Used to provide amount of steam consumed   |
| bos:point:<br/>metering:degree_days | Metering  | Degree Days | Degree Days  | Used to quantify the demand for energy needed to heat/cool a building  |
| bos:point:<br/>metering:degree_days_heat  | Metering  | Degree Days | Heating Degree Days  | Used to quantify the demand for energy needed to heat a building |
| bos:point:<br/>metering:degree_days_cool  | Metering  | Degree Days | Cooling Degree Days  | Used to quantify the demand for energy needed to cool a building |
| bos:point:<br/>metering:bioenergy | Metering  | Production  | Bioenergy  | Used to provide amount of calories produced by a bioenergy generation  |
| bos:point:<br/>metering:district_heating  | Metering  | Production  | District Heating | Used to provide amount of district heating calories consumed   |
| bos:point:<br/>metering:geothermal  | Metering  | Production  | Geothermal | Used to provide amount of calories produced by a geothermal generation |
| bos:point:<br/>metering:photovoltaic  | Metering  | Production  | Solar Photovoltaic | Used to provide amount of photovoltaic power generated   |
| bos:point:<br/>metering:oil | Metering  | Production  | Oil  | Used to provide amount of oil consumed   |
| bos:point:<br/>metering:solar_thermal | Metering  | Production  | Solar Thermal  | Used to provide amount of solar heated water   |
| bos:point:<br/>metering:windmill  | Metering  | Production  | Windmill | Used to provide amount of electricity produced by a windmill generation  |
| bos:point:<br/>other:currency | Others  | | Currency | Used to represent a currency   |
| bos:point:<br/>other:device_presence  | Others  | Equipment | Device Presence  | Used to report the presence/absence of a device  |
| bos:point:<br/>other:ip_address | Others  | Equipment | IP Address | Used to provide an IPv4 address   |
| bos:point:<br/>other:ip_address_v6  | Others  | Equipment | IP Address v6  | Used to provide an IPv6 address   |
| bos:point:<br/>other:ip_protection  | Others  | Equipment | IP Protection  | Used to provide the protection level (Ingress Protection) of an element  |
| bos:point:<br/>others:manufacturer  | Others  | Equipment | Manufacturer | Used to provide the manufacturer of an equipment   |
| bos:point:<br/>others:reference | Others  | Equipment | Reference  | Used to provide the reference of an equipment  |
| bos:point:<br/>others:version | Others  | Equipment | Version  | Used to provide the version of an equipment  |
| bos:point:<br/>other:scene  | Others  | Amenities | Scene Control  | Provide the number of the scene to be played   |
| bos:point:<br/>other:coffee_machine | Others  | Amenities | Coffee Machine | Used to provide the presence of a coffee machine   |
| bos:point:<br/>other:videoconference  | Others  | Amenities | Videoconference  | Used to provide the presence of a video conference system   |
| bos:point:<br/>other:video projector  | Others  | Amenities | Video Projector  | Used to provide the quantity of video projectors   |
| bos:point:<br/>other:tv_screen  | Others  | Amenities | TV Screen  | Used to provide the quantity of TV screens   |
| bos:point:<br/>other:white_board  | Others  | Amenities | White Board  | Used to provide the quantity of white boards   |
| bos:point:<br/>other:sound_system | Others  | Amenities | Sound system | Used to provide the quantity of sound systems  |
| bos:point:<br/>other:microphone | Others  | Amenities | Microphone | Used to provide the quantity of microphones  |
| bos:point:<br/>other:surface_gross  | Others  | Dimensions  | Surface - Gross  | Used to provide a gross surface  |
| bos:point:<br/>other:surface_net  | Others  | Dimensions  | Surface - Net  | Used to provide a net surface  |
| bos:point:<br/>other:height | Others  | Dimensions  | Height | Used to provide the height of an element   |
| bos:point:<br/>other:length | Others  | Dimensions  | Length | Used to provide the length of an element   |
| bos:point:<br/>other:width  | Others  | Dimensions  | Width  | Used to provide the width of an element  |
| bos:point:<br/>other:weigth | Others  | Dimensions  | Weight | Used to provide the weight of an element   |
| bos:point:<br/>other:volume_space | Others  | Dimensions  | Volume - Space | Used to provide a volume of a space  |
| bos:point:<br/>other:seats  | Others  | Dimensions  | Seats  | Used to provide the quantity of seats  |
| bos:point:<br/>others:people_max  | Others  | Dimensions  | People - Maximum | Used to provide the maximum of people allowed like in a <br/>space or in a building |
| bos:point:<br/>other:density  | Others  | Physics | Density  | Used to provide density of a material  |
| bos:point:<br/>other:ph | Others  | Physics | pH | Used to provide of how acidic/basic an aqueous solution is   |
| bos:point:<br/>other:enthalpy | Others  | Physics | Enthalpy | Used to provide the sum of the internal energy and the <br/>product of the pressure and volume of a thermodynamic system  |
| bos:point:<br/>other:entropy  | Others  | Physics | Entropy  | Used to provide a system’s thermal energy per unit temperature<br/> that is unavailable for doing useful work |
| bos:point:<br/>other:mass | Others  | Physics | Mass | Used to provide the amount of matter in an object, different from weight |
| bos:point:<br/>hvac:rotation  | Others  | Physics | Rotation | Used to provide the angular velocity of an element   |
| bos:point:<br/>others:material  | Others  | Physics | Material | Used to provide the material of an element like equipment,<br/> wall, ceiling, etc. |
| bos:point:<br/>other:color  | Others  | Physics | Color  | Used to provide the color of an element  |
| bos:point:<br/>other:speed  | Others  | Physics | Speed  | Provide the speed of an element  |
| bos:point:<br/>other:volume_liquid  | Others  | Physics | Volume - Liquid  | Used to provide a volume (of a liquid for instance)  |
| bos:point:<br/>shutter:auto_manu  | Shutter | | Auto/Manu  | Used for auto/manu shutter control   |
| bos:point:<br/>shutter:up_down  | Shutter | | Up/Down  | Used for shutter up/down status  |
| bos:point:<br/>shutter:left_right | Shutter | | Left/Right | Used for shutter left/right status   |
| bos:point:<br/>shutter:inclination  | Shutter | | Inclination  | Used for shutter inclination angle   |
| bos:point:<br/>shutter:level  | Shutter | | Level  | Used for shutter opening level   |
| bos:point:<br/>temp:ambient | Temperature | Measure | Ambient  | Used to provide the ambient temperature within a space   |
| bos:point:<br/>temp:difference  | Temperature | Measure | Difference | Used to provide the difference of a temperature measurement  |
| bos:point:<br/>temp:offset  | Temperature | Measure | Offset | Used to provide the offset of a temperature, usually used <br/>for temperature control  |
| bos:point:<br/>temp:discharge | Temperature | Measure | Discharge  | Used to provide capacity control of heating and cooling <br/>equipment via a duct -mounted temperature sensor  |
| bos:point:<br/>temp:exhaust | Temperature | Measure | Exhaust  | Used to provide the temperature of the exhausted air   |
| bos:point:<br/>temp:exterior  | Temperature | Measure | Exterior | Used to provide the outside temperature  |
| bos:point:<br/>temp:other | Temperature | Measure | Other  | Used to provide any other temperature measurement/command  |
| bos:point:<br/>temp:return  | Temperature | Measure | Return | Used to provide the temperature of the return air  |
| bos:point:<br/>temp:supply  | Temperature | Measure | Supply | Used to provide the temperature of the air supply  |
| bos:point:<br/>temp:water | Temperature | Measure | Water  | Used to provide the temperature of water   |
| bos:point:<br/>temp:mixed_air | Temperature | Measure | Mixed Air  | Used to provide the temperature of mixed air   |
| bos:point:<br/>temp:setpoint  | Temperature | Set point | Set point  | Used to provide the desired temperature of a space or a <br/>technical equipment  |
| bos:point:<br/>temp:setpoint_effective  | Temperature | Set point | Effective set point  | Used to provide the actual setpoint calculated by the<br/> PID loop of an equipment |
| bos:point:<br/>temp:setpoint_freeze | Temperature | Set point | Freeze protection set point  | Used to provide the freeze protection setpoint under which<br/> the equipment will turn heating on  |
| bos:point:<br/>temp:setpoint_cool | Temperature | Set point | Set point - Cooling  | Used to provide the set point in cooling mode  |
| bos:point:<br/>temp:setpoint_cool_occ | Temperature | Set point | Set point - Cooling Occupied | Used to provide the set point in cooling mode and occupied   |
| bos:point:<br/>temp:setpoint_cool_stby  | Temperature | Set point | Set point - Cooling Standby  | Used to provide the set point in cooling mode and standby  |
| bos:point:<br/>temp:setpoint_cool_unocc | Temperature | Set point | Set point - Cooling Unoccupied | Used to provide the set point in cooling mode and unoccupied   |
| bos:point:<br/>temp:setpoint_frost_protection | Temperature | Set point | Set point - Frost Protection | Temperature set point for frost guard/protection   |
| bos:point:<br/>temp:setpoint_heat | Temperature | Set point | Set point - Heating  | Used to provide the set point in heating mode  |
| bos:point:<br/>temp:setpoint_heat_occ | Temperature | Set point | Set point - Heating Occupied | Used to provide the set point in heating mode and occupied   |
| bos:point:<br/>temp:setpoint_heat_stby  | Temperature | Set point | Set point - Heating Standby  | Used to provide the set point in heating mode and standby  |
| bos:point:<br/>temp:setpoint_heat_unocc | Temperature | Set point | Set point - Heating Unoccupied | Used to provide the set point in heating mode and unoccupied   |

List of datapoints units with minimimum and maximum values: 

| Tag  | Format  | Unit Category (code) | Unit (code)  | Min Value  | Max Value  | Enum Name  |
|--|-|--|--|--|--|--|
| bos:point:<br/>alarm:default_NC | Enum  | -  | -  | No Default | Default  | Default_NC |
| bos:point:<br/>alarm:default_NO | Enum  | -  | -  | Default  | No Default | Default_NO |
| bos:point:<br/>alarm:fault  | Enum  | -  | -  | No Fault | Fault  | Fault  |
| bos:point:<br/>alarm:fire | Enum  | -  | -  | No Fire  | Fire | Fire |
| bos:point:<br/>alarm:on_off | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>datetime:day | Integer | -  | -  | 1  | 7  |  |
| bos:point:<br/>datetime:month | Integer | -  | -  | 1  | 31 |  |
| bos:point:<br/>datetime:year  | Integer | -  | -  | 1  | 9.999  |  |
| bos:point:<br/>datetime:season  | String  | -  | -  |  |  |  |
| bos:point:<br/>datetime:heat_season_start | Double  | -  | -  | 01. Jan  | 31. Dez  |  |
| bos:point:<br/>datetime:heat_season_end | Double  | -  | -  | 01. Jan  | 31. Dez  |  |
| bos:point:<br/>datetime:cool_season_start | Double  | -  | -  | 01. Jan  | 31. Dez  |  |
| bos:point:<br/>datetime:cool_season_end | Double  | -  | -  | 01. Jan  | 31. Dez  |  |
| bos:point:<br/>datetime:hours | Float | Duration | Hours  | 0,00 | 23,00  |  |
| bos:point:<br/>datetime:minutes | Float | Duration | Minutes  | 0,00 | 59,00  |  |
| bos:point:<br/>datetime:seconds | Float | Duration | Seconds  | 0,00 | 59,00  |  |
| bos:point:<br/>datetime:time _elapsed | Float | Duration | Seconds  | 0,00 | 999.999,99 |  |
| bos:point:<br/>datetime:timestamp | Integer | Duration | Seconds  | 0  | 999.999  |  |
| bos:point:<br/>datetime:timezone  | Integer | -  | -  | -12  | 14 |  |
| bos:point:<br/>datetime:delay | Integer | Duration | Seconds  | 0,00 | 999.999  |  |
| bos:point:<br/>datetime:hold_time | Integer | Duration | Seconds  | 0,00 | 999.999  |  |
| bos:point:<br/>electricity:dry_contact  | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>plug:managed plug  | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>electricity:current_angle  | Float | Angle  | Degrees  | -180,00  | 180,00 |  |
| bos:point:<br/>electricity:current_harmonics  | Float | Angle  | Degrees  | -180,00  | 180,00 |  |
| bos:point:<br/>electricity:current  | Float | ElectricCurrent  | Amperes  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:resistance | Float | ElectricResistance | Ohms | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>electricity:frequency  | Float | Frequency  | Hertz  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_load | Float | Power  | Watts  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_reactive | Float | Power  | Watts  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_factor | Float | PowerFactor  | PowerFactors | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_active | Float | ReactivePower  | VoltamperesReactive  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_apparent | Float | ApparentEnergy | Voltamperes  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_angle  | Float | Angle  | Degrees  | -180,00  | 180  |  |
| bos:point:<br/>electricity:voltage_harmonics  | Float | Ratio  | Percent  | 0,00 | 99,99  |  |
| bos:point:<br/>electricity:voltage  | Float | ElectricPotential  | Volts  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:voltage_angle  | Float | Angle  | Degrees  | -180,00  | 180  |  |
| bos:point:<br/>hvac:coil_preheat_elec_power | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:coil_preheat_elec_status  | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>hvac:coil_reheat_elec_power  | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:coil_reheat_elec_status | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>hvac:coil_water  | Float | Ratio  | Percent  | 0,00 | 100,00 | On_Off |
| bos:point:<br/>hvac:coil_cool_water | Float | Ratio  | Percent  | 0,00 | 100,00 | On_Off |
| bos:point:<br/>hvac:coil_heat_water | Float | Ratio  | Percent  | 0,00 | 100,00 | On_Off |
| bos:point:<br/>hvac:damper mode | Enum  | -  | -  |  |  | HVAC_Damper_Mode |
| bos:point:<br/>hvac:damper_position | Integer | Ratio  | Percent  | 0  | 100  |  |
| bos:point:<br/>hvac:damper_response | Integer | Ratio  | Percent  | 0  | 100  |  |
| bos:point:<br/>hvac:damper_speed  | Integer | Duration | Seconds  | 0  | 999.999  |  |
| bos:point:<br/>hvac:damper_rotation | Enum  | -  | -  | Clockwise  | Counterclockwise | Rotation |
| bos:point:<br/>hvac:damper_3states  | Enum  | -  | -  |  |  | HVAC_Damper3States |
| bos:point:<br/>hvac:damper_4states  | Enum  | -  | -  |  |  | HVAC_Damper4States |
| bos:point:<br/>hvac:evaporator_state  | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>hvac:evaporator_status | Enum  | -  | -  |  |  | Evaporator_status  |
| bos:point:<br/>hvac:filter state  | Enum  | -  | -  | Clean  | Dirty  | Filter_state |
| bos:point:<br/>hvac:pump_speed  | Enum  | -  | -  | Constant Speed | Variable Speed | Pump_Speed |
| bos:point:<br/>hvac:pump_mode | Enum  | -  | -  |  |  | Pump_Mode  |
| bos:point:<br/>hvac:change_over | Enum  | -  | -  |  |  | HVAC_ChangeOver  |
| bos:point:<br/>hvac:defrost | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>hvac:mode  | Enum  | -  | -  |  |  | HVAC_Mode  |
| bos:point:<br/>hvac:status  | Enum  | -  | -  |  |  | HVAC_Status  |
| bos:point:<br/>hvac:motor_state | Enum  | -  | -  |  |  | Motor_State  |
| bos:point:<br/>hvac:on_off  | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>hvac:override  | Enum  | -  | -  | Not overridden | Overriden  | Override |
| bos:point:<br/>hvac:btu | Float | Energy | BritishThermalUnits  | 0,00 |  |  |
| bos:point:<br/>hvac:pump_speed  | Integer | Ratio  | Percent  | 0  | 100  |  |
| bos:point:<br/>hvac:evaporator_drain  | Float | Flow | LitersPerHour  | 0,00 |  |  |
| bos:point:<br/>hvac:fresh_air_req_bool  | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>hvac:fresh_air_req_weight  | Float | -  | -  |  |  |  |
| bos:point:<br/>hvac:co2_control | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>hvac:fanspeed_3speed | Enum  | -  | -  |  |  | HVAC_Fanspeed  |
| bos:point:<br/>hvac:fanspeed_percent  | Integer | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:fan_start_stop  | Boolean | -  | -  | Off  | On | On_Off |
| bos:point:<br/>hvac:air_flow  | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_in | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_out  | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:water_flow  | Float | Flow | LitersPerHour  | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_cool  | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_heat  | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_vent  | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_occ | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_unocc | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_stdby | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_min | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_max | Float | Flow | CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:valve_2way  | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_2way_cool | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_2way_heat | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_3way_cool | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_3way_heat | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_6way  | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>light:auto_manu  | Enum  | -  | -  | Automatic  | Manual | Auto_Manu  |
| bos:point:<br/>light:on_off | Enum  | -  | -  | Off  | On | On_Off |
| bos:point:<br/>light:bounce time  | Float | Duration | Seconds  | 1,00 |  |  |
| bos:point:<br/>light:brightness | Integer | Illuminance  | Lux  | 0  | 1.000.000  |  |
| bos:point:<br/>light:dimming  | Integer | Ratio  | Percent  | 0  | 100  |  |
| bos:point:<br/>light:warmth | Integer | Temperature  | Kelvins  | 1.000  | 100.000  |  |
| bos:point:<br/>measure:co2  | Integer | Ratio  | PartsPerMillion  | 0,00 |  |  |
| bos:point:<br/>measure:co2_setpoint | Integer | Ratio  | PartsPerMillion  | 0,00 |  |  |
| bos:point:<br/>measure:voc  | Integer | Ratio  | PartsPerBillion  | 0,00 |  |  |
| bos:point:<br/>measure:voc_setpoint | Integer | Ratio  | PartsPerBillion  | 0,00 |  |  |
| bos:point:<br/>measure:smoke  | Integer | Ratio  | PartsPerBillion  | 0,00 |  |  |
| bos:point:<br/>measure:dew_point  | Integer | Temperature  | DegreesCelsius |  |  |  |
| bos:point:<br/>measure:battery_level  | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>measure:battery_volt | Float | ElectricPotential  | Volts  | 0,00 | 100,00 |  |
| bos:point:<br/>measure:contact_door | Enum  | -  | -  | Closed | Open | Open_close |
| bos:point:<br/>measure:contact_window | Enum  | -  | -  | Closed | Open | Open_close |
| bos:point:<br/>measure:run_hours  | Float | Duration | Hours  | 0,00 |  |  |
| bos:point:<br/>measure:humidity_absolute  | Float | Density  | GramsPerCubicMeter | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:humidity_relative  | Float | Ratio  | Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>measure:leak_water_detect  | Enum  | -  | -  | No leak  | Leak | Leak |
| bos:point:<br/>measure:leak_water_qty | Float | Volume | Liters |  |  |  |
| bos:point:<br/>measure:leak_air_detect  | Enum  | -  | -  | No leak  | Leak | Leak |
| bos:point:<br/>measure:leak_air_qty | Float | Speed  | MetersPerSecond  |  |  |  |
| bos:point:<br/>measure:uv | Float | Irradiance | WattsPerSquareMeter  | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:luminosity | Float | Luminance  | CandelasPerSquareMeter | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:sound_intensity  | Float | Level  | Decibels | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:people_count | Integer | -  | -  | 0  |  |  |
| bos:point:<br/>measure:occupancy_status | Enum  | -  | -  |  |  | Occupancy  |
| bos:point:<br/>measure:detection  | Enum  | -  | -  | Not occupied | Occupied | Presence_Detection |
| bos:point:<br/>measure:pressure_airflow | Integer | Pressure | Hectopascals | -999.999 | 999.999  |  |
| bos:point:<br/>measure:pressure_equipment | Integer | Pressure | Kilopascals  | -999.999 | 999.999  |  |
| bos:point:<br/>measure:pressure_room  | Integer | Pressure | Kilopascals  | 0  | 999.999  |  |
| bos:point:<br/>measure:pressure_water | Integer | Pressure | Kilopascals  | -999.999 | 999.999  |  |
| bos:point:<br/>measure:pressure_duct  | Integer | Pressure | Kilopascals  | -999.999 | 999.999  |  |
| bos:point:<br/>measure:wind | Float | Speed  | MetersPerSecond  | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:rain | Float | Length | Millimeters  | 0,00 | 999.999,99 |  |
| bos:point:<br/>metering:electricity | Float | Energy | KilowattHours  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:gas | Float | Volume | CubicMeters  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:water | Float | Volume | CubicMeters  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:steam | Float | Volume | CubicMeters  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:degree_days | Integer | -  | -  | -9.999.999 | 9.999.999  |  |
| bos:point:<br/>metering:degree_days_heat  | Integer | -  | -  | -9.999.999 | 9.999.999  |  |
| bos:point:<br/>metering:degree_days_cool  | Integer | -  | -  | -9.999.999 | 9.999.999  |  |
| bos:point:<br/>metering:bioenergy | Float | Energy | Joules | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:district_heating  | Float | Energy | Joules | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:geothermal  | Float | Energy | Joules | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:photovoltaic  | Float | Energy | KilowattHours  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:oil | Float | Volume | Liters | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:solar_thermal | Float | Volume | Liters | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:windmill  | Float | Energy | KilowattHours  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>other:currency | String  | -  | -  |  |  |  |
| bos:point:<br/>other:device_presence  | Enum  | -  | -  | Absent | Present  | Device_Presence  |
| bos:point:<br/>other:ip_address | String  | -  | -  |  |  |  |
| bos:point:<br/>other:ip_address_v6  | String  | -  | -  |  |  |  |
| bos:point:<br/>other:ip_protection  | String  | -  | -  |  |  |  |
| bos:point:<br/>others:manufacturer  | String  | -  | -  |  |  |  |
| bos:point:<br/>others:reference | String  | -  | -  |  |  |  |
| bos:point:<br/>others:version | String  | -  | -  |  |  |  |
| bos:point:<br/>other:scene  | Integer | -  | -  | 0,00 | 4.096  |  |
| bos:point:<br/>other:coffee_machine | Integer | -  | -  | 0,00 |  |  |
| bos:point:<br/>other:videoconference  | Integer | -  | -  | 0,00 |  |  |
| bos:point:<br/>other:video projector  | Integer | -  | -  | 0,00 |  |  |
| bos:point:<br/>other:tv_screen  | Integer | -  | -  | 0,00 |  |  |
| bos:point:<br/>other:white_board  | Integer | -  | -  | 0,00 |  |  |
| bos:point:<br/>other:sound_system | Integer | -  | -  | 0,00 |  |  |
| bos:point:<br/>other:microphone | Integer | -  | -  | 0,00 |  |  |
| bos:point:<br/>other:surface_gross  | Float | Area | SquareMeters | 0,00 |  |  |
| bos:point:<br/>other:surface_net  | Float | Area | SquareMeters | 0,00 |  |  |
| bos:point:<br/>other:height | Float | Length | Meters | 0,00 |  |  |
| bos:point:<br/>other:length | Float | Length | Meters | 0,00 |  |  |
| bos:point:<br/>other:width  | Float | Length | Meters | 0,00 |  |  |
| bos:point:<br/>other:weigth | Float | Mass | Kilograms  | 0,00 |  |  |
| bos:point:<br/>other:volume_space | Float | Volume | CubicMeters  | 0,00 |  |  |
| bos:point:<br/>other:seats  | Integer | -  | -  | 0,00 |  |  |
| bos:point:<br/>others:people_max  | Integer | -  | -  | 0  | 999.999  |  |
| bos:point:<br/>other:density  | Integer | Density  | GramsPerCubicMeter | 0,00 |  |  |
| bos:point:<br/>other:ph | Float | -  | -  | 0,00 | 14,00  |  |
| bos:point:<br/>other:enthalpy | Float | Energy | Joules | 0,00 |  |  |
| bos:point:<br/>other:entropy  | Float | HeatCapacity | JoulesPerKelvin  | 0,00 |  |  |
| bos:point:<br/>other:mass | Float | Mass | Kilograms  | 0,00 |  |  |
| bos:point:<br/>hvac:rotation  | Float | RotationalSpeed  | RevolutionsPerMinute |  |  |  |
| bos:point:<br/>others:material  | String  | -  | -  |  |  |  |
| bos:point:<br/>other:color  | String  | -  | -  |  |  |  |
| bos:point:<br/>other:speed  | Float | Speed  | MetersPerSecond  | 0,00 | 299.792.458,00 |  |
| bos:point:<br/>other:volume_liquid  | Float | Volume | Liters | 0,00 |  |  |
| bos:point:<br/>shutter:auto_manu  | Enum  | -  | -  | Automatic  | Manual | Auto_Manu  |
| bos:point:<br/>shutter:up_down  | Enum  | -  | -  | Down | Up | Updown |
| bos:point:<br/>shutter:left_right | Enum  | -  | -  | Left | Right  | Leftright  |
| bos:point:<br/>shutter:inclination  | Integer | Ratio  | Percent  | 0  | 100  |  |
| bos:point:<br/>shutter:level  | Integer | Ratio  | Percent  | 0  | 100  |  |
| bos:point:<br/>temp:ambient | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:difference  | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:offset  | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:discharge | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:exhaust | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:exterior  | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:other | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:return  | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:supply  | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:water | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:mixed_air | Float | Temperature  | DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint  | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_effective  | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_freeze | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_cool | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_cool_occ | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_cool_stby  | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_cool_unocc | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_frost_protection | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_heat | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_heat_occ | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_heat_stby  | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_heat_unocc | Float | Temperature  | DegreesCelsius | -999.999 | 99.999,99  |

Please find below a list of corresponding Enumeration types:

| Enum Name  | State Number | State Description  | Field point value |
|--|--|--|-|
|  |  |  | |
| HVAC_Mode  |  | bos:standardtype:hvacmode  | |
|  | 1  | Automatic  | 0 |
|  | 2  | Heating  | 1 |
|  | 3  | Morning warm-up  | 2 |
|  | 4  | Cooling  | 3 |
|  | 5  | Night purge  | 4 |
|  | 6  | Pre-cooling  | 5 |
|  | 7  | Off  | 6 |
|  | 8  | Test | 7 |
|  | 9  | Emergency heating  | 8 |
|  | 10 | Fan only | 9 |
|  | 11 | Free cooling | 10  |
|  | 12 | Ice-making mode  | 11  |
|  | 13 | Maximum heating  | 12  |
|  | 14 | Economic mode (heat/cool)  | 13  |
|  | 15 | Dehumidification | 14  |
|  | 16 | Calibration  | 15  |
|  | 17 | Emergency cooling  | 16  |
|  | 18 | Emergency steam  | 17  |
|  |  |  | |
| Occupancy  |  | bos:standardtype:occupancy | |
|  | 1  | Occupied | 0 |
|  | 2  | Unoccupied | 1 |
|  | 3  | Bypass | 2 |
|  | 4  | Stand-by | 3 |
|  |  |  | |
| HVAC_Status  |  | bos:standardtype:hvacstatus  | |
|  | 1  | Auto | 0 |
|  | 2  | Comfort  | 1 |
|  | 3  | Standby  | 2 |
|  | 4  | Economy  | 3 |
|  | 5  | Building Protection  | 4 |
|  |  |  | |
| HVAC_ChangeOver  |  | bos:standardtype:hvacchangeover  | |
|  | 1  | Auto | 0 |
|  | 2  | Cooling  | 1 |
|  | 3  | Heating  | 2 |
|  |  |  | |
| HVAC_Damper_Mode |  | bos:standardtype:hvacdampermode  | |
|  | 1  | Fresh Air  | 0 |
|  | 2  | Supply Air | 1 |
|  | 3  | Extract Air  | 2 |
|  |  |  | |
| HVAC_Fanspeed  |  | bos:standardtype:hvacfanspeed  | |
|  | 1  | Off  | -1  |
|  | 2  | Auto | 0 |
|  | 3  | Speed 1  | 33  |
|  | 4  | Speed 2  | 66  |
|  | 5  | Speed 3  | 100 |
| On_Off |  | bos:standardtype:onoff | |
|  | 1  | Off  | 0 |
|  | 2  | On | 1 |
| Override |  | bos:standardtype:override  | |
|  | 1  | Not overridden | 0 |
|  | 2  | Overridden | 1 |
| Motor_State  |  | bos:standardtype:motorstate  | |
|  | 1  | Stopped  | 0 |
|  | 2  | Starting | 1 |
|  | 3  | Accelerating | 2 |
|  | 4  | Standby  | 3 |
|  | 5  | Normal | 4 |
|  | 6  | Reference  | 5 |
|  | 7  | Decelerating | 6 |
|  | 8  | Stopping | 7 |
| Pump_Speed |  | bos:standardtype:pumpspeed | |
|  | 1  | Constant Speed | 0 |
|  | 2  | Variable Speed | 1 |
| Pump_Mode  |  | bos:standardtype:pumpmode  | |
|  | 1  | Off  | 0 |
|  | 2  | Max  | 1 |
|  | 3  | Control  | 2 |
|  | 4  | Hold | 3 |
|  | 5  | Limited Max  | 4 |
| Filter_state |  | bos:standardtype:filterstate | |
|  | 1  | Clean  | 0 |
|  | 2  | Dirty  | 1 |
| Evaporator_status  |  | bos:standardtype:evapstatus  | |
|  | 1  | Normal | 0 |
|  | 2  | Low pressure | 1 |
|  | 3  | Frozen | 2 |
| Device_Presence  |  | bos:standardtype:devicepresence  | |
|  | 1  | Absent | 0 |
|  | 2  | Present  | 1 |
| Open_Close |  | bos:standardtype:openclose | |
|  | 1  | Closed | 0 |
|  | 2  | Open | 1 |
| Auto_Manu  |  | bos:standardtype:automanu  | |
|  | 1  | Automatic  | 0 |
|  | 2  | Manual | 1 |
| Leak |  | bos:standardtype:leak  | |
|  | 1  | No Leak  | 0 |
|  | 2  | Leak | 1 |
| Updown |  | bos:standardtype:updown  | |
|  | 1  | Down | 0 |
|  | 2  | Up | 1 |
| Leftright  |  | bos:standardtype:leftright | |
|  | 1  | Left | 0 |
|  | 2  | Right  | 1 |
| Default_NC |  | bos:standardtype:defaultnc | |
|  | 1  | No Default | 0 |
|  | 2  | Default  | 1 |
| Default_NO |  | bos:standardtype:defaultno | |
|  | 1  | Default  | 0 |
|  | 2  | No Default | 1 |
| Fault  |  | bos:standardtype:fault | |
|  | 1  | No fault | 0 |
|  | 2  | Fault  | 1 |
| Fire |  | bos:standardtype:fire  | |
|  | 1  | No Fire  | 0 |
|  | 2  | Fire | 1 |
| Rotation |  | bos:standardtype:rotation  | |
|  | 1  | Clockwise  | 0 |
|  | 2  | Counterclockwise | 1 |
| HVAC_Damper3States |  | bos:standardtype:hvacdamper3states | |
|  | 1  | Closed | -1  |
|  | 2  | Auto | 0 |
|  | 3  | Mid  | 50  |
|  | 4  | Open | 100 |
| HVAC_Damper4States |  | bos:standardtype:hvacdamper4states | |
|  | 1  | Closed | -1  |
|  | 2  | Auto | 0 |
|  | 3  | Position 1 | 33  |
|  | 4  | Position 2 | 66  |
|  | 5  | Position 3 | 100 |
| Presence_Detection |  | bos:standardtype:presencedetection | |
|  | 1  | Not occupied | 0 |
|  | 2  | Occupied | 1 |
