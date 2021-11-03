# Associated tags with datapoints

| Tag  | Category<br/>Sub-Category | Datapoint name (display) | Description | Format | Unit Cat. (code)<br/>Unit (code)  | Min Value  | Max Value  | Enum Name  ||
| :- | :- | :- | :-- | :- | :- | :- | :- | :- | :- |
| bos:point:<br/>alarm:default_NC | Alarm| Default NC | Used to provide a feedback on a default - normally closed | Enum | - <br/>-  | No Default | Default  | Default_NC |
| bos:point:<br/>alarm:default_NO | Alarm| Default NO | Used to provide a feedback on a default - normally opened | Enum | - <br/>-  | Default  | No Default | Default_NO |
| bos:point:<br/>alarm:fault  | Alarm| Fault  | Used to provide a feedback on a fault | Enum | - <br/> -  | No Fault | Fault  | Fault  |
| bos:point:<br/>alarm:fire | Alarm| Fire | Used to report the state of a fire alarm system | Enum | - <br/> -  | No Fire  | Fire | Fire |
| bos:point:<br/>alarm:on_off | Alarm| On/Off | Used as a device output to report a boolean alarm state | Enum | - <br/> -  | Off  | On | On_Off |
| bos:point:<br/>datetime:day | Date & Time <br/> Date | Day  | Used to provide a day of the week (1=Monday to 7=Sunday)  | Integer  | - <br/>-  | 1  | 7  |  |
| bos:point:<br/>datetime:month | Date & Time <br/>Date | Month  | Used to provide a day of the month (1=January to 12=December) | Integer  | - <br/>-  | 1  | 31 |  |
| bos:point:<br/>datetime:year  | Date & Time <br/>Date | Year | Used to provide a year  | Integer  | - <br/>-  | 1  | 9.999  |  |
| bos:point:<br/>datetime:season  | Date & Time <br/>Season | Season | Used to provide a season as plain text  | String | - <br/>-  |  |  |  |
| bos:point:<br/>datetime:heat_season_start | Date & Time <br/>Season | Heating Season - Start | Used to provide the date at which the heating season starts and where heating equipment are turned on | Double | - <br/>-  | 01. Jan  | 31. Dez  |  |
| bos:point:<br/>datetime:heat_season_end | Date & Time <br/>Season | Heating Season - End | Used to provide the date at which the heating season ends and where heating equipment are turned off  | Double | - <br/>-  | 01. Jan  | 31. Dez  |  |
| bos:point:<br/>datetime:cool_season_start | Date & Time <br/>Season | Cooling Season - Start | Used to provide the date at which the cooling season starts and where cooling equipment are turned on | Double | - <br/>-  | 01. Jan  | 31. Dez  |  |
| bos:point:<br/>datetime:cool_season_end | Date & Time <br/>Season | Cooling Season - End | Used to provide the date at which the cooling season ends and where cooling equipment are turned off  | Double | - <br/>-  | 01. Jan  | 31. Dez  |  |
| bos:point:<br/>datetime:hours | Date & Time <br/>Time | Time - Hours | Used to provide the hours of the day in a 24h format  | Float  | Duration<br/>Hours  | 0,00 | 23,00  |  |
| bos:point:<br/>datetime:minutes | Date & Time <br/>Time | Time - Minutes | Used to provide the minutes of the hour | Float  | Duration<br/>Minutes  | 0,00 | 59,00  |  |
| bos:point:<br/>datetime:seconds | Date & Time <br/>Time | Seconds  | Used to provide the seconds of the minute | Float  | Duration<br/>Seconds  | 0,00 | 59,00  |  |
| bos:point:<br/>datetime:time _elapsed  | Date & Time <br/>Time | Time - Elapsed | Used ot provide the time elapsed since the previous event | Float  | Duration<br/>Seconds  | 0,00 | 999.999,99 |  |
| bos:point:<br/>datetime:timestamp | Date & Time <br/>Time | Timestamp  | Used to provide the timestamp of a particular event | Integer  | Duration<br/>Seconds  | 0  | 999.999  |  |
| bos:point:<br/>datetime:timezone  | Date & Time <br/>Time | Timezone | Used to provide a timezone  | Integer  | - <br/>-  | -12  | 14 |  |
| bos:point:<br/>datetime:delay | Date & Time <br/>Time | Delay  | Used to provide a delay | Integer  | Duration<br/>Seconds  | 0,00 | 999.999  |  |
| bos:point:<br/>datetime:hold_time | Date & Time <br/>Time | Hold time  | Usually used with a motion sensor, it represents how long a controller remains in a given state | Integer  | Duration<br/>Seconds  | 0,00 | 999.999  |  |
| bos:point:<br/>electricity:dry_contact  | Electricity <br/>  | Dry contact  | Used to communicate with electrical contacts such as breakers, switches, etc. | Enum | - <br/>-  | Off  | On | On_Off |
| bos:point:<br/>plug:managed plug  | Electricity <br/>  | Managed plug | Used to provide the state of a managed electrical plug (On/Off) | Enum | - <br/>-  | Off  | On | On_Off |
| bos:point:<br/>electricity:current_angle  | Electricity <br/> Current  | Angle  | Used to provide the instantaneous current phase angle | Float  | Angle <br/>Degrees  | -180,00  | 180,00 |  |
| bos:point:<br/>electricity:current_harmonics  | Electricity <br/> Current  | Harmonic | Used to provide the harmonics distortion rate (THD) of the current  | Float  | Angle<br/>Degrees  | -180,00  | 180,00 |  |
| bos:point:<br/>electricity:current  | Electricity <br/> Current  | Current  | Used to provide amperage measurement  | Float  | ElectricCurrent<br/>Amperes  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:resistance | Electricity <br/> Current  | Resistance | Used to provide the resistance of an electrical circuit | Float  | ElectricResistance<br/>Ohms | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>electricity:frequency  | Electricity <br/> Current  | Frequency  | Used for defining how many times one cycle of the waveform is repeated per second | Float  | Frequency<br/>Hertz  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_load | Electricity <br/> Power  | Load | Used for measure of electrical energy consumed, per unit of time, by an electric circuit  | Float  | Power<br/>Watts  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_reactive | Electricity <br/> Power  | Reactive Power | Used for the resultant power of an AC circuit when the current waveform is out of phase with the waveform of the voltage  | Float  | Power<br/>Watts  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_factor | Electricity <br/> Power  | Power factor | Used for the angle between the apparent power (U*I) vector and the active power component, described as phase displacement | Float  | PowerFactor<br/>PowerFactors | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_active | Electricity <br/> Power  | Active Power | Used for the power which is consumed or utilised in an AC Circuit | Float  | ReactivePower<br/>VoltamperesReactive  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_apparent | Electricity <br/> Power  | Apparent Power | Used for the combination of reactive power and active power. It is the product of a circuit’s voltage and current | Float  | ApparentEnergy<br/>Voltamperes  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:power_angle  | Electricity <br/> Power  | Power Angle  | Used to provide the instantaneous power phase angle | Float  | Angle<br/>Degrees  | -180,00  | 180  |  |
| bos:point:<br/>electricity:voltage_harmonics  | Electricity <br/> Voltage  | Harmonic | Used to provide the harmonic distortion rate (THD) of the voltage | Float  | Ratio<br/>Percent  | 0,00 | 99,99  |  |
| bos:point:<br/>electricity:voltage  | Electricity <br/> Voltage  | Voltage  | Used to provide voltage measurement | Float  | ElectricPotential<br/>Volts  | 0,00 | 999.999,99 |  |
| bos:point:<br/>electricity:voltage_angle  | Electricity <br/> Voltage  | Angle  | Used to provide the instantaneous voltage phase angle | Float  | Angle<br/>Degrees  | -180,00  | 180  |  |
| bos:point:<br/>hvac:coil_preheat_elec_power | HVAC  <br/>Coil | Preheating coil - Elec Power | Used to provide the percentage of usage of an electrical coil for preheating  | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:coil_preheat_elec_status  | HVAC  <br/>Coil | Preheating coil - Elec Status  | Used to provide the status of an electrical coil for preheating | Enum | -<br/>-  | Off  | On | On_Off |
| bos:point:<br/>hvac:coil_reheat_elec_power  | HVAC  <br/>Coil | Reheating coil - Elec Power  | Used to provide the percentage of usage of an electrical coil for reheating | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:coil_reheat_elec_status | HVAC  <br/>Coil | Reheating coil - Elec Status | Used to provide the status of an electrical coil for reheating  | Enum | -<br/>-  | Off  | On | On_Off |
| bos:point:<br/>hvac:coil_water  | HVAC  <br/>Coil | Heating/Cooling Coil - Water | Used to provide the percentage of usage of a water coil used either for heating or cooling with a changeover  | Float  | Ratio<br/>Percent  | 0,00 | 100,00 | On_Off |
| bos:point:<br/>hvac:coil_cool_water | HVAC  <br/>Coil | Cooling coil - Water | Used to provide the percentage of usage of a cooling water coil | Float  | Ratio<br/>Percent  | 0,00 | 100,00 | On_Off |
| bos:point:<br/>hvac:coil_heat_water | HVAC  <br/>Coil | Heating coil - Water | Used to provide the percentage of usage of a heating water coil | Float  | Ratio<br/>Percent  | 0,00 | 100,00 | On_Off |
| bos:point:<br/>hvac:damper mode | HVAC  <br/>Equipment  | Damper - Mode  | Used to provide damper mode (fresh air, supply, extract)  | Enum | -<br/>-  |  |  | HVAC_Damper_Mode |
| bos:point:<br/>hvac:damper_position | HVAC  <br/>Equipment  | Damper - Position  | Used to provide the actual position of the damper based on the damper feedback  | Integer  | Ratio<br/>Percent  | 0  | 100  |  |
| bos:point:<br/>hvac:damper_response | HVAC  <br/>Equipment  | Damper - Response  | Used to provide the multiplier (in %) applied to the calculated damper movement, used to adjust the reaction speed of the damper | Integer | Ratio<br/>Percent  | 0 | 100  |  |
| bos:point:<br/>hvac:damper_speed  | HVAC  <br/>Equipment  | Damper - Speed | Used to provide the time that the damper takes to go from the fully closed position to the fully open position or vice-versa | Integer | Duration<br/>Seconds  | 0 | 999.999  |  |
| bos:point:<br/>hvac:damper_rotation | HVAC  <br/>Equipment  | Damper - Rotation  | Used to provide the direction (clockwise or counter clockwise) in which the actuator rotates to open the damper  | Enum  | - <br/>-  | Clockwise | Counterclockwise | Rotation |
| bos:point:<br/>hvac:damper_3states  | HVAC  <br/>Equipment  | Damper - 3 states  | Used to provide the opening state of a damper over 4 positions (Closed/Mid/Full or Auto)  | Enum | -<br/>-  |  |  | HVAC_Damper3States |
| bos:point:<br/>hvac:damper_4states  | HVAC  <br/>Equipment  | Damper - 4 states  | Used to provide the opening state of a damper over 4 positions (Closed/33/66/100 or Auto) | Enum | -<br/>-  |  |  | HVAC_Damper4States |
| bos:point:<br/>hvac:evaporator_state  | HVAC  <br/>Equipment  | Evaporator State | Used to provide if the evaporator is running or not (on/off)  | Enum | -<br/>-  | Off  | On | On_Off |
| bos:point:<br/>hvac:evaporator_status | HVAC  <br/>Equipment  | Evaporator Status  | Used to provide condition status of the evaporator when running | Enum | -<br/>-  |  |  | Evaporator_status  |
| bos:point:<br/>hvac:filter state  | HVAC  <br/>Equipment  | Filter state | Used to provide the state of a filter (dirty/clean) | Enum | -<br/>-  | Clean  | Dirty  | Filter_state |
| bos:point:<br/>hvac:pump_speed  | HVAC  <br/>Equipment  | Pump Speed | Used to provide the speed mode of the pump  | Enum | -<br/>-  | Constant Speed | Variable Speed | Pump_Speed |
| bos:point:<br/>hvac:pump_mode | HVAC  <br/>Equipment  | Pump Mode  | Used to provide the control mode of the pump  | Enum | -<br/>-  |  |  | Pump_Mode  |
| bos:point:<br/>hvac:change_over | HVAC  <br/>Equipment  | Changeover | Used to provide the functioning mode (heating/cooling/auto) of a single coil equipment  | Enum | -<br/>-  |  |  | HVAC_ChangeOver  |
| bos:point:<br/>hvac:defrost | HVAC  <br/>Equipment  | Defrost  | Used to provide information about frost protection mode for a technical equipment | Enum | -<br/>-  | Off  | On | On_Off |
| bos:point:<br/>hvac:mode  | HVAC  <br/>Equipment  | HVAC Mode  | Used to provide if the equipment is in Cooling/Heating - Auto/Manu  | Enum | -<br/>-  |  |  | HVAC_Mode  |
| bos:point:<br/>hvac:status  | HVAC  <br/>Equipment  | HVAC Status  | Used to provide the HVAC status (auto, comfort, eco…) | Enum | -<br/>-  |  |  | HVAC_Status  |
| bos:point:<br/>hvac:motor_state | HVAC  <br/>Equipment  | Motor State  | Used to provide information about the state of a mechanical motor; whether pump, fan, or other  | Enum | -<br/>-  |  |  | Motor_State  |
| bos:point:<br/>hvac:on_off  | HVAC  <br/>Equipment  | On/Off | Used to provide the On/Off status of an HVAC equipment  | Enum | -<br/>-  | Off  | On | On_Off |
| bos:point:<br/>hvac:override  | HVAC  <br/>Equipment  | Override | Used for provide if the equipment is running nominally or forced externally | Enum | -<br/>-  | Not overridden | Overriden  | Override |
| bos:point:<br/>hvac:btu | HVAC  <br/>Equipment  | BTU  | Used to provide the thermal energy  | Float  | Energy<br/>BritishThermalUnits  | 0,00 |  |  |
| bos:point:<br/>hvac:pump_speed  | HVAC  <br/>Equipment  | Pump Speed | Used to provide the speed of a pump | Integer  | Ratio<br/>Percent  | 0  | 100  |  |
| bos:point:<br/>hvac:evaporator_drain  | HVAC  <br/>Equipment  | Evaporator Drain | Used to provide the quantity of water drained out, or released from, of an evaporator | Float  | Flow<br/>LitersPerHour  | 0,00 |  |  |
| bos:point:<br/>hvac:fresh_air_req_bool  | HVAC  <br/>Equipment  | Fresh Air Request Boolean  | Used to request supply of fresh air via a boolean value | Enum | -<br/>-  | Off  | On | On_Off |
| bos:point:<br/>hvac:fresh_air_req_weight  | HVAC  <br/>Equipment  | Fresh Air Request Weight | Used to request supply of fresh air via a weighted value  | Float  | - <br/>-  |  |  |  |
| bos:point:<br/>hvac:co2_control | HVAC  <br/>Equipment  | CO2 Control Status | Used to provide if CO2 control is active or not | Enum | -<br/>-  | Off  | On | On_Off |
| bos:point:<br/>hvac:fanspeed_3speed | HVAC  <br/>Fan  | Fan Speed - 3 Speeds | Used to provide the speed of a 3 speeds fan (Off/S1/S2/S3 or Auto)  | Enum | -<br/>-  |  |  | HVAC_Fanspeed  |
| bos:point:<br/>hvac:fanspeed_percent  | HVAC  <br/>Fan  | Fan Speed - Percent  | Used to provide the speed of a 0-10v fan, ranging from 0% to 100% | Integer  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:fan_start_stop  | HVAC  <br/>Fan  | Start/Stop | Used to provide the start/stop status of the fan  | Boolean  | -<br/>-  | Off  | On | On_Off |
| bos:point:<br/>hvac:air_flow  | HVAC  <br/>Flow | Air Flow Volume  | Used to provide the volume of an air flow | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_in | HVAC  <br/>Flow | Air Flow Volume - Intake | Used to provide the volume of an intake air flow  | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_out  | HVAC  <br/>Flow | Air Flow Volume - Supply | Used to provide the volume of a supply air flow | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:water_flow  | HVAC  <br/>Flow | Water Flow Volume  | Used to provide the volume of a water flow  | Float  | Flow<br/>LitersPerHour  | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint | HVAC  <br/>Flow | Air Flow Set Point | Used to provide the set point of an air flow volume | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_cool  | HVAC  <br/>Flow | Air Flow Set Point - Cooling | Used to provide the set point of an air flow volume in cooling mode | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_heat  | HVAC  <br/>Flow | Air Flow Set Point - Heating | Used to provide the set point of an air flow volume in heating mode | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_vent  | HVAC  <br/>Flow | Air Flow Set Point - Ventilation | Used to provide the set point of an air flow volume in ventilation mode | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_occ | HVAC  <br/>Flow | Air Flow Set Point - Occupied  | Used to provide the set point of an air flow volume when occupied | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_unocc | HVAC  <br/>Flow | Air Flow Set Point - Unoccupied  | Used to provide the set point of an air flow volume when unoccupied | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_stdby | HVAC  <br/>Flow | Air Flow Set Point - Standby | Used to provide the set point of an air flow volume when in standby | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_min | HVAC  <br/>Flow | Air Flow Set Point - Minimum | Used to provide the minimum air flow set point  | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:air_flow_setpoint_max | HVAC  <br/>Flow | Air Flow Set Point - Maximum | Used to provide the maximum air flow set point  | Float  | Flow<br/>CubicMetersPerHour | 0,00 |  |  |
| bos:point:<br/>hvac:valve_2way  | HVAC  <br/>Valve  | 2-way Actuator | Used to provide opening status of a 2-way regulation valve  | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_2way_cool | HVAC  <br/>Valve  | 2-way Actuator Cooling | Used to provide opening status of a 2-way regulation valve for cooling applications | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_2way_heat | HVAC  <br/>Valve  | 2-way Actuator Heating | Used to provide opening status of a 2-way regulation valve for heating applications | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_3way_cool | HVAC  <br/>Valve  | 3-way Actuator Cooling | Used to provide opening status of a 3-way regulation valve for cooling applications | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_3way_heat | HVAC  <br/>Valve  | 3-way Actuator Heating | Used to provide opening status of a 3-way regulation valve for heating applications | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>hvac:valve_6way  | HVAC  <br/>Valve  | 6-way Actuator | Used to provide opening status of a 6-way regulation valve for heating & cooling applications | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>light:auto_manu  | Light <br/>  | Auto/Manu  | Used to provide the lighting regulation mode, automatic or manually done  | Enum | -<br/>-  | Automatic  | Manual | Auto_Manu  |
| bos:point:<br/>light:on_off | Light <br/>  | On/Off | Used to provide an On/Off state of a light  | Enum | -<br/>-  | Off  | On | On_Off |
| bos:point:<br/>light:bounce time  | Light <br/>  | Bounce time  | Used to provide the bounce time between the On/Off states | Float  | Duration<br/>Seconds  | 1,00 |  |  |
| bos:point:<br/>light:brightness | Light <br/>  | Brightness | Used to provide the brightness level of a space | Integer  | Illuminance<br/>Lux  | 0  | 1.000.000  |  |
| bos:point:<br/>light:dimming  | Light <br/>  | Dimming  | Used to provide a dimming state (brightness level) of a Light <br/> Integer  | Ratio<br/>Percent  | 0  | 100  |  |
| bos:point:<br/>light:warmth | Light <br/>  | Warmth | Used to provide the lighting temperature (Warm White/Cold White)  | Integer  | Temperature<br/>Kelvins  | 1.000  | 100.000  |  |
| bos:point:<br/>measure:co2  | Measure <br/> Air  | CO2 Level  | Used to provide measure of CO2 levels | Integer  | Ratio<br/>PartsPerMillion  | 0,00 |  |  |
| bos:point:<br/>measure:co2_setpoint | Measure <br/> Air  | CO2 Set Point  | Used to provide target set point for CO2 level  | Integer  | Ratio<br/>PartsPerMillion  | 0,00 |  |  |
| bos:point:<br/>measure:voc  | Measure <br/> Air  | VOC Level  | Used to provide measure of Volatile organic compounds (VOCs) levels | Integer  | Ratio<br/>PartsPerBillion  | 0,00 |  |  |
| bos:point:<br/>measure:voc_setpoint | Measure <br/> Air  | VOC Set Point  | Used to provide target set point for Volatile organic compounds (VOCs)  | Integer  | Ratio<br/>PartsPerBillion  | 0,00 |  |  |
| bos:point:<br/>measure:smoke  | Measure <br/> Air  | Smoke  | Used to provide measure of smoke levels | Integer  | Ratio<br/>PartsPerBillion  | 0,00 |  |  |
| bos:point:<br/>measure:dew_point  | Measure <br/> Air  | Dew Point  | Used to provide the dew point of a space  | Integer  | Temperature<br/>DegreesCelsius |  |  |  |
| bos:point:<br/>measure:battery_level  | Measure <br/> Battery  | Battery level  | Used to provide the charge level of a battery | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>measure:battery_volt | Measure <br/> Battery  | Battery voltage  | Used to provide the voltage of a battery  | Float  | ElectricPotential<br/>Volts  | 0,00 | 100,00 |  |
| bos:point:<br/>measure:contact_door | Measure <br/> Contact  | Door | Used to provide the open/close status of a door | Enum | -<br/>-  | Closed | Open | Open_close |
| bos:point:<br/>measure:contact_window | Measure <br/> Contact  | Window | Used to provide the open/close status of a door | Enum | -<br/>-  | Closed | Open | Open_close |
| bos:point:<br/>measure:run_hours  | Measure <br/> Equipment  | Run Hours  | Used to provide the quantity of functioning hours | Float  | Duration<br/>Hours  | 0,00 |  |  |
| bos:point:<br/>measure:humidity_absolute  | Measure <br/> Humidity | Absolute | Used to provide absolute humidity measure of water vapor (moisture) in the air, regardless of Temperature <br/> Float  | Density<br/>GramsPerCubicMeter | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:humidity_relative  | Measure <br/> Humidity | Relative | Used to provide relative humidity, being the ratio of the current absolute humidity to the highest possible absolute humidity | Float  | Ratio<br/>Percent  | 0,00 | 100,00 |  |
| bos:point:<br/>measure:leak_water_detect  | Measure <br/> Leak | Water leak - Detection | Used to provide the status of detection of a liquid leak  | Enum | -<br/>-  | No leak  | Leak | Leak |
| bos:point:<br/>measure:leak_water_qty | Measure <br/> Leak | Water leak - Quantity  | Used to provide the quantity of a liquid leak | Float  | Volume<br/>Liters |  |  |  |
| bos:point:<br/>measure:leak_air_detect  | Measure <br/> Leak | Air leak - Detection | Used to provide the status of detection of an air leak  | Enum | -<br/>-  | No leak  | Leak | Leak |
| bos:point:<br/>measure:leak_air_qty | Measure <br/> Leak | Air leak - Quantity  | Used to provide the quantity of an air leak | Float  | Speed<br/>MetersPerSecond  |  |  |  |
| bos:point:<br/>measure:uv | Measure <br/> Light  | UV | Used to provide an UV (ultra-violets) radiation Measure <br/> Float  | Irradiance<br/>WattsPerSquareMeter  | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:luminosity | Measure <br/> Light  | Luminosity Intensity | Used to provide the intensity of luminosity, being luminous power per unit solid angle  | Float  | Luminance<br/>CandelasPerSquareMeter | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:sound_intensity  | Measure <br/> Sound  | Sound Intensity  | Used to report the intensity of a sound in decibels | Float  | Level<br/>Decibels | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:people_count | Measure <br/> Occupancy  | People Counted | Used to provide the quantity of people currently present in a space | Integer  | - <br/>-  | 0  |  |  |
| bos:point:<br/>measure:occupancy_status | Measure <br/> Occupancy  | Occupancy Status | Used to provide the occupancy status of a space (occupied, inoccupied, standby…)  | Enum | -<br/>-  |  |  | Occupancy  |
| bos:point:<br/>measure:detection  | Measure <br/> Occupancy  | Presence Detection | Used to provide the status of presence of a space, ex. from a PIR | Enum | -<br/>-  | Not occupied | Occupied | Presence_Detection |
| bos:point:<br/>measure:pressure_airflow | Measure <br/> Pressure | Air Flow Pressure  | Used to provide a pressure level of an air flow | Integer  | Pressure<br/>Hectopascals | -999.999 | 999.999  |  |
| bos:point:<br/>measure:pressure_equipment | Measure <br/> Pressure | Equipment Pressure | Used to provide a pressure level of a technical equipment (delta measured between 2 points) | Integer  | Pressure<br/>Kilopascals  | -999.999 | 999.999  |  |
| bos:point:<br/>measure:pressure_room  | Measure <br/> Pressure | Room Pressure  | Used to provide a pressure level within a room or a space | Integer  | Pressure<br/>Kilopascals  | 0  | 999.999  |  |
| bos:point:<br/>measure:pressure_water | Measure <br/> Pressure | Water Flow Pressure  | Used to provide a pressure level of a water flow  | Integer  | Pressure<br/>Kilopascals  | -999.999 | 999.999  |  |
| bos:point:<br/>measure:pressure_duct  | Measure <br/> Pressure | Duct Pressure  | Used to provide a pressure level within a duct  | Integer  | Pressure<br/>Kilopascals  | -999.999 | 999.999  |  |
| bos:point:<br/>measure:wind | Measure <br/> Weather  | Wind | Used to report the wind speed measured by a weather station | Float  | Speed<br/>MetersPerSecond  | 0,00 | 999.999,99 |  |
| bos:point:<br/>measure:rain | Measure <br/> Weather  | Rain | Used to report the rain quantity measured by a weather station  | Float  | Length<br/>Millimeters  | 0,00 | 999.999,99 |  |
| bos:point:<br/>metering:Electricity <br/> Metering  <br/> Consumption  | Electricity  | Used to provide amount of electricity consumed  | Float  | Energy<br/>KilowattHours  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:gas | Metering  <br/> Consumption  | Gas  | Used to provide amount of gas consumed  | Float  | Volume<br/>CubicMeters  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:water | Metering  <br/> Consumption  | Water  | Used to provide amount of water consumed  | Float  | Volume<br/>CubicMeters  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:steam | Metering  <br/> Consumption  | Steam  | Used to provide amount of steam consumed  | Float  | Volume<br/>CubicMeters  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:degree_days | Metering  <br/> Degree Days  | Degree Days  | Used to quantify the demand for energy needed to heat/cool a building | Integer  | - <br/>-  | -9.999.999 | 9.999.999  |  |
| bos:point:<br/>metering:degree_days_heat  | Metering  <br/> Degree Days  | Heating Degree Days  | Used to quantify the demand for energy needed to heat a building  | Integer  | - <br/> -  | -9.999.999 | 9.999.999  |  |
| bos:point:<br/>metering:degree_days_cool  | Metering  <br/> Degree Days  | Cooling Degree Days  | Used to quantify the demand for energy needed to cool a building  | Integer  | - <br/> -  | -9.999.999 | 9.999.999  |  |
| bos:point:<br/>metering:bioenergy | Metering  <br/> Production | Bioenergy  | Used to provide amount of calories produced by a bioenergy generation | Float  | Energy<br/>Joules | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:district_heating  | Metering  <br/> Production | District Heating | Used to provide amount of district heating calories consumed  | Float  | Energy<br/>Joules | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:geothermal  | Metering  <br/> Production | Geothermal | Used to provide amount of calories produced by a geothermal generation  | Float  | Energy<br/>Joules | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:photovoltaic  | Metering  <br/> Production | Solar Photovoltaic | Used to provide amount of photovoltaic power generated  | Float  | Energy<br/>KilowattHours  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:oil | Metering  <br/> Production | Oil  | Used to provide amount of oil consumed  | Float  | Volume<br/>Liters | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:solar_thermal | Metering  <br/> Production | Solar Thermal  | Used to provide amount of solar heated water  | Float  | Volume<br/>Liters | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>metering:windmill  | Metering  <br/> Production | Windmill | Used to provide amount of electricity produced by a windmill generation | Float  | Energy<br/>KilowattHours  | 0,00 | 99.999.999,99  |  |
| bos:point:<br/>other:currency | Others  <br/>  | Currency | Used to represent a currency  | String | - <br/> -  |  |  |  |
| bos:point:<br/>other:device_presence  | Others  <br/> Equipment  | Device Presence  | Used to report the presence/absence of a device | Enum | -<br/> -  | Absent | Present  | Device_Presence  |
| bos:point:<br/>other:ip_address | Others  <br/> Equipment  | IP Address | Used to provide an IP v4 address  | String | - <br/> -  |  |  |  |
| bos:point:<br/>other:ip_address_v6  | Others  <br/> Equipment  | IP Address v6  | Used to provide an IP v6 address  | String | - <br/> -  |  |  |  |
| bos:point:<br/>other:ip_protection  | Others  <br/> Equipment  | IP Protection  | Used to provide the protection level (Ingress Protection) of an element | String | - <br/> -  |  |  |  |
| bos:point:<br/>others:manufacturer  | Others  <br/> Equipment  | Manufacturer | Used to provide the manufacturer of an equipment  | String | -  <br/> -  |  |  |  |
| bos:point:<br/>others:reference | Others  <br/> Equipment  | Reference  | Used to provide the reference of an equipment | String | -  <br/> -  |  |  |  |
| bos:point:<br/>others:version | Others  <br/> Equipment  | Version  | Used to provide the version of an equipment | String | -  <br/> -  |  |  |  |
| bos:point:<br/>other:scene  | Others  <br/> Amenities  | Scene Control  | Provide the number of the scene to be played  | Integer  | -  <br/> -  | 0,00 | 4.096  |  |
| bos:point:<br/>other:coffee_machine | Others  <br/> Amenities  | Coffee Machine | Used to provide the presence of a coffee machine  | Integer  | -  <br/> -  | 0,00 |  |  |
| bos:point:<br/>other:videoconference  | Others  <br/> Amenities  | Videoconference  | Used to provide the presence of a videoconference system  | Integer  | -  <br/> -  | 0,00 |  |  |
| bos:point:<br/>other:video projector  | Others  <br/> Amenities  | Video Projector  | Used to provide the quantity of video projectors  | Integer  | -  <br/> -  | 0,00 |  |  |
| bos:point:<br/>other:tv_screen  | Others  <br/> Amenities  | TV Screen  | Used to provide the quantity of TV screens  | Integer  | -  <br/> -  | 0,00 |  |  |
| bos:point:<br/>other:white_board  | Others  <br/> Amenities  | White Board  | Used to provide the quantity of white boards  | Integer  | -  <br/> -  | 0,00 |  |  |
| bos:point:<br/>other:sound_system | Others  <br/> Amenities  | Sound system | Used to provide the quantity of sound systems | Integer  | -  <br/> -  | 0,00 |  |  |
| bos:point:<br/>other:microphone | Others  <br/> Amenities  | Microphone | Used to provide the quantity of microphones | Integer  | -  <br/> -  | 0,00 |  |  |
| bos:point:<br/>other:surface_gross  | Others  <br/> Dimensions | Surface - Gross  | Used to provide a gross surface | Float  | Area <br/> SquareMeters | 0,00 |  |  |
| bos:point:<br/>other:surface_net  | Others  <br/> Dimensions | Surface - Net  | Used to provide a net surface | Float  | Area <br/> SquareMeters | 0,00 |  |  |
| bos:point:<br/>other:height | Others  <br/> Dimensions | Height | Used to provide the height of an element  | Float  | Length <br/> Meters | 0,00 |  |  |
| bos:point:<br/>other:length | Others  <br/> Dimensions | Length | Used to provide the length of an element  | Float  | Length <br/> Meters | 0,00 |  |  |
| bos:point:<br/>other:width  | Others  <br/> Dimensions | Width  | Used to provide the width of an element | Float  | Length <br/> Meters | 0,00 |  |  |
| bos:point:<br/>other:weigth | Others  <br/> Dimensions | Weight | Used to provide the weight of an element  | Float  | Mass <br/> Kilograms  | 0,00 |  |  |
| bos:point:<br/>other:volume_space | Others  <br/> Dimensions | Volume - Space | Used to provide a volume of a space | Float  | Volume <br/> CubicMeters  | 0,00 |  |  |
| bos:point:<br/>other:seats  | Others  <br/> Dimensions | Seats  | Used to provide the quantity of seats | Integer  | -  <br/> -  | 0,00 |  |  |
| bos:point:<br/>others:people_max  | Others  <br/> Dimensions | People - Maximum | Used to provide the maximum of people allowed like in a space or in a building  | Integer  | -  <br/> -  | 0  | 999.999  |  |
| bos:point:<br/>other:density  | Others  <br/> Physics  | Density  | Used to provide density of a material | Integer  | Density <br/> GramsPerCubicMeter | 0,00 |  |  |
| bos:point:<br/>other:ph | Others  <br/> Physics  | pH | Used to provide of how acidic/basic an aqueous solution is  | Float  | - <br/>  -  | 0,00 | 14,00  |  |
| bos:point:<br/>other:enthalpy | Others  <br/> Physics  | Enthalpy | Used to provide the sum of the internal energy and the product of the pressure and volume of a thermodynamic system | Float  | Energy <br/> Joules | 0,00 |  |  |
| bos:point:<br/>other:entropy  | Others  <br/> Physics  | Entropy  | Used to provide a system’s thermal energy per unit temperature that is unavailable for doing useful work  | Float  | HeatCapacity <br/> JoulesPerKelvin  | 0,00 |  |  |
| bos:point:<br/>other:mass | Others  <br/> Physics  | Mass | Used to provide the amount of matter in an object, different from weight  | Float  | Mass <br/> Kilograms  | 0,00 |  |  |
| bos:point:<br/>hvac:rotation  | Others  <br/> Physics  | Rotation | Used to provide the angular velocity of an element  | Float  | RotationalSpeed <br/> RevolutionsPerMinute |  |  |  |
| bos:point:<br/>others:material  | Others  <br/> Physics  | Material | Used to provide the material of an element like equipment, wall, ceiling, etc.  | String | -  <br/> -  |  |  |  |
| bos:point:<br/>other:color  | Others  <br/> Physics  | Color  | Used to provide the color of an element | String | -  <br/> -  |  |  |  |
| bos:point:<br/>other:speed  | Others  <br/> Physics  | Speed  | Provide the speed of an element | Float  | Speed <br/> MetersPerSecond  | 0,00 | 299.792.458,00 |  |
| bos:point:<br/>other:volume_liquid  | Others  <br/> Physics  | Volume - Liquid  | Used to provide a volume (of a liquid for instance) | Float  | Volume <br/> Liters | 0,00 |  |  |
| bos:point:<br/>shutter:auto_manu  | Shutter <br/>  | Auto/Manu  | Used for auto/manu shutter control  | Enum | -<br/>-  | Automatic  | Manual | Auto_Manu  |
| bos:point:<br/>shutter:up_down  | Shutter <br/>  | Up/Down  | Used for shutter up/down status | Enum | -<br/>-  | Down | Up | Updown |
| bos:point:<br/>shutter:left_right | Shutter <br/>  | Left/Right | Used for shutter left/right status  | Enum | -<br/>-  | Left | Right  | Leftright  |
| bos:point:<br/>shutter:inclination  | Shutter <br/>  | Inclination  | Used for shutter inclination angle  | Integer  | Ratio <br/> Percent  | 0  | 100  |  |
| bos:point:<br/>shutter:level  | Shutter <br/>  | Level  | Used for shutter opening level  | Integer  | Ratio <br/> Percent  | 0  | 100  |  |
| bos:point:<br/>temp:ambient | Temperature <br/> Measure  | Ambient  | Used to provide the ambient temperature within a space  | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:difference  | Temperature <br/> Measure  | Difference | Used to provide the difference of a temperature measurement | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:offset  | Temperature <br/> Measure  | Offset | Used to provide the offset of a temperature, usually used for temperature control | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:discharge | Temperature <br/> Measure  | Discharge  | Used to provide capacity control of heating and cooling equipment via a duct mounted temperature sensor | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:exhaust | Temperature <br/> Measure  | Exhaust  | Used to provide the temperature of the exhausted air  | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:exterior  | Temperature <br/> Measure  | Exterior | Used to provide the outside Temperature <br/> Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:other | Temperature <br/> Measure  | Other  | Used to provide any other temperature measurement/command | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:return  | Temperature <br/> Measure  | Return | Used to provide the temperature of the return air | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:supply  | Temperature <br/> Measure  | Supply | Used to provide the temperature of the air supply | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:water | Temperature <br/> Measure  | Water  | Used to provide the temperature of water  | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:mixed_air | Temperature <br/> Measure  | Mixed Air  | Used to provide the temperature of mixed air  | Float  | Temperature <br/> DegreesCelsius | -99.999,90 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint  | Temperature <br/> Set point  | Set point  | Used to provide the desired temperature of a space or a technical equipment | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_effective  | Temperature <br/> Set point  | Effective set point  | Used to provide the actual setpoint calculated by the PID loop of an equipment  | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_freeze | Temperature <br/> Set point  | Freeze protection set point  | Used to provide the freeze protection setpoint under which the equipment will turn heating on | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_cool | Temperature <br/> Set point  | Set point - Cooling  | Used to provide the set point in cooling mode | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_cool_occ | Temperature <br/> Set point  | Set point - Cooling Occupied | Used to provide the set point in cooling mode and occupied  | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_cool_stby  | Temperature <br/> Set point  | Set point - Cooling Standby  | Used to provide the set point in cooling mode and standby | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_cool_unocc | Temperature <br/> Set point  | Set point - Cooling Unoccupied | Used to provide the set point in cooling mode and unoccupied  | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_frost_protection | Temperature <br/> Set point  | Set point - Frost Protection | Temperature set point for frost guard/protection  | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_heat | Temperature <br/> Set point  | Set point - Heating  | Used to provide the set point in heating mode | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_heat_occ | Temperature <br/> Set point  | Set point - Heating Occupied | Used to provide the set point in heating mode and occupied  | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_heat_stby  | Temperature <br/> Set point  | Set point - Heating Standby  | Used to provide the set point in heating mode and standby | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
| bos:point:<br/>temp:setpoint_heat_unocc | Temperature <br/> Set point  | Set point - Heating Unoccupied | Used to provide the set point in heating mode and unoccupied  | Float  | Temperature <br/> DegreesCelsius | -999.999 | 99.999,99  |  |
