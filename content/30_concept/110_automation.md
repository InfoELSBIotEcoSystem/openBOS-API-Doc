# Handle automation functions

openBOS&reg; manages automation functions such as alarming and trending. 

openBOS&reg; publishes alarms and trends of the  Building Management System. An alarm compares the value from a monitored variable with the conditions of the alarm and 
generates an event if the conditions are fulfilled.
The Building Management System uses a trend log to collect data and then stores the records in a file. A trend is a log of values with their respective timestamps of a physical 
datapoint coming from a sensor. 
Values are stored  with a time frequency acquisition.



On a real site, openBOS&reg; runs on a Building edge. This is a physical piece of hardware located on premises that secured the connection between
 the sensors and actuators physically present in the building 
and the internet. ABB offers a collection of Building edges on which openBOS&reg; runs. You may interface with all of them.

These automation functions may be linked to a datapoint, a zone, a structure, 
a functional block, ...

Alarms are features of a collection of triggers (threshold, hysteresis, ...). Trend logs feature a retention policy. 

All the API endpoints are available to developers.

![Automation functions](/assets/openbos-documentation/static/images/Automation_hierarchy.png "Automation functions")

![Legend](/assets/openbos-documentation/static/images/Structure_legend.png "Legend")
