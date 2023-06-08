# Schemas

<h2 id="tocS_AccessRightDTO">AccessRightDTO</h2>
<!-- backwards compatibility -->
<a id="schemaaccessrightdto"></a>
<a id="schema_AccessRightDTO"></a>
<a id="tocSaccessrightdto"></a>
<a id="tocsaccessrightdto"></a>

```json
{
  "code": "string",
  "description": "string",
  "name": "string"
}

```

Access Right definition

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|Identification code|
|description|string¦null|false|none|Localized description|
|name|string¦null|false|none|Localized name|

<h2 id="tocS_AcknowledgeAlarmDTO">AcknowledgeAlarmDTO</h2>
<!-- backwards compatibility -->
<a id="schemaacknowledgealarmdto"></a>
<a id="schema_AcknowledgeAlarmDTO"></a>
<a id="tocSacknowledgealarmdto"></a>
<a id="tocsacknowledgealarmdto"></a>

```json
{
  "id": "string",
  "comment": "string"
}

```

Information to acknowledge an alarm

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of a live alarm to acknowledge|
|comment|string¦null|false|none|Comment of the acknowledge|

<h2 id="tocS_ActionDTO">ActionDTO</h2>
<!-- backwards compatibility -->
<a id="schemaactiondto"></a>
<a id="schema_ActionDTO"></a>
<a id="tocSactiondto"></a>
<a id="tocsactiondto"></a>

```json
{
  "id": "string",
  "name": "string",
  "custom": true,
  "color": "string",
  "valuesCanBeEditedInOperation": true,
  "actionElements": [
    {
      "priority": 0,
      "value": null,
      "type": "TemplateDatapointWriteDTO",
      "id": "string"
    }
  ]
}

```

Definition of an action for a schedule configuration.
An action is a set of elements (datapoint values to write) that will be executed by a schedule at a certain time.
Works for both template and individual schedules.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the action|
|name|string¦null|false|none|Name of the action|
|custom|boolean|false|none|Is the action custom (IE: Created in operator tool)|
|color|string¦null|false|none|Color of the action|
|valuesCanBeEditedInOperation|boolean|false|none|Whether the Values can be edited in operator tool<br>If the action is custom, always true|
|actionElements|[oneOf]¦null|false|none|Definition of elements associated with the action<br>ActionElementDatapointTemplateWriteDTO for a template schedule configuration<br>Or<br>ActionElementDatapointInstanceWriteDTO for an individual schedule configuration|

<h2 id="tocS_ActionElementType">ActionElementType</h2>
<!-- backwards compatibility -->
<a id="schemaactionelementtype"></a>
<a id="schema_ActionElementType"></a>
<a id="tocSactionelementtype"></a>
<a id="tocsactionelementtype"></a>

```json
"TemplateDatapointWriteDTO"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|TemplateDatapointWriteDTO|
|*anonymous*|IndividualDatapointWriteDTO|
|*anonymous*|ElementDatapointWriteDTO|

<h2 id="tocS_AdvancedDatapointInstanceDTO">AdvancedDatapointInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemaadvanceddatapointinstancedto"></a>
<a id="schema_AdvancedDatapointInstanceDTO"></a>
<a id="tocSadvanceddatapointinstancedto"></a>
<a id="tocsadvanceddatapointinstancedto"></a>

```json
{
  "datapointInstanceId": "string",
  "datapointTemplateId": "string",
  "direction": "Feedback",
  "displayName": "string",
  "displayUnit": "string",
  "dataType": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  }
}

```

Detailed information about a datapoint instance into a functional block or a zone instance control panel

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointInstanceId|string¦null|false|none|Unique identifier of the datapoint instance|
|datapointTemplateId|string¦null|false|none|Unique identifier of the datapoint template|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|displayName|string¦null|false|none|Display name|
|displayUnit|string¦null|false|none|Display unit|
|dataType|any|false|none|Data type|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

<h2 id="tocS_AdvancedDatapointTemplateDTO">AdvancedDatapointTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemaadvanceddatapointtemplatedto"></a>
<a id="schema_AdvancedDatapointTemplateDTO"></a>
<a id="tocSadvanceddatapointtemplatedto"></a>
<a id="tocsadvanceddatapointtemplatedto"></a>

```json
{
  "datapointTemplateId": "string",
  "direction": "Feedback",
  "displayName": "string",
  "displayUnit": "string",
  "dataType": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  }
}

```

Detailed information about a datapoint template configured into an asset or a zone template control panel

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointTemplateId|string¦null|false|none|Unique identifier of the datapoint template|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|displayName|string¦null|false|none|Display name|
|displayUnit|string¦null|false|none|Display unit|
|dataType|any|false|none|Data type|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

<h2 id="tocS_AdvancedPropertyInstanceDTO">AdvancedPropertyInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemaadvancedpropertyinstancedto"></a>
<a id="schema_AdvancedPropertyInstanceDTO"></a>
<a id="tocSadvancedpropertyinstancedto"></a>
<a id="tocsadvancedpropertyinstancedto"></a>

```json
{
  "propertyInstanceId": "string",
  "propertyTemplateId": "string",
  "propertyInstanceValue": null,
  "direction": "Feedback",
  "displayName": "string",
  "displayUnit": "string",
  "dataType": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  }
}

```

Detailed information about a property datapoint instance into a functional block or a zone instance control panel

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|propertyInstanceId|string¦null|false|none|Unique identifier of the property instance|
|propertyTemplateId|string¦null|false|none|Unique identifier of the property template|
|propertyInstanceValue|any|false|none|Property instance value|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|displayName|string¦null|false|none|Display name|
|displayUnit|string¦null|false|none|Display unit|
|dataType|any|false|none|Data type|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

<h2 id="tocS_AdvancedPropertyTemplateDTO">AdvancedPropertyTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemaadvancedpropertytemplatedto"></a>
<a id="schema_AdvancedPropertyTemplateDTO"></a>
<a id="tocSadvancedpropertytemplatedto"></a>
<a id="tocsadvancedpropertytemplatedto"></a>

```json
{
  "propertyDatapointTemplateId": "string",
  "direction": "Feedback",
  "displayName": "string",
  "displayUnit": "string",
  "dataType": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  }
}

```

Detailed information about a property datapoint template configured into an asset or a zone template control panel

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|propertyDatapointTemplateId|string¦null|false|none|Unique identifier of the property datapoint template|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|displayName|string¦null|false|none|Display name|
|displayUnit|string¦null|false|none|Display unit|
|dataType|any|false|none|Data type|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

<h2 id="tocS_AlarmConfigurationDTO">AlarmConfigurationDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmconfigurationdto"></a>
<a id="schema_AlarmConfigurationDTO"></a>
<a id="tocSalarmconfigurationdto"></a>
<a id="tocsalarmconfigurationdto"></a>

```json
{
  "name": "string",
  "frequency": 5000,
  "needAcknowledged": false,
  "deadband": 0,
  "triggers": [
    {
      "type": "string",
      "id": "string",
      "name": "string",
      "description": "string",
      "severity": "Log"
    }
  ],
  "hysteresis": 0
}

```

Alarm configuration

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the alarm template|
|frequency|integer(int64)¦null|false|none|Period of the alarm updates in milliseconds.<br>If not present it is will be 10 seconds, if zero disable the trend|
|needAcknowledged|boolean|false|none|Need acknowledged|
|deadband|number(double)¦null|false|none|Deadband<br>If not present it is will be 0|
|triggers|[oneOf]¦null|false|none|Triggers.<br>If no trigger the default trigger depend on the datapoint|

oneOf - discriminator: AlarmTriggerDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDTO](#schemaalarmtriggerdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalOFFDTO](#schemaalarmtriggerdigitaloffdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalONDTO](#schemaalarmtriggerdigitalondto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiDTO](#schemaalarmtriggerhidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiHiDTO](#schemaalarmtriggerhihidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerInBandDTO](#schemaalarmtriggerinbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoDTO](#schemaalarmtriggerlodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoLoDTO](#schemaalarmtriggerlolodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNetworkDTO](#schemaalarmtriggernetworkdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNotValueDTO](#schemaalarmtriggernotvaluedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerOutOfBandDTO](#schemaalarmtriggeroutofbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerValueDTO](#schemaalarmtriggervaluedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|hysteresis|number(double)¦null|false|none|Hysteresis.<br>If not present it will be 0|

<h2 id="tocS_AlarmHistoricDTO">AlarmHistoricDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmhistoricdto"></a>
<a id="schema_AlarmHistoricDTO"></a>
<a id="tocSalarmhistoricdto"></a>
<a id="tocsalarmhistoricdto"></a>

```json
{
  "id": "string",
  "middlewareId": "string",
  "alarmInstanceId": "string",
  "dataPointInstanceId": "string",
  "alarmTriggerId": "string",
  "dataPointName": "string",
  "alarmInstanceName": "string",
  "sessionId": "string",
  "description": "string",
  "trigger": "none",
  "active": true,
  "acked": true,
  "closed": true,
  "desynchro": true,
  "timeStamp": "2019-08-24T14:15:22Z",
  "quality": "none",
  "value": 0,
  "userId": "string",
  "comment": "string",
  "needAcknowledge": true,
  "severity": "Log",
  "functionalBlockName": "string",
  "functionalBlockId": "string",
  "zoneName": "string",
  "zoneId": "string",
  "structureName": "string",
  "dataPointTags": [
    "string"
  ],
  "displayUnitShortString": "string"
}

```

This DTO is used when you return alarm historic

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the alarm historic|
|middlewareId|string¦null|false|none|Id of the alarm historic in the middleware|
|alarmInstanceId|string¦null|false|none|Id of the alarm instance|
|dataPointInstanceId|string¦null|false|none|Id of the datapoint instance|
|alarmTriggerId|string¦null|false|none|Id of the alarm trigger|
|dataPointName|string¦null|false|none|Name of the datapoint instance|
|alarmInstanceName|string¦null|false|none|Name of the alarm instance|
|sessionId|string¦null|false|none|Id of the alarm historic session in the middleware|
|description|string¦null|false|none|Description of the alarm historic|
|trigger|[BOSAlarmTrigger](#schemabosalarmtrigger)|false|none|none|
|active|boolean|false|none|Active flag for alarm historic|
|acked|boolean|false|none|Acked flag for alarm historic|
|closed|boolean|false|none|Closed flag for alarm historic|
|desynchro|boolean|false|none|Desynchro flag for alarm historic|
|timeStamp|string(date-time)|false|none|Date of the alarm historic|
|quality|[MiddlewareQuality](#schemamiddlewarequality)|false|none|none|
|value|number(double)|false|none|Valie of the alarm historic|
|userId|string¦null|false|none|Id of the user that acks the alarm|
|comment|string¦null|false|none|Comment of the ack of the alarm|
|needAcknowledge|boolean|false|none|Need acknowledge or not|
|severity|[AlarmSeverity](#schemaalarmseverity)|false|none|none|
|functionalBlockName|string¦null|false|none|Functional block name if datapoint belongs to a functional block|
|functionalBlockId|string¦null|false|none|Functional block id if datapoint belongs to a functional block|
|zoneName|string¦null|false|none|Zone name if datapoint belongs to a zone|
|zoneId|string¦null|false|none|Zone id if datapoint belongs to a zone|
|structureName|string¦null|false|none|Structure name of the zone or of the functional block|
|dataPointTags|[string]¦null|false|none|List of tag matching the datapoint|
|displayUnitShortString|string¦null|false|none|Display unit short string|

<h2 id="tocS_AlarmInstanceAdvancedDTO">AlarmInstanceAdvancedDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarminstanceadvanceddto"></a>
<a id="schema_AlarmInstanceAdvancedDTO"></a>
<a id="tocSalarminstanceadvanceddto"></a>
<a id="tocsalarminstanceadvanceddto"></a>

```json
{
  "zoneId": "string",
  "zoneName": "string",
  "zoneTemplateName": "string",
  "zoneParentName": "string",
  "functionalBlockId": "string",
  "functionalBlockName": "string",
  "functionalBlockTemplateName": "string",
  "id": "string",
  "datapoint": {
    "identifier": {
      "type": 0,
      "busDatapointId": "string",
      "networkId": "string",
      "id": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    },
    "displayName": "string"
  },
  "active": true,
  "hysteresis": 0,
  "needAcknowledge": true,
  "triggers": [
    {
      "type": "string",
      "id": "string",
      "name": "string",
      "description": "string",
      "severity": "Log"
    }
  ],
  "override": true,
  "alarmTemplateId": "string",
  "deadband": 0,
  "frequency": 0,
  "applicationSource": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneId|string¦null|false|none|ID of the zone of the datapoint instance or empty|
|zoneName|string¦null|false|none|Name of the zone of the datapoint instance or empty|
|zoneTemplateName|string¦null|false|none|Name of the zone template of the datapoint instance or empty|
|zoneParentName|string¦null|false|none|Name of the zone parent of the zone of the datapoint instance or empty|
|functionalBlockId|string¦null|false|none|Id of the functionalBlock of the datapoint instance or empty|
|functionalBlockName|string¦null|false|none|Name of the functionalBlock of the datapoint instance or empty|
|functionalBlockTemplateName|string¦null|false|none|Name of the functionalBlock template of the datapoint instance or empty|
|id|string¦null|false|none|Id of the alarm instance|
|datapoint|[DatapointIdentifierWithNameDTO](#schemadatapointidentifierwithnamedto)|false|none|Common data for all datapoint identifier dtos with display name|
|active|boolean|false|none|Active flag for the alarm instance|
|hysteresis|number(double)|false|none|Hysteresis of the alarm instance|
|needAcknowledge|boolean|false|none|NeedAcknowledge flag for the alarm instance        <br>If true the alarm disappears only when no more present on network AND acknowledged.<br>If false the alarm disappears when no more present on network even if not acknowledged.|
|triggers|[oneOf]¦null|false|none|List of alarm trigger for the alarm instance|

oneOf - discriminator: AlarmTriggerDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDTO](#schemaalarmtriggerdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalOFFDTO](#schemaalarmtriggerdigitaloffdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalONDTO](#schemaalarmtriggerdigitalondto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiDTO](#schemaalarmtriggerhidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiHiDTO](#schemaalarmtriggerhihidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerInBandDTO](#schemaalarmtriggerinbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoDTO](#schemaalarmtriggerlodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoLoDTO](#schemaalarmtriggerlolodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNetworkDTO](#schemaalarmtriggernetworkdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNotValueDTO](#schemaalarmtriggernotvaluedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerOutOfBandDTO](#schemaalarmtriggeroutofbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerValueDTO](#schemaalarmtriggervaluedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|override|boolean|false|none|Override flag of the alarm instance. This flag is only used when alarm instance is created from alarm template<br>   If true, some data of the alarm instance has replaced that coming from alarm template|
|alarmTemplateId|string¦null|false|none|Id of the alarm template|
|deadband|number(double)|false|none|Deadband of the alarm instance|
|frequency|integer(int64)¦null|false|none|Period of the alarm updates in milliseconds.|
|applicationSource|string¦null|false|none|Name of the application responsible for alarm instance creation/update. May be null|

<h2 id="tocS_AlarmInstanceCreationDTO">AlarmInstanceCreationDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarminstancecreationdto"></a>
<a id="schema_AlarmInstanceCreationDTO"></a>
<a id="tocSalarminstancecreationdto"></a>
<a id="tocsalarminstancecreationdto"></a>

```json
{
  "datapoint": {
    "identifier": {
      "type": 0,
      "busDatapointId": "string",
      "networkId": "string",
      "id": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    },
    "displayName": "string"
  },
  "active": true,
  "hysteresis": 0,
  "needAcknowledge": true,
  "triggers": [
    {
      "type": "string",
      "id": "string",
      "name": "string",
      "description": "string",
      "severity": "Log"
    }
  ],
  "deadband": 0,
  "frequency": 0,
  "applicationSource": "string",
  "functionalBlockId": "string",
  "zoneId": "string"
}

```

This DTO is used when we create a new AlarmInstance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapoint|[DatapointIdentifierWithNameDTO](#schemadatapointidentifierwithnamedto)|false|none|Common data for all datapoint identifier dtos with display name|
|active|boolean|false|none|Active flag for the alarm instance|
|hysteresis|number(double)|false|none|Hysteresis of the alarm instance|
|needAcknowledge|boolean|false|none|NeedAcknowledge flag for the alarm instance  <br>If true the alarm disappears only when no more present on network AND acknowledged.<br>If false the alarm disappears when no more present on network even if not acknowledged.|
|triggers|[oneOf]¦null|false|none|List of alarm trigger for the alarm instance|

oneOf - discriminator: AlarmTriggerDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDTO](#schemaalarmtriggerdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalOFFDTO](#schemaalarmtriggerdigitaloffdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalONDTO](#schemaalarmtriggerdigitalondto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiDTO](#schemaalarmtriggerhidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiHiDTO](#schemaalarmtriggerhihidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerInBandDTO](#schemaalarmtriggerinbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoDTO](#schemaalarmtriggerlodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoLoDTO](#schemaalarmtriggerlolodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNetworkDTO](#schemaalarmtriggernetworkdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNotValueDTO](#schemaalarmtriggernotvaluedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerOutOfBandDTO](#schemaalarmtriggeroutofbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerValueDTO](#schemaalarmtriggervaluedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|deadband|number(double)|false|none|Deadband of the alarm instance|
|frequency|integer(int64)¦null|false|none|Period in milliseconds|
|applicationSource|string¦null|false|none|Name of the application responsible for alarm instance creation/update. May be null|
|functionalBlockId|string¦null|false|none|Id of asset. For individual alarms only.|
|zoneId|string¦null|false|none|Id of zone. For individual alarms only.|

<h2 id="tocS_AlarmInstanceDTO">AlarmInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarminstancedto"></a>
<a id="schema_AlarmInstanceDTO"></a>
<a id="tocSalarminstancedto"></a>
<a id="tocsalarminstancedto"></a>

```json
{
  "id": "string",
  "datapoint": {
    "identifier": {
      "type": 0,
      "busDatapointId": "string",
      "networkId": "string",
      "id": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    },
    "displayName": "string"
  },
  "active": true,
  "hysteresis": 0,
  "needAcknowledge": true,
  "triggers": [
    {
      "type": "string",
      "id": "string",
      "name": "string",
      "description": "string",
      "severity": "Log"
    }
  ],
  "override": true,
  "alarmTemplateId": "string",
  "deadband": 0,
  "frequency": 0,
  "applicationSource": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the alarm instance|
|datapoint|[DatapointIdentifierWithNameDTO](#schemadatapointidentifierwithnamedto)|false|none|Common data for all datapoint identifier dtos with display name|
|active|boolean|false|none|Active flag for the alarm instance|
|hysteresis|number(double)|false|none|Hysteresis of the alarm instance|
|needAcknowledge|boolean|false|none|NeedAcknowledge flag for the alarm instance        <br>If true the alarm disappears only when no more present on network AND acknowledged.<br>If false the alarm disappears when no more present on network even if not acknowledged.|
|triggers|[oneOf]¦null|false|none|List of alarm trigger for the alarm instance|

oneOf - discriminator: AlarmTriggerDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDTO](#schemaalarmtriggerdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalOFFDTO](#schemaalarmtriggerdigitaloffdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalONDTO](#schemaalarmtriggerdigitalondto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiDTO](#schemaalarmtriggerhidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiHiDTO](#schemaalarmtriggerhihidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerInBandDTO](#schemaalarmtriggerinbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoDTO](#schemaalarmtriggerlodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoLoDTO](#schemaalarmtriggerlolodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNetworkDTO](#schemaalarmtriggernetworkdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNotValueDTO](#schemaalarmtriggernotvaluedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerOutOfBandDTO](#schemaalarmtriggeroutofbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerValueDTO](#schemaalarmtriggervaluedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|override|boolean|false|none|Override flag of the alarm instance. This flag is only used when alarm instance is created from alarm template<br>   If true, some data of the alarm instance has replaced that coming from alarm template|
|alarmTemplateId|string¦null|false|none|Id of the alarm template|
|deadband|number(double)|false|none|Deadband of the alarm instance|
|frequency|integer(int64)¦null|false|none|Period of the alarm updates in milliseconds.|
|applicationSource|string¦null|false|none|Name of the application responsible for alarm instance creation/update. May be null|

<h2 id="tocS_AlarmInstanceInfoDTO">AlarmInstanceInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarminstanceinfodto"></a>
<a id="schema_AlarmInstanceInfoDTO"></a>
<a id="tocSalarminstanceinfodto"></a>
<a id="tocsalarminstanceinfodto"></a>

```json
{
  "id": "string",
  "datapoint": {
    "identifier": {
      "type": 0,
      "busDatapointId": "string",
      "networkId": "string",
      "id": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    },
    "displayName": "string"
  },
  "alarmTemplateId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the alarm instance|
|datapoint|[DatapointIdentifierWithNameDTO](#schemadatapointidentifierwithnamedto)|false|none|Common data for all datapoint identifier dtos with display name|
|alarmTemplateId|string¦null|false|none|Id of the alarm template|

<h2 id="tocS_AlarmInstanceStatisticDTO">AlarmInstanceStatisticDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarminstancestatisticdto"></a>
<a id="schema_AlarmInstanceStatisticDTO"></a>
<a id="tocSalarminstancestatisticdto"></a>
<a id="tocsalarminstancestatisticdto"></a>

```json
{
  "severity": "string",
  "countTotal": 0,
  "countActive": 0,
  "needNeedAcknowledge": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|severity|string¦null|false|none|none|
|countTotal|integer(int32)|false|none|none|
|countActive|integer(int32)|false|none|none|
|needNeedAcknowledge|boolean|false|none|none|

<h2 id="tocS_AlarmSeverity">AlarmSeverity</h2>
<!-- backwards compatibility -->
<a id="schemaalarmseverity"></a>
<a id="schema_AlarmSeverity"></a>
<a id="tocSalarmseverity"></a>
<a id="tocsalarmseverity"></a>

```json
"Log"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Log|
|*anonymous*|Low|
|*anonymous*|High|
|*anonymous*|Urgent|
|*anonymous*|Critical|

<h2 id="tocS_AlarmSynchroErrorDTO">AlarmSynchroErrorDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmsynchroerrordto"></a>
<a id="schema_AlarmSynchroErrorDTO"></a>
<a id="tocSalarmsynchroerrordto"></a>
<a id="tocsalarmsynchroerrordto"></a>

```json
{
  "id": "string",
  "error": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|error|string¦null|false|none|none|

<h2 id="tocS_AlarmTemplateDescriptionPreviewDTO">AlarmTemplateDescriptionPreviewDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtemplatedescriptionpreviewdto"></a>
<a id="schema_AlarmTemplateDescriptionPreviewDTO"></a>
<a id="tocSalarmtemplatedescriptionpreviewdto"></a>
<a id="tocsalarmtemplatedescriptionpreviewdto"></a>

```json
{
  "string": "string",
  "trigger": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|string|string¦null|false|none|The placeholder to test|
|trigger|string¦null|false|none|The value of the trigger|

<h2 id="tocS_AlarmTemplateDTO">AlarmTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtemplatedto"></a>
<a id="schema_AlarmTemplateDTO"></a>
<a id="tocSalarmtemplatedto"></a>
<a id="tocsalarmtemplatedto"></a>

```json
{
  "id": "string",
  "name": "string",
  "hysteresis": 0,
  "needAcknowledge": true,
  "datapointSelector": {
    "id": "string"
  },
  "triggers": [
    {
      "type": "string",
      "id": "string",
      "name": "string",
      "description": "string",
      "severity": "Log"
    }
  ],
  "deadband": 0,
  "frequency": 0,
  "needRefreshInstances": true,
  "complexDataTypeFieldName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the alarm template|
|name|string¦null|false|none|Name of th alarm template|
|hysteresis|number(double)|false|none|Hysteresis of the alarm template|
|needAcknowledge|boolean|false|none|NeedAcknowledge flag for the alarm template<br>If true the alarm disappears only when no more present on network AND acknowledged.<br>If false the alarm disappears when no more present on network even if not acknowledged.|
|datapointSelector|[DatapointSelectorDTO](#schemadatapointselectordto)|false|none|none|
|triggers|[oneOf]¦null|false|none|Array of alarm trigger|

oneOf - discriminator: AlarmTriggerDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDTO](#schemaalarmtriggerdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalOFFDTO](#schemaalarmtriggerdigitaloffdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerDigitalONDTO](#schemaalarmtriggerdigitalondto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiDTO](#schemaalarmtriggerhidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerHiHiDTO](#schemaalarmtriggerhihidto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerInBandDTO](#schemaalarmtriggerinbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoDTO](#schemaalarmtriggerlodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerLoLoDTO](#schemaalarmtriggerlolodto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNetworkDTO](#schemaalarmtriggernetworkdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerNotValueDTO](#schemaalarmtriggernotvaluedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerOutOfBandDTO](#schemaalarmtriggeroutofbanddto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[AlarmTriggerValueDTO](#schemaalarmtriggervaluedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|deadband|number(double)|false|none|Deadband of the alarm template|
|frequency|integer(int64)¦null|false|none|Period in milliseconds|
|needRefreshInstances|boolean|false|none|NeedRefreshInstances flag of the alarm template<br> If true, indicates that alarm template must recalculate all alarm instance|
|complexDataTypeFieldName|string¦null|false|none|Name of the field of the complex data type of the datapoint to use<br>Ignored if the datapoint data type is not a complex data type|

<h2 id="tocS_AlarmTriggerDigitalOFFDTO">AlarmTriggerDigitalOFFDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggerdigitaloffdto"></a>
<a id="schema_AlarmTriggerDigitalOFFDTO"></a>
<a id="tocSalarmtriggerdigitaloffdto"></a>
<a id="tocsalarmtriggerdigitaloffdto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|

<h2 id="tocS_AlarmTriggerDigitalONDTO">AlarmTriggerDigitalONDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggerdigitalondto"></a>
<a id="schema_AlarmTriggerDigitalONDTO"></a>
<a id="tocSalarmtriggerdigitalondto"></a>
<a id="tocsalarmtriggerdigitalondto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|

<h2 id="tocS_AlarmTriggerDTO">AlarmTriggerDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggerdto"></a>
<a id="schema_AlarmTriggerDTO"></a>
<a id="tocSalarmtriggerdto"></a>
<a id="tocsalarmtriggerdto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string|true|none|none|
|id|string¦null|false|none|Id of the alarm trigger|
|name|string¦null|false|none|Name of the alarm trigger|
|description|string¦null|false|none|Description of the alarm trigger|
|severity|[AlarmSeverity](#schemaalarmseverity)|false|none|none|

<h2 id="tocS_AlarmTriggerHiDTO">AlarmTriggerHiDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggerhidto"></a>
<a id="schema_AlarmTriggerHiDTO"></a>
<a id="tocSalarmtriggerhidto"></a>
<a id="tocsalarmtriggerhidto"></a>

```json
{
  "type": "Unknown",
  "threshold": 0,
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|
|threshold|number(double)|false|none|Threshold of the alarm trigger|
|id|string¦null|false|none|Id of the alarm trigger|
|name|string¦null|false|none|Name of the alarm trigger|
|description|string¦null|false|none|Description of the alarm trigger|
|severity|[AlarmSeverity](#schemaalarmseverity)|false|none|none|

<h2 id="tocS_AlarmTriggerHiHiDTO">AlarmTriggerHiHiDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggerhihidto"></a>
<a id="schema_AlarmTriggerHiHiDTO"></a>
<a id="tocSalarmtriggerhihidto"></a>
<a id="tocsalarmtriggerhihidto"></a>

```json
{
  "type": "Unknown",
  "threshold": 0,
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|
|threshold|number(double)|false|none|Threshold of the alarm trigger|
|id|string¦null|false|none|Id of the alarm trigger|
|name|string¦null|false|none|Name of the alarm trigger|
|description|string¦null|false|none|Description of the alarm trigger|
|severity|[AlarmSeverity](#schemaalarmseverity)|false|none|none|

<h2 id="tocS_AlarmTriggerInBandDTO">AlarmTriggerInBandDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggerinbanddto"></a>
<a id="schema_AlarmTriggerInBandDTO"></a>
<a id="tocSalarmtriggerinbanddto"></a>
<a id="tocsalarmtriggerinbanddto"></a>

```json
{
  "index": 0,
  "thresholdLower": 0,
  "thresholdUpper": 0,
  "type": "string",
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|index|integer(int32)|false|none|Index of alarm trigger|
|thresholdLower|number(double)|false|none|Threshold lower of the alarm trigger|
|thresholdUpper|number(double)|false|none|Threshold upper of the alarm trigger|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|

<h2 id="tocS_AlarmTriggerLoDTO">AlarmTriggerLoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggerlodto"></a>
<a id="schema_AlarmTriggerLoDTO"></a>
<a id="tocSalarmtriggerlodto"></a>
<a id="tocsalarmtriggerlodto"></a>

```json
{
  "type": "Unknown",
  "threshold": 0,
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|
|threshold|number(double)|false|none|Threshold of the alarm trigger|
|id|string¦null|false|none|Id of the alarm trigger|
|name|string¦null|false|none|Name of the alarm trigger|
|description|string¦null|false|none|Description of the alarm trigger|
|severity|[AlarmSeverity](#schemaalarmseverity)|false|none|none|

<h2 id="tocS_AlarmTriggerLoLoDTO">AlarmTriggerLoLoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggerlolodto"></a>
<a id="schema_AlarmTriggerLoLoDTO"></a>
<a id="tocSalarmtriggerlolodto"></a>
<a id="tocsalarmtriggerlolodto"></a>

```json
{
  "type": "Unknown",
  "threshold": 0,
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|
|threshold|number(double)|false|none|Threshold of the alarm trigger|
|id|string¦null|false|none|Id of the alarm trigger|
|name|string¦null|false|none|Name of the alarm trigger|
|description|string¦null|false|none|Description of the alarm trigger|
|severity|[AlarmSeverity](#schemaalarmseverity)|false|none|none|

<h2 id="tocS_AlarmTriggerNetworkDTO">AlarmTriggerNetworkDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggernetworkdto"></a>
<a id="schema_AlarmTriggerNetworkDTO"></a>
<a id="tocSalarmtriggernetworkdto"></a>
<a id="tocsalarmtriggernetworkdto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|

<h2 id="tocS_AlarmTriggerNotValueDTO">AlarmTriggerNotValueDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggernotvaluedto"></a>
<a id="schema_AlarmTriggerNotValueDTO"></a>
<a id="tocSalarmtriggernotvaluedto"></a>
<a id="tocsalarmtriggernotvaluedto"></a>

```json
{
  "type": "Unknown",
  "threshold": 0,
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|
|threshold|number(double)|false|none|Threshold of the alarm trigger|
|id|string¦null|false|none|Id of the alarm trigger|
|name|string¦null|false|none|Name of the alarm trigger|
|description|string¦null|false|none|Description of the alarm trigger|
|severity|[AlarmSeverity](#schemaalarmseverity)|false|none|none|

<h2 id="tocS_AlarmTriggerOutOfBandDTO">AlarmTriggerOutOfBandDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggeroutofbanddto"></a>
<a id="schema_AlarmTriggerOutOfBandDTO"></a>
<a id="tocSalarmtriggeroutofbanddto"></a>
<a id="tocsalarmtriggeroutofbanddto"></a>

```json
{
  "index": 0,
  "thresholdLower": 0,
  "thresholdUpper": 0,
  "type": "string",
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|index|integer(int32)|false|none|Index of the alarm trigger|
|thresholdLower|number(double)|false|none|Threshold lower of the alarm trigger|
|thresholdUpper|number(double)|false|none|Threshold upper of the alarm trigger|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|

<h2 id="tocS_AlarmTriggerType">AlarmTriggerType</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggertype"></a>
<a id="schema_AlarmTriggerType"></a>
<a id="tocSalarmtriggertype"></a>
<a id="tocsalarmtriggertype"></a>

```json
"Unknown"

```

Discriminator of AlarmTrigger

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Discriminator of AlarmTrigger|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Unknown|
|*anonymous*|AlarmTriggerDigitalOFFDTO|
|*anonymous*|AlarmTriggerDigitalONDTO|
|*anonymous*|AlarmTriggerHiDTO|
|*anonymous*|AlarmTriggerHiHiDTO|
|*anonymous*|AlarmTriggerLoDTO|
|*anonymous*|AlarmTriggerLoLoDTO|
|*anonymous*|AlarmTriggerInBandDTO|
|*anonymous*|AlarmTriggerNetworkDTO|
|*anonymous*|AlarmTriggerNotValueDTO|
|*anonymous*|AlarmTriggerOutOfBandDTO|
|*anonymous*|AlarmTriggerValueDTO|

<h2 id="tocS_AlarmTriggerValueDTO">AlarmTriggerValueDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalarmtriggervaluedto"></a>
<a id="schema_AlarmTriggerValueDTO"></a>
<a id="tocSalarmtriggervaluedto"></a>
<a id="tocsalarmtriggervaluedto"></a>

```json
{
  "type": "Unknown",
  "threshold": 0,
  "id": "string",
  "name": "string",
  "description": "string",
  "severity": "Log"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[AlarmTriggerType](#schemaalarmtriggertype)|false|none|Discriminator of AlarmTrigger|
|threshold|number(double)|false|none|Threshold of the alarm trigger|
|id|string¦null|false|none|Id of the alarm trigger|
|name|string¦null|false|none|Name of the alarm trigger|
|description|string¦null|false|none|Description of the alarm trigger|
|severity|[AlarmSeverity](#schemaalarmseverity)|false|none|none|

<h2 id="tocS_AlgoConfigurationDTO">AlgoConfigurationDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoconfigurationdto"></a>
<a id="schema_AlgoConfigurationDTO"></a>
<a id="tocSalgoconfigurationdto"></a>
<a id="tocsalgoconfigurationdto"></a>

```json
{
  "parameters": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "id": "string",
  "name": "string",
  "needRecomputeInstances": true,
  "algoTemplateId": "string",
  "zoneTemplateId": "string"
}

```

DTO of an algorithm configuration
AlgorithmConfiguration links a zone template to an algorithm template.
It defines the values of parameters that are specifics to an algorithm.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|parameters|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|Values of the parameters of the algo for this configuration|
|id|string¦null|false|none|Id|
|name|string¦null|false|none|Name|
|needRecomputeInstances|boolean|false|none|NeedRecomputeInstances flag of the algorithm configuration<br> If true, indicates that algorithm instances based on the algorithm configuration must be recomputed|
|algoTemplateId|string¦null|false|none|Algorithm template targeted by the configuration|
|zoneTemplateId|string¦null|false|none|Zone targeted by the configuration|

<h2 id="tocS_AlgoConfigurationInfoDTO">AlgoConfigurationInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoconfigurationinfodto"></a>
<a id="schema_AlgoConfigurationInfoDTO"></a>
<a id="tocSalgoconfigurationinfodto"></a>
<a id="tocsalgoconfigurationinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "needRecomputeInstances": true,
  "algoTemplateId": "string",
  "zoneTemplateId": "string"
}

```

Information about an algorithm configuration

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id|
|name|string¦null|false|none|Name|
|needRecomputeInstances|boolean|false|none|NeedRecomputeInstances flag of the algorithm configuration<br> If true, indicates that algorithm instances based on the algorithm configuration must be recomputed|
|algoTemplateId|string¦null|false|none|Algorithm template targeted by the configuration|
|zoneTemplateId|string¦null|false|none|Zone targeted by the configuration|

<h2 id="tocS_AlgoConfigurationUpdateDTO">AlgoConfigurationUpdateDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoconfigurationupdatedto"></a>
<a id="schema_AlgoConfigurationUpdateDTO"></a>
<a id="tocSalgoconfigurationupdatedto"></a>
<a id="tocsalgoconfigurationupdatedto"></a>

```json
{
  "id": "string",
  "name": "string",
  "parameters": [
    {
      "value": null,
      "id": "string"
    }
  ]
}

```

DTO of an algorithm configuration for update operation
AlgorithmConfiguration links a zone template to an algorithm template.
It defines the values of parameters that are specifics to an algorithm.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id|
|name|string¦null|false|none|Name|
|parameters|[[PropertyDatapointInstanceValueDTO](#schemapropertydatapointinstancevaluedto)]¦null|false|none|Values of the parameters of the algo for this configuration|

<h2 id="tocS_AlgoError">AlgoError</h2>
<!-- backwards compatibility -->
<a id="schemaalgoerror"></a>
<a id="schema_AlgoError"></a>
<a id="tocSalgoerror"></a>
<a id="tocsalgoerror"></a>

```json
"None"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|None|
|*anonymous*|MissingInputTag|
|*anonymous*|MissingOutputTag|
|*anonymous*|MissingInputValue|
|*anonymous*|GeneralException|

<h2 id="tocS_AlgoExecutionBusDatapointDTO">AlgoExecutionBusDatapointDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoexecutionbusdatapointdto"></a>
<a id="schema_AlgoExecutionBusDatapointDTO"></a>
<a id="tocSalgoexecutionbusdatapointdto"></a>
<a id="tocsalgoexecutionbusdatapointdto"></a>

```json
{
  "tag": "string",
  "isCommand": true,
  "value": null,
  "aggregatedValue": null,
  "unit": "string",
  "unitShortString": "string",
  "busInformation": "string",
  "lastWriteError": "string",
  "datapointPath": "string",
  "datapointId": "string",
  "timeStamp": "2019-08-24T14:15:22Z",
  "protocolArguments": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tag|string¦null|false|none|none|
|isCommand|boolean|false|none|none|
|value|any|false|none|none|
|aggregatedValue|any|false|none|none|
|unit|string¦null|false|none|none|
|unitShortString|string¦null|false|none|none|
|busInformation|string¦null|false|none|none|
|lastWriteError|string¦null|false|none|none|
|datapointPath|string¦null|false|none|none|
|datapointId|string¦null|false|none|none|
|timeStamp|string(date-time)|false|none|none|
|protocolArguments|string¦null|false|none|none|

<h2 id="tocS_AlgoExecutionMemoryDatapointDTO">AlgoExecutionMemoryDatapointDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoexecutionmemorydatapointdto"></a>
<a id="schema_AlgoExecutionMemoryDatapointDTO"></a>
<a id="tocSalgoexecutionmemorydatapointdto"></a>
<a id="tocsalgoexecutionmemorydatapointdto"></a>

```json
{
  "name": "string",
  "value": null,
  "unit": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|value|any|false|none|none|
|unit|string¦null|false|none|none|

<h2 id="tocS_AlgoInstanceConfigurationDTO">AlgoInstanceConfigurationDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoinstanceconfigurationdto"></a>
<a id="schema_AlgoInstanceConfigurationDTO"></a>
<a id="tocSalgoinstanceconfigurationdto"></a>
<a id="tocsalgoinstanceconfigurationdto"></a>

```json
{
  "id": "string",
  "parameters": [
    {
      "value": null,
      "id": "string"
    }
  ]
}

```

Algorithm instance for update operation

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id|
|parameters|[[PropertyDatapointInstanceValueDTO](#schemapropertydatapointinstancevaluedto)]¦null|false|none|Parameters of the algorithm|

<h2 id="tocS_AlgoInstanceDTO">AlgoInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoinstancedto"></a>
<a id="schema_AlgoInstanceDTO"></a>
<a id="tocSalgoinstancedto"></a>
<a id="tocsalgoinstancedto"></a>

```json
{
  "parameters": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "id": "string",
  "active": true,
  "algoConfigurationId": "string",
  "algoTemplateId": "string",
  "zoneInstanceId": "string"
}

```

Alrorithm instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|parameters|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|Parameters of the algorithm|
|id|string¦null|false|none|Id|
|active|boolean|false|none|Indicates if the algorithm instance is active or not|
|algoConfigurationId|string¦null|false|none|Associated algorithm configuration|
|algoTemplateId|string¦null|false|none|Associated algorithm template|
|zoneInstanceId|string¦null|false|none|Associated zone instance|

<h2 id="tocS_AlgoInstanceExecutionDetailDTO">AlgoInstanceExecutionDetailDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoinstanceexecutiondetaildto"></a>
<a id="schema_AlgoInstanceExecutionDetailDTO"></a>
<a id="tocSalgoinstanceexecutiondetaildto"></a>
<a id="tocsalgoinstanceexecutiondetaildto"></a>

```json
{
  "busDatapoints": [
    {
      "tag": "string",
      "isCommand": true,
      "value": null,
      "aggregatedValue": null,
      "unit": "string",
      "unitShortString": "string",
      "busInformation": "string",
      "lastWriteError": "string",
      "datapointPath": "string",
      "datapointId": "string",
      "timeStamp": "2019-08-24T14:15:22Z",
      "protocolArguments": "string"
    }
  ],
  "requiredDatapointTags": [
    "string"
  ],
  "memoryDatapoints": [
    {
      "name": "string",
      "value": null,
      "unit": "string"
    }
  ],
  "zoneInstanceId": "string",
  "zoneInstanceName": "string",
  "state": "Started",
  "error": "None"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|busDatapoints|[[AlgoExecutionBusDatapointDTO](#schemaalgoexecutionbusdatapointdto)]¦null|false|none|none|
|requiredDatapointTags|[string]¦null|false|none|none|
|memoryDatapoints|[[AlgoExecutionMemoryDatapointDTO](#schemaalgoexecutionmemorydatapointdto)]¦null|false|none|none|
|zoneInstanceId|string¦null|false|none|none|
|zoneInstanceName|string¦null|false|none|none|
|state|[AlgoState](#schemaalgostate)|false|none|none|
|error|[AlgoError](#schemaalgoerror)|false|none|none|

<h2 id="tocS_AlgoInstanceExecutionInfoDTO">AlgoInstanceExecutionInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoinstanceexecutioninfodto"></a>
<a id="schema_AlgoInstanceExecutionInfoDTO"></a>
<a id="tocSalgoinstanceexecutioninfodto"></a>
<a id="tocsalgoinstanceexecutioninfodto"></a>

```json
{
  "zoneInstanceId": "string",
  "zoneInstanceName": "string",
  "state": "Started",
  "error": "None"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneInstanceId|string¦null|false|none|none|
|zoneInstanceName|string¦null|false|none|none|
|state|[AlgoState](#schemaalgostate)|false|none|none|
|error|[AlgoError](#schemaalgoerror)|false|none|none|

<h2 id="tocS_AlgoInstanceInfoDTO">AlgoInstanceInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgoinstanceinfodto"></a>
<a id="schema_AlgoInstanceInfoDTO"></a>
<a id="tocSalgoinstanceinfodto"></a>
<a id="tocsalgoinstanceinfodto"></a>

```json
{
  "id": "string",
  "active": true,
  "algoConfigurationId": "string",
  "algoTemplateId": "string",
  "zoneInstanceId": "string"
}

```

Information about an algrorithm instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id|
|active|boolean|false|none|Indicates if the algorithm instance is active or not|
|algoConfigurationId|string¦null|false|none|Associated algorithm configuration|
|algoTemplateId|string¦null|false|none|Associated algorithm template|
|zoneInstanceId|string¦null|false|none|Associated zone instance|

<h2 id="tocS_AlgoModuleDTO">AlgoModuleDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgomoduledto"></a>
<a id="schema_AlgoModuleDTO"></a>
<a id="tocSalgomoduledto"></a>
<a id="tocsalgomoduledto"></a>

```json
{
  "id": "string",
  "name": "string",
  "mandatoryDatapointIds": [
    "string"
  ],
  "optionalDatapointIds": [
    "string"
  ],
  "parameterIds": [
    "string"
  ],
  "moduleActivityParameterId": "string"
}

```

DTO of a module of an algorithm template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the module|
|name|string¦null|false|none|Name of the module|
|mandatoryDatapointIds|[string]¦null|false|none|List of referenced mandatory datapoints of the module|
|optionalDatapointIds|[string]¦null|false|none|List of referenced optional datapoints of the module|
|parameterIds|[string]¦null|false|none|List of associated parameters|
|moduleActivityParameterId|string¦null|false|none|Id of the parameter that activates the module|

<h2 id="tocS_AlgoRunningActivationSubscriptionDTO">AlgoRunningActivationSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgorunningactivationsubscriptiondto"></a>
<a id="schema_AlgoRunningActivationSubscriptionDTO"></a>
<a id="tocSalgorunningactivationsubscriptiondto"></a>
<a id="tocsalgorunningactivationsubscriptiondto"></a>

```json
{
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_AlgoSetState">AlgoSetState</h2>
<!-- backwards compatibility -->
<a id="schemaalgosetstate"></a>
<a id="schema_AlgoSetState"></a>
<a id="tocSalgosetstate"></a>
<a id="tocsalgosetstate"></a>

```json
"Pause"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Pause|
|*anonymous*|Restart|
|*anonymous*|HardRestart|

<h2 id="tocS_AlgoState">AlgoState</h2>
<!-- backwards compatibility -->
<a id="schemaalgostate"></a>
<a id="schema_AlgoState"></a>
<a id="tocSalgostate"></a>
<a id="tocsalgostate"></a>

```json
"Started"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Started|
|*anonymous*|Stopped|
|*anonymous*|Paused|

<h2 id="tocS_AlgoTemplateDTO">AlgoTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgotemplatedto"></a>
<a id="schema_AlgoTemplateDTO"></a>
<a id="tocSalgotemplatedto"></a>
<a id="tocsalgotemplatedto"></a>

```json
{
  "modules": [
    {
      "id": "string",
      "name": "string",
      "mandatoryDatapointIds": [
        "string"
      ],
      "optionalDatapointIds": [
        "string"
      ],
      "parameterIds": [
        "string"
      ],
      "moduleActivityParameterId": "string"
    }
  ],
  "datapoints": [
    {
      "busUnitId": "string",
      "id": "string",
      "name": "string",
      "description": "string",
      "tags": [
        "string"
      ],
      "direction": "Feedback",
      "typeId": "string",
      "displayUnitId": "string",
      "publicId": "string"
    }
  ],
  "parameters": [
    {
      "defaultValue": null,
      "id": "string",
      "name": "string",
      "description": "string",
      "tags": [
        "string"
      ],
      "direction": "Feedback",
      "typeId": "string",
      "displayUnitId": "string",
      "publicId": "string"
    }
  ],
  "id": "string",
  "name": "string",
  "tags": [
    "string"
  ]
}

```

DTO of an algorithm template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|modules|[[AlgoModuleDTO](#schemaalgomoduledto)]¦null|false|none|List of modules associated to the algorithm template|
|datapoints|[[DatapointTemplateDTO](#schemadatapointtemplatedto)]¦null|false|none|List of datapoint templates attached to the algorithm template|
|parameters|[[PropertyDatapointTemplateDTO](#schemapropertydatapointtemplatedto)]¦null|false|none|List of properties templates attached to the algorithm template|
|id|string¦null|false|none|Id|
|name|string¦null|false|none|Name|
|tags|[string]¦null|false|none|Associated tags.|

<h2 id="tocS_AlgoTemplateInfoDTO">AlgoTemplateInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaalgotemplateinfodto"></a>
<a id="schema_AlgoTemplateInfoDTO"></a>
<a id="tocSalgotemplateinfodto"></a>
<a id="tocsalgotemplateinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "tags": [
    "string"
  ]
}

```

Information about an algorithm template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id|
|name|string¦null|false|none|Name|
|tags|[string]¦null|false|none|Associated tags.|

<h2 id="tocS_AnimationsInfoDTO">AnimationsInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaanimationsinfodto"></a>
<a id="schema_AnimationsInfoDTO"></a>
<a id="tocSanimationsinfodto"></a>
<a id="tocsanimationsinfodto"></a>

```json
{
  "functionalBlocks": [
    {
      "functionalBlockTemplateId": "string",
      "textAnimation": {
        "id": "string",
        "datapointTemplateId": "string",
        "functionalBlockTemplateId": "string",
        "type": {
          "type": "string",
          "id": "string",
          "name": "string",
          "tag": "string",
          "transport": "none"
        },
        "selectionModeForZone": "All",
        "complexDataTypeFieldName": "string"
      },
      "iconAnimation": {
        "ranges": [
          {
            "value": "string",
            "min": 0,
            "minIncluded": true,
            "max": 0,
            "maxIncluded": true
          }
        ],
        "animationType": "Float",
        "defaultValue": "string",
        "id": "string",
        "datapointTemplateId": "string",
        "functionalBlockTemplateId": "string",
        "type": {
          "type": "string",
          "id": "string",
          "name": "string",
          "tag": "string",
          "transport": "none"
        },
        "selectionModeForZone": "All",
        "complexDataTypeFieldName": "string"
      },
      "selectionMode": "All",
      "name": "string",
      "showAlarms": true,
      "active": true,
      "id": "string"
    }
  ],
  "zones": [
    {
      "zoneTemplateId": "string",
      "backgroundColorAnimation": {
        "ranges": [
          {
            "value": "string",
            "min": 0,
            "minIncluded": true,
            "max": 0,
            "maxIncluded": true
          }
        ],
        "animationType": "Float",
        "defaultValue": "string",
        "id": "string",
        "datapointTemplateId": "string",
        "functionalBlockTemplateId": "string",
        "type": {
          "type": "string",
          "id": "string",
          "name": "string",
          "tag": "string",
          "transport": "none"
        },
        "selectionModeForZone": "All",
        "complexDataTypeFieldName": "string"
      },
      "borderColorAnimation": {
        "ranges": [
          {
            "value": "string",
            "min": 0,
            "minIncluded": true,
            "max": 0,
            "maxIncluded": true
          }
        ],
        "animationType": "Float",
        "defaultValue": "string",
        "id": "string",
        "datapointTemplateId": "string",
        "functionalBlockTemplateId": "string",
        "type": {
          "type": "string",
          "id": "string",
          "name": "string",
          "tag": "string",
          "transport": "none"
        },
        "selectionModeForZone": "All",
        "complexDataTypeFieldName": "string"
      },
      "name": "string",
      "showAlarms": true,
      "active": true,
      "id": "string"
    }
  ]
}

```

All view animation configurations.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlocks|[[FunctionalBlockAnimationDTO](#schemafunctionalblockanimationdto)]¦null|false|none|All functional block animation configurations.|
|zones|[[ZoneAnimationDTO](#schemazoneanimationdto)]¦null|false|none|All Zone template animation configurations.|

<h2 id="tocS_AnimationType">AnimationType</h2>
<!-- backwards compatibility -->
<a id="schemaanimationtype"></a>
<a id="schema_AnimationType"></a>
<a id="tocSanimationtype"></a>
<a id="tocsanimationtype"></a>

```json
"Float"

```

Types of animation.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Types of animation.|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Float|
|*anonymous*|Enum|
|*anonymous*|Bool|

<h2 id="tocS_AreaDTO">AreaDTO</h2>
<!-- backwards compatibility -->
<a id="schemaareadto"></a>
<a id="schema_AreaDTO"></a>
<a id="tocSareadto"></a>
<a id="tocsareadto"></a>

```json
{
  "zoneType": "string",
  "structureChildren": "string",
  "structureParents": "string",
  "zoneChildren": "string",
  "zoneParents": "string",
  "spaceChildren": "string",
  "spaceParents": "string",
  "tenants": "string",
  "owners": "string",
  "propertyManagers": "string",
  "facilityManagers": "string",
  "visitors": "string",
  "administrators": "string",
  "datapoints": [
    {
      "stationId": "string",
      "networkId": "string",
      "busUnitId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "converterId": "string",
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "properties": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "functionalBlocks": [
    {
      "functionalBlockId": "string",
      "group": "string",
      "masterMode": "None",
      "inZone": true
    }
  ],
  "authorized": true,
  "parentIds": [
    "string"
  ],
  "childrenIds": [
    "string"
  ],
  "hasMapView": true,
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "type": "Physical",
  "tags": [
    "string"
  ],
  "propertyZoneType": "Property",
  "isExternal": true
}

```

Represents a area

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneType|string¦null|false|none|Type of area|
|structureChildren|string¦null|false|none|Resource path to query the children structures of the area|
|structureParents|string¦null|false|none|Resource path to query the parent structures of the area|
|zoneChildren|string¦null|false|none|Resource path to query the children areas of the area|
|zoneParents|string¦null|false|none|Resource path to query the parent areas of the area|
|spaceChildren|string¦null|false|none|Resource path to query the children spaces of the area|
|spaceParents|string¦null|false|none|Resource path to query the parent spaces of the area|
|tenants|string¦null|false|none|Resource path to query the tenants of the area|
|owners|string¦null|false|none|Resource path to query the owners of the area|
|propertyManagers|string¦null|false|none|Resource path to query the property managers of the area|
|facilityManagers|string¦null|false|none|Resource path to query the facility managers of the area|
|visitors|string¦null|false|none|Resource path to query the visitors of the area|
|administrators|string¦null|false|none|Resource path to query the administrators of the area|
|datapoints|[[DatapointInstanceDTO](#schemadatapointinstancedto)]¦null|false|none|List of dataPoint instances inherited from datapoint template|
|properties|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|List of properties inherited from property template|
|functionalBlocks|[[FunctionalBlockInstanceOfZoneDTO](#schemafunctionalblockinstanceofzonedto)]¦null|false|none|List of functional block instances attached to the zone|
|authorized|boolean|false|none|If true access is granted to this zone.|
|parentIds|[string]¦null|false|none|List of parent zones attached to the zone|
|childrenIds|[string]¦null|false|none|List of children zone instance definition attached to the created zone<br>(information only)|
|hasMapView|boolean|false|none|True if zone has a mapview attached to it|
|id|string¦null|false|none|Unique identifier of the zone instance|
|name|string¦null|false|none|Localized name of the zone instance|
|icon|string¦null|false|none|Optional image representing the zoneInstance<br>This field is readonly and ignored during a put/post for a zone instance attached to a zone template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the zone instance template (if any)|
|type|[ZoneType](#schemazonetype)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the zone|
|propertyZoneType|[PropertyZoneType](#schemapropertyzonetype)|false|none|Type of a property area|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_ArrayDataTypeDTO">ArrayDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemaarraydatatypedto"></a>
<a id="schema_ArrayDataTypeDTO"></a>
<a id="tocSarraydatatypedto"></a>
<a id="tocsarraydatatypedto"></a>

```json
{
  "type": "string",
  "elementType": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|
|elementType|any|false|none|DataType of the elements in the array.|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

<h2 id="tocS_AssignDatapointToBusDatapointDTO">AssignDatapointToBusDatapointDTO</h2>
<!-- backwards compatibility -->
<a id="schemaassigndatapointtobusdatapointdto"></a>
<a id="schema_AssignDatapointToBusDatapointDTO"></a>
<a id="tocSassigndatapointtobusdatapointdto"></a>
<a id="tocsassigndatapointtobusdatapointdto"></a>

```json
{
  "datapointInstanceId": "string",
  "converterId": "string",
  "busUnit": "string",
  "busDatapointId": "string",
  "additionalArguments": {
    "property1": null,
    "property2": null
  }
}

```

Data to assign a datapoint to a bus datapoint

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointInstanceId|string¦null|false|none|Id of datapoint instance to assign|
|converterId|string¦null|false|none|Id of converter to use. Null for no converter|
|busUnit|string¦null|false|none|Bus unit to use for bus datapoint.<br>Null to ignore unit|
|busDatapointId|string¦null|false|none|Id of bus datapoint to assign.<br>If null or empty then datapoint will be UNASSIGNED|
|additionalArguments|object¦null|false|none|Additional protocol argument.<br>Arguments that will be added to the bus datapoint protocol arguments before assignation.<br>These arguments will override bus datapoint protocol arguments if they already exist in the bus datapoint.<br>If null or empty then no additional protocol arguments will be added|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_AsyncMethodLaunchDTO">AsyncMethodLaunchDTO</h2>
<!-- backwards compatibility -->
<a id="schemaasyncmethodlaunchdto"></a>
<a id="schema_AsyncMethodLaunchDTO"></a>
<a id="tocSasyncmethodlaunchdto"></a>
<a id="tocsasyncmethodlaunchdto"></a>

```json
{
  "subscription": {
    "id": "string",
    "tags": [
      "string"
    ],
    "webhookURL": "string",
    "webhookRetryCount": 0,
    "webhookRetryDelay": 0,
    "webhookPersist": true,
    "connectionId": "string",
    "returnInternalFormat": true,
    "webhookLeaseTime": 0
  },
  "parameters": [
    {
      "id": "string",
      "value": null,
      "identifier": "string"
    }
  ]
}

```

DTO that hold data for an asynchronous driver method call.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|subscription|[SubscriptionDTO](#schemasubscriptiondto)|false|none|none|
|parameters|[[DriverPropertyValueDTO](#schemadriverpropertyvaluedto)]¦null|false|none|Parameters for the call.|

<h2 id="tocS_AuthenticationDTO">AuthenticationDTO</h2>
<!-- backwards compatibility -->
<a id="schemaauthenticationdto"></a>
<a id="schema_AuthenticationDTO"></a>
<a id="tocSauthenticationdto"></a>
<a id="tocsauthenticationdto"></a>

```json
{
  "login": "string",
  "password": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|login|string¦null|false|none|none|
|password|string¦null|false|none|none|

<h2 id="tocS_BackgroundStatusDTO">BackgroundStatusDTO</h2>
<!-- backwards compatibility -->
<a id="schemabackgroundstatusdto"></a>
<a id="schema_BackgroundStatusDTO"></a>
<a id="tocSbackgroundstatusdto"></a>
<a id="tocsbackgroundstatusdto"></a>

```json
{
  "isAvailable": true,
  "generationProgress": 0,
  "errorCode": "string",
  "error": "string",
  "errorData": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isAvailable|boolean|false|none|Indicates if a background exists.|
|generationProgress|number(double)|false|none|Completion ratio for the generation of a new background.<br>System.Double.NaN if no new background is being generated.|
|errorCode|string¦null|false|none|Error code produced by the last background generation (if any).|
|error|string¦null|false|none|Error produced by the last background generation (if any).|
|errorData|string¦null|false|none|Technical data about the error produced by the last background generation (if any).|

<h2 id="tocS_BackupKind">BackupKind</h2>
<!-- backwards compatibility -->
<a id="schemabackupkind"></a>
<a id="schema_BackupKind"></a>
<a id="tocSbackupkind"></a>
<a id="tocsbackupkind"></a>

```json
"Full"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Full|
|*anonymous*|ConfigurationOnly|

<h2 id="tocS_BackupRequestDTO">BackupRequestDTO</h2>
<!-- backwards compatibility -->
<a id="schemabackuprequestdto"></a>
<a id="schema_BackupRequestDTO"></a>
<a id="tocSbackuprequestdto"></a>
<a id="tocsbackuprequestdto"></a>

```json
{
  "connectionId": "string",
  "description": "string",
  "password": "string",
  "kind": "Full"
}

```

Backup request

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|connectionId|string¦null|false|none|Subscription's connectionId used for backup notification|
|description|string¦null|false|none|Description of the backup|
|password|string¦null|false|none|An optional password to use for backup encryption|
|kind|[BackupKind](#schemabackupkind)|false|none|none|

<h2 id="tocS_BaseActionElementDTO">BaseActionElementDTO</h2>
<!-- backwards compatibility -->
<a id="schemabaseactionelementdto"></a>
<a id="schema_BaseActionElementDTO"></a>
<a id="tocSbaseactionelementdto"></a>
<a id="tocsbaseactionelementdto"></a>

```json
{
  "type": "TemplateDatapointWriteDTO",
  "id": "string"
}

```

Base class of an action element

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ActionElementType](#schemaactionelementtype)|true|none|none|
|id|string¦null|false|none|If theelement is linked to template schedule configuration:<br>    Unique BOS identifier of a datapoint selector.<br>    See TemplatedDatapointSelectorDTO docummentation.<br>    TemplatedDatapointSelectorDTO.Selector may be:<br>        - a ZoneTemplateSelectorDTO if the datapoint template is linked to a zone template<br>        In this case, the zone template must be configured in ZoneTemplateIds list<br>        - a FunctionalBlockSelectorDTO if the datapoint template is linked to a functional block template<br>        In this case, the functional block template can be any functional block template of the project (no limitation)<br>    <br>Otherwise, if element is linked to individual schedule configuration:<br>    Unique BOS identifier of a datapoint instance|

<h2 id="tocS_BatchDTO">BatchDTO</h2>
<!-- backwards compatibility -->
<a id="schemabatchdto"></a>
<a id="schema_BatchDTO"></a>
<a id="tocSbatchdto"></a>
<a id="tocsbatchdto"></a>

```json
{
  "requests": [
    {
      "uri": "string",
      "method": "string",
      "content": "string"
    }
  ],
  "useTransaction": true,
  "stopAtFirstError": true,
  "oldVersion": true
}

```

Represents the requests to execute as a batch

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|requests|[[BatchRequestDTO](#schemabatchrequestdto)]¦null|false|none|The list of requests|
|useTransaction|boolean|false|none|Indicates if the requests should be executed in the same transaction|
|stopAtFirstError|boolean|false|none|Indicates the requests should stop to be executed when the first error occurs (only available when UseTransaction is false)|
|oldVersion|boolean¦null|false|none|If OldVersion = true, then we use the serializer without EnumToStringConverter<br>If OldVersion = false, then we use the serializer with EnumToStringConverter|

<h2 id="tocS_BatchRequestDTO">BatchRequestDTO</h2>
<!-- backwards compatibility -->
<a id="schemabatchrequestdto"></a>
<a id="schema_BatchRequestDTO"></a>
<a id="tocSbatchrequestdto"></a>
<a id="tocsbatchrequestdto"></a>

```json
{
  "uri": "string",
  "method": "string",
  "content": "string"
}

```

The description of a single request to execute within a batch

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|uri|string¦null|false|none|the uri of the request|
|method|string¦null|false|none|the method to use for the request. Should be either GET, POST, PUT or DELETE|
|content|string¦null|false|none|The content of the request (the serialized DTO)|

<h2 id="tocS_BatchResultDTO">BatchResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemabatchresultdto"></a>
<a id="schema_BatchResultDTO"></a>
<a id="tocSbatchresultdto"></a>
<a id="tocsbatchresultdto"></a>

```json
{
  "status": "Continue",
  "content": "string"
}

```

Represents the result of a single batch request

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|status|[HttpStatusCode](#schemahttpstatuscode)|false|none|none|
|content|string¦null|false|none|The result of the request.<br>If the request is a success : the expected result. If the request was a POST, the result is the id of the new entity created<br>If the request is a success, but a following request failed and they were in transactions : "Canceled by transaction"<br>If the request has not been executed : "Skipped"|

<h2 id="tocS_BEEfficiencyLicenseDTO">BEEfficiencyLicenseDTO</h2>
<!-- backwards compatibility -->
<a id="schemabeefficiencylicensedto"></a>
<a id="schema_BEEfficiencyLicenseDTO"></a>
<a id="tocSbeefficiencylicensedto"></a>
<a id="tocsbeefficiencylicensedto"></a>

```json
{
  "state": "None",
  "type": "string",
  "rooms": 0,
  "expirationDate": "2019-08-24T14:15:22Z",
  "trial": true
}

```

License description for BEEfficiancy

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|state|[LicenseState](#schemalicensestate)|false|none|none|
|type|string¦null|false|none|Type.<br>Engineering (none), BE-SpaceEfficient-1Y|
|rooms|integer(int64)|false|none|Number of rooms covered by license|
|expirationDate|string(date-time)¦null|false|none|Expiration date. Null if none|
|trial|boolean|false|none|Trial license|

<h2 id="tocS_BoolDataTypeDTO">BoolDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemabooldatatypedto"></a>
<a id="schema_BoolDataTypeDTO"></a>
<a id="tocSbooldatatypedto"></a>
<a id="tocsbooldatatypedto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

Bool data type value definition.  (type:"bool")

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|

<h2 id="tocS_BooleanStringAnimationDTO">BooleanStringAnimationDTO</h2>
<!-- backwards compatibility -->
<a id="schemabooleanstringanimationdto"></a>
<a id="schema_BooleanStringAnimationDTO"></a>
<a id="tocSbooleanstringanimationdto"></a>
<a id="tocsbooleanstringanimationdto"></a>

```json
{
  "falseValue": "string",
  "trueValue": "string",
  "animationType": "Float",
  "defaultValue": "string",
  "id": "string",
  "datapointTemplateId": "string",
  "functionalBlockTemplateId": "string",
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "selectionModeForZone": "All",
  "complexDataTypeFieldName": "string"
}

```

Animation of a boolean datapoint.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|falseValue|string¦null|false|none|String value for false value.|
|trueValue|string¦null|false|none|String value for true value.|
|animationType|[AnimationType](#schemaanimationtype)|false|none|Types of animation.|

<h2 id="tocS_BOSAlarmTrigger">BOSAlarmTrigger</h2>
<!-- backwards compatibility -->
<a id="schemabosalarmtrigger"></a>
<a id="schema_BOSAlarmTrigger"></a>
<a id="tocSbosalarmtrigger"></a>
<a id="tocsbosalarmtrigger"></a>

```json
"none"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|none|
|*anonymous*|analognotvalue|
|*anonymous*|analogvalue|
|*anonymous*|digitaloff|
|*anonymous*|digitalon|
|*anonymous*|analogoutband2|
|*anonymous*|analogoutband1|
|*anonymous*|analoginband2|
|*anonymous*|analoginband1|
|*anonymous*|analoglo|
|*anonymous*|analoglolo|
|*anonymous*|analoghi|
|*anonymous*|analoghihi|
|*anonymous*|networkerror|
|*anonymous*|addresserror|
|*anonymous*|all|

<h2 id="tocS_BOSLicenseDTO">BOSLicenseDTO</h2>
<!-- backwards compatibility -->
<a id="schemaboslicensedto"></a>
<a id="schema_BOSLicenseDTO"></a>
<a id="tocSboslicensedto"></a>
<a id="tocsboslicensedto"></a>

```json
{
  "state": "None",
  "type": "string",
  "points": 0,
  "pointsBeingUsed": 0,
  "expirationDate": "2019-08-24T14:15:22Z",
  "trial": true
}

```

License description for BOS

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|state|[LicenseState](#schemalicensestate)|false|none|none|
|type|string¦null|false|none|Type.<br>Engineering (none), BE-OPENBOS-LITE, BE-OPENBOS-MEDIUM, BE-OPENBOS-LARGE, BE-OPENBOS-JUMBO|
|points|integer(int64)|false|none|Number of points covered by license|
|pointsBeingUsed|integer(int64)|false|none|Number of points being used|
|expirationDate|string(date-time)¦null|false|none|Expiration date. Null if none|
|trial|boolean|false|none|Trial license|

<h2 id="tocS_BranchDTO">BranchDTO</h2>
<!-- backwards compatibility -->
<a id="schemabranchdto"></a>
<a id="schema_BranchDTO"></a>
<a id="tocSbranchdto"></a>
<a id="tocsbranchdto"></a>

```json
{
  "childrenIds": [
    "string"
  ],
  "datapoints": [
    {
      "id": "string",
      "description": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "completeProtocolArguments": {
        "property1": null,
        "property2": null
      },
      "networkId": "string"
    }
  ],
  "children": [
    {
      "id": "string",
      "name": "string",
      "type": "Device",
      "additionalData": {
        "property1": "string",
        "property2": "string"
      },
      "networkId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    }
  ],
  "id": "string",
  "name": "string",
  "type": "Device",
  "additionalData": {
    "property1": "string",
    "property2": "string"
  },
  "networkId": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

Information of a branch

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|childrenIds|[string]¦null|false|none|List of unique identifiers of children branches|
|datapoints|[[BusDatapointDTO](#schemabusdatapointdto)]¦null|false|none|List of datapoints of the branch|
|children|[[BranchInfoDTO](#schemabranchinfodto)]¦null|false|none|Minimal information about children branches|
|id|string¦null|false|none|Unique identifier of the branch|
|name|string¦null|false|none|Name of the branch|
|type|[BranchType](#schemabranchtype)|false|none|none|
|additionalData|object¦null|false|none|Additional data for the branch|
|» **additionalProperties**|string|false|none|none|
|networkId|string¦null|false|none|Unique identifier of the network the branch belongs to|
|protocolArguments|object¦null|false|none|List of protocol argument values of the branch|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_BranchInfoDTO">BranchInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemabranchinfodto"></a>
<a id="schema_BranchInfoDTO"></a>
<a id="tocSbranchinfodto"></a>
<a id="tocsbranchinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "type": "Device",
  "additionalData": {
    "property1": "string",
    "property2": "string"
  },
  "networkId": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

Minimal Information of a branch

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the branch|
|name|string¦null|false|none|Name of the branch|
|type|[BranchType](#schemabranchtype)|false|none|none|
|additionalData|object¦null|false|none|Additional data for the branch|
|» **additionalProperties**|string|false|none|none|
|networkId|string¦null|false|none|Unique identifier of the network the branch belongs to|
|protocolArguments|object¦null|false|none|List of protocol argument values of the branch|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_BranchType">BranchType</h2>
<!-- backwards compatibility -->
<a id="schemabranchtype"></a>
<a id="schema_BranchType"></a>
<a id="tocSbranchtype"></a>
<a id="tocsbranchtype"></a>

```json
"Device"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Device|
|*anonymous*|Folder|
|*anonymous*|Function|
|*anonymous*|GroupMain|
|*anonymous*|GroupMiddle|
|*anonymous*|GroupRange|

<h2 id="tocS_BranchUpdateDTO">BranchUpdateDTO</h2>
<!-- backwards compatibility -->
<a id="schemabranchupdatedto"></a>
<a id="schema_BranchUpdateDTO"></a>
<a id="tocSbranchupdatedto"></a>
<a id="tocsbranchupdatedto"></a>

```json
{
  "id": "string",
  "name": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

Definition of a network organization branch for update

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the branch|
|name|string¦null|false|none|Name of the branch|
|protocolArguments|object¦null|false|none|List of protocol argument values of the branch|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_BuildingDTO">BuildingDTO</h2>
<!-- backwards compatibility -->
<a id="schemabuildingdto"></a>
<a id="schema_BuildingDTO"></a>
<a id="tocSbuildingdto"></a>
<a id="tocsbuildingdto"></a>

```json
{
  "surfaceGross": "string",
  "surfaceNet": "string",
  "people": "string",
  "image": "string",
  "gpsLat": "string",
  "gpsLon": "string",
  "property": "string",
  "structures": "string",
  "zoneChildren": "string",
  "zoneParents": "string",
  "tenants": "string",
  "owners": "string",
  "propertyManagers": "string",
  "facilityManagers": "string",
  "visitors": "string",
  "administrators": "string",
  "datapoints": [
    {
      "stationId": "string",
      "networkId": "string",
      "busUnitId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "converterId": "string",
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "properties": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "functionalBlocks": [
    {
      "functionalBlockId": "string",
      "group": "string",
      "masterMode": "None",
      "inZone": true
    }
  ],
  "authorized": true,
  "parentIds": [
    "string"
  ],
  "childrenIds": [
    "string"
  ],
  "hasMapView": true,
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "type": "Physical",
  "tags": [
    "string"
  ],
  "propertyZoneType": "Property",
  "isExternal": true
}

```

Represents a building

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|surfaceGross|string¦null|false|none|Gross surface|
|surfaceNet|string¦null|false|none|Net surface|
|people|string¦null|false|none|Number of people|
|image|string¦null|false|none|Image of the build|
|gpsLat|string¦null|false|none|GPS Latitude|
|gpsLon|string¦null|false|none|GPS Longitude|
|property|string¦null|false|none|Resource path to query the properties of the building|
|structures|string¦null|false|none|Resource path to query the structures of the building|
|zoneChildren|string¦null|false|none|Resource path to query the children zone of the building|
|zoneParents|string¦null|false|none|Resource path to query the parent zones of the building|
|tenants|string¦null|false|none|Resource path to query the tenants of the building|
|owners|string¦null|false|none|Resource path to query the owners of the building|
|propertyManagers|string¦null|false|none|Resource path to query the property managers of the building|
|facilityManagers|string¦null|false|none|Resource path to query the facility managers of the building|
|visitors|string¦null|false|none|Resource path to query the visitors of the building|
|administrators|string¦null|false|none|Resource path to query the administrators of the building|
|datapoints|[[DatapointInstanceDTO](#schemadatapointinstancedto)]¦null|false|none|List of dataPoint instances inherited from datapoint template|
|properties|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|List of properties inherited from property template|
|functionalBlocks|[[FunctionalBlockInstanceOfZoneDTO](#schemafunctionalblockinstanceofzonedto)]¦null|false|none|List of functional block instances attached to the zone|
|authorized|boolean|false|none|If true access is granted to this zone.|
|parentIds|[string]¦null|false|none|List of parent zones attached to the zone|
|childrenIds|[string]¦null|false|none|List of children zone instance definition attached to the created zone<br>(information only)|
|hasMapView|boolean|false|none|True if zone has a mapview attached to it|
|id|string¦null|false|none|Unique identifier of the zone instance|
|name|string¦null|false|none|Localized name of the zone instance|
|icon|string¦null|false|none|Optional image representing the zoneInstance<br>This field is readonly and ignored during a put/post for a zone instance attached to a zone template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the zone instance template (if any)|
|type|[ZoneType](#schemazonetype)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the zone|
|propertyZoneType|[PropertyZoneType](#schemapropertyzonetype)|false|none|Type of a property area|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_BuildingWizardDTO">BuildingWizardDTO</h2>
<!-- backwards compatibility -->
<a id="schemabuildingwizarddto"></a>
<a id="schema_BuildingWizardDTO"></a>
<a id="tocSbuildingwizarddto"></a>
<a id="tocsbuildingwizarddto"></a>

```json
{
  "id": "string",
  "applied": true,
  "name": "string",
  "tags": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|applied|boolean|false|none|none|
|name|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|

<h2 id="tocS_BusDatapointDTO">BusDatapointDTO</h2>
<!-- backwards compatibility -->
<a id="schemabusdatapointdto"></a>
<a id="schema_BusDatapointDTO"></a>
<a id="tocSbusdatapointdto"></a>
<a id="tocsbusdatapointdto"></a>

```json
{
  "id": "string",
  "description": "string",
  "name": "string",
  "direction": "Feedback",
  "typeId": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  },
  "completeProtocolArguments": {
    "property1": null,
    "property2": null
  },
  "networkId": "string"
}

```

Information of a field bus datapoint

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the datapoint|
|description|string¦null|false|none|Description of the datapoint|
|name|string¦null|false|none|Name of the datapoint|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|typeId|string¦null|false|none|Unique identifier of the datapoint data type|
|protocolArguments|object¦null|false|none|List of protocol argument values of the datapoint|
|» **additionalProperties**|any|false|none|none|
|completeProtocolArguments|object¦null|false|none|List of the complete protocol argument values of the datapoint|
|» **additionalProperties**|any|false|none|none|
|networkId|string¦null|false|none|Unique identifier of the network the datapoint belongs to|

<h2 id="tocS_BusDatapointIdentifierDTO">BusDatapointIdentifierDTO</h2>
<!-- backwards compatibility -->
<a id="schemabusdatapointidentifierdto"></a>
<a id="schema_BusDatapointIdentifierDTO"></a>
<a id="tocSbusdatapointidentifierdto"></a>
<a id="tocsbusdatapointidentifierdto"></a>

```json
{
  "type": 0,
  "busDatapointId": "string",
  "networkId": "string",
  "id": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

BusDatapoint specific data

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DatapointIdentifierType](#schemadatapointidentifiertype)|false|none|Discriminator of DatapointIdentifier|
|busDatapointId|string¦null|false|none|Identifier of related BusDatapoint|
|networkId|string¦null|false|none|Identifier of the network (only for reading).|

<h2 id="tocS_BusDatapointUpdateDTO">BusDatapointUpdateDTO</h2>
<!-- backwards compatibility -->
<a id="schemabusdatapointupdatedto"></a>
<a id="schema_BusDatapointUpdateDTO"></a>
<a id="tocSbusdatapointupdatedto"></a>
<a id="tocsbusdatapointupdatedto"></a>

```json
{
  "id": "string",
  "name": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

Definition of a field bus datapoint for update

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the datapoint|
|name|string¦null|false|none|Name of the datapoint|
|protocolArguments|object¦null|false|none|List of protocol argument values of the datapoint|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_ByteDataTypeDTO">ByteDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemabytedatatypedto"></a>
<a id="schema_ByteDataTypeDTO"></a>
<a id="tocSbytedatatypedto"></a>
<a id="tocsbytedatatypedto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|

<h2 id="tocS_Calendar365RoomDTO">Calendar365RoomDTO</h2>
<!-- backwards compatibility -->
<a id="schemacalendar365roomdto"></a>
<a id="schema_Calendar365RoomDTO"></a>
<a id="tocScalendar365roomdto"></a>
<a id="tocscalendar365roomdto"></a>

```json
{
  "name": "string",
  "address": "string",
  "capacity": 0
}

```

Conference room from the Microsoft Graph API.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the room.|
|address|string¦null|false|none|Address of the room.|
|capacity|integer(int32)¦null|false|none|Room capacity (if available).|

<h2 id="tocS_CalendarEntryDTO">CalendarEntryDTO</h2>
<!-- backwards compatibility -->
<a id="schemacalendarentrydto"></a>
<a id="schema_CalendarEntryDTO"></a>
<a id="tocScalendarentrydto"></a>
<a id="tocscalendarentrydto"></a>

```json
{
  "name": "string",
  "organizerName": "string",
  "start": "2019-08-24T14:15:22Z",
  "end": "2019-08-24T14:15:22Z",
  "attendeesCount": 0
}

```

Event of a calendar.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the event.|
|organizerName|string¦null|false|none|The name of the meeting organizer|
|start|string(date-time)|false|none|Date and time of when the event starts.|
|end|string(date-time)|false|none|Date and time of when the event ends.|
|attendeesCount|integer(int64)|false|none|Number of attendees at the event.|

<h2 id="tocS_CircuitDTO">CircuitDTO</h2>
<!-- backwards compatibility -->
<a id="schemacircuitdto"></a>
<a id="schema_CircuitDTO"></a>
<a id="tocScircuitdto"></a>
<a id="tocscircuitdto"></a>

```json
{
  "type": "string",
  "meter": {
    "id": "string",
    "name": "string",
    "icon": "string",
    "energyId": "string",
    "meterParentId": "string",
    "circuitId": "string",
    "deviceInstanceId": "string",
    "deviceInstanceName": "string",
    "zoneId": "string",
    "zoneName": "string",
    "zoneIcon": "string",
    "assignationDone": true,
    "functionalBlockInstanceId": "string",
    "functionalBlockName": "string",
    "tags": [
      "string"
    ]
  },
  "id": "string",
  "name": "string",
  "index": 0,
  "section": "string"
}

```

Information about a circuit (intput or output) of a distribution element

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string|true|none|none|
|meter|[MeterInfoDTO](#schemameterinfodto)|false|none|Minimal information about a meter|
|id|string¦null|false|none|Unique identifier of the circuit|
|name|string¦null|false|none|Name of the circuit|
|index|integer(int64)|false|none|Index of the circuit|
|section|string¦null|false|none|Name of the section of the circuit|

<h2 id="tocS_CircuitInputDTO">CircuitInputDTO</h2>
<!-- backwards compatibility -->
<a id="schemacircuitinputdto"></a>
<a id="schema_CircuitInputDTO"></a>
<a id="tocScircuitinputdto"></a>
<a id="tocscircuitinputdto"></a>

```json
{
  "type": "string",
  "meter": {
    "id": "string",
    "name": "string",
    "icon": "string",
    "energyId": "string",
    "meterParentId": "string",
    "circuitId": "string",
    "deviceInstanceId": "string",
    "deviceInstanceName": "string",
    "zoneId": "string",
    "zoneName": "string",
    "zoneIcon": "string",
    "assignationDone": true,
    "functionalBlockInstanceId": "string",
    "functionalBlockName": "string",
    "tags": [
      "string"
    ]
  },
  "id": "string",
  "name": "string",
  "index": 0,
  "section": "string"
}

```

Information about an input circuit of a distribution element

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[CircuitType](#schemacircuittype)|false|none|Discriminator of Circuit|

<h2 id="tocS_CircuitOutputDTO">CircuitOutputDTO</h2>
<!-- backwards compatibility -->
<a id="schemacircuitoutputdto"></a>
<a id="schema_CircuitOutputDTO"></a>
<a id="tocScircuitoutputdto"></a>
<a id="tocscircuitoutputdto"></a>

```json
{
  "type": "string",
  "lines": [
    {
      "inputDistribution": {
        "inputCircuits": [
          {
            "type": "string",
            "meter": {
              "id": "string",
              "name": "string",
              "icon": "string",
              "energyId": "string",
              "meterParentId": "string",
              "circuitId": "string",
              "deviceInstanceId": "string",
              "deviceInstanceName": "string",
              "zoneId": "string",
              "zoneName": "string",
              "zoneIcon": "string",
              "assignationDone": true,
              "functionalBlockInstanceId": "string",
              "functionalBlockName": "string",
              "tags": [
                "string"
              ]
            },
            "id": "string",
            "name": "string",
            "index": 0,
            "section": "string"
          }
        ],
        "outputCircuits": [
          {
            "type": "string",
            "lines": [],
            "meter": {
              "id": "string",
              "name": "string",
              "icon": "string",
              "energyId": "string",
              "meterParentId": "string",
              "circuitId": "string",
              "deviceInstanceId": "string",
              "deviceInstanceName": "string",
              "zoneId": "string",
              "zoneName": "string",
              "zoneIcon": "string",
              "assignationDone": true,
              "functionalBlockInstanceId": "string",
              "functionalBlockName": "string",
              "tags": [
                "string"
              ]
            },
            "id": "string",
            "name": "string",
            "index": 0,
            "section": "string"
          }
        ],
        "id": "string",
        "name": "string",
        "energyId": "string",
        "tags": [
          "string"
        ],
        "zoneId": "string",
        "zoneName": "string",
        "zoneIcon": "string"
      },
      "id": "string",
      "name": "string",
      "inputCircuitId": "string",
      "outputCircuitId": "string"
    }
  ],
  "meter": {
    "id": "string",
    "name": "string",
    "icon": "string",
    "energyId": "string",
    "meterParentId": "string",
    "circuitId": "string",
    "deviceInstanceId": "string",
    "deviceInstanceName": "string",
    "zoneId": "string",
    "zoneName": "string",
    "zoneIcon": "string",
    "assignationDone": true,
    "functionalBlockInstanceId": "string",
    "functionalBlockName": "string",
    "tags": [
      "string"
    ]
  },
  "id": "string",
  "name": "string",
  "index": 0,
  "section": "string"
}

```

Information about an output circuit of a distribution element

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[CircuitType](#schemacircuittype)|false|none|Discriminator of Circuit|
|lines|[[DistributionLineDTO](#schemadistributionlinedto)]¦null|false|none|Connection lines linked to this output circuit|

<h2 id="tocS_CircuitType">CircuitType</h2>
<!-- backwards compatibility -->
<a id="schemacircuittype"></a>
<a id="schema_CircuitType"></a>
<a id="tocScircuittype"></a>
<a id="tocscircuittype"></a>

```json
"CircuitInputDTO"

```

Discriminator of Circuit

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Discriminator of Circuit|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|CircuitInputDTO|
|*anonymous*|CircuitOutputDTO|

<h2 id="tocS_CloudBackupDTO">CloudBackupDTO</h2>
<!-- backwards compatibility -->
<a id="schemacloudbackupdto"></a>
<a id="schema_CloudBackupDTO"></a>
<a id="tocScloudbackupdto"></a>
<a id="tocscloudbackupdto"></a>

```json
{
  "id": "string",
  "description": "string",
  "createdAt": "string",
  "createdBy": "string",
  "isEncrypted": true,
  "kind": "Full"
}

```

Represents a backup that exists in cloud for this device

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier of this backup|
|description|string¦null|false|none|none|
|createdAt|string¦null|false|none|The time when the backup was created|
|createdBy|string¦null|false|none|The device user that created the backup|
|isEncrypted|boolean|false|none|Flag that tells whether the backup archive is encrypted|
|kind|[BackupKind](#schemabackupkind)|false|none|none|

<h2 id="tocS_CloudRegistrationStatus">CloudRegistrationStatus</h2>
<!-- backwards compatibility -->
<a id="schemacloudregistrationstatus"></a>
<a id="schema_CloudRegistrationStatus"></a>
<a id="tocScloudregistrationstatus"></a>
<a id="tocscloudregistrationstatus"></a>

```json
"None"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|None|
|*anonymous*|Failed|
|*anonymous*|Done|
|*anonymous*|Ignored|

<h2 id="tocS_CloudRestoreRequestDTO">CloudRestoreRequestDTO</h2>
<!-- backwards compatibility -->
<a id="schemacloudrestorerequestdto"></a>
<a id="schema_CloudRestoreRequestDTO"></a>
<a id="tocScloudrestorerequestdto"></a>
<a id="tocscloudrestorerequestdto"></a>

```json
{
  "connectionId": "string",
  "backupId": "string",
  "password": "string"
}

```

A request to perform a cloud restore

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|connectionId|string¦null|false|none|Subscription's connectionId used for backup notification|
|backupId|string¦null|false|none|The identifier of the backup to be restored on the device|
|password|string¦null|false|none|An optional password to use for backup encryption|

<h2 id="tocS_CompanyEnrolmentDTO">CompanyEnrolmentDTO</h2>
<!-- backwards compatibility -->
<a id="schemacompanyenrolmentdto"></a>
<a id="schema_CompanyEnrolmentDTO"></a>
<a id="tocScompanyenrolmentdto"></a>
<a id="tocscompanyenrolmentdto"></a>

```json
{
  "id": "string",
  "companyRoleId": "string",
  "companyId": "string",
  "companyName": "string",
  "enrolmentStatus": "Active",
  "createdAt": "2019-08-24T14:15:22Z",
  "authorizationCode": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier of the enrolment|
|companyRoleId|string¦null|false|none|The local company identifier|
|companyId|string¦null|false|none|The cloud company identifier|
|companyName|string¦null|false|none|The cloud company name|
|enrolmentStatus|[EnrolmentStatus](#schemaenrolmentstatus)|false|none|none|
|createdAt|string(date-time)|false|none|When the enrolment was initiated|
|authorizationCode|string¦null|false|none|The authorization code required for the cloud company administrator to perform the enrolment|

<h2 id="tocS_CompanyEnrolmentRequestDTO">CompanyEnrolmentRequestDTO</h2>
<!-- backwards compatibility -->
<a id="schemacompanyenrolmentrequestdto"></a>
<a id="schema_CompanyEnrolmentRequestDTO"></a>
<a id="tocScompanyenrolmentrequestdto"></a>
<a id="tocscompanyenrolmentrequestdto"></a>

```json
{
  "company": "string",
  "connectionId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|company|string|true|none|The identifier of the local company to associate|
|connectionId|string¦null|false|none|A SignalR connection where the enrolment completion notification should be sent|

<h2 id="tocS_ComplexDataTypeDTO">ComplexDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemacomplexdatatypedto"></a>
<a id="schema_ComplexDataTypeDTO"></a>
<a id="tocScomplexdatatypedto"></a>
<a id="tocscomplexdatatypedto"></a>

```json
{
  "type": "string",
  "fields": [
    {
      "id": "string",
      "name": "string",
      "rank": 0,
      "type": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ],
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

Complex data type value definition. (type:"Complex")

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|
|fields|[[FieldDTO](#schemafielddto)]¦null|false|none|List of fields attached to the complex type|

<h2 id="tocS_CompliantConverterRequestDeviceTemplateDTO">CompliantConverterRequestDeviceTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemacompliantconverterrequestdevicetemplatedto"></a>
<a id="schema_CompliantConverterRequestDeviceTemplateDTO"></a>
<a id="tocScompliantconverterrequestdevicetemplatedto"></a>
<a id="tocscompliantconverterrequestdevicetemplatedto"></a>

```json
{
  "wantExistingConverters": true,
  "wantNewConverter": true,
  "deviceTemplateId": "string",
  "datapointTemplateId": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

Used to get compliant converter for a device datapoint template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|wantExistingConverters|boolean|false|none|If true the resource path will return the list of existing compliant converters|
|wantNewConverter|boolean|false|none|If true the resource path will return a new converter|
|deviceTemplateId|string¦null|false|none|Id of the DeviceTemplateDatapoint|
|datapointTemplateId|string¦null|false|none|Id of the datapoint template of the functional block|
|protocolArguments|object¦null|false|none|Protocol arguments of the bus datapoint|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_CompliantConverterRequestFromBusDatapointDTO">CompliantConverterRequestFromBusDatapointDTO</h2>
<!-- backwards compatibility -->
<a id="schemacompliantconverterrequestfrombusdatapointdto"></a>
<a id="schema_CompliantConverterRequestFromBusDatapointDTO"></a>
<a id="tocScompliantconverterrequestfrombusdatapointdto"></a>
<a id="tocscompliantconverterrequestfrombusdatapointdto"></a>

```json
{
  "wantExistingConverters": true,
  "wantNewConverter": true,
  "busDatapointId": "string",
  "datapointInstanceId": "string",
  "additionalArguments": {
    "property1": null,
    "property2": null
  }
}

```

Used to get compliant converter for a datapoint instance assigned to a busdatapoint

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|wantExistingConverters|boolean|false|none|If true the resource path will return the list of existing compliant converters|
|wantNewConverter|boolean|false|none|If true the resource path will return a new converter|
|busDatapointId|string¦null|false|none|Id of the bus datapoint from the network organization|
|datapointInstanceId|string¦null|false|none|Id of the datapoint instance we want to assign|
|additionalArguments|object¦null|false|none|Additional protocol argument.<br>Arguments that will be added to the bus datapoint protocol arguments before analysing the compliant converter.<br>These arguments will override bus datapoint protocol arguments if they already exist in the bus datapoint.<br>If null or empty then no additional protocol arguments will be added|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_CompliantConverterRequestManualDTO">CompliantConverterRequestManualDTO</h2>
<!-- backwards compatibility -->
<a id="schemacompliantconverterrequestmanualdto"></a>
<a id="schema_CompliantConverterRequestManualDTO"></a>
<a id="tocScompliantconverterrequestmanualdto"></a>
<a id="tocscompliantconverterrequestmanualdto"></a>

```json
{
  "wantExistingConverters": true,
  "wantNewConverter": true,
  "protocolArguments": {
    "property1": null,
    "property2": null
  },
  "networkId": "string",
  "datapointInstanceId": "string"
}

```

Used to get compliant converter for a datapoint instance manually assigned to a bus datapoint

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|wantExistingConverters|boolean|false|none|If true the resource path will return the list of existing compliant converters|
|wantNewConverter|boolean|false|none|If true the resource path will return a new converter|
|protocolArguments|object¦null|false|none|Protocol arguments of the bus datapoint|
|» **additionalProperties**|any|false|none|none|
|networkId|string¦null|false|none|Id of network the bus datapoint belongs to|
|datapointInstanceId|string¦null|false|none|Id of the datapoint instance we want to assign|

<h2 id="tocS_CompliantConvertersDTO">CompliantConvertersDTO</h2>
<!-- backwards compatibility -->
<a id="schemacompliantconvertersdto"></a>
<a id="schema_CompliantConvertersDTO"></a>
<a id="tocScompliantconvertersdto"></a>
<a id="tocscompliantconvertersdto"></a>

```json
{
  "needConverter": "None",
  "existingConverters": [
    {
      "type": "string",
      "id": "string",
      "typeSource": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      },
      "typeDest": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      },
      "name": "string"
    }
  ],
  "newConverter": {
    "type": "string",
    "id": "string",
    "typeSource": {
      "type": "string",
      "id": "string",
      "name": "string",
      "tag": "string",
      "transport": "none"
    },
    "typeDest": {
      "type": "string",
      "id": "string",
      "name": "string",
      "tag": "string",
      "transport": "none"
    },
    "name": "string"
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|needConverter|[ConverterComplianceType](#schemaconvertercompliancetype)|false|none|Type of converter required when mapping a datapoint to a bus datapoint. <br>None means no converter needed, Required means a converter is required, Notpossible means datapoint cannot be assigned to this bus datpaoint|
|existingConverters|[oneOf]¦null|false|none|A list of existing converter compliant with the request(if any)<br>Always empty if WantExistingConverters is false<br>Always empty if NeedConverter is true|

oneOf - discriminator: ConverterDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ConverterDTO](#schemaconverterdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceBoolDestDoubleConverterDTO](#schemasourcebooldestdoubleconverterdto)|false|none|SourceBoolDestDoubleDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceBoolDestEnumConverterDTO](#schemasourcebooldestenumconverterdto)|false|none|SourceBoolDestEnumDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceDoubleDestBoolConverterDTO](#schemasourcedoubledestboolconverterdto)|false|none|SourceDoubleDestBoolDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceDoubleDestEnumConverterDTO](#schemasourcedoubledestenumconverterdto)|false|none|SourceDoubleDestEnumDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceEnumDestBoolConverterDTO](#schemasourceenumdestboolconverterdto)|false|none|SourceEnumDestBoolDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceEnumDestDoubleConverterDTO](#schemasourceenumdestdoubleconverterdto)|false|none|SourceEnumDestDoubleDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceEnumDestEnumConverterDTO](#schemasourceenumdestenumconverterdto)|false|none|SourceEnumDestEnumDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceEnumDestLongConverterDTO](#schemasourceenumdestlongconverterdto)|false|none|SourceEnumDestLongDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceLongDestBoolConverterDTO](#schemasourcelongdestboolconverterdto)|false|none|SourceLongDestBoolDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceLongDestEnumConverterDTO](#schemasourcelongdestenumconverterdto)|false|none|SourceLongDestEnumDTO Converter definition object.|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|newConverter|any|false|none|A newly converter initialized with default<br>Always empty if NeedConverter is true<br>Always empty if WantNewConverter is true|

oneOf - discriminator: ConverterDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ConverterDTO](#schemaconverterdto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceBoolDestDoubleConverterDTO](#schemasourcebooldestdoubleconverterdto)|false|none|SourceBoolDestDoubleDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceBoolDestEnumConverterDTO](#schemasourcebooldestenumconverterdto)|false|none|SourceBoolDestEnumDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceDoubleDestBoolConverterDTO](#schemasourcedoubledestboolconverterdto)|false|none|SourceDoubleDestBoolDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceDoubleDestEnumConverterDTO](#schemasourcedoubledestenumconverterdto)|false|none|SourceDoubleDestEnumDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceEnumDestBoolConverterDTO](#schemasourceenumdestboolconverterdto)|false|none|SourceEnumDestBoolDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceEnumDestDoubleConverterDTO](#schemasourceenumdestdoubleconverterdto)|false|none|SourceEnumDestDoubleDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceEnumDestEnumConverterDTO](#schemasourceenumdestenumconverterdto)|false|none|SourceEnumDestEnumDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceEnumDestLongConverterDTO](#schemasourceenumdestlongconverterdto)|false|none|SourceEnumDestLongDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceLongDestBoolConverterDTO](#schemasourcelongdestboolconverterdto)|false|none|SourceLongDestBoolDTO Converter definition object.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[SourceLongDestEnumConverterDTO](#schemasourcelongdestenumconverterdto)|false|none|SourceLongDestEnumDTO Converter definition object.|

<h2 id="tocS_ConfigStateDto">ConfigStateDto</h2>
<!-- backwards compatibility -->
<a id="schemaconfigstatedto"></a>
<a id="schema_ConfigStateDto"></a>
<a id="tocSconfigstatedto"></a>
<a id="tocsconfigstatedto"></a>

```json
{
  "step": "string",
  "completed": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|step|string|true|none|none|
|completed|boolean|true|none|none|

<h2 id="tocS_ConverterComplianceType">ConverterComplianceType</h2>
<!-- backwards compatibility -->
<a id="schemaconvertercompliancetype"></a>
<a id="schema_ConverterComplianceType"></a>
<a id="tocSconvertercompliancetype"></a>
<a id="tocsconvertercompliancetype"></a>

```json
"None"

```

Type of converter required when mapping a datapoint to a bus datapoint. 
None means no converter needed, Required means a converter is required, Notpossible means datapoint cannot be assigned to this bus datpaoint

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Type of converter required when mapping a datapoint to a bus datapoint. <br>None means no converter needed, Required means a converter is required, Notpossible means datapoint cannot be assigned to this bus datpaoint|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|None|
|*anonymous*|Required|
|*anonymous*|Notpossible|

<h2 id="tocS_ConverterDTO">ConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemaconverterdto"></a>
<a id="schema_ConverterDTO"></a>
<a id="tocSconverterdto"></a>
<a id="tocsconverterdto"></a>

```json
{
  "type": "string",
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string|true|none|none|
|id|string¦null|false|none|Unique identifier of the converter object.|
|typeSource|any|false|none|Type of the source (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|typeDest|any|false|none|Type of the destination (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the converter.|

<h2 id="tocS_ConverterInfoDTO">ConverterInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaconverterinfodto"></a>
<a id="schema_ConverterInfoDTO"></a>
<a id="tocSconverterinfodto"></a>
<a id="tocsconverterinfodto"></a>

```json
{
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the converter object.|
|typeSource|any|false|none|Type of the source (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|typeDest|any|false|none|Type of the destination (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the converter.|

<h2 id="tocS_ConverterType">ConverterType</h2>
<!-- backwards compatibility -->
<a id="schemaconvertertype"></a>
<a id="schema_ConverterType"></a>
<a id="tocSconvertertype"></a>
<a id="tocsconvertertype"></a>

```json
"Unknown"

```

Discriminator of DataType

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Discriminator of DataType|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Unknown|
|*anonymous*|SourceBoolDestDoubleConverter|
|*anonymous*|SourceBoolDestEnumConverter|
|*anonymous*|SourceBoolDestLongConverter|
|*anonymous*|SourceDoubleDestBoolConverter|
|*anonymous*|SourceDoubleDestEnumConverter|
|*anonymous*|SourceEnumDestBoolConverter|
|*anonymous*|SourceEnumDestDoubleConverter|
|*anonymous*|SourceEnumDestEnumConverter|
|*anonymous*|SourceEnumDestLongConverter|
|*anonymous*|SourceLongDestBoolConverter|
|*anonymous*|SourceLongDestEnumConverter|

<h2 id="tocS_CountAndAlarmsStatisticsDTO">CountAndAlarmsStatisticsDTO</h2>
<!-- backwards compatibility -->
<a id="schemacountandalarmsstatisticsdto"></a>
<a id="schema_CountAndAlarmsStatisticsDTO"></a>
<a id="tocScountandalarmsstatisticsdto"></a>
<a id="tocscountandalarmsstatisticsdto"></a>

```json
{
  "tag": "string",
  "count": 0,
  "activeAlarms": 0
}

```

Statistics of instances and alarms count

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tag|string¦null|false|none|Tag of the entities|
|count|integer(int64)|false|none|Number of instances|
|activeAlarms|integer(int64)|false|none|Number of active alarms|

<h2 id="tocS_DatapointDirection">DatapointDirection</h2>
<!-- backwards compatibility -->
<a id="schemadatapointdirection"></a>
<a id="schema_DatapointDirection"></a>
<a id="tocSdatapointdirection"></a>
<a id="tocsdatapointdirection"></a>

```json
"Feedback"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Feedback|
|*anonymous*|Command|
|*anonymous*|CommandAndFeedback|
|*anonymous*|Configuration|

<h2 id="tocS_DatapointIdentifierDTO">DatapointIdentifierDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointidentifierdto"></a>
<a id="schema_DatapointIdentifierDTO"></a>
<a id="tocSdatapointidentifierdto"></a>
<a id="tocsdatapointidentifierdto"></a>

```json
{
  "type": 0,
  "id": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

Common data for all datapoint identifier dtos

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DatapointIdentifierType](#schemadatapointidentifiertype)|true|none|Discriminator of DatapointIdentifier|
|id|string¦null|false|none|Optional identifier of the datapoint.|
|protocolArguments|object¦null|false|none|ProtocolArguments to apply for DatapointIdentifier|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_DatapointIdentifierType">DatapointIdentifierType</h2>
<!-- backwards compatibility -->
<a id="schemadatapointidentifiertype"></a>
<a id="schema_DatapointIdentifierType"></a>
<a id="tocSdatapointidentifiertype"></a>
<a id="tocsdatapointidentifiertype"></a>

```json
0

```

Discriminator of DatapointIdentifier

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|integer(int32)|false|none|Discriminator of DatapointIdentifier|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|0|
|*anonymous*|1|
|*anonymous*|2|

<h2 id="tocS_DatapointIdentifierWithNameDTO">DatapointIdentifierWithNameDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointidentifierwithnamedto"></a>
<a id="schema_DatapointIdentifierWithNameDTO"></a>
<a id="tocSdatapointidentifierwithnamedto"></a>
<a id="tocsdatapointidentifierwithnamedto"></a>

```json
{
  "identifier": {
    "type": 0,
    "busDatapointId": "string",
    "networkId": "string",
    "id": "string",
    "protocolArguments": {
      "property1": null,
      "property2": null
    }
  },
  "displayName": "string"
}

```

Common data for all datapoint identifier dtos with display name

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|identifier|any|false|none|Datapoint identifier|

oneOf

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BusDatapointIdentifierDTO](#schemabusdatapointidentifierdto)|false|none|BusDatapoint specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DatapointInstanceIdentifierDTO](#schemadatapointinstanceidentifierdto)|false|none|DatapointInstance specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ProtocolArgumentsOnlyIdentifierDTO](#schemaprotocolargumentsonlyidentifierdto)|false|none|ProtocolArgumentsOnly specific data|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|displayName|string¦null|false|none|Name to display for the datapoint identifier|

<h2 id="tocS_DatapointInstanceDTO">DatapointInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointinstancedto"></a>
<a id="schema_DatapointInstanceDTO"></a>
<a id="tocSdatapointinstancedto"></a>
<a id="tocsdatapointinstancedto"></a>

```json
{
  "stationId": "string",
  "networkId": "string",
  "busUnitId": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  },
  "converterId": "string",
  "id": "string",
  "name": "string",
  "direction": "Feedback",
  "typeId": "string",
  "tags": [
    "string"
  ],
  "templateId": "string",
  "functionalBlockId": "string",
  "zoneId": "string",
  "displayUnitId": "string",
  "unitId": "string"
}

```

Datapoint instance definition

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|stationId|string¦null|false|none|Unique identifier of the station managing the datapoint instance|
|networkId|string¦null|false|none|Unique identifier of the network managing the datapoint instance|
|busUnitId|string¦null|false|none|Bus unit id|
|protocolArguments|object¦null|false|none|Protocol arguments|
|» **additionalProperties**|any|false|none|none|
|converterId|string¦null|false|none|Id of the converter|
|id|string¦null|false|none|Id|
|name|string¦null|false|none|Name of datapoint<br>This field is readonly and ignored during a put/post for a datapoint instance attached to a datapoint template|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|typeId|string¦null|false|none|Unique identifier DataType<br>This field is readonly and ignored during a put/post for a datapoint instance attached to a datapoint template|
|tags|[string]¦null|false|none|List of tag matching the datapoint<br>This field is readonly and ignored during a put/post for a datapoint instance attached to a datapoint template|
|templateId|string¦null|false|none|Unique identifier of the datapoint template (if any)|
|functionalBlockId|string¦null|false|none|Id of the functionalblock instance the datapoint belongs to.<br>Empty if datapoint does not belong to a functionalblock instance.<br>Readonly (for information only).|
|zoneId|string¦null|false|none|Id of the zone instance the datapoint belongs to.<br>Empty if datapoint does not belong to a zone instance.<br>Readonly (for information only).|
|displayUnitId|string¦null|false|none|Identifier of the display unit|
|unitId|string¦null|false|none|Identifier of the unit of the template of the datapoint<br>Readonly (for information only).|

<h2 id="tocS_DatapointInstanceIdentifierDTO">DatapointInstanceIdentifierDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointinstanceidentifierdto"></a>
<a id="schema_DatapointInstanceIdentifierDTO"></a>
<a id="tocSdatapointinstanceidentifierdto"></a>
<a id="tocsdatapointinstanceidentifierdto"></a>

```json
{
  "type": 0,
  "datapointInstanceId": "string",
  "id": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

DatapointInstance specific data

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DatapointIdentifierType](#schemadatapointidentifiertype)|false|none|Discriminator of DatapointIdentifier|
|datapointInstanceId|string¦null|false|none|Identifier of related DatapointInstance|

<h2 id="tocS_DatapointInstanceReadExtendedDTO">DatapointInstanceReadExtendedDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointinstancereadextendeddto"></a>
<a id="schema_DatapointInstanceReadExtendedDTO"></a>
<a id="tocSdatapointinstancereadextendeddto"></a>
<a id="tocsdatapointinstancereadextendeddto"></a>

```json
{
  "datapointClientId": "string",
  "identifier": {
    "type": 0,
    "busDatapointId": "string",
    "networkId": "string",
    "id": "string",
    "protocolArguments": {
      "property1": null,
      "property2": null
    }
  }
}

```

Definition of item used to read value on datapoint identifier

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointClientId|string¦null|false|none|Identifier of a DatapointIdentifier dto.|
|identifier|any|false|none|Datapoint identifier to write on|

oneOf

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BusDatapointIdentifierDTO](#schemabusdatapointidentifierdto)|false|none|BusDatapoint specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DatapointInstanceIdentifierDTO](#schemadatapointinstanceidentifierdto)|false|none|DatapointInstance specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ProtocolArgumentsOnlyIdentifierDTO](#schemaprotocolargumentsonlyidentifierdto)|false|none|ProtocolArgumentsOnly specific data|

<h2 id="tocS_DatapointInstanceTreeDisplayDTO">DatapointInstanceTreeDisplayDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointinstancetreedisplaydto"></a>
<a id="schema_DatapointInstanceTreeDisplayDTO"></a>
<a id="tocSdatapointinstancetreedisplaydto"></a>
<a id="tocsdatapointinstancetreedisplaydto"></a>

```json
{
  "id": "string",
  "name": "string",
  "direction": "Feedback",
  "tags": [
    "string"
  ],
  "templateId": "string",
  "displayUnitId": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  },
  "networkId": "string",
  "driverDescriptorId": "string"
}

```

Datapoint instance definition for tree display

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id|
|name|string¦null|false|none|Name of datapoint|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the datapoint|
|templateId|string¦null|false|none|Unique identifier of the datapoint template (if any)|
|displayUnitId|string¦null|false|none|Identifier of the display unit|
|protocolArguments|object¦null|false|none|Protocol arguments|
|» **additionalProperties**|any|false|none|none|
|networkId|string¦null|false|none|Identifier of the network managing the datapoint instance|
|driverDescriptorId|string¦null|false|none|Identifier of the driver descriptor|

<h2 id="tocS_DatapointInstanceValueDTO">DatapointInstanceValueDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointinstancevaluedto"></a>
<a id="schema_DatapointInstanceValueDTO"></a>
<a id="tocSdatapointinstancevaluedto"></a>
<a id="tocsdatapointinstancevaluedto"></a>

```json
{
  "id": "string",
  "value": null,
  "quality": "none",
  "innerError": "string",
  "timeStamp": "2019-08-24T14:15:22Z"
}

```

Result of a read operation on a datapoint.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier of the datapoint.|
|value|any|false|none|Value of the datapoint.|
|quality|[DataQuality](#schemadataquality)|false|none|none|
|innerError|string¦null|false|none|More explicit error when quality is badinternalerror or badmiddlewarecommunication|
|timeStamp|string(date-time)|false|none|Timestamp of the read operation in UTC.|

<h2 id="tocS_DatapointInstanceWriteDTO">DatapointInstanceWriteDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointinstancewritedto"></a>
<a id="schema_DatapointInstanceWriteDTO"></a>
<a id="tocSdatapointinstancewritedto"></a>
<a id="tocsdatapointinstancewritedto"></a>

```json
{
  "id": "string",
  "value": null
}

```

Information for a write operation on a datapoint

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier of the datapoint|
|value|any|false|none|Value of the datapoint|

<h2 id="tocS_DatapointInstanceWriteExtendedDTO">DatapointInstanceWriteExtendedDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointinstancewriteextendeddto"></a>
<a id="schema_DatapointInstanceWriteExtendedDTO"></a>
<a id="tocSdatapointinstancewriteextendeddto"></a>
<a id="tocsdatapointinstancewriteextendeddto"></a>

```json
{
  "datapointClientId": "string",
  "identifier": {
    "type": 0,
    "busDatapointId": "string",
    "networkId": "string",
    "id": "string",
    "protocolArguments": {
      "property1": null,
      "property2": null
    }
  },
  "value": null
}

```

Definition of item used to write value on datapoint identifier

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointClientId|string¦null|false|none|Identifier of a DatapointIdentifier dto.|
|identifier|any|false|none|Datapoint identifier to write on|

oneOf

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BusDatapointIdentifierDTO](#schemabusdatapointidentifierdto)|false|none|BusDatapoint specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DatapointInstanceIdentifierDTO](#schemadatapointinstanceidentifierdto)|false|none|DatapointInstance specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ProtocolArgumentsOnlyIdentifierDTO](#schemaprotocolargumentsonlyidentifierdto)|false|none|ProtocolArgumentsOnly specific data|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|value|any|false|none|Value to write|

<h2 id="tocS_DatapointInstanceWriteResultDTO">DatapointInstanceWriteResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointinstancewriteresultdto"></a>
<a id="schema_DatapointInstanceWriteResultDTO"></a>
<a id="tocSdatapointinstancewriteresultdto"></a>
<a id="tocsdatapointinstancewriteresultdto"></a>

```json
{
  "id": "string",
  "errorCode": "string",
  "innerError": "string"
}

```

Result of a write operation on a datapoint.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier of the datapoint.|
|errorCode|string¦null|false|none|Error code (empty if succeed)|
|innerError|string¦null|false|none|Middleware error.<br>Only when ErrorCode is LIV-004|

<h2 id="tocS_DatapointSelectorDTO">DatapointSelectorDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointselectordto"></a>
<a id="schema_DatapointSelectorDTO"></a>
<a id="tocSdatapointselectordto"></a>
<a id="tocsdatapointselectordto"></a>

```json
{
  "id": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|

<h2 id="tocS_DatapointsInformationDTO">DatapointsInformationDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsinformationdto"></a>
<a id="schema_DatapointsInformationDTO"></a>
<a id="tocSdatapointsinformationdto"></a>
<a id="tocsdatapointsinformationdto"></a>

```json
{
  "items": [
    {
      "type": 0,
      "busDatapointId": "string",
      "networkId": "string",
      "id": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    }
  ]
}

```

Definition of datapoint identifiers needing information such as display name, type and unit

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|items|[oneOf]¦null|false|none|Datapoint items needing information such as display name, type and unit|

oneOf

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BusDatapointIdentifierDTO](#schemabusdatapointidentifierdto)|false|none|BusDatapoint specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DatapointInstanceIdentifierDTO](#schemadatapointinstanceidentifierdto)|false|none|DatapointInstance specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ProtocolArgumentsOnlyIdentifierDTO](#schemaprotocolargumentsonlyidentifierdto)|false|none|ProtocolArgumentsOnly specific data|

<h2 id="tocS_DatapointSubscriptionCreateDTO">DatapointSubscriptionCreateDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsubscriptioncreatedto"></a>
<a id="schema_DatapointSubscriptionCreateDTO"></a>
<a id="tocSdatapointsubscriptioncreatedto"></a>
<a id="tocsdatapointsubscriptioncreatedto"></a>

```json
{
  "ignoreErrors": true,
  "items": [
    {
      "scanRate": 0,
      "deadBand": 0,
      "datapointClientId": "string",
      "datapoint": {
        "type": 0,
        "busDatapointId": "string",
        "networkId": "string",
        "id": "string",
        "protocolArguments": {
          "property1": null,
          "property2": null
        }
      },
      "tags": [
        "string"
      ]
    }
  ]
}

```

Definition of items to add to extended subscription

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|ignoreErrors|boolean|false|none|Ignore errors when subscribing to datapoint identifiers|
|items|[[DatapointSubscriptionCreateItemDTO](#schemadatapointsubscriptioncreateitemdto)]¦null|false|none|Datapoint items to subscribe|

<h2 id="tocS_DatapointSubscriptionCreateItemDTO">DatapointSubscriptionCreateItemDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsubscriptioncreateitemdto"></a>
<a id="schema_DatapointSubscriptionCreateItemDTO"></a>
<a id="tocSdatapointsubscriptioncreateitemdto"></a>
<a id="tocsdatapointsubscriptioncreateitemdto"></a>

```json
{
  "scanRate": 0,
  "deadBand": 0,
  "datapointClientId": "string",
  "datapoint": {
    "type": 0,
    "busDatapointId": "string",
    "networkId": "string",
    "id": "string",
    "protocolArguments": {
      "property1": null,
      "property2": null
    }
  },
  "tags": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|scanRate|integer(int32)|false|none|Scan rate (in ms) for the datapoint.|
|deadBand|number(double)|false|none|Deadband for the datapoint.|
|datapointClientId|string¦null|false|none|Identifier of a DatapointIdentifier dto.|
|datapoint|any|false|none|Datapoint item to subscribe|

oneOf

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BusDatapointIdentifierDTO](#schemabusdatapointidentifierdto)|false|none|BusDatapoint specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DatapointInstanceIdentifierDTO](#schemadatapointinstanceidentifierdto)|false|none|DatapointInstance specific data|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ProtocolArgumentsOnlyIdentifierDTO](#schemaprotocolargumentsonlyidentifierdto)|false|none|ProtocolArgumentsOnly specific data|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tags|[string]¦null|false|none|none|

<h2 id="tocS_DatapointSubscriptionCreateItemResultDTO">DatapointSubscriptionCreateItemResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsubscriptioncreateitemresultdto"></a>
<a id="schema_DatapointSubscriptionCreateItemResultDTO"></a>
<a id="tocSdatapointsubscriptioncreateitemresultdto"></a>
<a id="tocsdatapointsubscriptioncreateitemresultdto"></a>

```json
{
  "datapointClientId": "string",
  "displayName": "string",
  "address": "string",
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "unit": {
    "displayName": "string",
    "unitShortString": "string",
    "resolution": 0,
    "category": "string",
    "preferredMin": 0,
    "preferredMax": 0
  },
  "parentName": "string",
  "parentIcon": "string",
  "parentIconFillColor": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  },
  "networkId": "string"
}

```

Data of created subscription item

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointClientId|string¦null|false|none|Id of datapoint subscription item|
|displayName|string¦null|false|none|Built display name for subscription item|
|address|string¦null|false|none|Built display address for subscription item|
|type|any|false|none|Data type value definition|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|unit|[UnitDTO](#schemaunitdto)|false|none|Unit description|
|parentName|string¦null|false|none|Parent name of related subscription item datapoint|
|parentIcon|string¦null|false|none|Parent icon of related subscription item datapoint|
|parentIconFillColor|string¦null|false|none|Parent icon fill color of related subscription item datapoint|
|protocolArguments|object¦null|false|none|ProtocolArguments of related subscription item datapoint|
|» **additionalProperties**|any|false|none|none|
|networkId|string¦null|false|none|Unique identifier of the network the datapoint belongs to|

<h2 id="tocS_DatapointSubscriptionCreateResultDTO">DatapointSubscriptionCreateResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsubscriptioncreateresultdto"></a>
<a id="schema_DatapointSubscriptionCreateResultDTO"></a>
<a id="tocSdatapointsubscriptioncreateresultdto"></a>
<a id="tocsdatapointsubscriptioncreateresultdto"></a>

```json
{
  "items": [
    {
      "datapointClientId": "string",
      "displayName": "string",
      "address": "string",
      "type": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      },
      "unit": {
        "displayName": "string",
        "unitShortString": "string",
        "resolution": 0,
        "category": "string",
        "preferredMin": 0,
        "preferredMax": 0
      },
      "parentName": "string",
      "parentIcon": "string",
      "parentIconFillColor": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "networkId": "string"
    }
  ]
}

```

Result dto with all created subscription items

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|items|[[DatapointSubscriptionCreateItemResultDTO](#schemadatapointsubscriptioncreateitemresultdto)]¦null|false|none|Collection of created subscription items|

<h2 id="tocS_DatapointSubscriptionDTO">DatapointSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsubscriptiondto"></a>
<a id="schema_DatapointSubscriptionDTO"></a>
<a id="tocSdatapointsubscriptiondto"></a>
<a id="tocsdatapointsubscriptiondto"></a>

```json
{
  "keepAllChanges": true,
  "minSendTime": 0,
  "maxSendTime": 0,
  "items": [
    {
      "datapointInstanceId": "string",
      "scanRate": 0,
      "deadBand": 0,
      "tags": [
        "string"
      ]
    }
  ],
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

Definition of a sunscription to monitor datapoints.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|keepAllChanges|boolean|false|none|True if the subscription returns all data changes, false if it returns only the last value of a datapoint.|
|minSendTime|integer(int32)|false|none|Minimum duration (in ms) between two reports: limits the arrival of too numerous notifications|
|maxSendTime|integer(int32)¦null|false|none|Maximum duration (in ms) between two reports: sends a notification, even if the value has not changed after a given time|
|items|[[DatapointSubscriptionItemDTO](#schemadatapointsubscriptionitemdto)]¦null|false|none|Item in subscriptions (datapoints to monitor).|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_DatapointSubscriptionExtendedDTO">DatapointSubscriptionExtendedDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsubscriptionextendeddto"></a>
<a id="schema_DatapointSubscriptionExtendedDTO"></a>
<a id="tocSdatapointsubscriptionextendeddto"></a>
<a id="tocsdatapointsubscriptionextendeddto"></a>

```json
{
  "keepAllChanges": true,
  "minSendTime": 0,
  "maxSendTime": 0,
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

Definition of a subscription to monitor datapoint identifiers.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|keepAllChanges|boolean|false|none|True if the subscription returns all data changes, false if it returns only the last value of a datapoint.|
|minSendTime|integer(int32)|false|none|Minimum duration (in ms) between two reports: limits the arrival of too numerous notifications|
|maxSendTime|integer(int32)¦null|false|none|Maximum duration (in ms) between two reports: sends a notification, even if the value has not changed after a given time|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_DatapointSubscriptionItemDTO">DatapointSubscriptionItemDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsubscriptionitemdto"></a>
<a id="schema_DatapointSubscriptionItemDTO"></a>
<a id="tocSdatapointsubscriptionitemdto"></a>
<a id="tocsdatapointsubscriptionitemdto"></a>

```json
{
  "datapointInstanceId": "string",
  "scanRate": 0,
  "deadBand": 0,
  "tags": [
    "string"
  ]
}

```

Datapoint definition in a subscription.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointInstanceId|string¦null|false|none|Identifier of a datapoint.|
|scanRate|integer(int32)|false|none|Scan rate (in ms) for the datapoint.|
|deadBand|number(double)|false|none|Deadband for the datapoint.|
|tags|[string]¦null|false|none|none|

<h2 id="tocS_DatapointSubscriptionUpdateDTO">DatapointSubscriptionUpdateDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsubscriptionupdatedto"></a>
<a id="schema_DatapointSubscriptionUpdateDTO"></a>
<a id="tocSdatapointsubscriptionupdatedto"></a>
<a id="tocsdatapointsubscriptionupdatedto"></a>

```json
{
  "ignoreErrors": true,
  "items": [
    {
      "datapointClientId": "string",
      "scanRate": 0,
      "deadBand": 0
    }
  ]
}

```

Definition of items to update in extended subscription

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|ignoreErrors|boolean|false|none|Ignore errors when subscribing to datapoint identifiers|
|items|[[DatapointSubscriptionUpdateItemDTO](#schemadatapointsubscriptionupdateitemdto)]¦null|false|none|Datapoint values to update|

<h2 id="tocS_DatapointSubscriptionUpdateItemDTO">DatapointSubscriptionUpdateItemDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointsubscriptionupdateitemdto"></a>
<a id="schema_DatapointSubscriptionUpdateItemDTO"></a>
<a id="tocSdatapointsubscriptionupdateitemdto"></a>
<a id="tocsdatapointsubscriptionupdateitemdto"></a>

```json
{
  "datapointClientId": "string",
  "scanRate": 0,
  "deadBand": 0
}

```

Definition of values that can be updated on subscribed datapoint identifiers

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointClientId|string¦null|false|none|Identifier of a DatapointIdentifier dto.|
|scanRate|integer(int32)|false|none|Scan rate (in ms) for the datapoint.|
|deadBand|number(double)|false|none|Deadband for the datapoint.|

<h2 id="tocS_DatapointTemplateDesc">DatapointTemplateDesc</h2>
<!-- backwards compatibility -->
<a id="schemadatapointtemplatedesc"></a>
<a id="schema_DatapointTemplateDesc"></a>
<a id="tocSdatapointtemplatedesc"></a>
<a id="tocsdatapointtemplatedesc"></a>

```json
{
  "id": "string",
  "name": "string",
  "direction": "Feedback",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|name|string¦null|false|none|none|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|protocolArguments|object¦null|false|none|none|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_DatapointTemplateDTO">DatapointTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatapointtemplatedto"></a>
<a id="schema_DatapointTemplateDTO"></a>
<a id="tocSdatapointtemplatedto"></a>
<a id="tocsdatapointtemplatedto"></a>

```json
{
  "busUnitId": "string",
  "id": "string",
  "name": "string",
  "description": "string",
  "tags": [
    "string"
  ],
  "direction": "Feedback",
  "typeId": "string",
  "displayUnitId": "string",
  "publicId": "string"
}

```

Definition of datapoint template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|busUnitId|string¦null|false|none|Bus unit id|
|id|string¦null|false|none|Unique identifier of the datapoint template|
|name|string¦null|false|none|Localized name|
|description|string¦null|false|none|Localized description|
|tags|[string]¦null|false|none|List of tags attached to the datapoint template|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|typeId|string¦null|false|none|Data type value unique identifier|
|displayUnitId|string¦null|false|none|Identifier of the display unit|
|publicId|string¦null|false|none|Public Unique identifier for datapoint template (User for Import / Export)|

<h2 id="tocS_DataQuality">DataQuality</h2>
<!-- backwards compatibility -->
<a id="schemadataquality"></a>
<a id="schema_DataQuality"></a>
<a id="tocSdataquality"></a>
<a id="tocsdataquality"></a>

```json
"none"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|none|
|*anonymous*|uncertain|
|*anonymous*|good|
|*anonymous*|bad|
|*anonymous*|mask|
|*anonymous*|notcommissioned|
|*anonymous*|badrequiredformat|
|*anonymous*|badpreparingrawstring|
|*anonymous*|badcatalog|
|*anonymous*|badninotopened|
|*anonymous*|badinternalerror|
|*anonymous*|badopcitemsubscription|
|*anonymous*|badopcgroupsubscription|
|*anonymous*|badopcdisconnected|
|*anonymous*|badcannotberead|
|*anonymous*|badninotfound|
|*anonymous*|badninone|
|*anonymous*|badnierroropen|
|*anonymous*|baddeviceabsent|
|*anonymous*|badConfigurationError|
|*anonymous*|badDeviceFailure|
|*anonymous*|badLastKnownValue|
|*anonymous*|badNotConnected|
|*anonymous*|badOutOfService|
|*anonymous*|badSensorFailure|
|*anonymous*|badWaitingForInitialData|
|*anonymous*|uncertainEUExceeded|
|*anonymous*|uncertainLastUsableValue|
|*anonymous*|uncertainSensorNotAccurate|
|*anonymous*|uncertainSubNormal|
|*anonymous*|badCommFailure|
|*anonymous*|badServerStopped|
|*anonymous*|badInactiveTrend|
|*anonymous*|badDbTransactionTimeout|
|*anonymous*|badDbWrite|
|*anonymous*|badAverage|
|*anonymous*|badunknownproperty|
|*anonymous*|badunknownobject|
|*anonymous*|badsubscriptionfailed|
|*anonymous*|badlicense|
|*anonymous*|badResetTrend|
|*anonymous*|badbitmask|
|*anonymous*|badstationnoaddress|
|*anonymous*|badnoaddress|
|*anonymous*|badmiddlewarecommunication|
|*anonymous*|BadBecauseConversion|

<h2 id="tocS_DataTypeDTO">DataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatatypedto"></a>
<a id="schema_DataTypeDTO"></a>
<a id="tocSdatatypedto"></a>
<a id="tocsdatatypedto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

Data type value definition

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string|true|none|none|
|id|string¦null|false|none|Unique identifier of the data type object<br>Can be one of the well-known identifiers (bool/integer/numeric/string/enumeration/complex)|
|name|string¦null|false|none|Localized name of the data type|
|tag|string¦null|false|none|Tag of type.<br>Standard type always have a tag starting with bos:standardtype<br>Standard type cannot be updated, deleted or created by a client.|
|transport|[TransportType](#schematransporttype)|false|none|none|

<h2 id="tocS_DataTypeRequestDTO">DataTypeRequestDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatatyperequestdto"></a>
<a id="schema_DataTypeRequestDTO"></a>
<a id="tocSdatatyperequestdto"></a>
<a id="tocsdatatyperequestdto"></a>

```json
{}

```

Search pattern of all available datatype

### Properties

*None*

<h2 id="tocS_DataTypeType">DataTypeType</h2>
<!-- backwards compatibility -->
<a id="schemadatatypetype"></a>
<a id="schema_DataTypeType"></a>
<a id="tocSdatatypetype"></a>
<a id="tocsdatatypetype"></a>

```json
"Unknown"

```

Discriminator of DataType

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Discriminator of DataType|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Unknown|
|*anonymous*|Bool|
|*anonymous*|Numeric|
|*anonymous*|Long|
|*anonymous*|Double|
|*anonymous*|Enum|
|*anonymous*|Complex|
|*anonymous*|String|
|*anonymous*|DateTimeOffset|
|*anonymous*|TimeSpan|
|*anonymous*|IPAddress|
|*anonymous*|IPEndPoint|
|*anonymous*|Array|
|*anonymous*|Byte|

<h2 id="tocS_DataVersionDTO">DataVersionDTO</h2>
<!-- backwards compatibility -->
<a id="schemadataversiondto"></a>
<a id="schema_DataVersionDTO"></a>
<a id="tocSdataversiondto"></a>
<a id="tocsdataversiondto"></a>

```json
{
  "version": "string"
}

```

Definition of data version DTO

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|version|string¦null|false|none|Data version|

<h2 id="tocS_DataVersionSubscriptionDTO">DataVersionSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemadataversionsubscriptiondto"></a>
<a id="schema_DataVersionSubscriptionDTO"></a>
<a id="tocSdataversionsubscriptiondto"></a>
<a id="tocsdataversionsubscriptiondto"></a>

```json
{
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_DataVersionSubscriptionResultDTO">DataVersionSubscriptionResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemadataversionsubscriptionresultdto"></a>
<a id="schema_DataVersionSubscriptionResultDTO"></a>
<a id="tocSdataversionsubscriptionresultdto"></a>
<a id="tocsdataversionsubscriptionresultdto"></a>

```json
{
  "id": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier of subscription|

<h2 id="tocS_DateTimeOffsetDataTypeDTO">DateTimeOffsetDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemadatetimeoffsetdatatypedto"></a>
<a id="schema_DateTimeOffsetDataTypeDTO"></a>
<a id="tocSdatetimeoffsetdatatypedto"></a>
<a id="tocsdatetimeoffsetdatatypedto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|

<h2 id="tocS_DayOfWeek">DayOfWeek</h2>
<!-- backwards compatibility -->
<a id="schemadayofweek"></a>
<a id="schema_DayOfWeek"></a>
<a id="tocSdayofweek"></a>
<a id="tocsdayofweek"></a>

```json
"Sunday"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Sunday|
|*anonymous*|Monday|
|*anonymous*|Tuesday|
|*anonymous*|Wednesday|
|*anonymous*|Thursday|
|*anonymous*|Friday|
|*anonymous*|Saturday|

<h2 id="tocS_DebugActionDTO">DebugActionDTO</h2>
<!-- backwards compatibility -->
<a id="schemadebugactiondto"></a>
<a id="schema_DebugActionDTO"></a>
<a id="tocSdebugactiondto"></a>
<a id="tocsdebugactiondto"></a>

```json
{
  "id": "string",
  "name": "string",
  "elements": [
    {
      "id": "string",
      "priority": 0,
      "value": "string",
      "protocolArguments": "string",
      "networkId": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|name|string¦null|false|none|none|
|elements|[[DebugWriteDTO](#schemadebugwritedto)]¦null|false|none|none|

<h2 id="tocS_DebugImportMigrationDTO">DebugImportMigrationDTO</h2>
<!-- backwards compatibility -->
<a id="schemadebugimportmigrationdto"></a>
<a id="schema_DebugImportMigrationDTO"></a>
<a id="tocSdebugimportmigrationdto"></a>
<a id="tocsdebugimportmigrationdto"></a>

```json
{
  "maxNumberOfTrendInstanceFBT": 500,
  "maxNumberOfTrendInstanceZT": 500,
  "maxNumberOfAlarmInstanceFBT": 500,
  "maxNumberOfAlarmInstanceZT": 500,
  "numberOfDPTperFBT": 10,
  "numberOfFBT": 5,
  "numberOfDPTperZT": 10,
  "numberOfZT": 5,
  "numberOfZIPerZT": 20,
  "numberOfFBIperZI": 3,
  "generateTrends": true,
  "generateAlarms": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|maxNumberOfTrendInstanceFBT|integer(int32)|false|none|none|
|maxNumberOfTrendInstanceZT|integer(int32)|false|none|none|
|maxNumberOfAlarmInstanceFBT|integer(int32)|false|none|none|
|maxNumberOfAlarmInstanceZT|integer(int32)|false|none|none|
|numberOfDPTperFBT|integer(int32)|false|none|none|
|numberOfFBT|integer(int32)|false|none|none|
|numberOfDPTperZT|integer(int32)|false|none|none|
|numberOfZT|integer(int32)|false|none|none|
|numberOfZIPerZT|integer(int32)|false|none|none|
|numberOfFBIperZI|integer(int32)|false|none|none|
|generateTrends|boolean|false|none|none|
|generateAlarms|boolean|false|none|none|

<h2 id="tocS_DebugScheduleDTO">DebugScheduleDTO</h2>
<!-- backwards compatibility -->
<a id="schemadebugscheduledto"></a>
<a id="schema_DebugScheduleDTO"></a>
<a id="tocSdebugscheduledto"></a>
<a id="tocsdebugscheduledto"></a>

```json
{
  "id": "string",
  "nextActionDate": "2019-08-24T14:15:22Z",
  "nextEntryToExecute": {
    "dateEntryId": "string",
    "dateEntryInfo": "string",
    "timeEntryId": "string",
    "actionId": "string",
    "actionName": "string",
    "timeStamp": "string"
  },
  "timeZoneInfo": "string",
  "stopped": true,
  "changedDate": "2019-08-24T14:15:22Z",
  "actions": [
    {
      "id": "string",
      "name": "string",
      "elements": [
        {
          "id": "string",
          "priority": 0,
          "value": "string",
          "protocolArguments": "string",
          "networkId": "string"
        }
      ]
    }
  ],
  "writes": [
    {
      "dateEntryId": "string",
      "dateEntryInfo": "string",
      "timeEntryId": "string",
      "actionId": "string",
      "actionName": "string",
      "timeStamp": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|nextActionDate|string(date-time)¦null|false|none|none|
|nextEntryToExecute|[DebugTimeEntryDTO](#schemadebugtimeentrydto)|false|none|none|
|timeZoneInfo|string¦null|false|none|none|
|stopped|boolean|false|none|none|
|changedDate|string(date-time)¦null|false|none|none|
|actions|[[DebugActionDTO](#schemadebugactiondto)]¦null|false|none|none|
|writes|[[DebugTimeEntryDTO](#schemadebugtimeentrydto)]¦null|false|none|none|

<h2 id="tocS_DebugTimeEntryDTO">DebugTimeEntryDTO</h2>
<!-- backwards compatibility -->
<a id="schemadebugtimeentrydto"></a>
<a id="schema_DebugTimeEntryDTO"></a>
<a id="tocSdebugtimeentrydto"></a>
<a id="tocsdebugtimeentrydto"></a>

```json
{
  "dateEntryId": "string",
  "dateEntryInfo": "string",
  "timeEntryId": "string",
  "actionId": "string",
  "actionName": "string",
  "timeStamp": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|dateEntryId|string¦null|false|none|none|
|dateEntryInfo|string¦null|false|none|none|
|timeEntryId|string¦null|false|none|none|
|actionId|string¦null|false|none|none|
|actionName|string¦null|false|none|none|
|timeStamp|string(date-span)|false|none|none|

<h2 id="tocS_DebugWriteDTO">DebugWriteDTO</h2>
<!-- backwards compatibility -->
<a id="schemadebugwritedto"></a>
<a id="schema_DebugWriteDTO"></a>
<a id="tocSdebugwritedto"></a>
<a id="tocsdebugwritedto"></a>

```json
{
  "id": "string",
  "priority": 0,
  "value": "string",
  "protocolArguments": "string",
  "networkId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|priority|integer(int64)|false|none|none|
|value|string¦null|false|none|none|
|protocolArguments|string¦null|false|none|none|
|networkId|string¦null|false|none|none|

<h2 id="tocS_DensityHeatmapEntryDTO">DensityHeatmapEntryDTO</h2>
<!-- backwards compatibility -->
<a id="schemadensityheatmapentrydto"></a>
<a id="schema_DensityHeatmapEntryDTO"></a>
<a id="tocSdensityheatmapentrydto"></a>
<a id="tocsdensityheatmapentrydto"></a>

```json
{
  "day": "2019-08-24T14:15:22Z",
  "averageNumberOfPeoplePerHour": 0
}

```

Represents the occupation density of a room for a specific day.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|day|string(date-time)|false|none|Day represented by this entry.|
|averageNumberOfPeoplePerHour|number(double)|false|none|Average number of people per hour occupying the room.|

<h2 id="tocS_DeviceDTO">DeviceDTO</h2>
<!-- backwards compatibility -->
<a id="schemadevicedto"></a>
<a id="schema_DeviceDTO"></a>
<a id="tocSdevicedto"></a>
<a id="tocsdevicedto"></a>

```json
{
  "functionalBlocks": [
    {
      "datapoints": [
        {
          "stationId": "string",
          "networkId": "string",
          "busUnitId": "string",
          "protocolArguments": {
            "property1": null,
            "property2": null
          },
          "converterId": "string",
          "id": "string",
          "name": "string",
          "direction": "Feedback",
          "typeId": "string",
          "tags": [
            "string"
          ],
          "templateId": "string",
          "functionalBlockId": "string",
          "zoneId": "string",
          "displayUnitId": "string",
          "unitId": "string"
        }
      ],
      "properties": [
        {
          "value": null,
          "userId": "string",
          "roleId": "string",
          "isOverride": true,
          "id": "string",
          "name": "string",
          "direction": "Feedback",
          "typeId": "string",
          "tags": [
            "string"
          ],
          "templateId": "string",
          "functionalBlockId": "string",
          "zoneId": "string",
          "displayUnitId": "string",
          "unitId": "string"
        }
      ],
      "zones": [
        {
          "zoneId": "string",
          "inZone": true
        }
      ],
      "masterMode": "None",
      "id": "string",
      "name": "string",
      "icon": "string",
      "iconFillColor": "string",
      "templateId": "string",
      "specializationType": "string",
      "specializationId": "string",
      "tags": [
        "string"
      ],
      "deviceInstanceId": "string",
      "deviceFunctionalBlockTemplateId": "string",
      "assignationDone": true,
      "isExternal": true
    }
  ],
  "physicalPoints": [
    {
      "name": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "type": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ],
  "deviceTemplateId": "string",
  "protocolArguments": "string",
  "name": "string",
  "id": "string"
}

```

Represents a Device

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlocks|[[FunctionalBlockInstanceDTO](#schemafunctionalblockinstancedto)]¦null|false|none|Functional blocks of the device|
|physicalPoints|[[PhysicalPointDTO](#schemaphysicalpointdto)]¦null|false|none|Physical points of the device|
|deviceTemplateId|string¦null|false|none|Id of the device template|
|protocolArguments|string¦null|false|none|Protocol arguments|
|name|string¦null|false|none|Name of the device|
|id|string¦null|false|none|Id of the device template|

<h2 id="tocS_DeviceIdType">DeviceIdType</h2>
<!-- backwards compatibility -->
<a id="schemadeviceidtype"></a>
<a id="schema_DeviceIdType"></a>
<a id="tocSdeviceidtype"></a>
<a id="tocsdeviceidtype"></a>

```json
{
  "deviceId": "12AF3B",
  "checkDigit": "string"
}

```

Struct for device id + check digit

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|deviceId|string¦null|false|none|Device id as hex number|
|checkDigit|string¦null|false|none|Check digit to check integrity of device id|

<h2 id="tocS_DeviceInfoDTO">DeviceInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemadeviceinfodto"></a>
<a id="schema_DeviceInfoDTO"></a>
<a id="tocSdeviceinfodto"></a>
<a id="tocsdeviceinfodto"></a>

```json
{
  "deviceTemplateId": "string",
  "protocolArguments": "string",
  "name": "string",
  "id": "string"
}

```

Represents a simplified device DTO

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|deviceTemplateId|string¦null|false|none|Id of the device template|
|protocolArguments|string¦null|false|none|Protocol arguments|
|name|string¦null|false|none|Name of the device|
|id|string¦null|false|none|Id of the device template|

<h2 id="tocS_DeviceInstanceDTO">DeviceInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemadeviceinstancedto"></a>
<a id="schema_DeviceInstanceDTO"></a>
<a id="tocSdeviceinstancedto"></a>
<a id="tocsdeviceinstancedto"></a>

```json
{
  "protocolArguments": {
    "property1": null,
    "property2": null
  },
  "properties": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "functionalBlockInstances": [
    "string"
  ],
  "id": "string",
  "name": "string",
  "tags": [
    "string"
  ],
  "networkId": "string",
  "deviceTemplateId": "string",
  "physicalDeviceId": "string"
}

```

Device instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|protocolArguments|object¦null|false|none|Protocol arguments|
|» **additionalProperties**|any|false|none|none|
|properties|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|Properties|
|functionalBlockInstances|[string]¦null|false|none|Id of the functional block instances that belong to this device instance|
|id|string¦null|false|none|Identifier of the device instance|
|name|string¦null|false|none|Name.|
|tags|[string]¦null|false|none|Associated tags.|
|networkId|string¦null|false|none|Id of the network of the device instance|
|deviceTemplateId|string¦null|false|none|Device template id|
|physicalDeviceId|string¦null|false|none|Physical device attached to this device instance.<br>Readonly information|

<h2 id="tocS_DeviceInstanceInfoDTO">DeviceInstanceInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemadeviceinstanceinfodto"></a>
<a id="schema_DeviceInstanceInfoDTO"></a>
<a id="tocSdeviceinstanceinfodto"></a>
<a id="tocsdeviceinstanceinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "tags": [
    "string"
  ],
  "networkId": "string",
  "deviceTemplateId": "string",
  "physicalDeviceId": "string"
}

```

Information about a device instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier of the device instance|
|name|string¦null|false|none|Name.|
|tags|[string]¦null|false|none|Associated tags.|
|networkId|string¦null|false|none|Id of the network of the device instance|
|deviceTemplateId|string¦null|false|none|Device template id|
|physicalDeviceId|string¦null|false|none|Physical device attached to this device instance.<br>Readonly information|

<h2 id="tocS_DeviceTemplateDatapointDTO">DeviceTemplateDatapointDTO</h2>
<!-- backwards compatibility -->
<a id="schemadevicetemplatedatapointdto"></a>
<a id="schema_DeviceTemplateDatapointDTO"></a>
<a id="tocSdevicetemplatedatapointdto"></a>
<a id="tocsdevicetemplatedatapointdto"></a>

```json
{
  "datapointTemplateId": "string",
  "busUnit": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  },
  "converterId": "string"
}

```

Parameters for a datapoint associated with a device template.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointTemplateId|string¦null|false|none|Associated datapoint.|
|busUnit|string¦null|false|none|Identifier of the bus unit.|
|protocolArguments|object¦null|false|none|Protocol argument for the datapoint level.|
|» **additionalProperties**|any|false|none|none|
|converterId|string¦null|false|none|Converter to use for the datapoint|

<h2 id="tocS_DeviceTemplateDTO">DeviceTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemadevicetemplatedto"></a>
<a id="schema_DeviceTemplateDTO"></a>
<a id="tocSdevicetemplatedto"></a>
<a id="tocsdevicetemplatedto"></a>

```json
{
  "protocolArguments": {
    "property1": null,
    "property2": null
  },
  "functionalBlocks": [
    {
      "id": "string",
      "name": "string",
      "functionalBlockTemplateId": "string",
      "datapoints": [
        {
          "datapointTemplateId": "string",
          "busUnit": "string",
          "protocolArguments": {
            "property1": null,
            "property2": null
          },
          "converterId": "string"
        }
      ]
    }
  ],
  "properties": [
    {
      "defaultValue": null,
      "id": "string",
      "name": "string",
      "description": "string",
      "tags": [
        "string"
      ],
      "direction": "Feedback",
      "typeId": "string",
      "displayUnitId": "string",
      "publicId": "string"
    }
  ],
  "id": "string",
  "name": "string",
  "icon": "string",
  "version": "string",
  "tags": [
    "string"
  ],
  "manufacturer": "string",
  "productReference": "string",
  "driverDescriptorId": "string",
  "instancesCount": 0,
  "firmwareVersion": "string"
}

```

Information about a device template.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|protocolArguments|object¦null|false|none|Protocol arguments for the device level.|
|» **additionalProperties**|any|false|none|none|
|functionalBlocks|[[DeviceTemplateFunctionalBlockDTO](#schemadevicetemplatefunctionalblockdto)]¦null|false|none|Functional blocks in device.|
|properties|[[PropertyDatapointTemplateDTO](#schemapropertydatapointtemplatedto)]¦null|false|none|List of properties templates attached to the device.|
|id|string¦null|false|none|Identifier of the device template.|
|name|string¦null|false|none|Name.|
|icon|string¦null|false|none|Icon.|
|version|string¦null|false|none|Version.|
|tags|[string]¦null|false|none|Associated tags.|
|manufacturer|string¦null|false|none|Manufacturer.|
|productReference|string¦null|false|none|Product reference.|
|driverDescriptorId|string¦null|false|none|Identifier of the driver.|
|instancesCount|integer(int64)|false|none|Number of device instances using this template.<br>Information only. Readonly.|
|firmwareVersion|string¦null|false|none|Firmware version|

<h2 id="tocS_DeviceTemplateFunctionalBlockDTO">DeviceTemplateFunctionalBlockDTO</h2>
<!-- backwards compatibility -->
<a id="schemadevicetemplatefunctionalblockdto"></a>
<a id="schema_DeviceTemplateFunctionalBlockDTO"></a>
<a id="tocSdevicetemplatefunctionalblockdto"></a>
<a id="tocsdevicetemplatefunctionalblockdto"></a>

```json
{
  "id": "string",
  "name": "string",
  "functionalBlockTemplateId": "string",
  "datapoints": [
    {
      "datapointTemplateId": "string",
      "busUnit": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "converterId": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier.|
|name|string¦null|false|none|Name.|
|functionalBlockTemplateId|string¦null|false|none|Id of the associated functional block template.|
|datapoints|[[DeviceTemplateDatapointDTO](#schemadevicetemplatedatapointdto)]¦null|false|none|Parameters for the datapoints included in the functional block.|

<h2 id="tocS_DeviceTemplateImportResultDTO">DeviceTemplateImportResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemadevicetemplateimportresultdto"></a>
<a id="schema_DeviceTemplateImportResultDTO"></a>
<a id="tocSdevicetemplateimportresultdto"></a>
<a id="tocsdevicetemplateimportresultdto"></a>

```json
{
  "id": "string",
  "name": "string",
  "added": true,
  "uptodate": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|name|string¦null|false|none|none|
|added|boolean|false|none|none|
|uptodate|boolean|false|none|none|

<h2 id="tocS_DeviceTemplateInfoDTO">DeviceTemplateInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemadevicetemplateinfodto"></a>
<a id="schema_DeviceTemplateInfoDTO"></a>
<a id="tocSdevicetemplateinfodto"></a>
<a id="tocsdevicetemplateinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "icon": "string",
  "version": "string",
  "tags": [
    "string"
  ],
  "manufacturer": "string",
  "productReference": "string",
  "driverDescriptorId": "string",
  "instancesCount": 0,
  "firmwareVersion": "string"
}

```

Information about a device template.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier of the device template.|
|name|string¦null|false|none|Name.|
|icon|string¦null|false|none|Icon.|
|version|string¦null|false|none|Version.|
|tags|[string]¦null|false|none|Associated tags.|
|manufacturer|string¦null|false|none|Manufacturer.|
|productReference|string¦null|false|none|Product reference.|
|driverDescriptorId|string¦null|false|none|Identifier of the driver.|
|instancesCount|integer(int64)|false|none|Number of device instances using this template.<br>Information only. Readonly.|
|firmwareVersion|string¦null|false|none|Firmware version|

<h2 id="tocS_DiagnosticsDTO">DiagnosticsDTO</h2>
<!-- backwards compatibility -->
<a id="schemadiagnosticsdto"></a>
<a id="schema_DiagnosticsDTO"></a>
<a id="tocSdiagnosticsdto"></a>
<a id="tocsdiagnosticsdto"></a>

```json
{
  "status": "string"
}

```

System diagnostics

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|status|string¦null|false|none|Services status field|

<h2 id="tocS_DisplayType">DisplayType</h2>
<!-- backwards compatibility -->
<a id="schemadisplaytype"></a>
<a id="schema_DisplayType"></a>
<a id="tocSdisplaytype"></a>
<a id="tocsdisplaytype"></a>

```json
"Curve"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Curve|
|*anonymous*|DigitalStep|
|*anonymous*|Point|
|*anonymous*|Line|
|*anonymous*|Bar|

<h2 id="tocS_DistributionDTO">DistributionDTO</h2>
<!-- backwards compatibility -->
<a id="schemadistributiondto"></a>
<a id="schema_DistributionDTO"></a>
<a id="tocSdistributiondto"></a>
<a id="tocsdistributiondto"></a>

```json
{
  "inputCircuits": [
    {
      "type": "string",
      "meter": {
        "id": "string",
        "name": "string",
        "icon": "string",
        "energyId": "string",
        "meterParentId": "string",
        "circuitId": "string",
        "deviceInstanceId": "string",
        "deviceInstanceName": "string",
        "zoneId": "string",
        "zoneName": "string",
        "zoneIcon": "string",
        "assignationDone": true,
        "functionalBlockInstanceId": "string",
        "functionalBlockName": "string",
        "tags": [
          "string"
        ]
      },
      "id": "string",
      "name": "string",
      "index": 0,
      "section": "string"
    }
  ],
  "outputCircuits": [
    {
      "type": "string",
      "lines": [
        {
          "inputDistribution": {
            "inputCircuits": [
              {
                "type": "string",
                "meter": {
                  "id": "string",
                  "name": "string",
                  "icon": "string",
                  "energyId": "string",
                  "meterParentId": "string",
                  "circuitId": "string",
                  "deviceInstanceId": "string",
                  "deviceInstanceName": "string",
                  "zoneId": "string",
                  "zoneName": "string",
                  "zoneIcon": "string",
                  "assignationDone": true,
                  "functionalBlockInstanceId": "string",
                  "functionalBlockName": "string",
                  "tags": [
                    "string"
                  ]
                },
                "id": "string",
                "name": "string",
                "index": 0,
                "section": "string"
              }
            ],
            "outputCircuits": [],
            "id": "string",
            "name": "string",
            "energyId": "string",
            "tags": [
              "string"
            ],
            "zoneId": "string",
            "zoneName": "string",
            "zoneIcon": "string"
          },
          "id": "string",
          "name": "string",
          "inputCircuitId": "string",
          "outputCircuitId": "string"
        }
      ],
      "meter": {
        "id": "string",
        "name": "string",
        "icon": "string",
        "energyId": "string",
        "meterParentId": "string",
        "circuitId": "string",
        "deviceInstanceId": "string",
        "deviceInstanceName": "string",
        "zoneId": "string",
        "zoneName": "string",
        "zoneIcon": "string",
        "assignationDone": true,
        "functionalBlockInstanceId": "string",
        "functionalBlockName": "string",
        "tags": [
          "string"
        ]
      },
      "id": "string",
      "name": "string",
      "index": 0,
      "section": "string"
    }
  ],
  "id": "string",
  "name": "string",
  "energyId": "string",
  "tags": [
    "string"
  ],
  "zoneId": "string",
  "zoneName": "string",
  "zoneIcon": "string"
}

```

Information about a distribution element

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|inputCircuits|[[CircuitInputDTO](#schemacircuitinputdto)]¦null|false|none|Inputs circuits of the distribution element|
|outputCircuits|[[CircuitOutputDTO](#schemacircuitoutputdto)]¦null|false|none|Output circuits of the distribution element|
|id|string¦null|false|none|Unique identifier of the distribution element|
|name|string¦null|false|none|Name of the distribution element|
|energyId|string¦null|false|none|Unique identifier of the energy of the distribution element|
|tags|[string]¦null|false|none|Tags of the distribution element|
|zoneId|string¦null|false|none|Unique identifier of the zone the distribution element is linked to. Null if none|
|zoneName|string¦null|false|none|Name of the zone the distribution element is linked to. Null if none|
|zoneIcon|string¦null|false|none|none|

<h2 id="tocS_DistributionLineDTO">DistributionLineDTO</h2>
<!-- backwards compatibility -->
<a id="schemadistributionlinedto"></a>
<a id="schema_DistributionLineDTO"></a>
<a id="tocSdistributionlinedto"></a>
<a id="tocsdistributionlinedto"></a>

```json
{
  "inputDistribution": {
    "inputCircuits": [
      {
        "type": "string",
        "meter": {
          "id": "string",
          "name": "string",
          "icon": "string",
          "energyId": "string",
          "meterParentId": "string",
          "circuitId": "string",
          "deviceInstanceId": "string",
          "deviceInstanceName": "string",
          "zoneId": "string",
          "zoneName": "string",
          "zoneIcon": "string",
          "assignationDone": true,
          "functionalBlockInstanceId": "string",
          "functionalBlockName": "string",
          "tags": [
            "string"
          ]
        },
        "id": "string",
        "name": "string",
        "index": 0,
        "section": "string"
      }
    ],
    "outputCircuits": [
      {
        "type": "string",
        "lines": [
          {
            "inputDistribution": {},
            "id": "string",
            "name": "string",
            "inputCircuitId": "string",
            "outputCircuitId": "string"
          }
        ],
        "meter": {
          "id": "string",
          "name": "string",
          "icon": "string",
          "energyId": "string",
          "meterParentId": "string",
          "circuitId": "string",
          "deviceInstanceId": "string",
          "deviceInstanceName": "string",
          "zoneId": "string",
          "zoneName": "string",
          "zoneIcon": "string",
          "assignationDone": true,
          "functionalBlockInstanceId": "string",
          "functionalBlockName": "string",
          "tags": [
            "string"
          ]
        },
        "id": "string",
        "name": "string",
        "index": 0,
        "section": "string"
      }
    ],
    "id": "string",
    "name": "string",
    "energyId": "string",
    "tags": [
      "string"
    ],
    "zoneId": "string",
    "zoneName": "string",
    "zoneIcon": "string"
  },
  "id": "string",
  "name": "string",
  "inputCircuitId": "string",
  "outputCircuitId": "string"
}

```

Information about a connection line between an input circuit and an output circuit of 2 distribution elements

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|inputDistribution|[DistributionDTO](#schemadistributiondto)|false|none|Information about a distribution element|
|id|string¦null|false|none|Unique identifier of the connection line|
|name|string¦null|false|none|Name of the connection line|
|inputCircuitId|string¦null|false|none|Unique identifier of the input circuit the connection line is linked to|
|outputCircuitId|string¦null|false|none|Unique identifier of the output circuit the connection line is linked to|

<h2 id="tocS_DistributionLineInfoDTO">DistributionLineInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemadistributionlineinfodto"></a>
<a id="schema_DistributionLineInfoDTO"></a>
<a id="tocSdistributionlineinfodto"></a>
<a id="tocsdistributionlineinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "inputCircuitId": "string",
  "outputCircuitId": "string"
}

```

Minimal information about a connection line between an input circuit and an output circuit of 2 distribution elements

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the connection line|
|name|string¦null|false|none|Name of the connection line|
|inputCircuitId|string¦null|false|none|Unique identifier of the input circuit the connection line is linked to|
|outputCircuitId|string¦null|false|none|Unique identifier of the output circuit the connection line is linked to|

<h2 id="tocS_DistributionLineSetDTO">DistributionLineSetDTO</h2>
<!-- backwards compatibility -->
<a id="schemadistributionlinesetdto"></a>
<a id="schema_DistributionLineSetDTO"></a>
<a id="tocSdistributionlinesetdto"></a>
<a id="tocsdistributionlinesetdto"></a>

```json
{
  "name": "string",
  "inputCircuitId": "string",
  "inputDistributionId": "string",
  "inputCircuitIndex": 0,
  "outputCircuitId": "string"
}

```

Information about a connection line to create when creating a distribution element

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the connection line|
|inputCircuitId|string¦null|false|none|Unique identifier of the input circuit the connection line is linked to. Null if the input circuit is defined with InputDistributionId and InputCircuitIndex|
|inputDistributionId|string¦null|false|none|Unique identifier of the distribution element the input circuit the connection line is linked to belongs to. Null if the input circuit is defined with InputCircuitId|
|inputCircuitIndex|integer(int64)|false|none|Index of the input circuit the connection line is linked to. Null if the input circuit is defined with InputCircuitId|
|outputCircuitId|string¦null|false|none|Unique identifier of the output circuit the connection line is linked to|

<h2 id="tocS_DistributionSetDTO">DistributionSetDTO</h2>
<!-- backwards compatibility -->
<a id="schemadistributionsetdto"></a>
<a id="schema_DistributionSetDTO"></a>
<a id="tocSdistributionsetdto"></a>
<a id="tocsdistributionsetdto"></a>

```json
{
  "inputCircuits": [
    {
      "type": "string",
      "meter": {
        "id": "string",
        "name": "string",
        "icon": "string",
        "energyId": "string",
        "meterParentId": "string",
        "circuitId": "string",
        "deviceInstanceId": "string",
        "deviceInstanceName": "string",
        "zoneId": "string",
        "zoneName": "string",
        "zoneIcon": "string",
        "assignationDone": true,
        "functionalBlockInstanceId": "string",
        "functionalBlockName": "string",
        "tags": [
          "string"
        ]
      },
      "id": "string",
      "name": "string",
      "index": 0,
      "section": "string"
    }
  ],
  "outputCircuits": [
    {
      "type": "string",
      "lines": [
        {
          "inputDistribution": {
            "inputCircuits": [
              {
                "type": "string",
                "meter": {
                  "id": "string",
                  "name": "string",
                  "icon": "string",
                  "energyId": "string",
                  "meterParentId": "string",
                  "circuitId": "string",
                  "deviceInstanceId": "string",
                  "deviceInstanceName": "string",
                  "zoneId": "string",
                  "zoneName": "string",
                  "zoneIcon": "string",
                  "assignationDone": true,
                  "functionalBlockInstanceId": "string",
                  "functionalBlockName": "string",
                  "tags": [
                    "string"
                  ]
                },
                "id": "string",
                "name": "string",
                "index": 0,
                "section": "string"
              }
            ],
            "outputCircuits": [
              {
                "type": "string",
                "lines": [],
                "meter": {
                  "id": "string",
                  "name": "string",
                  "icon": "string",
                  "energyId": "string",
                  "meterParentId": "string",
                  "circuitId": "string",
                  "deviceInstanceId": "string",
                  "deviceInstanceName": "string",
                  "zoneId": "string",
                  "zoneName": "string",
                  "zoneIcon": "string",
                  "assignationDone": true,
                  "functionalBlockInstanceId": "string",
                  "functionalBlockName": "string",
                  "tags": [
                    "string"
                  ]
                },
                "id": "string",
                "name": "string",
                "index": 0,
                "section": "string"
              }
            ],
            "id": "string",
            "name": "string",
            "energyId": "string",
            "tags": [
              "string"
            ],
            "zoneId": "string",
            "zoneName": "string",
            "zoneIcon": "string"
          },
          "id": "string",
          "name": "string",
          "inputCircuitId": "string",
          "outputCircuitId": "string"
        }
      ],
      "meter": {
        "id": "string",
        "name": "string",
        "icon": "string",
        "energyId": "string",
        "meterParentId": "string",
        "circuitId": "string",
        "deviceInstanceId": "string",
        "deviceInstanceName": "string",
        "zoneId": "string",
        "zoneName": "string",
        "zoneIcon": "string",
        "assignationDone": true,
        "functionalBlockInstanceId": "string",
        "functionalBlockName": "string",
        "tags": [
          "string"
        ]
      },
      "id": "string",
      "name": "string",
      "index": 0,
      "section": "string"
    }
  ],
  "id": "string",
  "name": "string",
  "energyId": "string",
  "tags": [
    "string"
  ],
  "zoneId": "string",
  "zoneName": "string",
  "zoneIcon": "string"
}

```

Information about a distribution element to create

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|inputCircuits|[[CircuitInputDTO](#schemacircuitinputdto)]¦null|false|none|Inputs circuits of the distribution element|
|outputCircuits|[[CircuitOutputDTO](#schemacircuitoutputdto)]¦null|false|none|Output circuits of the distribution element|
|id|string¦null|false|none|Unique identifier of the distribution element|
|name|string¦null|false|none|Name of the distribution element|
|energyId|string¦null|false|none|Unique identifier of the energy of the distribution element|
|tags|[string]¦null|false|none|Tags of the distribution element|
|zoneId|string¦null|false|none|Unique identifier of the zone the distribution element is linked to. Null if none|
|zoneName|string¦null|false|none|Name of the zone the distribution element is linked to. Null if none|
|zoneIcon|string¦null|false|none|none|

<h2 id="tocS_DoubleDataTypeDTO">DoubleDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemadoubledatatypedto"></a>
<a id="schema_DoubleDataTypeDTO"></a>
<a id="tocSdoubledatatypedto"></a>
<a id="tocsdoubledatatypedto"></a>

```json
{
  "type": "string",
  "unitId": "string",
  "min": 0,
  "max": 0,
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

Double data type value definition.  (type:"double")

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|
|unitId|string¦null|false|none|Unit id|
|min|number(double)¦null|false|none|Min|
|max|number(double)¦null|false|none|Max|

<h2 id="tocS_DoubleToBoolDTO">DoubleToBoolDTO</h2>
<!-- backwards compatibility -->
<a id="schemadoubletobooldto"></a>
<a id="schema_DoubleToBoolDTO"></a>
<a id="tocSdoubletobooldto"></a>
<a id="tocsdoubletobooldto"></a>

```json
{
  "min": 0,
  "max": 0,
  "minIncluded": true,
  "maxIncluded": true,
  "value": true
}

```

How to map a double to bool

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|min|number(double)¦null|false|none|Min value. No value means infinite|
|max|number(double)¦null|false|none|Max value. No value means infinite|
|minIncluded|boolean|false|none|Min is included or not|
|maxIncluded|boolean|false|none|Max is included or not|
|value|boolean|false|none|Corresponding value|

<h2 id="tocS_DoubleToEnumDTO">DoubleToEnumDTO</h2>
<!-- backwards compatibility -->
<a id="schemadoubletoenumdto"></a>
<a id="schema_DoubleToEnumDTO"></a>
<a id="tocSdoubletoenumdto"></a>
<a id="tocsdoubletoenumdto"></a>

```json
{
  "min": 0,
  "max": 0,
  "minIncluded": true,
  "maxIncluded": true,
  "value": 0
}

```

How to map a double to an enum

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|min|number(double)¦null|false|none|Min value. No value means infinite|
|max|number(double)¦null|false|none|Max value. No value means infinite|
|minIncluded|boolean|false|none|Min is included or not|
|maxIncluded|boolean|false|none|Max is included or not|
|value|integer(int64)|false|none|Corresponding value|

<h2 id="tocS_DownSamplingFunction">DownSamplingFunction</h2>
<!-- backwards compatibility -->
<a id="schemadownsamplingfunction"></a>
<a id="schema_DownSamplingFunction"></a>
<a id="tocSdownsamplingfunction"></a>
<a id="tocsdownsamplingfunction"></a>

```json
"TimeWeightedAverage"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|TimeWeightedAverage|
|*anonymous*|Mean|
|*anonymous*|Median|
|*anonymous*|Minimum|
|*anonymous*|Maximum|
|*anonymous*|Spread|
|*anonymous*|StandardDeviation|
|*anonymous*|Sum|
|*anonymous*|Top|
|*anonymous*|Bottom|
|*anonymous*|Occupancy|
|*anonymous*|Density|

<h2 id="tocS_DownSamplingOptionDTO">DownSamplingOptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemadownsamplingoptiondto"></a>
<a id="schema_DownSamplingOptionDTO"></a>
<a id="tocSdownsamplingoptiondto"></a>
<a id="tocsdownsamplingoptiondto"></a>

```json
{
  "id": "string",
  "name": "string",
  "alignTime": "string",
  "groupedBy": "string",
  "functions": "TimeWeightedAverage",
  "duration": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the downsampling option|
|name|string¦null|false|none|Localized name of the downsampling option|
|alignTime|string(date-span)|false|none|Time period where trend values set used for downsampling operation is starting|
|groupedBy|string(date-span)|false|none|Time period of trend values used for each operation|
|functions|[DownSamplingFunction](#schemadownsamplingfunction)|false|none|none|
|duration|string(date-span)|false|none|Length of time trends are stored|

<h2 id="tocS_DriverDescriptorCreationDTO">DriverDescriptorCreationDTO</h2>
<!-- backwards compatibility -->
<a id="schemadriverdescriptorcreationdto"></a>
<a id="schema_DriverDescriptorCreationDTO"></a>
<a id="tocSdriverdescriptorcreationdto"></a>
<a id="tocsdriverdescriptorcreationdto"></a>

```json
{
  "jsonContent": "string"
}

```

Information about a driver for creation

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|jsonContent|string¦null|false|none|Content in JSON format|

<h2 id="tocS_DriverDescriptorDTO">DriverDescriptorDTO</h2>
<!-- backwards compatibility -->
<a id="schemadriverdescriptordto"></a>
<a id="schema_DriverDescriptorDTO"></a>
<a id="tocSdriverdescriptordto"></a>
<a id="tocsdriverdescriptordto"></a>

```json
{
  "properties": [
    {
      "id": "string",
      "identifier": "string",
      "isPublic": true,
      "isReadOnly": true,
      "isStatic": true,
      "name": "string",
      "defaultValue": null,
      "typeId": "string"
    }
  ],
  "methods": [
    {
      "id": "string",
      "identifier": "string",
      "asynchronous": true,
      "name": "string",
      "parameters": [
        {
          "id": "string",
          "identifier": "string",
          "isPublic": true,
          "isReadOnly": true,
          "isStatic": true,
          "name": "string",
          "defaultValue": null,
          "typeId": "string"
        }
      ],
      "result": [
        {
          "id": "string",
          "identifier": "string",
          "isPublic": true,
          "isReadOnly": true,
          "isStatic": true,
          "name": "string",
          "defaultValue": null,
          "typeId": "string"
        }
      ]
    }
  ],
  "protocolArguments": [
    {
      "key": "string",
      "levels": "None",
      "mandatories": "None",
      "identity": "None",
      "type": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      },
      "description": "string",
      "defaultValue": null,
      "displayOrder": 0
    }
  ],
  "id": "string",
  "identifier": "string",
  "groupByPort": "string",
  "company": "string",
  "multiInstance": true,
  "multiInstanceOnIP": true,
  "name": "string",
  "version": "string",
  "portType": "None",
  "transport": "none",
  "driverType": "Dll"
}

```

Detailed information about a driver available on a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|properties|[[DriverPropertyDefinitionDTO](#schemadriverpropertydefinitiondto)]¦null|false|none|Properties of the driver|
|methods|[[DriverMethodDefinitionDTO](#schemadrivermethoddefinitiondto)]¦null|false|none|Methods of the driver|
|protocolArguments|[[ProtocolArgumentDTO](#schemaprotocolargumentdto)]¦null|false|none|List of protocol arguments of the driver|
|id|string¦null|false|none|Unique database identifier of the driver|
|identifier|string¦null|false|none|Unique identifier of the driver|
|groupByPort|string¦null|false|none|If not null, all the networks based on driver descriptors with the same GroupByPort value<br>must be created on the same port.|
|company|string¦null|false|none|Name of the company responsible for the driver development|
|multiInstance|boolean|false|none|Indicates if the driver can be instantiate several times on a station|
|multiInstanceOnIP|boolean|false|none|Indicates if the driver can be instantiate several times on the same IP port on a station|
|name|string¦null|false|none|Name|
|version|string¦null|false|none|Version|
|portType|[PortType](#schemaporttype)|false|none|none|
|transport|[TransportType](#schematransporttype)|false|none|none|
|driverType|[DriverType](#schemadrivertype)|false|none|none|

<h2 id="tocS_DriverDescriptorInfoDTO">DriverDescriptorInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemadriverdescriptorinfodto"></a>
<a id="schema_DriverDescriptorInfoDTO"></a>
<a id="tocSdriverdescriptorinfodto"></a>
<a id="tocsdriverdescriptorinfodto"></a>

```json
{
  "id": "string",
  "identifier": "string",
  "groupByPort": "string",
  "company": "string",
  "multiInstance": true,
  "multiInstanceOnIP": true,
  "name": "string",
  "version": "string",
  "portType": "None",
  "transport": "none",
  "driverType": "Dll"
}

```

Information about a driver available on a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the driver|
|identifier|string¦null|false|none|Unique identifier of the driver|
|groupByPort|string¦null|false|none|If not null, all the networks based on driver descriptors with the same GroupByPort value<br>must be created on the same port.|
|company|string¦null|false|none|Name of the company responsible for the driver development|
|multiInstance|boolean|false|none|Indicates if the driver can be instantiate several times on a station|
|multiInstanceOnIP|boolean|false|none|Indicates if the driver can be instantiate several times on the same IP port on a station|
|name|string¦null|false|none|Name|
|version|string¦null|false|none|Version|
|portType|[PortType](#schemaporttype)|false|none|none|
|transport|[TransportType](#schematransporttype)|false|none|none|
|driverType|[DriverType](#schemadrivertype)|false|none|none|

<h2 id="tocS_DriverDescriptorUpdateDTO">DriverDescriptorUpdateDTO</h2>
<!-- backwards compatibility -->
<a id="schemadriverdescriptorupdatedto"></a>
<a id="schema_DriverDescriptorUpdateDTO"></a>
<a id="tocSdriverdescriptorupdatedto"></a>
<a id="tocsdriverdescriptorupdatedto"></a>

```json
{
  "id": "string",
  "jsonContent": "string"
}

```

Information about a driver for update

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the driver descriptor|
|jsonContent|string¦null|false|none|Content in JSON format|

<h2 id="tocS_DriverMethodDefinitionDTO">DriverMethodDefinitionDTO</h2>
<!-- backwards compatibility -->
<a id="schemadrivermethoddefinitiondto"></a>
<a id="schema_DriverMethodDefinitionDTO"></a>
<a id="tocSdrivermethoddefinitiondto"></a>
<a id="tocsdrivermethoddefinitiondto"></a>

```json
{
  "id": "string",
  "identifier": "string",
  "asynchronous": true,
  "name": "string",
  "parameters": [
    {
      "id": "string",
      "identifier": "string",
      "isPublic": true,
      "isReadOnly": true,
      "isStatic": true,
      "name": "string",
      "defaultValue": null,
      "typeId": "string"
    }
  ],
  "result": [
    {
      "id": "string",
      "identifier": "string",
      "isPublic": true,
      "isReadOnly": true,
      "isStatic": true,
      "name": "string",
      "defaultValue": null,
      "typeId": "string"
    }
  ]
}

```

Information about a method of a driver of a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the method|
|identifier|string¦null|false|none|Unique identifier of the method|
|asynchronous|boolean|false|none|Indicated if method call is a asynchronous or synchronous|
|name|string¦null|false|none|Name|
|parameters|[[DriverPropertyDefinitionDTO](#schemadriverpropertydefinitiondto)]¦null|false|none|Parameters for method call|
|result|[[DriverPropertyDefinitionDTO](#schemadriverpropertydefinitiondto)]¦null|false|none|Result of method call|

<h2 id="tocS_DriverPropertyDefinitionDTO">DriverPropertyDefinitionDTO</h2>
<!-- backwards compatibility -->
<a id="schemadriverpropertydefinitiondto"></a>
<a id="schema_DriverPropertyDefinitionDTO"></a>
<a id="tocSdriverpropertydefinitiondto"></a>
<a id="tocsdriverpropertydefinitiondto"></a>

```json
{
  "id": "string",
  "identifier": "string",
  "isPublic": true,
  "isReadOnly": true,
  "isStatic": true,
  "name": "string",
  "defaultValue": null,
  "typeId": "string"
}

```

Information about a property of a driver of a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the property|
|identifier|string¦null|false|none|Unique identifier of the property|
|isPublic|boolean|false|none|Indicates if the property is public or private.<br>If it is public, the read value for the property will always be null.|
|isReadOnly|boolean|false|none|Indicates if the property is read only.|
|isStatic|boolean|false|none|Indicates if the property is static.<br>If it is static, all the driver property values linked to it will always have the same value.|
|name|string¦null|false|none|Name|
|defaultValue|any|false|none|Default value|
|typeId|string¦null|false|none|Unique identifier of the data type of the property|

<h2 id="tocS_DriverPropertyValueDTO">DriverPropertyValueDTO</h2>
<!-- backwards compatibility -->
<a id="schemadriverpropertyvaluedto"></a>
<a id="schema_DriverPropertyValueDTO"></a>
<a id="tocSdriverpropertyvaluedto"></a>
<a id="tocsdriverpropertyvaluedto"></a>

```json
{
  "id": "string",
  "value": null,
  "identifier": "string"
}

```

Information about a value of a property of a driver of a station, a parameter of a XDriver method call or the result of a method execution.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the property value|
|value|any|false|none|Value|
|identifier|string¦null|false|none|Identifier member value of DriverPropertyDefinitionDTO of the property|

<h2 id="tocS_DriverType">DriverType</h2>
<!-- backwards compatibility -->
<a id="schemadrivertype"></a>
<a id="schema_DriverType"></a>
<a id="tocSdrivertype"></a>
<a id="tocsdrivertype"></a>

```json
"Dll"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Dll|

<h2 id="tocS_DummyDatabaseGeneratorAlarmDTO">DummyDatabaseGeneratorAlarmDTO</h2>
<!-- backwards compatibility -->
<a id="schemadummydatabasegeneratoralarmdto"></a>
<a id="schema_DummyDatabaseGeneratorAlarmDTO"></a>
<a id="tocSdummydatabasegeneratoralarmdto"></a>
<a id="tocsdummydatabasegeneratoralarmdto"></a>

```json
{
  "alarmsOnRooms": false,
  "alarmsOnFbs": false,
  "maxAlarmsCount": 0,
  "highAlarmThreshold": 50,
  "highAlarmMustBeAcked": false,
  "highAlarmDeadband": 0,
  "highAlarmHyst": 0,
  "highAlarmFrequency": 1000
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|alarmsOnRooms|boolean|false|none|Create alarms on rooms|
|alarmsOnFbs|boolean|false|none|Create alarms on fbs|
|maxAlarmsCount|integer(int64)¦null|false|none|Maximum number of datapoins in alarms. If not present all datapoints will have an alarms|
|highAlarmThreshold|number(double)¦null|false|none|High alarm threshold. If not present threshold will be 50.|
|highAlarmMustBeAcked|boolean|false|none|Alarm must be acked or not|
|highAlarmDeadband|number(double)|false|none|High alarm deadband.|
|highAlarmHyst|number(double)|false|none|High alarm hysteresis.|
|highAlarmFrequency|integer(int64)¦null|false|none|High alarm frequency.<br>If not present default value is 1000 ms|

<h2 id="tocS_DummyDatabaseGeneratorDTO">DummyDatabaseGeneratorDTO</h2>
<!-- backwards compatibility -->
<a id="schemadummydatabasegeneratordto"></a>
<a id="schema_DummyDatabaseGeneratorDTO"></a>
<a id="tocSdummydatabasegeneratordto"></a>
<a id="tocsdummydatabasegeneratordto"></a>

```json
{
  "numberOfFunctionalBlockTemplates": 0,
  "numberOfPropertiesPerFBT": 0,
  "numberOfDatapointsPerFB": 0,
  "numberOfFunctionalBlockInstancesPerTemplate": 0,
  "numberOfTypesOfRoom": 0,
  "numberOfPropertiesPerRoom": 0,
  "numberOfDatapointsPerRoom": 0,
  "numberOfRoomsPerTypeAndPerFloor": 0,
  "numberOfFunctionalBlockInstancePerRoom": 0,
  "useMemoryDPOnRooms": true,
  "useMemoryDPOnFbs": true,
  "memoryDPFormat": "/scene=ana:20000:0:100",
  "alarms": {
    "alarmsOnRooms": false,
    "alarmsOnFbs": false,
    "maxAlarmsCount": 0,
    "highAlarmThreshold": 50,
    "highAlarmMustBeAcked": false,
    "highAlarmDeadband": 0,
    "highAlarmHyst": 0,
    "highAlarmFrequency": 1000
  },
  "synchronousGeneration": false,
  "numberOfBuildings": 0,
  "numberOfFloorsPerBuilding": 0,
  "generateMapviewForEachFloor": false,
  "mapviewFunctionalBlockWidthAndHeight": 0,
  "mapviewFunctionalBlockSpace": 0,
  "mapviewZoneWidthAndHeight": 0,
  "mapviewZoneSpace": 0,
  "createUserAccessingAll": false,
  "createUserAccessingFloor": false,
  "createUserAccessingRoom": false
}

```

Settings to generate the dummy project

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|numberOfFunctionalBlockTemplates|integer(int64)|false|none|Number of functional block templates to create<br /> <br>Name of each functional block template will be FBT#x with x from 1 to n<br /> <br>Each functional block template has a tag bos:function:fb#x with x from 1 to n|
|numberOfPropertiesPerFBT|integer(int64)|false|none|Number of properties in each functional block template<br /> <br>Name of each property will be Property#x with x from 1 to n<br /> <br>Each property has a tag bos:function:property#x with x from 1 to n|
|numberOfDatapointsPerFB|integer(int64)|false|none|Number of datapoints in each functional block template<br /> <br>Name of each datapoint will be Datapoint#x with x from 1 to n<br /> <br>Each datapoint has a tag bos:function:datapoint#x with x from 1 to n|
|numberOfFunctionalBlockInstancesPerTemplate|integer(int64)|false|none|Number of functional block instance for each functional block template<br /> <br>Name of each functional block instance will be FBT#x_FBI#y with FBT#x being name of template and y from 1 to n<br /> <br>Each functional block instance has a tag bos:function:fb#x with x from 1 to n|
|numberOfTypesOfRoom|integer(int64)|false|none|Number of type of room (zone template)<br /> <br>Each room zone template will be named TRoom#x with x from 1 to n<br /> <br>Each room template will have the tag bos:space:room:office<br>Each room template will have the tag myroom#x with x based on the number of its template|
|numberOfPropertiesPerRoom|integer(int64)|false|none|Number of properties in each room zone template (note that building and floor has NO properties)<br /> <br>Name of each property will be Property#x with x from 1 to n<br /> <br>Each property has a tag bos:function:property#x with x from 1 to n|
|numberOfDatapointsPerRoom|integer(int64)|false|none|Number of datapoints in each room zone template (note that building and floor has NO datapoints)<br /> <br>Name of each datapoint will be Datapoint#x with x from 1 to n<br /> <br>Each datapoint has a tag bos:function:datapoint#x with x from 1 to n|
|numberOfRoomsPerTypeAndPerFloor|integer(int64)|false|none|Number of room (zone instance) per floor and per room type<br /> <br>Each room zone instance will be named TRoom#x_Room#y with TRoom#x name of template and x from 1 to n<br /> <br>Each room zone instance will have the tag bos:space:room:office|
|numberOfFunctionalBlockInstancePerRoom|integer(int64)|false|none|Number of functional block instance that are put inside each room<br>If there is not enough functional block instance (compare to number of rooms) then some functional block instance will belong to several room|
|useMemoryDPOnRooms|boolean|false|none|If true datapoints of room will have a random memory datapoint address with a scene that cause the datapoint to change continously|
|useMemoryDPOnFbs|boolean|false|none|If true datapoints of functional blocks will have a random memory datapoint address|
|memoryDPFormat|string¦null|false|none|Format of the memory datapoint scene. <br /> If empty the scene will be : /scene=ana:x:y:z to  build a DP with continuous changing value<br /> <br>Format is : /scene=ana:{periodMs}:{minValue}:{maxValue}|
|alarms|[DummyDatabaseGeneratorAlarmDTO](#schemadummydatabasegeneratoralarmdto)|false|none|none|
|synchronousGeneration|boolean|false|none|If true generation of database will be synchronous (rest call will be blocked during execution)|
|numberOfBuildings|integer(int64)|false|none|Number of buildings (zone instance)<br /> <br>Zone template of all buildings will be named TBuilding<br /> <br>Zone template of the building has a tag bos:building<br /> <br>Each building zone instance will be named Building#x with x from 1 to n<br /> <br>Zone intance of the building has a tag bos:building|
|numberOfFloorsPerBuilding|integer(int64)|false|none|Number of floors per building<br /> <br>Zone template of all floors will be named TFloor<br /> <br>Zone template of the floor has a tag bos:structure:floor<br /> <br>Each floor zone instance will be named Floor#x with x from 1 to n<br /> <br>Zone intance of the floor has a tag bos:structure:floor|
|generateMapviewForEachFloor|boolean|false|none|Indicates if we generate a mapview for each floor|
|mapviewFunctionalBlockWidthAndHeight|number(double)|false|none|Width and height of each functional block on mapview (between 0 and 1)|
|mapviewFunctionalBlockSpace|number(double)|false|none|X and Y space between functional blocks on mapview (between 0 and 1)|
|mapviewZoneWidthAndHeight|number(double)|false|none|Width and height of each zone polygon on mapview between 0 and 1|
|mapviewZoneSpace|number(double)|false|none|X and Y space between zones on mapview (between 0 and 1)|
|createUserAccessingAll|boolean|false|none|Create the user that can access all.<br /> <br>Name of user is : UserALL<br /> <br>Paswword of user is : UserALL(1)|
|createUserAccessingFloor|boolean|false|none|Create the user that can access a floor and all its rooms<br /> <br>Name of user is : User_NameOfFloor with NameOfFloor name of the floor<br /> <br>Paswword of user is : Pass_NameOfFloor(1) with NameOfFloor name of the floor|
|createUserAccessingRoom|boolean|false|none|Create the user that can access only one room<br /> <br>Name of user is : User_NameOfRoom with NameOfRoom name of the room<br /> <br>Paswword of user is : Pass_NameOfRoom(1) with NameOfRoom name of the room|

<h2 id="tocS_ElementDatapointWriteDTO">ElementDatapointWriteDTO</h2>
<!-- backwards compatibility -->
<a id="schemaelementdatapointwritedto"></a>
<a id="schema_ElementDatapointWriteDTO"></a>
<a id="tocSelementdatapointwritedto"></a>
<a id="tocselementdatapointwritedto"></a>

```json
{
  "priority": 0,
  "value": null,
  "type": "TemplateDatapointWriteDTO",
  "id": "string"
}

```

Common datapoint write action element information of template and individual schedule configurations

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|priority|integer(int64)|false|none|Priority value for datapoint write|
|value|any|false|none|Datapoint value to write|
|type|[ActionElementType](#schemaactionelementtype)|false|none|none|

<h2 id="tocS_ElementType">ElementType</h2>
<!-- backwards compatibility -->
<a id="schemaelementtype"></a>
<a id="schema_ElementType"></a>
<a id="tocSelementtype"></a>
<a id="tocselementtype"></a>

```json
"None"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|None|
|*anonymous*|FunctionalBlock|
|*anonymous*|Zone|
|*anonymous*|Image|
|*anonymous*|Text|

<h2 id="tocS_EmbeddedErrorDTO">EmbeddedErrorDTO</h2>
<!-- backwards compatibility -->
<a id="schemaembeddederrordto"></a>
<a id="schema_EmbeddedErrorDTO"></a>
<a id="tocSembeddederrordto"></a>
<a id="tocsembeddederrordto"></a>

```json
{
  "code": "string",
  "message": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|message|string¦null|false|none|none|

<h2 id="tocS_EnergyDTO">EnergyDTO</h2>
<!-- backwards compatibility -->
<a id="schemaenergydto"></a>
<a id="schema_EnergyDTO"></a>
<a id="tocSenergydto"></a>
<a id="tocsenergydto"></a>

```json
{
  "id": "string",
  "name": "string",
  "iconSvg": "string",
  "functionalBlockTags": [
    "string"
  ],
  "useDistribution": true,
  "allowSubMeters": true
}

```

Information about a primary energy

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the primary energy|
|name|string¦null|false|none|Name of the primary energy|
|iconSvg|string¦null|false|none|Content of the SVG icon file of the primary energy|
|functionalBlockTags|[string]¦null|false|none|List of asset tags supported by this primary energy|
|useDistribution|boolean|false|none|Use of distribution entity.|
|allowSubMeters|boolean|false|none|Allow sub-meters.|

<h2 id="tocS_EnergyStructureTypeDTO">EnergyStructureTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemaenergystructuretypedto"></a>
<a id="schema_EnergyStructureTypeDTO"></a>
<a id="tocSenergystructuretypedto"></a>
<a id="tocsenergystructuretypedto"></a>

```json
{
  "id": "string",
  "canBeRoot": true,
  "defaultInputCircuitName": "string",
  "defaultInputCircuitSection": "string",
  "defaultOutputCircuitName": "string",
  "defaultOutputCircuitSection": "string",
  "hasSection": true,
  "iconSvg": "string",
  "iconColor": "string",
  "iconBackColor": "string",
  "name": "string",
  "shortName": "string",
  "uniqueNameInProject": "string",
  "supportedChildrenTags": [
    "string"
  ],
  "tag": "string"
}

```

Information about an available type of distribution element for an energy

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the type of distribution element|
|canBeRoot|boolean|false|none|Indicates if a distribution element can be defined as a root distribution element|
|defaultInputCircuitName|string¦null|false|none|Default name for the input circuit at distribution element creation|
|defaultInputCircuitSection|string¦null|false|none|Default name for the section of the input circuit at distribution element creation|
|defaultOutputCircuitName|string¦null|false|none|Default name for the output circuit at distribution element creation|
|defaultOutputCircuitSection|string¦null|false|none|Default name for the section of the output circuit at distribution element creation|
|hasSection|boolean|false|none|Indicates if a distribution element supports a section|
|iconSvg|string¦null|false|none|Content of the SVG icon file of the distribution element|
|iconColor|string¦null|false|none|Color of the SVG icon of the distribution element|
|iconBackColor|string¦null|false|none|Back color of the SVG icon of the distribution element|
|name|string¦null|false|none|Name of the distribution element|
|shortName|string¦null|false|none|Short name of the distribution element|
|uniqueNameInProject|string¦null|false|none|Indicates if the distribution element name must be unique or not in the whole project|
|supportedChildrenTags|[string]¦null|false|none|List of tags of distribution elements that can be added as chidlren of this distribution element|
|tag|string¦null|false|none|Tag of the distribution element|

<h2 id="tocS_EnrolmentStatus">EnrolmentStatus</h2>
<!-- backwards compatibility -->
<a id="schemaenrolmentstatus"></a>
<a id="schema_EnrolmentStatus"></a>
<a id="tocSenrolmentstatus"></a>
<a id="tocsenrolmentstatus"></a>

```json
"Active"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Active|
|*anonymous*|Pending|
|*anonymous*|Expired|

<h2 id="tocS_EnumerationDataTypeDTO">EnumerationDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemaenumerationdatatypedto"></a>
<a id="schema_EnumerationDataTypeDTO"></a>
<a id="tocSenumerationdatatypedto"></a>
<a id="tocsenumerationdatatypedto"></a>

```json
{
  "type": "string",
  "values": {
    "property1": "string",
    "property2": "string"
  },
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

Enumeration data type value definition. (type:"Enum")

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|
|values|object¦null|false|none|Enumeration values possible as a value|
|» **additionalProperties**|string|false|none|none|

<h2 id="tocS_EnumStringAnimationDTO">EnumStringAnimationDTO</h2>
<!-- backwards compatibility -->
<a id="schemaenumstringanimationdto"></a>
<a id="schema_EnumStringAnimationDTO"></a>
<a id="tocSenumstringanimationdto"></a>
<a id="tocsenumstringanimationdto"></a>

```json
{
  "elements": [
    {
      "selectors": [
        null
      ],
      "value": "string"
    }
  ],
  "animationType": "Float",
  "defaultValue": "string",
  "id": "string",
  "datapointTemplateId": "string",
  "functionalBlockTemplateId": "string",
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "selectionModeForZone": "All",
  "complexDataTypeFieldName": "string"
}

```

Datapoint animation of an enumeration typed datapoint.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|elements|[[EnumStringAnimationElementDTO](#schemaenumstringanimationelementdto)]¦null|false|none|Definition of string result for each value of the enumeration.|
|animationType|[AnimationType](#schemaanimationtype)|false|none|Types of animation.|

<h2 id="tocS_EnumStringAnimationElementDTO">EnumStringAnimationElementDTO</h2>
<!-- backwards compatibility -->
<a id="schemaenumstringanimationelementdto"></a>
<a id="schema_EnumStringAnimationElementDTO"></a>
<a id="tocSenumstringanimationelementdto"></a>
<a id="tocsenumstringanimationelementdto"></a>

```json
{
  "selectors": [
    null
  ],
  "value": "string"
}

```

Definition of a string value for a set of enumeration values.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|selectors|[any]¦null|false|none|Set of enumeration values.|
|value|string¦null|false|none|Associated string value.|

<h2 id="tocS_ErrorBaseDTO">ErrorBaseDTO</h2>
<!-- backwards compatibility -->
<a id="schemaerrorbasedto"></a>
<a id="schema_ErrorBaseDTO"></a>
<a id="tocSerrorbasedto"></a>
<a id="tocserrorbasedto"></a>

```json
{
  "code": "string",
  "message": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|message|string¦null|false|none|none|

<h2 id="tocS_ErrorDTO">ErrorDTO</h2>
<!-- backwards compatibility -->
<a id="schemaerrordto"></a>
<a id="schema_ErrorDTO"></a>
<a id="tocSerrordto"></a>
<a id="tocserrordto"></a>

```json
{
  "errors": [
    {
      "code": "string",
      "message": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|errors|[[ErrorBaseDTO](#schemaerrorbasedto)]¦null|false|none|none|

<h2 id="tocS_ExceptionType">ExceptionType</h2>
<!-- backwards compatibility -->
<a id="schemaexceptiontype"></a>
<a id="schema_ExceptionType"></a>
<a id="tocSexceptiontype"></a>
<a id="tocsexceptiontype"></a>

```json
"SingleDate"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|SingleDate|
|*anonymous*|RangeDate|
|*anonymous*|WeekOfMonth|

<h2 id="tocS_ExportDTO">ExportDTO</h2>
<!-- backwards compatibility -->
<a id="schemaexportdto"></a>
<a id="schema_ExportDTO"></a>
<a id="tocSexportdto"></a>
<a id="tocsexportdto"></a>

```json
{
  "functionalBlockTemplateIds": [
    "string"
  ],
  "zoneTemplateIds": [
    "string"
  ],
  "deviceTemplateIds": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockTemplateIds|[string]¦null|false|none|List of FunctionalBlockTemplate Ids|
|zoneTemplateIds|[string]¦null|false|none|List of ZoneTemplate Ids|
|deviceTemplateIds|[string]¦null|false|none|List of DeviceTemplate Ids|

<h2 id="tocS_FBTypeOfSelection">FBTypeOfSelection</h2>
<!-- backwards compatibility -->
<a id="schemafbtypeofselection"></a>
<a id="schema_FBTypeOfSelection"></a>
<a id="tocSfbtypeofselection"></a>
<a id="tocsfbtypeofselection"></a>

```json
"All"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|All|
|*anonymous*|Master|
|*anonymous*|AnySlave|
|*anonymous*|Slaves|
|*anonymous*|Any|
|*anonymous*|OnlyIfInZone|
|*anonymous*|OnlyOutOfZone|

<h2 id="tocS_FieldDTO">FieldDTO</h2>
<!-- backwards compatibility -->
<a id="schemafielddto"></a>
<a id="schema_FieldDTO"></a>
<a id="tocSfielddto"></a>
<a id="tocsfielddto"></a>

```json
{
  "id": "string",
  "name": "string",
  "rank": 0,
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  }
}

```

Data type field value definition

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the field|
|name|string¦null|false|none|Name fo the field|
|rank|integer(int64)|false|none|Field rank in the complex type|
|type|any|false|none|DataType definition attached to the field (One of the valid defined DataTypeDTO)|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

<h2 id="tocS_FirmwareDTO">FirmwareDTO</h2>
<!-- backwards compatibility -->
<a id="schemafirmwaredto"></a>
<a id="schema_FirmwareDTO"></a>
<a id="tocSfirmwaredto"></a>
<a id="tocsfirmwaredto"></a>

```json
{
  "wantedVersion": "string",
  "when": "2019-08-24T14:15:22Z",
  "automaticReboot": true
}

```

Used to schedule the installation of a new update

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|wantedVersion|string¦null|false|none|The version that should be installed<br>This needs to be a version that was first received with a GET|
|when|string(date-time)¦null|false|none|Date and time when the installation should happen<br>If the date is in the past or null the installation will happen<br>immediatly after the download of the bundle|
|automaticReboot|boolean|false|none|If true the system reboots immediatly after a successful installation<br>The default is false|

<h2 id="tocS_FirmwareUpdateStatus">FirmwareUpdateStatus</h2>
<!-- backwards compatibility -->
<a id="schemafirmwareupdatestatus"></a>
<a id="schema_FirmwareUpdateStatus"></a>
<a id="tocSfirmwareupdatestatus"></a>
<a id="tocsfirmwareupdatestatus"></a>

```json
"NoUpdateScheduled"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|NoUpdateScheduled|
|*anonymous*|DownloadFailed_WaitingForRetry|
|*anonymous*|DownloadIsRunning|
|*anonymous*|WaitingForInstallationTime|
|*anonymous*|UpdateIsRunning|
|*anonymous*|InstallationFailed|
|*anonymous*|InstallationDone|
|*anonymous*|SystemReboots|

<h2 id="tocS_FloatStringAnimationDTO">FloatStringAnimationDTO</h2>
<!-- backwards compatibility -->
<a id="schemafloatstringanimationdto"></a>
<a id="schema_FloatStringAnimationDTO"></a>
<a id="tocSfloatstringanimationdto"></a>
<a id="tocsfloatstringanimationdto"></a>

```json
{
  "ranges": [
    {
      "value": "string",
      "min": 0,
      "minIncluded": true,
      "max": 0,
      "maxIncluded": true
    }
  ],
  "animationType": "Float",
  "defaultValue": "string",
  "id": "string",
  "datapointTemplateId": "string",
  "functionalBlockTemplateId": "string",
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "selectionModeForZone": "All",
  "complexDataTypeFieldName": "string"
}

```

Definition of a datapoint animation for a numeric datapoint.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|ranges|[[StringAnimationRangeDTO](#schemastringanimationrangedto)]¦null|false|none|Ranges with associated string values.|
|animationType|[AnimationType](#schemaanimationtype)|false|none|Types of animation.|

<h2 id="tocS_FloorMinimalWizardDTO">FloorMinimalWizardDTO</h2>
<!-- backwards compatibility -->
<a id="schemafloorminimalwizarddto"></a>
<a id="schema_FloorMinimalWizardDTO"></a>
<a id="tocSfloorminimalwizarddto"></a>
<a id="tocsfloorminimalwizarddto"></a>

```json
{
  "jsonType": "string",
  "id": "string",
  "name": "string",
  "buildingId": "string",
  "networkId": "string",
  "levelToGround": 0,
  "doNotImport": true,
  "tags": [
    "string"
  ],
  "applied": true,
  "appliedMapViewZones": true,
  "appliedMapViewFB": true
}

```

Discribes a floor for import project wizard

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|jsonType|string¦null|false|read-only|Json type|
|id|string¦null|false|none|Unique identifier of floor|
|name|string¦null|false|none|Name of floor|
|buildingId|string¦null|false|none|Identifier of of floor's building, can be null empty|
|networkId|string¦null|false|none|Identifier of of floor's network, can be null empty|
|levelToGround|integer(int64)|false|none|Value of floor's level ( max and min depend of type of floor in tags)|
|doNotImport|boolean|false|none|True to ignore to import this floor|
|tags|[string]¦null|false|none|Contains type of floor|
|applied|boolean|false|none|True when floor has been deployed to bos database|
|appliedMapViewZones|boolean|false|none|True when floor's zones have been deployed to bos database|
|appliedMapViewFB|boolean|false|none|True when floor's assets have been deployed to bos database|

<h2 id="tocS_FloorStep">FloorStep</h2>
<!-- backwards compatibility -->
<a id="schemafloorstep"></a>
<a id="schema_FloorStep"></a>
<a id="tocSfloorstep"></a>
<a id="tocsfloorstep"></a>

```json
"buildingAndStructure"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|buildingAndStructure|
|*anonymous*|levelToGround|
|*anonymous*|network|

<h2 id="tocS_FloorWizardStepDTO">FloorWizardStepDTO</h2>
<!-- backwards compatibility -->
<a id="schemafloorwizardstepdto"></a>
<a id="schema_FloorWizardStepDTO"></a>
<a id="tocSfloorwizardstepdto"></a>
<a id="tocsfloorwizardstepdto"></a>

```json
{
  "step": "buildingAndStructure",
  "floors": [
    {
      "jsonType": "string",
      "id": "string",
      "name": "string",
      "buildingId": "string",
      "networkId": "string",
      "levelToGround": 0,
      "doNotImport": true,
      "tags": [
        "string"
      ],
      "applied": true,
      "appliedMapViewZones": true,
      "appliedMapViewFB": true
    }
  ]
}

```

Contains the floor to coonfigure and the step of configuration

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|step|[FloorStep](#schemafloorstep)|false|none|none|
|floors|[[FloorMinimalWizardDTO](#schemafloorminimalwizarddto)]¦null|false|none|List of floor to post|

<h2 id="tocS_FontStyle">FontStyle</h2>
<!-- backwards compatibility -->
<a id="schemafontstyle"></a>
<a id="schema_FontStyle"></a>
<a id="tocSfontstyle"></a>
<a id="tocsfontstyle"></a>

```json
"Regular"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Regular|
|*anonymous*|Bold|
|*anonymous*|Italic|
|*anonymous*|Underline|
|*anonymous*|Strikeout|

<h2 id="tocS_FunctionalBlockAnimationDTO">FunctionalBlockAnimationDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblockanimationdto"></a>
<a id="schema_FunctionalBlockAnimationDTO"></a>
<a id="tocSfunctionalblockanimationdto"></a>
<a id="tocsfunctionalblockanimationdto"></a>

```json
{
  "functionalBlockTemplateId": "string",
  "textAnimation": {
    "id": "string",
    "datapointTemplateId": "string",
    "functionalBlockTemplateId": "string",
    "type": {
      "type": "string",
      "id": "string",
      "name": "string",
      "tag": "string",
      "transport": "none"
    },
    "selectionModeForZone": "All",
    "complexDataTypeFieldName": "string"
  },
  "iconAnimation": {
    "ranges": [
      {
        "value": "string",
        "min": 0,
        "minIncluded": true,
        "max": 0,
        "maxIncluded": true
      }
    ],
    "animationType": "Float",
    "defaultValue": "string",
    "id": "string",
    "datapointTemplateId": "string",
    "functionalBlockTemplateId": "string",
    "type": {
      "type": "string",
      "id": "string",
      "name": "string",
      "tag": "string",
      "transport": "none"
    },
    "selectionModeForZone": "All",
    "complexDataTypeFieldName": "string"
  },
  "selectionMode": "All",
  "name": "string",
  "showAlarms": true,
  "active": true,
  "id": "string"
}

```

Animation of a functional block on a mapview.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockTemplateId|string¦null|false|none|Functional block template id of the animated functional block instance.|
|textAnimation|[TextAnimationDTO](#schematextanimationdto)|false|none|Text animation in a functional block animation (may be enriched in the future).|
|iconAnimation|any|false|none|Icon animation (if exists).|

oneOf

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[FloatStringAnimationDTO](#schemafloatstringanimationdto)|false|none|Definition of a datapoint animation for a numeric datapoint.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumStringAnimationDTO](#schemaenumstringanimationdto)|false|none|Datapoint animation of an enumeration typed datapoint.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BooleanStringAnimationDTO](#schemabooleanstringanimationdto)|false|none|Animation of a boolean datapoint.|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|selectionMode|[FBTypeOfSelection](#schemafbtypeofselection)|false|none|none|
|name|string¦null|false|none|Name of the animation.|
|showAlarms|boolean|false|none|Are alarms displayed ?.|
|active|boolean|false|none|Is the animation active.|
|id|string¦null|false|none|none|

<h2 id="tocS_FunctionalBlockAnimationRuntimeDTO">FunctionalBlockAnimationRuntimeDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblockanimationruntimedto"></a>
<a id="schema_FunctionalBlockAnimationRuntimeDTO"></a>
<a id="tocSfunctionalblockanimationruntimedto"></a>
<a id="tocsfunctionalblockanimationruntimedto"></a>

```json
{
  "animationId": "string",
  "functionalBlockInstanceId": "string",
  "iconDatapointId": "string",
  "textDatapointId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|animationId|string¦null|false|none|none|
|functionalBlockInstanceId|string¦null|false|none|none|
|iconDatapointId|string¦null|false|none|none|
|textDatapointId|string¦null|false|none|none|

<h2 id="tocS_FunctionalBlockInstanceControlPanelDTO">FunctionalBlockInstanceControlPanelDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblockinstancecontrolpaneldto"></a>
<a id="schema_FunctionalBlockInstanceControlPanelDTO"></a>
<a id="tocSfunctionalblockinstancecontrolpaneldto"></a>
<a id="tocsfunctionalblockinstancecontrolpaneldto"></a>

```json
{
  "functionalBlockInstanceId": "string",
  "functionalBlockInstanceName": "string",
  "functionalBlockInstanceIcon": "string",
  "functionalBlockTemplateId": "string",
  "functionalBlockTemplateName": "string",
  "masterMode": "None",
  "tags": [
    "string"
  ],
  "datapoints": [
    {
      "datapointInstanceId": "string",
      "datapointTemplateId": "string",
      "direction": "Feedback",
      "displayName": "string",
      "displayUnit": "string",
      "dataType": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ],
  "properties": [
    {
      "propertyInstanceId": "string",
      "propertyTemplateId": "string",
      "propertyInstanceValue": null,
      "direction": "Feedback",
      "displayName": "string",
      "displayUnit": "string",
      "dataType": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ]
}

```

Detailed information about the control panel of a functional block instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockInstanceId|string¦null|false|none|Unique identifier of the functional block instance|
|functionalBlockInstanceName|string¦null|false|none|Name of the functional block instance|
|functionalBlockInstanceIcon|string¦null|false|none|URI link to the functional block instance icon|
|functionalBlockTemplateId|string¦null|false|none|Unique identifier of the functional block template|
|functionalBlockTemplateName|string¦null|false|none|Name of the functional block template|
|masterMode|[MasterMode](#schemamastermode)|false|none|none|
|tags|[string]¦null|false|none|Tags of the functional block instance|
|datapoints|[[AdvancedDatapointInstanceDTO](#schemaadvanceddatapointinstancedto)]¦null|false|none|List of datapoint instances to display in the control panel|
|properties|[[AdvancedPropertyInstanceDTO](#schemaadvancedpropertyinstancedto)]¦null|false|none|List of property instances to display in the control panel|

<h2 id="tocS_FunctionalBlockInstanceDTO">FunctionalBlockInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblockinstancedto"></a>
<a id="schema_FunctionalBlockInstanceDTO"></a>
<a id="tocSfunctionalblockinstancedto"></a>
<a id="tocsfunctionalblockinstancedto"></a>

```json
{
  "datapoints": [
    {
      "stationId": "string",
      "networkId": "string",
      "busUnitId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "converterId": "string",
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "properties": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "zones": [
    {
      "zoneId": "string",
      "inZone": true
    }
  ],
  "masterMode": "None",
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "specializationType": "string",
  "specializationId": "string",
  "tags": [
    "string"
  ],
  "deviceInstanceId": "string",
  "deviceFunctionalBlockTemplateId": "string",
  "assignationDone": true,
  "isExternal": true
}

```

Detailed information of a functional block instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapoints|[[DatapointInstanceDTO](#schemadatapointinstancedto)]¦null|false|none|List of DatapointInstances that are inherited from a template|
|properties|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|List of properties that are inherited from a template|
|zones|[[ZoneOfFunctionalBlockDTO](#schemazoneoffunctionalblockdto)]¦null|false|none|List of zones to which belongs the functional block directly (InZone) or indirectly<br>This list is readonly. For information only.|
|masterMode|[MasterMode](#schemamastermode)|false|none|none|
|id|string¦null|false|none|Unique identifier of the functional block|
|name|string¦null|false|none|Localized name of the functional block<br>This field is readonly and ignored during a put/post for a functionalblock instance attached to a functionalblock template|
|icon|string¦null|false|none|Optional image of the functional block<br>This field is readonly and ignored during a put/post for a functionalblock instance attached to a functionalblock template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the functional block template|
|specializationType|string¦null|false|none|Specialization type (metering)|
|specializationId|string¦null|false|none|Unique identifier of the specialization|
|tags|[string]¦null|false|none|List of tags attached to the object|
|deviceInstanceId|string¦null|false|none|Id of device instance the functional block instance belongs to.<br>Null if none|
|deviceFunctionalBlockTemplateId|string¦null|false|none|Functional block of the device template this instance is attached to.<br>Null if none|
|assignationDone|boolean¦null|false|none|Assignation of datapoints fully done or not.<br>Always true for a functional block instance attached to a device instance.<br>If null on update then the value will not be updated on fb|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_FunctionalBlockInstanceInfoDTO">FunctionalBlockInstanceInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblockinstanceinfodto"></a>
<a id="schema_FunctionalBlockInstanceInfoDTO"></a>
<a id="tocSfunctionalblockinstanceinfodto"></a>
<a id="tocsfunctionalblockinstanceinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "specializationType": "string",
  "specializationId": "string",
  "tags": [
    "string"
  ],
  "deviceInstanceId": "string",
  "deviceFunctionalBlockTemplateId": "string",
  "assignationDone": true,
  "isExternal": true
}

```

Basic information of the functional block instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the functional block|
|name|string¦null|false|none|Localized name of the functional block<br>This field is readonly and ignored during a put/post for a functionalblock instance attached to a functionalblock template|
|icon|string¦null|false|none|Optional image of the functional block<br>This field is readonly and ignored during a put/post for a functionalblock instance attached to a functionalblock template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the functional block template|
|specializationType|string¦null|false|none|Specialization type (metering)|
|specializationId|string¦null|false|none|Unique identifier of the specialization|
|tags|[string]¦null|false|none|List of tags attached to the object|
|deviceInstanceId|string¦null|false|none|Id of device instance the functional block instance belongs to.<br>Null if none|
|deviceFunctionalBlockTemplateId|string¦null|false|none|Functional block of the device template this instance is attached to.<br>Null if none|
|assignationDone|boolean¦null|false|none|Assignation of datapoints fully done or not.<br>Always true for a functional block instance attached to a device instance.<br>If null on update then the value will not be updated on fb|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_FunctionalBlockInstanceOfZoneDTO">FunctionalBlockInstanceOfZoneDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblockinstanceofzonedto"></a>
<a id="schema_FunctionalBlockInstanceOfZoneDTO"></a>
<a id="tocSfunctionalblockinstanceofzonedto"></a>
<a id="tocsfunctionalblockinstanceofzonedto"></a>

```json
{
  "functionalBlockId": "string",
  "group": "string",
  "masterMode": "None",
  "inZone": true
}

```

Definition of a functional block attached to a zone

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockId|string¦null|false|none|Unique identifier of the functional block|
|group|string¦null|false|none|Group the functionalblock belongs to in the zone|
|masterMode|[MasterMode](#schemamastermode)|false|none|none|
|inZone|boolean|false|none|Weither the functionalblock belongs to this zone or a child zone|

<h2 id="tocS_FunctionalBlockInstanceTreeDisplayDTO">FunctionalBlockInstanceTreeDisplayDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblockinstancetreedisplaydto"></a>
<a id="schema_FunctionalBlockInstanceTreeDisplayDTO"></a>
<a id="tocSfunctionalblockinstancetreedisplaydto"></a>
<a id="tocsfunctionalblockinstancetreedisplaydto"></a>

```json
{
  "datapoints": [
    {
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "displayUnitId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "networkId": "string",
      "driverDescriptorId": "string"
    }
  ],
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "specializationType": "string",
  "specializationId": "string",
  "tags": [
    "string"
  ],
  "deviceInstanceId": "string",
  "deviceFunctionalBlockTemplateId": "string",
  "assignationDone": true,
  "isExternal": true
}

```

Functional block instance definition for tree display

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapoints|[[DatapointInstanceTreeDisplayDTO](#schemadatapointinstancetreedisplaydto)]¦null|false|none|List of dataPoint instances attached to the functional block instance|
|id|string¦null|false|none|Unique identifier of the functional block|
|name|string¦null|false|none|Localized name of the functional block<br>This field is readonly and ignored during a put/post for a functionalblock instance attached to a functionalblock template|
|icon|string¦null|false|none|Optional image of the functional block<br>This field is readonly and ignored during a put/post for a functionalblock instance attached to a functionalblock template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the functional block template|
|specializationType|string¦null|false|none|Specialization type (metering)|
|specializationId|string¦null|false|none|Unique identifier of the specialization|
|tags|[string]¦null|false|none|List of tags attached to the object|
|deviceInstanceId|string¦null|false|none|Id of device instance the functional block instance belongs to.<br>Null if none|
|deviceFunctionalBlockTemplateId|string¦null|false|none|Functional block of the device template this instance is attached to.<br>Null if none|
|assignationDone|boolean¦null|false|none|Assignation of datapoints fully done or not.<br>Always true for a functional block instance attached to a device instance.<br>If null on update then the value will not be updated on fb|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_FunctionalBlockLiveAlarmSubscriptionDTO">FunctionalBlockLiveAlarmSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblocklivealarmsubscriptiondto"></a>
<a id="schema_FunctionalBlockLiveAlarmSubscriptionDTO"></a>
<a id="tocSfunctionalblocklivealarmsubscriptiondto"></a>
<a id="tocsfunctionalblocklivealarmsubscriptiondto"></a>

```json
{
  "functionalBlockId": "string",
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockId|string¦null|false|none|none|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_FunctionalBlockTemplateControlPanelDTO">FunctionalBlockTemplateControlPanelDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblocktemplatecontrolpaneldto"></a>
<a id="schema_FunctionalBlockTemplateControlPanelDTO"></a>
<a id="tocSfunctionalblocktemplatecontrolpaneldto"></a>
<a id="tocsfunctionalblocktemplatecontrolpaneldto"></a>

```json
{
  "name": "string",
  "active": true,
  "functionalBlockTemplateId": "string",
  "selectionMode": "All",
  "supportMasterSlave": true,
  "datapoints": [
    {
      "datapointTemplateId": "string",
      "direction": "Feedback",
      "displayName": "string",
      "displayUnit": "string",
      "dataType": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ],
  "properties": [
    {
      "propertyDatapointTemplateId": "string",
      "direction": "Feedback",
      "displayName": "string",
      "displayUnit": "string",
      "dataType": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ]
}

```

Definition of the configuration of the control panel of a functional block template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the configuration of the control panel, may be null or empty|
|active|boolean|false|none|Indicates if the configuration of the control panel is active or not|
|functionalBlockTemplateId|string¦null|false|none|Unique identifier of the functional block template|
|selectionMode|[FBTypeOfSelection](#schemafbtypeofselection)|false|none|none|
|supportMasterSlave|boolean|false|none|Indicates if the functional block template supports the master/slave mode|
|datapoints|[[AdvancedDatapointTemplateDTO](#schemaadvanceddatapointtemplatedto)]¦null|false|none|List of datapoint templates to display in the control panel|
|properties|[[AdvancedPropertyTemplateDTO](#schemaadvancedpropertytemplatedto)]¦null|false|none|List of property templates to display in the control panel|

<h2 id="tocS_FunctionalBlockTemplateDTO">FunctionalBlockTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblocktemplatedto"></a>
<a id="schema_FunctionalBlockTemplateDTO"></a>
<a id="tocSfunctionalblocktemplatedto"></a>
<a id="tocsfunctionalblocktemplatedto"></a>

```json
{
  "datapoints": [
    {
      "busUnitId": "string",
      "id": "string",
      "name": "string",
      "description": "string",
      "tags": [
        "string"
      ],
      "direction": "Feedback",
      "typeId": "string",
      "displayUnitId": "string",
      "publicId": "string"
    }
  ],
  "properties": [
    {
      "defaultValue": null,
      "id": "string",
      "name": "string",
      "description": "string",
      "tags": [
        "string"
      ],
      "direction": "Feedback",
      "typeId": "string",
      "displayUnitId": "string",
      "publicId": "string"
    }
  ],
  "usages": [
    "string"
  ],
  "supportMasterSlave": true,
  "id": "string",
  "icon": "string",
  "iconFillColor": "string",
  "name": "string",
  "tags": [
    "string"
  ],
  "parentId": "string",
  "version": "string",
  "instancesCount": 0,
  "publicId": "string",
  "isExternal": true
}

```

Detailed information of a functional block template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapoints|[[DatapointTemplateDTO](#schemadatapointtemplatedto)]¦null|false|none|List of datapoint templates attached to the functional block|
|properties|[[PropertyDatapointTemplateDTO](#schemapropertydatapointtemplatedto)]¦null|false|none|List of properties templates attached to the functional block|
|usages|[string]¦null|false|none|FunctionalBlockTemplate usages (information only)|
|supportMasterSlave|boolean|false|none|This function supports or not master/slave mode|
|id|string¦null|false|none|Unique identifier of the functional block|
|icon|string¦null|false|none|URI link to the functional block template icon|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|name|string¦null|false|none|Localized name of the functional block template|
|tags|[string]¦null|false|none|List of tags attached to the object|
|parentId|string¦null|false|none|FunctionalBlockTemplate parent of this FunctionalBlockTemplate.<br>Null if root. Not null for a FunctionalBlockTemplate usage.|
|version|string¦null|false|none|Functional block template version.<br>Information only. Readonly.|
|instancesCount|integer(int64)|false|none|Number of functional block instances using this template.<br>Information only. Readonly.|
|publicId|string¦null|false|none|Unique public identifier of the functional block|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_FunctionalBlockTemplateDuplicateDTO">FunctionalBlockTemplateDuplicateDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblocktemplateduplicatedto"></a>
<a id="schema_FunctionalBlockTemplateDuplicateDTO"></a>
<a id="tocSfunctionalblocktemplateduplicatedto"></a>
<a id="tocsfunctionalblocktemplateduplicatedto"></a>

```json
{
  "icon": "string",
  "iconFillColor": "string",
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|icon|string¦null|false|none|Base64 string of the new icon|
|iconFillColor|string¦null|false|none|Icon fill color|
|name|string¦null|false|none|New name of duplicate item|

<h2 id="tocS_FunctionalBlockTemplateImportResultDTO">FunctionalBlockTemplateImportResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblocktemplateimportresultdto"></a>
<a id="schema_FunctionalBlockTemplateImportResultDTO"></a>
<a id="tocSfunctionalblocktemplateimportresultdto"></a>
<a id="tocsfunctionalblocktemplateimportresultdto"></a>

```json
{
  "id": "string",
  "name": "string",
  "added": true,
  "uptodate": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|name|string¦null|false|none|none|
|added|boolean|false|none|none|
|uptodate|boolean|false|none|none|

<h2 id="tocS_FunctionalBlockTemplateInfoDTO">FunctionalBlockTemplateInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblocktemplateinfodto"></a>
<a id="schema_FunctionalBlockTemplateInfoDTO"></a>
<a id="tocSfunctionalblocktemplateinfodto"></a>
<a id="tocsfunctionalblocktemplateinfodto"></a>

```json
{
  "id": "string",
  "icon": "string",
  "iconFillColor": "string",
  "name": "string",
  "tags": [
    "string"
  ],
  "parentId": "string",
  "version": "string",
  "instancesCount": 0,
  "publicId": "string",
  "isExternal": true
}

```

Basic information of a functionalblock template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the functional block|
|icon|string¦null|false|none|URI link to the functional block template icon|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|name|string¦null|false|none|Localized name of the functional block template|
|tags|[string]¦null|false|none|List of tags attached to the object|
|parentId|string¦null|false|none|FunctionalBlockTemplate parent of this FunctionalBlockTemplate.<br>Null if root. Not null for a FunctionalBlockTemplate usage.|
|version|string¦null|false|none|Functional block template version.<br>Information only. Readonly.|
|instancesCount|integer(int64)|false|none|Number of functional block instances using this template.<br>Information only. Readonly.|
|publicId|string¦null|false|none|Unique public identifier of the functional block|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_FunctionalBlockTemplateWizardDTO">FunctionalBlockTemplateWizardDTO</h2>
<!-- backwards compatibility -->
<a id="schemafunctionalblocktemplatewizarddto"></a>
<a id="schema_FunctionalBlockTemplateWizardDTO"></a>
<a id="tocSfunctionalblocktemplatewizarddto"></a>
<a id="tocsfunctionalblocktemplatewizarddto"></a>

```json
{
  "tags": [
    "string"
  ],
  "doNotImport": true,
  "applied": true,
  "iconChanged": true,
  "id": "string",
  "functionalBlockBaseId": "string",
  "name": "string",
  "functionalBlockBaseName": "string",
  "supportMasterSlave": true,
  "icon": "string",
  "iconExtension": "string",
  "version": 0,
  "datapoints": [
    {
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tags|[string]¦null|false|none|none|
|doNotImport|boolean|false|none|none|
|applied|boolean|false|none|none|
|iconChanged|boolean|false|none|none|
|id|string¦null|false|none|none|
|functionalBlockBaseId|string¦null|false|none|none|
|name|string¦null|false|none|none|
|functionalBlockBaseName|string¦null|false|none|none|
|supportMasterSlave|boolean|false|none|none|
|icon|string¦null|false|none|none|
|iconExtension|string¦null|false|none|none|
|version|integer(int64)|false|none|none|
|datapoints|[[DatapointTemplateDesc](#schemadatapointtemplatedesc)]¦null|false|none|none|

<h2 id="tocS_GetAddressDTO">GetAddressDTO</h2>
<!-- backwards compatibility -->
<a id="schemagetaddressdto"></a>
<a id="schema_GetAddressDTO"></a>
<a id="tocSgetaddressdto"></a>
<a id="tocsgetaddressdto"></a>

```json
{
  "networkID": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|networkID|string¦null|false|none|none|
|protocolArguments|object¦null|false|none|none|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_GraphApiAccessData">GraphApiAccessData</h2>
<!-- backwards compatibility -->
<a id="schemagraphapiaccessdata"></a>
<a id="schema_GraphApiAccessData"></a>
<a id="tocSgraphapiaccessdata"></a>
<a id="tocsgraphapiaccessdata"></a>

```json
{
  "tenant": "string",
  "clientId": "string",
  "clientSecret": "string",
  "secretExpirationDate": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tenant|string¦null|false|none|none|
|clientId|string¦null|false|none|none|
|clientSecret|string¦null|false|none|none|
|secretExpirationDate|string(date-time)¦null|false|none|none|

<h2 id="tocS_HardwareLayoutDTO">HardwareLayoutDTO</h2>
<!-- backwards compatibility -->
<a id="schemahardwarelayoutdto"></a>
<a id="schema_HardwareLayoutDTO"></a>
<a id="tocShardwarelayoutdto"></a>
<a id="tocshardwarelayoutdto"></a>

```json
{
  "id": "string",
  "name": "string",
  "layoutImage": "string",
  "thumbImage": "string",
  "supportedTransports": [
    "none"
  ],
  "ports": [
    {
      "id": "string",
      "name": "string",
      "displayName": "string",
      "description": "string",
      "position": {
        "x": 0,
        "y": 0,
        "width": 0,
        "height": 0
      },
      "supportMultiNetworks": true,
      "wiringImage": "string",
      "supportedTransports": [
        "none"
      ],
      "type": "None",
      "isDefaultIpPort": true,
      "defaultIpAddress": "string",
      "defaultSubnetMask": "string"
    }
  ]
}

```

Detailed information about a hardware layout of a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the hardware layout.|
|name|string¦null|false|none|Name of the hardware layout.|
|layoutImage|string¦null|false|none|Layout image of the hardware layout.|
|thumbImage|string¦null|false|none|Thumb image of the hardware layout.|
|supportedTransports|[[TransportType](#schematransporttype)]¦null|false|none|List of the transports supported by the hardware layout.|
|ports|[[HardwareLayoutPortDTO](#schemahardwarelayoutportdto)]¦null|false|none|List of available ports.|

<h2 id="tocS_HardwareLayoutInfoDTO">HardwareLayoutInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemahardwarelayoutinfodto"></a>
<a id="schema_HardwareLayoutInfoDTO"></a>
<a id="tocShardwarelayoutinfodto"></a>
<a id="tocshardwarelayoutinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "supportedTransports": [
    "none"
  ],
  "ports": [
    {
      "id": "string",
      "name": "string"
    }
  ]
}

```

Information about a hardware layout of a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the hardware layout.|
|name|string¦null|false|none|Name of the hardware layout.|
|supportedTransports|[[TransportType](#schematransporttype)]¦null|false|none|List of the transports supported by the hardware layout.|
|ports|[[HardwareLayoutPortInfoDTO](#schemahardwarelayoutportinfodto)]¦null|false|none|List of available ports.|

<h2 id="tocS_HardwareLayoutPortDTO">HardwareLayoutPortDTO</h2>
<!-- backwards compatibility -->
<a id="schemahardwarelayoutportdto"></a>
<a id="schema_HardwareLayoutPortDTO"></a>
<a id="tocShardwarelayoutportdto"></a>
<a id="tocshardwarelayoutportdto"></a>

```json
{
  "id": "string",
  "name": "string",
  "displayName": "string",
  "description": "string",
  "position": {
    "x": 0,
    "y": 0,
    "width": 0,
    "height": 0
  },
  "supportMultiNetworks": true,
  "wiringImage": "string",
  "supportedTransports": [
    "none"
  ],
  "type": "None",
  "isDefaultIpPort": true,
  "defaultIpAddress": "string",
  "defaultSubnetMask": "string"
}

```

Detailed information about a port of a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the port.|
|name|string¦null|false|none|Name of the port.|
|displayName|string¦null|false|none|Display name of the port.|
|description|string¦null|false|none|Description of the port.|
|position|[RectangleDTO](#schemarectangledto)|false|none|none|
|supportMultiNetworks|boolean|false|none|Indicates if the port supports several networks.|
|wiringImage|string¦null|false|none|Image of wiring of the port.|
|supportedTransports|[[TransportType](#schematransporttype)]¦null|false|none|List of the transports supported by the port.|
|type|[PortType](#schemaporttype)|false|none|none|
|isDefaultIpPort|boolean|false|none|Indicates if the port is the default IP port.|
|defaultIpAddress|string¦null|false|none|Default static IP address, is empty if not applicable or DHCP is used by default.|
|defaultSubnetMask|string¦null|false|none|Default subnet mask, is empty if not applicable or DHCP is used by default.|

<h2 id="tocS_HardwareLayoutPortInfoDTO">HardwareLayoutPortInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemahardwarelayoutportinfodto"></a>
<a id="schema_HardwareLayoutPortInfoDTO"></a>
<a id="tocShardwarelayoutportinfodto"></a>
<a id="tocshardwarelayoutportinfodto"></a>

```json
{
  "id": "string",
  "name": "string"
}

```

Information about a port of a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the port.|
|name|string¦null|false|none|Name of the port.|

<h2 id="tocS_HierarchyDTO">HierarchyDTO</h2>
<!-- backwards compatibility -->
<a id="schemahierarchydto"></a>
<a id="schema_HierarchyDTO"></a>
<a id="tocShierarchydto"></a>
<a id="tocshierarchydto"></a>

```json
{
  "dataVersion": "string",
  "items": {
    "property1": {
      "type": "string",
      "name": "string",
      "tags": [
        "string"
      ],
      "iconUrl": "string",
      "metadata": {
        "property1": null,
        "property2": null
      }
    },
    "property2": {
      "type": "string",
      "name": "string",
      "tags": [
        "string"
      ],
      "iconUrl": "string",
      "metadata": {
        "property1": null,
        "property2": null
      }
    }
  },
  "links": [
    {
      "item1": "string",
      "item2": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|dataVersion|string¦null|false|none|none|
|items|object¦null|false|none|none|
|» **additionalProperties**|[HierarchyItemDTO](#schemahierarchyitemdto)|false|none|none|
|links|[[StringStringValueTuple](#schemastringstringvaluetuple)]¦null|false|none|none|

<h2 id="tocS_HierarchyItemDTO">HierarchyItemDTO</h2>
<!-- backwards compatibility -->
<a id="schemahierarchyitemdto"></a>
<a id="schema_HierarchyItemDTO"></a>
<a id="tocShierarchyitemdto"></a>
<a id="tocshierarchyitemdto"></a>

```json
{
  "type": "string",
  "name": "string",
  "tags": [
    "string"
  ],
  "iconUrl": "string",
  "metadata": {
    "property1": null,
    "property2": null
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string¦null|false|none|none|
|name|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|iconUrl|string¦null|false|none|none|
|metadata|object¦null|false|none|none|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_HttpStatusCode">HttpStatusCode</h2>
<!-- backwards compatibility -->
<a id="schemahttpstatuscode"></a>
<a id="schema_HttpStatusCode"></a>
<a id="tocShttpstatuscode"></a>
<a id="tocshttpstatuscode"></a>

```json
"Continue"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Continue|
|*anonymous*|SwitchingProtocols|
|*anonymous*|Processing|
|*anonymous*|EarlyHints|
|*anonymous*|OK|
|*anonymous*|Created|
|*anonymous*|Accepted|
|*anonymous*|NonAuthoritativeInformation|
|*anonymous*|NoContent|
|*anonymous*|ResetContent|
|*anonymous*|PartialContent|
|*anonymous*|MultiStatus|
|*anonymous*|AlreadyReported|
|*anonymous*|IMUsed|
|*anonymous*|Ambiguous|
|*anonymous*|Moved|
|*anonymous*|Redirect|
|*anonymous*|RedirectMethod|
|*anonymous*|NotModified|
|*anonymous*|UseProxy|
|*anonymous*|Unused|
|*anonymous*|TemporaryRedirect|
|*anonymous*|PermanentRedirect|
|*anonymous*|BadRequest|
|*anonymous*|Unauthorized|
|*anonymous*|PaymentRequired|
|*anonymous*|Forbidden|
|*anonymous*|NotFound|
|*anonymous*|MethodNotAllowed|
|*anonymous*|NotAcceptable|
|*anonymous*|ProxyAuthenticationRequired|
|*anonymous*|RequestTimeout|
|*anonymous*|Conflict|
|*anonymous*|Gone|
|*anonymous*|LengthRequired|
|*anonymous*|PreconditionFailed|
|*anonymous*|RequestEntityTooLarge|
|*anonymous*|RequestUriTooLong|
|*anonymous*|UnsupportedMediaType|
|*anonymous*|RequestedRangeNotSatisfiable|
|*anonymous*|ExpectationFailed|
|*anonymous*|MisdirectedRequest|
|*anonymous*|UnprocessableEntity|
|*anonymous*|Locked|
|*anonymous*|FailedDependency|
|*anonymous*|UpgradeRequired|
|*anonymous*|PreconditionRequired|
|*anonymous*|TooManyRequests|
|*anonymous*|RequestHeaderFieldsTooLarge|
|*anonymous*|UnavailableForLegalReasons|
|*anonymous*|InternalServerError|
|*anonymous*|NotImplemented|
|*anonymous*|BadGateway|
|*anonymous*|ServiceUnavailable|
|*anonymous*|GatewayTimeout|
|*anonymous*|HttpVersionNotSupported|
|*anonymous*|VariantAlsoNegotiates|
|*anonymous*|InsufficientStorage|
|*anonymous*|LoopDetected|
|*anonymous*|NotExtended|
|*anonymous*|NetworkAuthenticationRequired|

<h2 id="tocS_ImportEngineStatus">ImportEngineStatus</h2>
<!-- backwards compatibility -->
<a id="schemaimportenginestatus"></a>
<a id="schema_ImportEngineStatus"></a>
<a id="tocSimportenginestatus"></a>
<a id="tocsimportenginestatus"></a>

```json
"None"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|None|
|*anonymous*|AnalyzingData|
|*anonymous*|ApplyingData|
|*anonymous*|Wizard|

<h2 id="tocS_ImportProjectEvent">ImportProjectEvent</h2>
<!-- backwards compatibility -->
<a id="schemaimportprojectevent"></a>
<a id="schema_ImportProjectEvent"></a>
<a id="tocSimportprojectevent"></a>
<a id="tocsimportprojectevent"></a>

```json
{
  "cancelPossible": true,
  "done": true,
  "level": "Info",
  "lifeSignal": true,
  "message": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|cancelPossible|boolean|false|none|none|
|done|boolean|false|none|none|
|level|[LevelInfo](#schemalevelinfo)|false|none|none|
|lifeSignal|boolean|false|none|none|
|message|string¦null|false|none|none|

<h2 id="tocS_ImportResultDTO">ImportResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemaimportresultdto"></a>
<a id="schema_ImportResultDTO"></a>
<a id="tocSimportresultdto"></a>
<a id="tocsimportresultdto"></a>

```json
{
  "functionalBlockTemplates": [
    {
      "id": "string",
      "name": "string",
      "added": true,
      "uptodate": true
    }
  ],
  "zoneTemplates": [
    {
      "id": "string",
      "name": "string",
      "added": true,
      "uptodate": true
    }
  ],
  "deviceTemplates": [
    {
      "id": "string",
      "name": "string",
      "added": true,
      "uptodate": true
    }
  ]
}

```

Object containing the result of an import operation

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockTemplates|[[FunctionalBlockTemplateImportResultDTO](#schemafunctionalblocktemplateimportresultdto)]¦null|false|none|List of FunctionalBlock template imported with the associated changed flag (added/updated)|
|zoneTemplates|[[ZoneTemplateImportResultDTO](#schemazonetemplateimportresultdto)]¦null|false|none|List of Zone template imported with the associated changed flag (added/updated)|
|deviceTemplates|[[DeviceTemplateImportResultDTO](#schemadevicetemplateimportresultdto)]¦null|false|none|none|

<h2 id="tocS_ImportUserLevel">ImportUserLevel</h2>
<!-- backwards compatibility -->
<a id="schemaimportuserlevel"></a>
<a id="schema_ImportUserLevel"></a>
<a id="tocSimportuserlevel"></a>
<a id="tocsimportuserlevel"></a>

```json
"Integrator"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Integrator|
|*anonymous*|Installer|
|*anonymous*|FacilityManager|

<h2 id="tocS_IndividualScheduleConfigurationDTO">IndividualScheduleConfigurationDTO</h2>
<!-- backwards compatibility -->
<a id="schemaindividualscheduleconfigurationdto"></a>
<a id="schema_IndividualScheduleConfigurationDTO"></a>
<a id="tocSindividualscheduleconfigurationdto"></a>
<a id="tocsindividualscheduleconfigurationdto"></a>

```json
{
  "zoneInstanceId": "string",
  "datapoints": [
    {
      "identifier": {
        "type": 0,
        "busDatapointId": "string",
        "networkId": "string",
        "id": "string",
        "protocolArguments": {
          "property1": null,
          "property2": null
        }
      },
      "displayName": "string"
    }
  ],
  "type": "string",
  "id": "string",
  "name": "string",
  "generalSettings": {
    "exceptionsVisible": true,
    "resetOnUpdate": true,
    "resetOnReboot": true,
    "busRepetitionActive": true,
    "busRepetitionOnErrorOnly": true,
    "busRepetitionTimes": 0,
    "busRepetitionInterval": 0,
    "todayTomorrowVisible": true,
    "allowCustomAction": true
  },
  "actions": [
    {
      "id": "string",
      "name": "string",
      "custom": true,
      "color": "string",
      "valuesCanBeEditedInOperation": true,
      "actionElements": [
        {
          "priority": 0,
          "value": null,
          "type": "TemplateDatapointWriteDTO",
          "id": "string"
        }
      ]
    }
  ]
}

```

Complete information about an individual schedule configuration.
It is configured to act explicitly on a set of datapoint instances. In a sense, it is a static configuration.
Whereas a template schedule configuration is configured based on datapoint templates.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneInstanceId|string¦null|false|none|Id of the zone instance to which the schedule is associated to|
|datapoints|[[DatapointIdentifierWithNameDTO](#schemadatapointidentifierwithnamedto)]¦null|false|none|List of datapoints managed by the schedule configuration|
|type|[ScheduleConfigurationType](#schemascheduleconfigurationtype)|false|none|none|

<h2 id="tocS_IndividualScheduleConfigurationInfoDTO">IndividualScheduleConfigurationInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaindividualscheduleconfigurationinfodto"></a>
<a id="schema_IndividualScheduleConfigurationInfoDTO"></a>
<a id="tocSindividualscheduleconfigurationinfodto"></a>
<a id="tocsindividualscheduleconfigurationinfodto"></a>

```json
{
  "zoneInstanceName": "string",
  "type": "string",
  "id": "string",
  "name": "string"
}

```

Minimal information about an individual schedule configuration.
It is configured to act explicitly on a set of datapoint instances. In a sense, it is a static configuration.
Whereas a template schedule configuration is configured based on datapoint templates.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneInstanceName|string¦null|false|none|Name of the zone instance the scheduler configuration is linked to|
|type|[ScheduleConfigurationType](#schemascheduleconfigurationtype)|false|none|none|

<h2 id="tocS_InitializationStatus">InitializationStatus</h2>
<!-- backwards compatibility -->
<a id="schemainitializationstatus"></a>
<a id="schema_InitializationStatus"></a>
<a id="tocSinitializationstatus"></a>
<a id="tocsinitializationstatus"></a>

```json
"NotDone"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|NotDone|
|*anonymous*|PasswordSet|
|*anonymous*|CoreInitializationDone|
|*anonymous*|StructureInitializationDone|

<h2 id="tocS_InitializationStatusDTO">InitializationStatusDTO</h2>
<!-- backwards compatibility -->
<a id="schemainitializationstatusdto"></a>
<a id="schema_InitializationStatusDTO"></a>
<a id="tocSinitializationstatusdto"></a>
<a id="tocsinitializationstatusdto"></a>

```json
{
  "status": "NotDone"
}

```

Initialization status

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|status|[InitializationStatus](#schemainitializationstatus)|false|none|none|

<h2 id="tocS_InitUserDTO">InitUserDTO</h2>
<!-- backwards compatibility -->
<a id="schemainituserdto"></a>
<a id="schema_InitUserDTO"></a>
<a id="tocSinituserdto"></a>
<a id="tocsinituserdto"></a>

```json
{
  "name": "string",
  "initials": "string",
  "icon": "string",
  "email": "string",
  "company": "string",
  "firstname": "string",
  "lastname": "string",
  "phone": "string",
  "preferences": {
    "property1": "string",
    "property2": "string"
  },
  "hasAccessFromCloud": true,
  "password": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|initials|string¦null|false|none|none|
|icon|string¦null|false|none|none|
|email|string¦null|false|none|none|
|company|string¦null|false|none|none|
|firstname|string¦null|false|none|none|
|lastname|string¦null|false|none|none|
|phone|string¦null|false|none|none|
|preferences|object¦null|false|none|none|
|» **additionalProperties**|string|false|none|none|
|hasAccessFromCloud|boolean|false|none|none|
|password|string¦null|false|none|none|

<h2 id="tocS_IPAddressDataTypeDTO">IPAddressDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemaipaddressdatatypedto"></a>
<a id="schema_IPAddressDataTypeDTO"></a>
<a id="tocSipaddressdatatypedto"></a>
<a id="tocsipaddressdatatypedto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|

<h2 id="tocS_IPEndPointDataTypeDTO">IPEndPointDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemaipendpointdatatypedto"></a>
<a id="schema_IPEndPointDataTypeDTO"></a>
<a id="tocSipendpointdatatypedto"></a>
<a id="tocsipendpointdatatypedto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|

<h2 id="tocS_IPEndPointDTO">IPEndPointDTO</h2>
<!-- backwards compatibility -->
<a id="schemaipendpointdto"></a>
<a id="schema_IPEndPointDTO"></a>
<a id="tocSipendpointdto"></a>
<a id="tocsipendpointdto"></a>

```json
{
  "address": "string",
  "port": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|address|string¦null|false|none|none|
|port|integer(int32)|false|none|none|

<h2 id="tocS_LevelInfo">LevelInfo</h2>
<!-- backwards compatibility -->
<a id="schemalevelinfo"></a>
<a id="schema_LevelInfo"></a>
<a id="tocSlevelinfo"></a>
<a id="tocslevelinfo"></a>

```json
"Info"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Info|
|*anonymous*|Error|

<h2 id="tocS_LicenseDTO">LicenseDTO</h2>
<!-- backwards compatibility -->
<a id="schemalicensedto"></a>
<a id="schema_LicenseDTO"></a>
<a id="tocSlicensedto"></a>
<a id="tocslicensedto"></a>

```json
{
  "id": "string",
  "creationDate": "2019-08-24T14:15:22Z",
  "deviceId": "string",
  "productId": "string",
  "metrics": [
    {
      "size": 0,
      "unit": "string",
      "unlimited": true
    }
  ],
  "status": "string",
  "expirationDate": "2019-08-24T14:15:22Z",
  "expired": true,
  "expiredBecauseToken": true,
  "tokenExpirationDate": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|The Id of the license|
|creationDate|string(date-time)|false|none|The date of creation|
|deviceId|string¦null|false|none|Id of the device|
|productId|string¦null|false|none|Id of the product associated with the license|
|metrics|[[LicenseMetricDTO](#schemalicensemetricdto)]¦null|false|none|Metrics of the license|
|status|string¦null|false|none|Status of the license (trial, ...)|
|expirationDate|string(date-time)¦null|false|none|Expiration date of the license|
|expired|boolean|false|none|Whether the license is already expired or not|
|expiredBecauseToken|boolean|false|none|True if expiration is caused by token life time. False if expiration is because of subscription date.<br>Used only if Expired is true|
|tokenExpirationDate|string(date-time)|false|none|Token expiration date|

<h2 id="tocS_LicenseMetricDTO">LicenseMetricDTO</h2>
<!-- backwards compatibility -->
<a id="schemalicensemetricdto"></a>
<a id="schema_LicenseMetricDTO"></a>
<a id="tocSlicensemetricdto"></a>
<a id="tocslicensemetricdto"></a>

```json
{
  "size": 0,
  "unit": "string",
  "unlimited": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|size|integer(int32)|false|none|Size of license.<br>Not used if Unlimited is true|
|unit|string¦null|false|none|Type of item this license covered|
|unlimited|boolean|false|none|Unlimited license|

<h2 id="tocS_LicenseSetDebugDTO">LicenseSetDebugDTO</h2>
<!-- backwards compatibility -->
<a id="schemalicensesetdebugdto"></a>
<a id="schema_LicenseSetDebugDTO"></a>
<a id="tocSlicensesetdebugdto"></a>
<a id="tocslicensesetdebugdto"></a>

```json
{
  "bos": {
    "state": "None",
    "type": "string",
    "points": 0,
    "pointsBeingUsed": 0,
    "expirationDate": "2019-08-24T14:15:22Z",
    "trial": true
  },
  "beEfficiancy": {
    "state": "None",
    "type": "string",
    "rooms": 0,
    "expirationDate": "2019-08-24T14:15:22Z",
    "trial": true
  },
  "frequencyVerificationSeconds": 0
}

```

Set license (debug purpose only)

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|bos|[BOSLicenseDTO](#schemaboslicensedto)|false|none|License description for BOS|
|beEfficiancy|[BEEfficiencyLicenseDTO](#schemabeefficiencylicensedto)|false|none|License description for BEEfficiancy|
|frequencyVerificationSeconds|integer(int32)|false|none|Frequency to verify license in seconds|

<h2 id="tocS_LicenseState">LicenseState</h2>
<!-- backwards compatibility -->
<a id="schemalicensestate"></a>
<a id="schema_LicenseState"></a>
<a id="tocSlicensestate"></a>
<a id="tocslicensestate"></a>

```json
"None"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|None|
|*anonymous*|Active|
|*anonymous*|Expired|
|*anonymous*|NeedRefresh|

<h2 id="tocS_LinkScheduleDTO">LinkScheduleDTO</h2>
<!-- backwards compatibility -->
<a id="schemalinkscheduledto"></a>
<a id="schema_LinkScheduleDTO"></a>
<a id="tocSlinkscheduledto"></a>
<a id="tocslinkscheduledto"></a>

```json
{
  "link": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|link|boolean|false|none|specifies wether we want to link or unlink a schedule to its parent|

<h2 id="tocS_LiveAlarmSubscriptionDTO">LiveAlarmSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemalivealarmsubscriptiondto"></a>
<a id="schema_LiveAlarmSubscriptionDTO"></a>
<a id="tocSlivealarmsubscriptiondto"></a>
<a id="tocslivealarmsubscriptiondto"></a>

```json
{
  "alarmInstanceIds": [
    "string"
  ],
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|alarmInstanceIds|[string]¦null|false|none|none|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_LocalUserDTO">LocalUserDTO</h2>
<!-- backwards compatibility -->
<a id="schemalocaluserdto"></a>
<a id="schema_LocalUserDTO"></a>
<a id="tocSlocaluserdto"></a>
<a id="tocslocaluserdto"></a>

```json
{
  "id": "string",
  "login": "string",
  "hashedPassword": "string",
  "email": "string",
  "accessRights": [
    "string"
  ],
  "userId": "string",
  "hasAccessFromCloud": true,
  "active": true,
  "culture": "string",
  "timeZone": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|LocalUser id|
|login|string¦null|false|none|Local user login|
|hashedPassword|string¦null|false|none|Local user hashed password|
|email|string¦null|false|none|Local user email|
|accessRights|[string]¦null|false|none|List of access right identifiers|
|userId|string¦null|false|none|LocalUser related UserId|
|hasAccessFromCloud|boolean|false|none|LocalUser Cloud access|
|active|boolean|false|none|LocalUser is active|
|culture|string¦null|false|none|Culture of the local user|
|timeZone|string¦null|false|none|Time zone of the local user|

<h2 id="tocS_LoginResponseDTO">LoginResponseDTO</h2>
<!-- backwards compatibility -->
<a id="schemaloginresponsedto"></a>
<a id="schema_LoginResponseDTO"></a>
<a id="tocSloginresponsedto"></a>
<a id="tocsloginresponsedto"></a>

```json
{
  "access_token": "string",
  "user_id": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|access_token|string¦null|false|none|none|
|user_id|string¦null|false|none|none|

<h2 id="tocS_LogLevel">LogLevel</h2>
<!-- backwards compatibility -->
<a id="schemaloglevel"></a>
<a id="schema_LogLevel"></a>
<a id="tocSloglevel"></a>
<a id="tocsloglevel"></a>

```json
"Trace"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Trace|
|*anonymous*|Debug|
|*anonymous*|Information|
|*anonymous*|Warning|
|*anonymous*|Error|
|*anonymous*|Critical|
|*anonymous*|None|

<h2 id="tocS_LogSettingsDTO">LogSettingsDTO</h2>
<!-- backwards compatibility -->
<a id="schemalogsettingsdto"></a>
<a id="schema_LogSettingsDTO"></a>
<a id="tocSlogsettingsdto"></a>
<a id="tocslogsettingsdto"></a>

```json
{
  "logLevelNginx": "Trace",
  "logLevelBosPublication": "Trace",
  "logLevelBosDatabase": "Trace",
  "logLevelBosBusiness": "Trace",
  "logLevelBosMiddlewareSynchronization": "Trace",
  "logLevelMiddleware": "Trace",
  "logMiddlewareSynchronization": true,
  "logMiddlewareNetwork": true,
  "logMiddlewareAlarms": true,
  "logMiddlewareTrends": true,
  "logMiddlewareGeneral": true,
  "logNamespaces": [
    {
      "logLevel": "Trace",
      "namespace": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|logLevelNginx|[LogLevel](#schemaloglevel)|false|none|none|
|logLevelBosPublication|[LogLevel](#schemaloglevel)|false|none|none|
|logLevelBosDatabase|[LogLevel](#schemaloglevel)|false|none|none|
|logLevelBosBusiness|[LogLevel](#schemaloglevel)|false|none|none|
|logLevelBosMiddlewareSynchronization|[LogLevel](#schemaloglevel)|false|none|none|
|logLevelMiddleware|[LogLevel](#schemaloglevel)|false|none|none|
|logMiddlewareSynchronization|boolean|false|none|none|
|logMiddlewareNetwork|boolean|false|none|none|
|logMiddlewareAlarms|boolean|false|none|none|
|logMiddlewareTrends|boolean|false|none|none|
|logMiddlewareGeneral|boolean|false|none|none|
|logNamespaces|[[LogSettingsNamespaceDTO](#schemalogsettingsnamespacedto)]¦null|false|none|none|

<h2 id="tocS_LogSettingsNamespaceDTO">LogSettingsNamespaceDTO</h2>
<!-- backwards compatibility -->
<a id="schemalogsettingsnamespacedto"></a>
<a id="schema_LogSettingsNamespaceDTO"></a>
<a id="tocSlogsettingsnamespacedto"></a>
<a id="tocslogsettingsnamespacedto"></a>

```json
{
  "logLevel": "Trace",
  "namespace": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|logLevel|[LogLevel](#schemaloglevel)|false|none|none|
|namespace|string¦null|false|none|none|

<h2 id="tocS_LongDataTypeDTO">LongDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemalongdatatypedto"></a>
<a id="schema_LongDataTypeDTO"></a>
<a id="tocSlongdatatypedto"></a>
<a id="tocslongdatatypedto"></a>

```json
{
  "type": "string",
  "unitId": "string",
  "min": 0,
  "max": 0,
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

Long data type value definition. (type:"long")

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|
|unitId|string¦null|false|none|Unit id|
|min|integer(int64)¦null|false|none|Min value|
|max|integer(int64)¦null|false|none|Max value|

<h2 id="tocS_LongToBoolDTO">LongToBoolDTO</h2>
<!-- backwards compatibility -->
<a id="schemalongtobooldto"></a>
<a id="schema_LongToBoolDTO"></a>
<a id="tocSlongtobooldto"></a>
<a id="tocslongtobooldto"></a>

```json
{
  "min": 0,
  "max": 0,
  "minIncluded": true,
  "maxIncluded": true,
  "value": true
}

```

How to map a long to bool

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|min|integer(int64)¦null|false|none|Min value. If no value means infinite|
|max|integer(int64)¦null|false|none|Max value. If no value means infinite|
|minIncluded|boolean|false|none|Min is included or not|
|maxIncluded|boolean|false|none|Max is included or not|
|value|boolean|false|none|Corresponding value|

<h2 id="tocS_LongToEnumDTO">LongToEnumDTO</h2>
<!-- backwards compatibility -->
<a id="schemalongtoenumdto"></a>
<a id="schema_LongToEnumDTO"></a>
<a id="tocSlongtoenumdto"></a>
<a id="tocslongtoenumdto"></a>

```json
{
  "min": 0,
  "max": 0,
  "minIncluded": true,
  "maxIncluded": true,
  "value": 0
}

```

How to map a long to an enum

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|min|integer(int64)¦null|false|none|Min value. If no value means infinite|
|max|integer(int64)¦null|false|none|Max value. If no value means infinite|
|minIncluded|boolean|false|none|Min is included or not|
|maxIncluded|boolean|false|none|Max is included or not|
|value|integer(int64)|false|none|Corresponding value|

<h2 id="tocS_MapViewAnimationRuntimeDTO">MapViewAnimationRuntimeDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewanimationruntimedto"></a>
<a id="schema_MapViewAnimationRuntimeDTO"></a>
<a id="tocSmapviewanimationruntimedto"></a>
<a id="tocsmapviewanimationruntimedto"></a>

```json
{
  "functionalBlockAnimationRuntimes": [
    {
      "animationId": "string",
      "functionalBlockInstanceId": "string",
      "iconDatapointId": "string",
      "textDatapointId": "string"
    }
  ],
  "functionalBlockAnimationsConfigs": [
    {
      "functionalBlockTemplateId": "string",
      "textAnimation": {
        "id": "string",
        "datapointTemplateId": "string",
        "functionalBlockTemplateId": "string",
        "type": {
          "type": "string",
          "id": "string",
          "name": "string",
          "tag": "string",
          "transport": "none"
        },
        "selectionModeForZone": "All",
        "complexDataTypeFieldName": "string"
      },
      "iconAnimation": {
        "ranges": [
          {
            "value": "string",
            "min": 0,
            "minIncluded": true,
            "max": 0,
            "maxIncluded": true
          }
        ],
        "animationType": "Float",
        "defaultValue": "string",
        "id": "string",
        "datapointTemplateId": "string",
        "functionalBlockTemplateId": "string",
        "type": {
          "type": "string",
          "id": "string",
          "name": "string",
          "tag": "string",
          "transport": "none"
        },
        "selectionModeForZone": "All",
        "complexDataTypeFieldName": "string"
      },
      "selectionMode": "All",
      "name": "string",
      "showAlarms": true,
      "active": true,
      "id": "string"
    }
  ],
  "zoneAnimationRuntimes": [
    {
      "animationId": "string",
      "zoneId": "string",
      "backgroundDatapointId": "string",
      "borderDatapointId": "string",
      "functionalBlocks": [
        "string"
      ]
    }
  ],
  "zoneAnimationConfigs": [
    {
      "zoneTemplateId": "string",
      "backgroundColorAnimation": {
        "ranges": [
          {
            "value": "string",
            "min": 0,
            "minIncluded": true,
            "max": 0,
            "maxIncluded": true
          }
        ],
        "animationType": "Float",
        "defaultValue": "string",
        "id": "string",
        "datapointTemplateId": "string",
        "functionalBlockTemplateId": "string",
        "type": {
          "type": "string",
          "id": "string",
          "name": "string",
          "tag": "string",
          "transport": "none"
        },
        "selectionModeForZone": "All",
        "complexDataTypeFieldName": "string"
      },
      "borderColorAnimation": {
        "ranges": [
          {
            "value": "string",
            "min": 0,
            "minIncluded": true,
            "max": 0,
            "maxIncluded": true
          }
        ],
        "animationType": "Float",
        "defaultValue": "string",
        "id": "string",
        "datapointTemplateId": "string",
        "functionalBlockTemplateId": "string",
        "type": {
          "type": "string",
          "id": "string",
          "name": "string",
          "tag": "string",
          "transport": "none"
        },
        "selectionModeForZone": "All",
        "complexDataTypeFieldName": "string"
      },
      "name": "string",
      "showAlarms": true,
      "active": true,
      "id": "string"
    }
  ]
}

```

Runtime information for the animation of a mapview.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockAnimationRuntimes|[[FunctionalBlockAnimationRuntimeDTO](#schemafunctionalblockanimationruntimedto)]¦null|false|none|Runtime informations for the functional block animations.|
|functionalBlockAnimationsConfigs|[[FunctionalBlockAnimationDTO](#schemafunctionalblockanimationdto)]¦null|false|none|Configurations of the functional block animations.|
|zoneAnimationRuntimes|[[ZoneAnimationRuntimeDTO](#schemazoneanimationruntimedto)]¦null|false|none|Runtime information for the zone animations.|
|zoneAnimationConfigs|[[ZoneAnimationDTO](#schemazoneanimationdto)]¦null|false|none|Configurations of the zone animations.|

<h2 id="tocS_MapViewDTO">MapViewDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewdto"></a>
<a id="schema_MapViewDTO"></a>
<a id="tocSmapviewdto"></a>
<a id="tocsmapviewdto"></a>

```json
{
  "id": "string",
  "maxZoomLevel": 0,
  "ratioXonY": 0,
  "tilesDirectory": "string",
  "fileName": "string",
  "zoneId": "string",
  "geoloc": {
    "key": {
      "x": 0,
      "y": 0
    },
    "value": {
      "x": 0,
      "y": 0
    }
  },
  "scaleMeterForLogicOne": 0,
  "lastFunctionalBlockSizes": {
    "property1": {
      "width": 0,
      "height": 0
    },
    "property2": {
      "width": 0,
      "height": 0
    }
  },
  "delimitArea": [
    [
      {
        "x": 0,
        "y": 0
      }
    ]
  ]
}

```

Definition of a mapview.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the mapview.|
|maxZoomLevel|integer(int32)¦null|false|none|Maximum zoom level of the map.|
|ratioXonY|number(double)¦null|false|none|Aspect ratio of the map. (Width / Height)|
|tilesDirectory|string¦null|false|none|Directory containing the tiles.<br>For information only.|
|fileName|string¦null|false|none|Original name of the image file used to create the map.<br>For information only.|
|zoneId|string¦null|false|none|Unique identifier of the zone instance the mapview is attached to.|
|geoloc|[PointDPointDKeyValuePair](#schemapointdpointdkeyvaluepair)|false|none|none|
|scaleMeterForLogicOne|number(double)¦null|false|none|Length in meters for 1 unit on the map (either horizontally or vertically).|
|lastFunctionalBlockSizes|object¦null|false|none|Last size used for functional blocks.|
|» **additionalProperties**|[SizeD](#schemasized)|false|none|none|
|delimitArea|[array]¦null|false|none|Area covered by the mapview. The area is defined by a collection of polygons.|

<h2 id="tocS_MapViewElementBaseDTO">MapViewElementBaseDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewelementbasedto"></a>
<a id="schema_MapViewElementBaseDTO"></a>
<a id="tocSmapviewelementbasedto"></a>
<a id="tocsmapviewelementbasedto"></a>

```json
{
  "type": "None",
  "id": "string",
  "zOrder": 0
}

```

Mapview object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ElementType](#schemaelementtype)|true|none|none|
|id|string¦null|false|none|Unique identifier of the mapview object.|
|zOrder|integer(int64)|false|none|Z-order of the element on the mapview.|

<h2 id="tocS_MapViewElementFBDTO">MapViewElementFBDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewelementfbdto"></a>
<a id="schema_MapViewElementFBDTO"></a>
<a id="tocSmapviewelementfbdto"></a>
<a id="tocsmapviewelementfbdto"></a>

```json
{
  "type": "None",
  "functionalBlockId": "string",
  "orientation": 0,
  "position": {
    "x": 0,
    "y": 0
  },
  "size": {
    "width": 0,
    "height": 0
  },
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "assignationDone": true,
  "masterMode": "None",
  "isExternal": true,
  "functionalBlockTemplateId": "string",
  "supportMasterSlave": true,
  "functionalBlockTemplateName": "string",
  "id": "string",
  "zOrder": 0
}

```

Informations for the mapview representation of a functional block.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ElementType](#schemaelementtype)|false|none|none|
|functionalBlockId|string¦null|false|none|Unique identifier of the functional block instance.|
|orientation|number(double)|false|none|Orientation of the logo.|
|position|[PointD](#schemapointd)|false|none|none|
|size|[SizeD](#schemasized)|false|none|none|
|name|string¦null|false|none|Functional block name.|
|icon|string¦null|false|none|Icon.|
|iconFillColor|string¦null|false|none|Filler color for icon.|
|assignationDone|boolean¦null|false|none|True if assignation is done.|
|masterMode|[MasterMode](#schemamastermode)|false|none|none|
|isExternal|boolean|false|none|From external source.|
|functionalBlockTemplateId|string¦null|false|none|Id of the functional block template.|
|supportMasterSlave|boolean|false|none|Support master/slave.|
|functionalBlockTemplateName|string¦null|false|none|Name of functional block template.|

<h2 id="tocS_MapViewElementImageDTO">MapViewElementImageDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewelementimagedto"></a>
<a id="schema_MapViewElementImageDTO"></a>
<a id="tocSmapviewelementimagedto"></a>
<a id="tocsmapviewelementimagedto"></a>

```json
{
  "type": "None",
  "orientation": 0,
  "position": {
    "x": 0,
    "y": 0
  },
  "size": {
    "width": 0,
    "height": 0
  },
  "uri": "string",
  "backgroundColor": "string",
  "borderColor": "string",
  "id": "string",
  "zOrder": 0
}

```

Informations for the mapview representation of an image.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ElementType](#schemaelementtype)|false|none|none|
|orientation|number(double)|false|none|Orientation of the image.|
|position|[PointD](#schemapointd)|false|none|none|
|size|[SizeD](#schemasized)|false|none|none|
|uri|string¦null|false|none|URL to the image.|
|backgroundColor|string¦null|false|none|Background color.|
|borderColor|string¦null|false|none|Border color.|

<h2 id="tocS_MapViewElementTextDTO">MapViewElementTextDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewelementtextdto"></a>
<a id="schema_MapViewElementTextDTO"></a>
<a id="tocSmapviewelementtextdto"></a>
<a id="tocsmapviewelementtextdto"></a>

```json
{
  "type": "None",
  "orientation": 0,
  "position": {
    "x": 0,
    "y": 0
  },
  "size": {
    "width": 0,
    "height": 0
  },
  "text": "string",
  "fontStyle": "Regular",
  "fontColor": "string",
  "backgroundColor": "string",
  "borderColor": "string",
  "id": "string",
  "zOrder": 0
}

```

Informations for the mapview representation of a text.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ElementType](#schemaelementtype)|false|none|none|
|orientation|number(double)|false|none|Orientation of the text.|
|position|[PointD](#schemapointd)|false|none|none|
|size|[SizeD](#schemasized)|false|none|none|
|text|string¦null|false|none|Text shown on the mapview.|
|fontStyle|[FontStyle](#schemafontstyle)|false|none|none|
|fontColor|string¦null|false|none|Text color.|
|backgroundColor|string¦null|false|none|Background color.|
|borderColor|string¦null|false|none|Border color.|

<h2 id="tocS_MapViewElementZoneDTO">MapViewElementZoneDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewelementzonedto"></a>
<a id="schema_MapViewElementZoneDTO"></a>
<a id="tocSmapviewelementzonedto"></a>
<a id="tocsmapviewelementzonedto"></a>

```json
{
  "type": "None",
  "zoneId": "string",
  "borderColor": "string",
  "fillColor": "string",
  "points": [
    {
      "x": 0,
      "y": 0
    }
  ],
  "name": "string",
  "isExternal": true,
  "zoneTemplateId": "string",
  "icon": "string",
  "iconFillColor": "string",
  "zoneTemplateName": "string",
  "id": "string",
  "zOrder": 0
}

```

Informations for the mapview representation of a zone.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ElementType](#schemaelementtype)|false|none|none|
|zoneId|string¦null|false|none|Unique identifier of the zone.|
|borderColor|string¦null|false|none|Border color.|
|fillColor|string¦null|false|none|Fill color.|
|points|[[PointD](#schemapointd)]¦null|false|none|Points.|
|name|string¦null|false|none|Name.|
|isExternal|boolean|false|none|From external source.|
|zoneTemplateId|string¦null|false|none|Zone template ID.|
|icon|string¦null|false|none|Icon.|
|iconFillColor|string¦null|false|none|Icon fill color.|
|zoneTemplateName|string¦null|false|none|Name of zone template.|

<h2 id="tocS_MapViewProjectImportDTO">MapViewProjectImportDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewprojectimportdto"></a>
<a id="schema_MapViewProjectImportDTO"></a>
<a id="tocSmapviewprojectimportdto"></a>
<a id="tocsmapviewprojectimportdto"></a>

```json
{
  "id": "string",
  "maxZoomLevel": 0,
  "ratioXonY": 0,
  "tilesDirectory": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|maxZoomLevel|integer(int64)|false|none|none|
|ratioXonY|number(double)|false|none|none|
|tilesDirectory|string¦null|false|none|none|

<h2 id="tocS_MapViewSetDTO">MapViewSetDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewsetdto"></a>
<a id="schema_MapViewSetDTO"></a>
<a id="tocSmapviewsetdto"></a>
<a id="tocsmapviewsetdto"></a>

```json
{
  "zoneId": "string",
  "geoloc": {
    "key": {
      "x": 0,
      "y": 0
    },
    "value": {
      "x": 0,
      "y": 0
    }
  },
  "scaleMeterForLogicOne": 0,
  "lastFunctionalBlockSizes": {
    "property1": {
      "width": 0,
      "height": 0
    },
    "property2": {
      "width": 0,
      "height": 0
    }
  },
  "delimitArea": [
    [
      {
        "x": 0,
        "y": 0
      }
    ]
  ]
}

```

Definition of a mapview.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneId|string¦null|false|none|Unique identifier of the zone instance the mapview is attached to.|
|geoloc|[PointDPointDKeyValuePair](#schemapointdpointdkeyvaluepair)|false|none|none|
|scaleMeterForLogicOne|number(double)¦null|false|none|Length in meters for 1 unit on the map (either horizontally or vertically).|
|lastFunctionalBlockSizes|object¦null|false|none|Last size used for functional blocks.|
|» **additionalProperties**|[SizeD](#schemasized)|false|none|none|
|delimitArea|[array]¦null|false|none|Area covered by the mapview. The area is defined by a collection of polygons.|

<h2 id="tocS_MapViewSubscriptionDTO">MapViewSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemamapviewsubscriptiondto"></a>
<a id="schema_MapViewSubscriptionDTO"></a>
<a id="tocSmapviewsubscriptiondto"></a>
<a id="tocsmapviewsubscriptiondto"></a>

```json
{
  "mapviewIds": [
    "string"
  ],
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|mapviewIds|[string]¦null|false|none|none|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_MasterMode">MasterMode</h2>
<!-- backwards compatibility -->
<a id="schemamastermode"></a>
<a id="schema_MasterMode"></a>
<a id="tocSmastermode"></a>
<a id="tocsmastermode"></a>

```json
"None"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|None|
|*anonymous*|Master|
|*anonymous*|Slave|
|*anonymous*|Single|

<h2 id="tocS_MetaPackageDTO">MetaPackageDTO</h2>
<!-- backwards compatibility -->
<a id="schemametapackagedto"></a>
<a id="schema_MetaPackageDTO"></a>
<a id="tocSmetapackagedto"></a>
<a id="tocsmetapackagedto"></a>

```json
{
  "name": "string",
  "description": "string",
  "icon": "string",
  "constructorIcon": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Package name|
|description|string¦null|false|none|Package description|
|icon|string¦null|false|none|Bitmap icon as a base64|
|constructorIcon|string¦null|false|none|Bitmap constructor icon as a base64|

<h2 id="tocS_MeterDTO">MeterDTO</h2>
<!-- backwards compatibility -->
<a id="schemameterdto"></a>
<a id="schema_MeterDTO"></a>
<a id="tocSmeterdto"></a>
<a id="tocsmeterdto"></a>

```json
{
  "functionalBlockInstance": {
    "datapoints": [
      {
        "stationId": "string",
        "networkId": "string",
        "busUnitId": "string",
        "protocolArguments": {
          "property1": null,
          "property2": null
        },
        "converterId": "string",
        "id": "string",
        "name": "string",
        "direction": "Feedback",
        "typeId": "string",
        "tags": [
          "string"
        ],
        "templateId": "string",
        "functionalBlockId": "string",
        "zoneId": "string",
        "displayUnitId": "string",
        "unitId": "string"
      }
    ],
    "properties": [
      {
        "value": null,
        "userId": "string",
        "roleId": "string",
        "isOverride": true,
        "id": "string",
        "name": "string",
        "direction": "Feedback",
        "typeId": "string",
        "tags": [
          "string"
        ],
        "templateId": "string",
        "functionalBlockId": "string",
        "zoneId": "string",
        "displayUnitId": "string",
        "unitId": "string"
      }
    ],
    "zones": [
      {
        "zoneId": "string",
        "inZone": true
      }
    ],
    "masterMode": "None",
    "id": "string",
    "name": "string",
    "icon": "string",
    "iconFillColor": "string",
    "templateId": "string",
    "specializationType": "string",
    "specializationId": "string",
    "tags": [
      "string"
    ],
    "deviceInstanceId": "string",
    "deviceFunctionalBlockTemplateId": "string",
    "assignationDone": true,
    "isExternal": true
  },
  "meterIds": [
    "string"
  ],
  "id": "string",
  "name": "string",
  "icon": "string",
  "energyId": "string",
  "meterParentId": "string",
  "circuitId": "string",
  "deviceInstanceId": "string",
  "deviceInstanceName": "string",
  "zoneId": "string",
  "zoneName": "string",
  "zoneIcon": "string",
  "assignationDone": true,
  "functionalBlockInstanceId": "string",
  "functionalBlockName": "string",
  "tags": [
    "string"
  ]
}

```

Information about a meter

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockInstance|[FunctionalBlockInstanceDTO](#schemafunctionalblockinstancedto)|false|none|Detailed information of a functional block instance|
|meterIds|[string]¦null|false|none|List of the ids of the sub-meters. May be null if none|
|id|string¦null|false|none|Id of the meter|
|name|string¦null|false|none|Name of the meter|
|icon|string¦null|false|none|Icon of the meter|
|energyId|string¦null|false|none|Id of the primary energy of the meter|
|meterParentId|string¦null|false|none|Id of the parent meter of the meter. May be null if the meter is a root meter|
|circuitId|string¦null|false|none|Id of the circuit the meter is linked to|
|deviceInstanceId|string¦null|false|none|Id of the device instance of the asset linked to the meter comes from. May be null if the meter has been created from a functional block template|
|deviceInstanceName|string¦null|false|none|Name of the device instance of the asset linked to the meter comes from. May be null if the meter has been created from a functional block template|
|zoneId|string¦null|false|none|Id of the zone the meter is linked to. May be null if none|
|zoneName|string¦null|false|none|Name of the zone the meter is linked to. May be null if none|
|zoneIcon|string¦null|false|none|Name of the icon of the zone the meter is linked to. May be null if none|
|assignationDone|boolean|false|none|Indicates if the datapoint linked to the meter is asssigned or not|
|functionalBlockInstanceId|string¦null|false|none|Id of the functional block instance the meter has to be linked to. May be null if the meter must be created from a functional block template|
|functionalBlockName|string¦null|false|none|Name of functional block instance when meter was attached to an existing asset or name of functional block template when asset was created for the meter.|
|tags|[string]¦null|false|none|List of tags attached to the object|

<h2 id="tocS_MeterHierarchyInfoDTO">MeterHierarchyInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemameterhierarchyinfodto"></a>
<a id="schema_MeterHierarchyInfoDTO"></a>
<a id="tocSmeterhierarchyinfodto"></a>
<a id="tocsmeterhierarchyinfodto"></a>

```json
{
  "children": [
    {
      "children": [],
      "id": "string",
      "name": "string",
      "icon": "string",
      "energyId": "string",
      "meterParentId": "string",
      "circuitId": "string",
      "deviceInstanceId": "string",
      "deviceInstanceName": "string",
      "zoneId": "string",
      "zoneName": "string",
      "zoneIcon": "string",
      "assignationDone": true,
      "functionalBlockInstanceId": "string",
      "functionalBlockName": "string",
      "tags": [
        "string"
      ]
    }
  ],
  "id": "string",
  "name": "string",
  "icon": "string",
  "energyId": "string",
  "meterParentId": "string",
  "circuitId": "string",
  "deviceInstanceId": "string",
  "deviceInstanceName": "string",
  "zoneId": "string",
  "zoneName": "string",
  "zoneIcon": "string",
  "assignationDone": true,
  "functionalBlockInstanceId": "string",
  "functionalBlockName": "string",
  "tags": [
    "string"
  ]
}

```

Minimal information about a hierarchy of meters

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|children|[[MeterHierarchyInfoDTO](#schemameterhierarchyinfodto)]¦null|false|none|Minimal information about the sub-meters of the meters. May be null if none|
|id|string¦null|false|none|Id of the meter|
|name|string¦null|false|none|Name of the meter|
|icon|string¦null|false|none|Icon of the meter|
|energyId|string¦null|false|none|Id of the primary energy of the meter|
|meterParentId|string¦null|false|none|Id of the parent meter of the meter. May be null if the meter is a root meter|
|circuitId|string¦null|false|none|Id of the circuit the meter is linked to|
|deviceInstanceId|string¦null|false|none|Id of the device instance of the asset linked to the meter comes from. May be null if the meter has been created from a functional block template|
|deviceInstanceName|string¦null|false|none|Name of the device instance of the asset linked to the meter comes from. May be null if the meter has been created from a functional block template|
|zoneId|string¦null|false|none|Id of the zone the meter is linked to. May be null if none|
|zoneName|string¦null|false|none|Name of the zone the meter is linked to. May be null if none|
|zoneIcon|string¦null|false|none|Name of the icon of the zone the meter is linked to. May be null if none|
|assignationDone|boolean|false|none|Indicates if the datapoint linked to the meter is asssigned or not|
|functionalBlockInstanceId|string¦null|false|none|Id of the functional block instance the meter has to be linked to. May be null if the meter must be created from a functional block template|
|functionalBlockName|string¦null|false|none|Name of functional block instance when meter was attached to an existing asset or name of functional block template when asset was created for the meter.|
|tags|[string]¦null|false|none|List of tags attached to the object|

<h2 id="tocS_MeterInfoDTO">MeterInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemameterinfodto"></a>
<a id="schema_MeterInfoDTO"></a>
<a id="tocSmeterinfodto"></a>
<a id="tocsmeterinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "icon": "string",
  "energyId": "string",
  "meterParentId": "string",
  "circuitId": "string",
  "deviceInstanceId": "string",
  "deviceInstanceName": "string",
  "zoneId": "string",
  "zoneName": "string",
  "zoneIcon": "string",
  "assignationDone": true,
  "functionalBlockInstanceId": "string",
  "functionalBlockName": "string",
  "tags": [
    "string"
  ]
}

```

Minimal information about a meter

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the meter|
|name|string¦null|false|none|Name of the meter|
|icon|string¦null|false|none|Icon of the meter|
|energyId|string¦null|false|none|Id of the primary energy of the meter|
|meterParentId|string¦null|false|none|Id of the parent meter of the meter. May be null if the meter is a root meter|
|circuitId|string¦null|false|none|Id of the circuit the meter is linked to|
|deviceInstanceId|string¦null|false|none|Id of the device instance of the asset linked to the meter comes from. May be null if the meter has been created from a functional block template|
|deviceInstanceName|string¦null|false|none|Name of the device instance of the asset linked to the meter comes from. May be null if the meter has been created from a functional block template|
|zoneId|string¦null|false|none|Id of the zone the meter is linked to. May be null if none|
|zoneName|string¦null|false|none|Name of the zone the meter is linked to. May be null if none|
|zoneIcon|string¦null|false|none|Name of the icon of the zone the meter is linked to. May be null if none|
|assignationDone|boolean|false|none|Indicates if the datapoint linked to the meter is asssigned or not|
|functionalBlockInstanceId|string¦null|false|none|Id of the functional block instance the meter has to be linked to. May be null if the meter must be created from a functional block template|
|functionalBlockName|string¦null|false|none|Name of functional block instance when meter was attached to an existing asset or name of functional block template when asset was created for the meter.|
|tags|[string]¦null|false|none|List of tags attached to the object|

<h2 id="tocS_MeterSetDTO">MeterSetDTO</h2>
<!-- backwards compatibility -->
<a id="schemametersetdto"></a>
<a id="schema_MeterSetDTO"></a>
<a id="tocSmetersetdto"></a>
<a id="tocsmetersetdto"></a>

```json
{
  "functionalBlockTemplateId": "string",
  "inputDistributionId": "string",
  "inputCircuitIndex": 0,
  "id": "string",
  "name": "string",
  "icon": "string",
  "energyId": "string",
  "meterParentId": "string",
  "circuitId": "string",
  "deviceInstanceId": "string",
  "deviceInstanceName": "string",
  "zoneId": "string",
  "zoneName": "string",
  "zoneIcon": "string",
  "assignationDone": true,
  "functionalBlockInstanceId": "string",
  "functionalBlockName": "string",
  "tags": [
    "string"
  ]
}

```

Information about a meter to create

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockTemplateId|string¦null|false|none|Id of the functional block template the meter has to be created from. May be null if the meter must be created from a functional block instance|
|inputDistributionId|string¦null|false|none|Used to create a meter on the input circuit of a distribution.<br>In such case set InputDistributionId with id of distribution, InputCircuitIndex with index of input circuit and set MeterInfoDTO.CircuitId empty|
|inputCircuitIndex|integer(int64)|false|none|Used to create a meter on the input circuit of a distribution.<br>In such case set InputDistributionId with id of distribution, InputCircuitIndex with index of input circuit and set MeterInfoDTO.CircuitId empty|
|id|string¦null|false|none|Id of the meter|
|name|string¦null|false|none|Name of the meter|
|icon|string¦null|false|none|Icon of the meter|
|energyId|string¦null|false|none|Id of the primary energy of the meter|
|meterParentId|string¦null|false|none|Id of the parent meter of the meter. May be null if the meter is a root meter|
|circuitId|string¦null|false|none|Id of the circuit the meter is linked to|
|deviceInstanceId|string¦null|false|none|Id of the device instance of the asset linked to the meter comes from. May be null if the meter has been created from a functional block template|
|deviceInstanceName|string¦null|false|none|Name of the device instance of the asset linked to the meter comes from. May be null if the meter has been created from a functional block template|
|zoneId|string¦null|false|none|Id of the zone the meter is linked to. May be null if none|
|zoneName|string¦null|false|none|Name of the zone the meter is linked to. May be null if none|
|zoneIcon|string¦null|false|none|Name of the icon of the zone the meter is linked to. May be null if none|
|assignationDone|boolean|false|none|Indicates if the datapoint linked to the meter is asssigned or not|
|functionalBlockInstanceId|string¦null|false|none|Id of the functional block instance the meter has to be linked to. May be null if the meter must be created from a functional block template|
|functionalBlockName|string¦null|false|none|Name of functional block instance when meter was attached to an existing asset or name of functional block template when asset was created for the meter.|
|tags|[string]¦null|false|none|List of tags attached to the object|

<h2 id="tocS_MethodResultDTO">MethodResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemamethodresultdto"></a>
<a id="schema_MethodResultDTO"></a>
<a id="tocSmethodresultdto"></a>
<a id="tocsmethodresultdto"></a>

```json
{
  "returns": [
    {
      "id": "string",
      "value": null,
      "identifier": "string"
    }
  ],
  "knownResult": null
}

```

Result from a asynchronous call to a XDriver method.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|returns|[[DriverPropertyValueDTO](#schemadriverpropertyvaluedto)]¦null|false|none|Values of the properties for the result.|
|knownResult|any|false|none|Raw result data.|

<h2 id="tocS_MiddlewareQuality">MiddlewareQuality</h2>
<!-- backwards compatibility -->
<a id="schemamiddlewarequality"></a>
<a id="schema_MiddlewareQuality"></a>
<a id="tocSmiddlewarequality"></a>
<a id="tocsmiddlewarequality"></a>

```json
"none"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|none|
|*anonymous*|uncertain|
|*anonymous*|good|
|*anonymous*|bad|
|*anonymous*|mask|
|*anonymous*|notcommissioned|
|*anonymous*|badrequiredformat|
|*anonymous*|badpreparingrawstring|
|*anonymous*|badcatalog|
|*anonymous*|badninotopened|
|*anonymous*|badinternalerror|
|*anonymous*|badopcitemsubscription|
|*anonymous*|badopcgroupsubscription|
|*anonymous*|badopcdisconnected|
|*anonymous*|badcannotberead|
|*anonymous*|badninotfound|
|*anonymous*|badninone|
|*anonymous*|badnierroropen|
|*anonymous*|baddeviceabsent|
|*anonymous*|badConfigurationError|
|*anonymous*|badDeviceFailure|
|*anonymous*|badLastKnownValue|
|*anonymous*|badNotConnected|
|*anonymous*|badOutOfService|
|*anonymous*|badSensorFailure|
|*anonymous*|badWaitingForInitialData|
|*anonymous*|uncertainEUExceeded|
|*anonymous*|uncertainLastUsableValue|
|*anonymous*|uncertainSensorNotAccurate|
|*anonymous*|uncertainSubNormal|
|*anonymous*|badCommFailure|
|*anonymous*|badServerStopped|
|*anonymous*|badInactiveTrend|
|*anonymous*|badDbTransactionTimeout|
|*anonymous*|badDbWrite|
|*anonymous*|badAverage|
|*anonymous*|badunknownproperty|
|*anonymous*|badunknownobject|
|*anonymous*|badsubscriptionfailed|
|*anonymous*|badlicense|
|*anonymous*|badResetTrend|
|*anonymous*|badbitmask|

<h2 id="tocS_MiddlewareSynchroOptionsDTO">MiddlewareSynchroOptionsDTO</h2>
<!-- backwards compatibility -->
<a id="schemamiddlewaresynchrooptionsdto"></a>
<a id="schema_MiddlewareSynchroOptionsDTO"></a>
<a id="tocSmiddlewaresynchrooptionsdto"></a>
<a id="tocsmiddlewaresynchrooptionsdto"></a>

```json
{
  "stationId": "string",
  "full": true,
  "clearMiddleware": true,
  "tag": "string"
}

```

BOS to middleware synchronization parameters for a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|stationId|string¦null|false|none|Unique station identifier|
|full|boolean|false|none|true for full synchronization, false for partial|
|clearMiddleware|boolean|false|none|true to clear middleware database before sychronization|
|tag|string¦null|false|none|Tag to control if the synchronization is finished.|

<h2 id="tocS_MiddlewareTableDTO">MiddlewareTableDTO</h2>
<!-- backwards compatibility -->
<a id="schemamiddlewaretabledto"></a>
<a id="schema_MiddlewareTableDTO"></a>
<a id="tocSmiddlewaretabledto"></a>
<a id="tocsmiddlewaretabledto"></a>

```json
{
  "id": "string",
  "bosId": "string",
  "lastSynchroError": "string",
  "mapping": "string",
  "middlewareId": "string",
  "stationId": "string",
  "type": "string",
  "owner": "BOS",
  "state": "Idle",
  "used": true
}

```

Information about an item of the BOS MiddlewareTable.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the MiddlewareTable item.|
|bosId|string¦null|false|none|Unique database identifier of the BOS entity linked to the MiddlewareTable item.|
|lastSynchroError|string¦null|false|none|Error of last BOS to middleware synchronization, null if none.|
|mapping|string¦null|false|none|Mapping of internal objects of the BOS entity.<br>Internal use only.|
|middlewareId|string¦null|false|none|Unique identifier of the middleware entity.|
|stationId|string¦null|false|none|Unique identifier of the station the entity belongs to.|
|type|string¦null|false|none|Type of the entity (alarm, network, sched, trend, ...)|
|owner|[Owner](#schemaowner)|false|none|none|
|state|[SynchroState](#schemasynchrostate)|false|none|none|
|used|boolean|false|none|Indicates if entity must be synchronized or not.|

<h2 id="tocS_NetworkCreationDTO">NetworkCreationDTO</h2>
<!-- backwards compatibility -->
<a id="schemanetworkcreationdto"></a>
<a id="schema_NetworkCreationDTO"></a>
<a id="tocSnetworkcreationdto"></a>
<a id="tocsnetworkcreationdto"></a>

```json
{
  "name": "string",
  "simulated": true,
  "portId": "string",
  "stationId": "string",
  "driverDescriptorId": "string",
  "propertyValues": [
    {
      "id": "string",
      "value": null,
      "identifier": "string"
    }
  ]
}

```

Definition of a network for creation

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Localized name of the network|
|simulated|boolean|false|none|Indicates if network is simulated or not. If simulated no fieldbus operation will be performed.|
|portId|string¦null|false|none|Unique identifier of the hardware port layout the network is linked to (ie: LAN1/LAN2)|
|stationId|string¦null|false|none|Unique identifier of the station where the network will be created|
|driverDescriptorId|string¦null|false|none|Unique identifier of the driver descriptor the network is linked to|
|propertyValues|[[DriverPropertyValueDTO](#schemadriverpropertyvaluedto)]¦null|false|none|List of property values of the network.|

<h2 id="tocS_NetworkDTO">NetworkDTO</h2>
<!-- backwards compatibility -->
<a id="schemanetworkdto"></a>
<a id="schema_NetworkDTO"></a>
<a id="tocSnetworkdto"></a>
<a id="tocsnetworkdto"></a>

```json
{
  "id": "string",
  "name": "string",
  "simulated": true,
  "portId": "string",
  "stationId": "string",
  "driverDescriptorId": "string",
  "status": "Ok",
  "propertyValues": [
    {
      "id": "string",
      "value": null,
      "identifier": "string"
    }
  ],
  "organizationId": "string",
  "temporaryOrganizationId": "string"
}

```

Definition of a network for read

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the network|
|name|string¦null|false|none|Localized name of the network|
|simulated|boolean|false|none|Indicates if network is simulated or not|
|portId|string¦null|false|none|Unique identifier of the hardware port layout the network is linked to|
|stationId|string¦null|false|none|Unique identifier of the station the network belongs to|
|driverDescriptorId|string¦null|false|none|Unique identifier of the driver descriptor the network is linked to|
|status|[NetworkStatus](#schemanetworkstatus)|false|none|none|
|propertyValues|[[DriverPropertyValueDTO](#schemadriverpropertyvaluedto)]¦null|false|none|List of property values of the network|
|organizationId|string¦null|false|none|Unique identifier of the network organization of the network|
|temporaryOrganizationId|string¦null|false|none|Unique identifier of the temporary network organization of the network|

<h2 id="tocS_NetworkOrganizationApplyDTO">NetworkOrganizationApplyDTO</h2>
<!-- backwards compatibility -->
<a id="schemanetworkorganizationapplydto"></a>
<a id="schema_NetworkOrganizationApplyDTO"></a>
<a id="tocSnetworkorganizationapplydto"></a>
<a id="tocsnetworkorganizationapplydto"></a>

```json
{
  "toIgnoreBranchIds": [
    "string"
  ],
  "subscription": {
    "id": "string",
    "tags": [
      "string"
    ],
    "webhookURL": "string",
    "webhookRetryCount": 0,
    "webhookRetryDelay": 0,
    "webhookPersist": true,
    "connectionId": "string",
    "returnInternalFormat": true,
    "webhookLeaseTime": 0
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|toIgnoreBranchIds|[string]¦null|false|none|none|
|subscription|[SubscriptionDTO](#schemasubscriptiondto)|false|none|none|

<h2 id="tocS_NetworkOrganizationInfoDTO">NetworkOrganizationInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemanetworkorganizationinfodto"></a>
<a id="schema_NetworkOrganizationInfoDTO"></a>
<a id="tocSnetworkorganizationinfodto"></a>
<a id="tocsnetworkorganizationinfodto"></a>

```json
{
  "version": "string"
}

```

Information about a network organization

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|version|string¦null|false|none|Version of the network organization|

<h2 id="tocS_NetworkOrganizationMergeDTO">NetworkOrganizationMergeDTO</h2>
<!-- backwards compatibility -->
<a id="schemanetworkorganizationmergedto"></a>
<a id="schema_NetworkOrganizationMergeDTO"></a>
<a id="tocSnetworkorganizationmergedto"></a>
<a id="tocsnetworkorganizationmergedto"></a>

```json
{
  "toIgnoreBranchIds": [
    "string"
  ],
  "subscription": {
    "id": "string",
    "tags": [
      "string"
    ],
    "webhookURL": "string",
    "webhookRetryCount": 0,
    "webhookRetryDelay": 0,
    "webhookPersist": true,
    "connectionId": "string",
    "returnInternalFormat": true,
    "webhookLeaseTime": 0
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|toIgnoreBranchIds|[string]¦null|false|none|none|
|subscription|[SubscriptionDTO](#schemasubscriptiondto)|false|none|none|

<h2 id="tocS_NetworkOrganizationUpdateDTO">NetworkOrganizationUpdateDTO</h2>
<!-- backwards compatibility -->
<a id="schemanetworkorganizationupdatedto"></a>
<a id="schema_NetworkOrganizationUpdateDTO"></a>
<a id="tocSnetworkorganizationupdatedto"></a>
<a id="tocsnetworkorganizationupdatedto"></a>

```json
{
  "branches": [
    {
      "id": "string",
      "name": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    }
  ],
  "busDatapoints": [
    {
      "id": "string",
      "name": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    }
  ]
}

```

Definition of a network organization for update

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|branches|[[BranchUpdateDTO](#schemabranchupdatedto)]¦null|false|none|Definition of branches|
|busDatapoints|[[BusDatapointUpdateDTO](#schemabusdatapointupdatedto)]¦null|false|none|Definition of field bus datapoints|

<h2 id="tocS_NetworkStatus">NetworkStatus</h2>
<!-- backwards compatibility -->
<a id="schemanetworkstatus"></a>
<a id="schema_NetworkStatus"></a>
<a id="tocSnetworkstatus"></a>
<a id="tocsnetworkstatus"></a>

```json
"Ok"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Ok|
|*anonymous*|XDriverVersionNotCompliant|
|*anonymous*|XDriverMissing|
|*anonymous*|InternalError|

<h2 id="tocS_NetworkSynchroErrorDTO">NetworkSynchroErrorDTO</h2>
<!-- backwards compatibility -->
<a id="schemanetworksynchroerrordto"></a>
<a id="schema_NetworkSynchroErrorDTO"></a>
<a id="tocSnetworksynchroerrordto"></a>
<a id="tocsnetworksynchroerrordto"></a>

```json
{
  "stationId": "string",
  "id": "string",
  "error": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|stationId|string¦null|false|none|none|
|id|string¦null|false|none|none|
|error|string¦null|false|none|none|

<h2 id="tocS_NetworkUpdateDTO">NetworkUpdateDTO</h2>
<!-- backwards compatibility -->
<a id="schemanetworkupdatedto"></a>
<a id="schema_NetworkUpdateDTO"></a>
<a id="tocSnetworkupdatedto"></a>
<a id="tocsnetworkupdatedto"></a>

```json
{
  "id": "string",
  "name": "string",
  "simulated": true,
  "propertyValues": [
    {
      "id": "string",
      "value": null,
      "identifier": "string"
    }
  ]
}

```

Definition of a network for update

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the network|
|name|string¦null|false|none|Localized name of the network|
|simulated|boolean|false|none|Indicates if network is simulated or not|
|propertyValues|[[DriverPropertyValueDTO](#schemadriverpropertyvaluedto)]¦null|false|none|List of property values of the network|

<h2 id="tocS_NetworkWizardDTO">NetworkWizardDTO</h2>
<!-- backwards compatibility -->
<a id="schemanetworkwizarddto"></a>
<a id="schema_NetworkWizardDTO"></a>
<a id="tocSnetworkwizarddto"></a>
<a id="tocsnetworkwizarddto"></a>

```json
{
  "id": "string",
  "applied": true,
  "name": "string",
  "portId": "string",
  "routing": true,
  "address": {
    "address": "string",
    "port": 0
  },
  "isSecured": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|applied|boolean|false|none|none|
|name|string¦null|false|none|none|
|portId|string¦null|false|none|none|
|routing|boolean|false|none|none|
|address|[IPEndPointDTO](#schemaipendpointdto)|false|none|none|
|isSecured|boolean|false|none|none|

<h2 id="tocS_OccupancyHeatmapEntryDTO">OccupancyHeatmapEntryDTO</h2>
<!-- backwards compatibility -->
<a id="schemaoccupancyheatmapentrydto"></a>
<a id="schema_OccupancyHeatmapEntryDTO"></a>
<a id="tocSoccupancyheatmapentrydto"></a>
<a id="tocsoccupancyheatmapentrydto"></a>

```json
{
  "day": "2019-08-24T14:15:22Z",
  "numberOfMinutesOccupied": 0
}

```

Represents the occupency of a room for a specific day.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|day|string(date-time)|false|none|Day represented by this entry.|
|numberOfMinutesOccupied|integer(int64)|false|none|Number of minutes the room was occupied.|

<h2 id="tocS_Owner">Owner</h2>
<!-- backwards compatibility -->
<a id="schemaowner"></a>
<a id="schema_Owner"></a>
<a id="tocSowner"></a>
<a id="tocsowner"></a>

```json
"BOS"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|BOS|
|*anonymous*|Middleware|

<h2 id="tocS_ParentScheduleDTO">ParentScheduleDTO</h2>
<!-- backwards compatibility -->
<a id="schemaparentscheduledto"></a>
<a id="schema_ParentScheduleDTO"></a>
<a id="tocSparentscheduledto"></a>
<a id="tocsparentscheduledto"></a>

```json
{
  "zoneInstanceId": "string",
  "zoneInstanceName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneInstanceId|string¦null|false|none|Zone instance Id of the schedule|
|zoneInstanceName|string¦null|false|none|Name of the zone instance of the schedule|

<h2 id="tocS_PendingSynchronization">PendingSynchronization</h2>
<!-- backwards compatibility -->
<a id="schemapendingsynchronization"></a>
<a id="schema_PendingSynchronization"></a>
<a id="tocSpendingsynchronization"></a>
<a id="tocspendingsynchronization"></a>

```json
"Done"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Done|
|*anonymous*|Incremental|
|*anonymous*|Full|
|*anonymous*|None|

<h2 id="tocS_PhysicalDeviceDTO">PhysicalDeviceDTO</h2>
<!-- backwards compatibility -->
<a id="schemaphysicaldevicedto"></a>
<a id="schema_PhysicalDeviceDTO"></a>
<a id="tocSphysicaldevicedto"></a>
<a id="tocsphysicaldevicedto"></a>

```json
{
  "id": "string",
  "name": "string",
  "deviceInstanceId": "string",
  "deviceTemplateId": "string",
  "manual": true,
  "networkOrganizationBranchId": "string",
  "assignationCounter": 0,
  "networkId": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

Physical device

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier|
|name|string¦null|false|none|Name|
|deviceInstanceId|string¦null|false|none|Id of the device instance it is attached too.<br>Null if none.|
|deviceTemplateId|string¦null|false|none|Id of the device template of the device instance it is attached too.<br>Null if none.|
|manual|boolean|false|none|True if this physical device was created by a rest client or internally.|
|networkOrganizationBranchId|string¦null|false|none|Unique identifier of the branch linked to this device in the device organization.<br>null if this device is not present in the network organization of its network.|
|assignationCounter|integer(int64)|false|none|Number of time this device has been assigned manually to a datapoint instance|
|networkId|string¦null|false|none|Id of the network of the device|
|protocolArguments|object¦null|false|none|Protocol arguments|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_PhysicalDeviceEditDTO">PhysicalDeviceEditDTO</h2>
<!-- backwards compatibility -->
<a id="schemaphysicaldeviceeditdto"></a>
<a id="schema_PhysicalDeviceEditDTO"></a>
<a id="tocSphysicaldeviceeditdto"></a>
<a id="tocsphysicaldeviceeditdto"></a>

```json
{
  "id": "string",
  "name": "string",
  "networkId": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

Physical device for update or insert

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier|
|name|string¦null|false|none|Name|
|networkId|string¦null|false|none|Id of the network of the device|
|protocolArguments|object¦null|false|none|Protocol arguments|
|» **additionalProperties**|any|false|none|none|

<h2 id="tocS_PhysicalPointDTO">PhysicalPointDTO</h2>
<!-- backwards compatibility -->
<a id="schemaphysicalpointdto"></a>
<a id="schema_PhysicalPointDTO"></a>
<a id="tocSphysicalpointdto"></a>
<a id="tocsphysicalpointdto"></a>

```json
{
  "name": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  },
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  }
}

```

Represents a physical point

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the physical point|
|protocolArguments|object¦null|false|none|Protocal arguments|
|» **additionalProperties**|any|false|none|none|
|type|any|false|none|Data type value definition|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

<h2 id="tocS_PointD">PointD</h2>
<!-- backwards compatibility -->
<a id="schemapointd"></a>
<a id="schema_PointD"></a>
<a id="tocSpointd"></a>
<a id="tocspointd"></a>

```json
{
  "x": 0,
  "y": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|x|number(double)|false|none|none|
|y|number(double)|false|none|none|

<h2 id="tocS_PointDPointDKeyValuePair">PointDPointDKeyValuePair</h2>
<!-- backwards compatibility -->
<a id="schemapointdpointdkeyvaluepair"></a>
<a id="schema_PointDPointDKeyValuePair"></a>
<a id="tocSpointdpointdkeyvaluepair"></a>
<a id="tocspointdpointdkeyvaluepair"></a>

```json
{
  "key": {
    "x": 0,
    "y": 0
  },
  "value": {
    "x": 0,
    "y": 0
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|key|[PointD](#schemapointd)|false|none|none|
|value|[PointD](#schemapointd)|false|none|none|

<h2 id="tocS_PortType">PortType</h2>
<!-- backwards compatibility -->
<a id="schemaporttype"></a>
<a id="schema_PortType"></a>
<a id="tocSporttype"></a>
<a id="tocsporttype"></a>

```json
"None"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|None|
|*anonymous*|IP|
|*anonymous*|Serial|

<h2 id="tocS_ProblemDetails">ProblemDetails</h2>
<!-- backwards compatibility -->
<a id="schemaproblemdetails"></a>
<a id="schema_ProblemDetails"></a>
<a id="tocSproblemdetails"></a>
<a id="tocsproblemdetails"></a>

```json
{
  "type": "string",
  "title": "string",
  "status": 0,
  "detail": "string",
  "instance": "string",
  "property1": null,
  "property2": null
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|**additionalProperties**|any|false|none|none|
|type|string¦null|false|none|none|
|title|string¦null|false|none|none|
|status|integer(int32)¦null|false|none|none|
|detail|string¦null|false|none|none|
|instance|string¦null|false|none|none|

<h2 id="tocS_ProjectApplicationHistoricalDTO">ProjectApplicationHistoricalDTO</h2>
<!-- backwards compatibility -->
<a id="schemaprojectapplicationhistoricaldto"></a>
<a id="schema_ProjectApplicationHistoricalDTO"></a>
<a id="tocSprojectapplicationhistoricaldto"></a>
<a id="tocsprojectapplicationhistoricaldto"></a>

```json
{
  "id": "string",
  "date": "2019-08-24T14:15:22Z",
  "userName": "string",
  "userId": "string",
  "status": "Inprogress",
  "sendNotification": true,
  "logFile": "string",
  "note": "string",
  "applicationName": "string"
}

```

Contains historical of project application

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the historical|
|date|string(date-time)|false|none|Date of last application status|
|userName|string¦null|false|none|Name of user who launches the application|
|userId|string¦null|false|none|Identifier of user who launches the application|
|status|[ProjectApplicationStatus](#schemaprojectapplicationstatus)|false|none|none|
|sendNotification|boolean|false|none|True if have to send notification when a user has created a subscription on application progress|
|logFile|string¦null|false|none|Path of log file|
|note|string¦null|false|none|End user's note|
|applicationName|string¦null|false|none|Name of application that started the migration|

<h2 id="tocS_ProjectApplicationStatus">ProjectApplicationStatus</h2>
<!-- backwards compatibility -->
<a id="schemaprojectapplicationstatus"></a>
<a id="schema_ProjectApplicationStatus"></a>
<a id="tocSprojectapplicationstatus"></a>
<a id="tocsprojectapplicationstatus"></a>

```json
"Inprogress"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Inprogress|
|*anonymous*|Complete|
|*anonymous*|Error|
|*anonymous*|Canceled|

<h2 id="tocS_ProjectApplicationSubscriptionDTO">ProjectApplicationSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemaprojectapplicationsubscriptiondto"></a>
<a id="schema_ProjectApplicationSubscriptionDTO"></a>
<a id="tocSprojectapplicationsubscriptiondto"></a>
<a id="tocsprojectapplicationsubscriptiondto"></a>

```json
{
  "applicationName": "string",
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|applicationName|string¦null|false|none|none|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_ProjectDesc">ProjectDesc</h2>
<!-- backwards compatibility -->
<a id="schemaprojectdesc"></a>
<a id="schema_ProjectDesc"></a>
<a id="tocSprojectdesc"></a>
<a id="tocsprojectdesc"></a>

```json
{
  "projectName": "string",
  "projectId": "string",
  "importId": "string",
  "globalVersion": 0,
  "userLevel": "Integrator",
  "mngPackageName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|projectName|string¦null|false|none|none|
|projectId|string¦null|false|none|none|
|importId|string¦null|false|none|none|
|globalVersion|integer(int64)|false|none|none|
|userLevel|[ImportUserLevel](#schemaimportuserlevel)|false|none|none|
|mngPackageName|string¦null|false|none|none|

<h2 id="tocS_ProjectLocalizationDataDTO">ProjectLocalizationDataDTO</h2>
<!-- backwards compatibility -->
<a id="schemaprojectlocalizationdatadto"></a>
<a id="schema_ProjectLocalizationDataDTO"></a>
<a id="tocSprojectlocalizationdatadto"></a>
<a id="tocsprojectlocalizationdatadto"></a>

```json
{
  "culture": "string",
  "timeZone": "string",
  "currentTime": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|culture|string¦null|false|none|none|
|timeZone|string¦null|false|none|none|
|currentTime|string(date-time)|false|none|none|

<h2 id="tocS_ProjectSettingsDTO">ProjectSettingsDTO</h2>
<!-- backwards compatibility -->
<a id="schemaprojectsettingsdto"></a>
<a id="schema_ProjectSettingsDTO"></a>
<a id="tocSprojectsettingsdto"></a>
<a id="tocsprojectsettingsdto"></a>

```json
{
  "firstTimeConnection": true,
  "projectName": "string",
  "deviceDetails": "string",
  "intervalSynchroCloudUserOnChangeInSeconds": 0,
  "intervalSynchroCloudUserOnErrorInSeconds": 0,
  "isDeviceSynchronized": true,
  "isFactoryResetSynchronized": true,
  "lastRestore": "2019-08-24T14:15:22Z",
  "lastBackup": "2019-08-24T14:15:22Z",
  "culture": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|firstTimeConnection|boolean|false|none|none|
|projectName|string¦null|false|none|none|
|deviceDetails|string¦null|false|none|none|
|intervalSynchroCloudUserOnChangeInSeconds|integer(int32)|false|none|none|
|intervalSynchroCloudUserOnErrorInSeconds|integer(int32)|false|none|none|
|isDeviceSynchronized|boolean|false|none|none|
|isFactoryResetSynchronized|boolean|false|none|none|
|lastRestore|string(date-time)¦null|false|none|none|
|lastBackup|string(date-time)¦null|false|none|none|
|culture|string¦null|false|none|none|

<h2 id="tocS_PropertyDatapointInstanceDTO">PropertyDatapointInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemapropertydatapointinstancedto"></a>
<a id="schema_PropertyDatapointInstanceDTO"></a>
<a id="tocSpropertydatapointinstancedto"></a>
<a id="tocspropertydatapointinstancedto"></a>

```json
{
  "value": null,
  "userId": "string",
  "roleId": "string",
  "isOverride": true,
  "id": "string",
  "name": "string",
  "direction": "Feedback",
  "typeId": "string",
  "tags": [
    "string"
  ],
  "templateId": "string",
  "functionalBlockId": "string",
  "zoneId": "string",
  "displayUnitId": "string",
  "unitId": "string"
}

```

Property datapoint instance definition

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|value|any|false|none|Property value|
|userId|string¦null|false|none|User id the properties is attached too (null for none)<br>Readonly (for information only).|
|roleId|string¦null|false|none|Role id the properties is attached too (null for none)<br>Readonly (for information only).|
|isOverride|boolean|false|none|Indicates if the value overrides the template default value|
|id|string¦null|false|none|Id|
|name|string¦null|false|none|Name of datapoint<br>This field is readonly and ignored during a put/post for a datapoint instance attached to a datapoint template|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|typeId|string¦null|false|none|Unique identifier DataType<br>This field is readonly and ignored during a put/post for a datapoint instance attached to a datapoint template|
|tags|[string]¦null|false|none|List of tag matching the datapoint<br>This field is readonly and ignored during a put/post for a datapoint instance attached to a datapoint template|
|templateId|string¦null|false|none|Unique identifier of the datapoint template (if any)|
|functionalBlockId|string¦null|false|none|Id of the functionalblock instance the datapoint belongs to.<br>Empty if datapoint does not belong to a functionalblock instance.<br>Readonly (for information only).|
|zoneId|string¦null|false|none|Id of the zone instance the datapoint belongs to.<br>Empty if datapoint does not belong to a zone instance.<br>Readonly (for information only).|
|displayUnitId|string¦null|false|none|Identifier of the display unit|
|unitId|string¦null|false|none|Identifier of the unit of the template of the datapoint<br>Readonly (for information only).|

<h2 id="tocS_PropertyDatapointInstanceValueDTO">PropertyDatapointInstanceValueDTO</h2>
<!-- backwards compatibility -->
<a id="schemapropertydatapointinstancevaluedto"></a>
<a id="schema_PropertyDatapointInstanceValueDTO"></a>
<a id="tocSpropertydatapointinstancevaluedto"></a>
<a id="tocspropertydatapointinstancevaluedto"></a>

```json
{
  "value": null,
  "id": "string"
}

```

DTO for property datapoint instance value

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|value|any|false|none|Property value|
|id|string¦null|false|none|When you send the DTO for a write:<br>For resource path property/value, must be unique id of the property.<br>For resource path property/value/fbsystem, must be [tag of system functional block]--[tag of property]<br>eg: bos:function:system:deviceinfo--bos:info::system:devicename<br><br>When receiving the DTo for a read, Id is always the unique id of the property.|

<h2 id="tocS_PropertyDatapointTemplateDTO">PropertyDatapointTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemapropertydatapointtemplatedto"></a>
<a id="schema_PropertyDatapointTemplateDTO"></a>
<a id="tocSpropertydatapointtemplatedto"></a>
<a id="tocspropertydatapointtemplatedto"></a>

```json
{
  "defaultValue": null,
  "id": "string",
  "name": "string",
  "description": "string",
  "tags": [
    "string"
  ],
  "direction": "Feedback",
  "typeId": "string",
  "displayUnitId": "string",
  "publicId": "string"
}

```

Definition of property datapoint template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|defaultValue|any|false|none|none|
|id|string¦null|false|none|Unique identifier of the datapoint template|
|name|string¦null|false|none|Localized name|
|description|string¦null|false|none|Localized description|
|tags|[string]¦null|false|none|List of tags attached to the datapoint template|
|direction|[DatapointDirection](#schemadatapointdirection)|false|none|none|
|typeId|string¦null|false|none|Data type value unique identifier|
|displayUnitId|string¦null|false|none|Identifier of the display unit|
|publicId|string¦null|false|none|Public Unique identifier for datapoint template (User for Import / Export)|

<h2 id="tocS_PropertyDTO">PropertyDTO</h2>
<!-- backwards compatibility -->
<a id="schemapropertydto"></a>
<a id="schema_PropertyDTO"></a>
<a id="tocSpropertydto"></a>
<a id="tocspropertydto"></a>

```json
{
  "address1": "string",
  "address2": "string",
  "town": "string",
  "country": "string",
  "state": "string",
  "surfaceGross": "string",
  "surfaceNet": "string",
  "people": "string",
  "image": "string",
  "gpsLat": "string",
  "gpsLon": "string",
  "buildings": "string",
  "tenants": "string",
  "owners": "string",
  "propertyManagers": "string",
  "facilityManagers": "string",
  "visitors": "string",
  "administrators": "string",
  "devices": "string",
  "datapoints": [
    {
      "stationId": "string",
      "networkId": "string",
      "busUnitId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "converterId": "string",
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "properties": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "functionalBlocks": [
    {
      "functionalBlockId": "string",
      "group": "string",
      "masterMode": "None",
      "inZone": true
    }
  ],
  "authorized": true,
  "parentIds": [
    "string"
  ],
  "childrenIds": [
    "string"
  ],
  "hasMapView": true,
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "type": "Physical",
  "tags": [
    "string"
  ],
  "propertyZoneType": "Property",
  "isExternal": true
}

```

Represents a property

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|address1|string¦null|false|none|Address of the property|
|address2|string¦null|false|none|Additional address of the property|
|town|string¦null|false|none|Town of the property|
|country|string¦null|false|none|Country of the property|
|state|string¦null|false|none|State of the property|
|surfaceGross|string¦null|false|none|Gross surface|
|surfaceNet|string¦null|false|none|Net surface|
|people|string¦null|false|none|Number of people|
|image|string¦null|false|none|Image|
|gpsLat|string¦null|false|none|GPS latitude|
|gpsLon|string¦null|false|none|GPS longitude|
|buildings|string¦null|false|none|Resource path to query the buildings of the propery|
|tenants|string¦null|false|none|Resource path to query the tenants of the propery|
|owners|string¦null|false|none|Resource path to query the owners of the propery|
|propertyManagers|string¦null|false|none|Resource path to query the property managers of the propery|
|facilityManagers|string¦null|false|none|Resource path to query the facility managers of the propery|
|visitors|string¦null|false|none|Resource path to query the visitors of the propery|
|administrators|string¦null|false|none|Resource path to query the administrators of the propery|
|devices|string¦null|false|none|Resource path to query the devices of the propery|
|datapoints|[[DatapointInstanceDTO](#schemadatapointinstancedto)]¦null|false|none|List of dataPoint instances inherited from datapoint template|
|properties|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|List of properties inherited from property template|
|functionalBlocks|[[FunctionalBlockInstanceOfZoneDTO](#schemafunctionalblockinstanceofzonedto)]¦null|false|none|List of functional block instances attached to the zone|
|authorized|boolean|false|none|If true access is granted to this zone.|
|parentIds|[string]¦null|false|none|List of parent zones attached to the zone|
|childrenIds|[string]¦null|false|none|List of children zone instance definition attached to the created zone<br>(information only)|
|hasMapView|boolean|false|none|True if zone has a mapview attached to it|
|id|string¦null|false|none|Unique identifier of the zone instance|
|name|string¦null|false|none|Localized name of the zone instance|
|icon|string¦null|false|none|Optional image representing the zoneInstance<br>This field is readonly and ignored during a put/post for a zone instance attached to a zone template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the zone instance template (if any)|
|type|[ZoneType](#schemazonetype)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the zone|
|propertyZoneType|[PropertyZoneType](#schemapropertyzonetype)|false|none|Type of a property area|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_PropertyZoneType">PropertyZoneType</h2>
<!-- backwards compatibility -->
<a id="schemapropertyzonetype"></a>
<a id="schema_PropertyZoneType"></a>
<a id="tocSpropertyzonetype"></a>
<a id="tocspropertyzonetype"></a>

```json
"Property"

```

Type of a property area

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Type of a property area|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Property|
|*anonymous*|Building|
|*anonymous*|Structure|
|*anonymous*|Area|
|*anonymous*|Space|
|*anonymous*|Undefined|

<h2 id="tocS_ProtocolArgumentDTO">ProtocolArgumentDTO</h2>
<!-- backwards compatibility -->
<a id="schemaprotocolargumentdto"></a>
<a id="schema_ProtocolArgumentDTO"></a>
<a id="tocSprotocolargumentdto"></a>
<a id="tocsprotocolargumentdto"></a>

```json
{
  "key": "string",
  "levels": "None",
  "mandatories": "None",
  "identity": "None",
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "description": "string",
  "defaultValue": null,
  "displayOrder": 0
}

```

Information about a protocol argument of a driver

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|key|string¦null|false|none|Unique identifier of the protocol argument|
|levels|[ProtocolArgumentLevel](#schemaprotocolargumentlevel)|false|none|none|
|mandatories|[ProtocolArgumentLevel](#schemaprotocolargumentlevel)|false|none|none|
|identity|[ProtocolArgumentLevel](#schemaprotocolargumentlevel)|false|none|none|
|type|any|false|none|Data type value definition|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|description|string¦null|false|none|Description|
|defaultValue|any|false|none|Default value|
|displayOrder|integer(int32)|false|none|Order to display the protocol argument. 1 -> first, 2 -> second, ...<br>0 for not ordered protocol argument.|

<h2 id="tocS_ProtocolArgumentLevel">ProtocolArgumentLevel</h2>
<!-- backwards compatibility -->
<a id="schemaprotocolargumentlevel"></a>
<a id="schema_ProtocolArgumentLevel"></a>
<a id="tocSprotocolargumentlevel"></a>
<a id="tocsprotocolargumentlevel"></a>

```json
"None"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|None|
|*anonymous*|DeviceTemplate|
|*anonymous*|DeviceInstance|
|*anonymous*|FunctionalBlock|
|*anonymous*|Datapoint|
|*anonymous*|All|

<h2 id="tocS_ProtocolArgumentsOnlyIdentifierDTO">ProtocolArgumentsOnlyIdentifierDTO</h2>
<!-- backwards compatibility -->
<a id="schemaprotocolargumentsonlyidentifierdto"></a>
<a id="schema_ProtocolArgumentsOnlyIdentifierDTO"></a>
<a id="tocSprotocolargumentsonlyidentifierdto"></a>
<a id="tocsprotocolargumentsonlyidentifierdto"></a>

```json
{
  "type": 0,
  "networkId": "string",
  "id": "string",
  "protocolArguments": {
    "property1": null,
    "property2": null
  }
}

```

ProtocolArgumentsOnly specific data

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DatapointIdentifierType](#schemadatapointidentifiertype)|false|none|Discriminator of DatapointIdentifier|
|networkId|string¦null|false|none|Identifier of network|

<h2 id="tocS_ProxySettingsDTO">ProxySettingsDTO</h2>
<!-- backwards compatibility -->
<a id="schemaproxysettingsdto"></a>
<a id="schema_ProxySettingsDTO"></a>
<a id="tocSproxysettingsdto"></a>
<a id="tocsproxysettingsdto"></a>

```json
{
  "address": "string",
  "login": "string",
  "password": "string"
}

```

Settings for configuring box proxy

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|address|string¦null|false|none|Address of used http proxy|
|login|string¦null|false|none|Login for http proxy|
|password|string¦null|false|none|Password for http proxy|

<h2 id="tocS_PublicInformationDTO">PublicInformationDTO</h2>
<!-- backwards compatibility -->
<a id="schemapublicinformationdto"></a>
<a id="schema_PublicInformationDTO"></a>
<a id="tocSpublicinformationdto"></a>
<a id="tocspublicinformationdto"></a>

```json
{
  "serialNumber": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|serialNumber|string¦null|false|none|none|

<h2 id="tocS_Quality">Quality</h2>
<!-- backwards compatibility -->
<a id="schemaquality"></a>
<a id="schema_Quality"></a>
<a id="tocSquality"></a>
<a id="tocsquality"></a>

```json
"Uncertain"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Uncertain|
|*anonymous*|Good|
|*anonymous*|Bad|

<h2 id="tocS_RebootDTO">RebootDTO</h2>
<!-- backwards compatibility -->
<a id="schemarebootdto"></a>
<a id="schema_RebootDTO"></a>
<a id="tocSrebootdto"></a>
<a id="tocsrebootdto"></a>

```json
{
  "reason": "string"
}

```

Informations to pass to BOS when rebooting

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|reason|string¦null|false|none|Reboot reason|

<h2 id="tocS_RectangleDTO">RectangleDTO</h2>
<!-- backwards compatibility -->
<a id="schemarectangledto"></a>
<a id="schema_RectangleDTO"></a>
<a id="tocSrectangledto"></a>
<a id="tocsrectangledto"></a>

```json
{
  "x": 0,
  "y": 0,
  "width": 0,
  "height": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|x|integer(int32)|false|none|none|
|y|integer(int32)|false|none|none|
|width|integer(int32)|false|none|none|
|height|integer(int32)|false|none|none|

<h2 id="tocS_RefreshAlarmInstanceDTO">RefreshAlarmInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemarefreshalarminstancedto"></a>
<a id="schema_RefreshAlarmInstanceDTO"></a>
<a id="tocSrefreshalarminstancedto"></a>
<a id="tocsrefreshalarminstancedto"></a>

```json
{
  "alarmTemplateId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|alarmTemplateId|string¦null|false|none|If empty refresh alarm instances for any alarm template that have been changed since the last RefreshAlarm controller call|

<h2 id="tocS_RefreshTokenDTO">RefreshTokenDTO</h2>
<!-- backwards compatibility -->
<a id="schemarefreshtokendto"></a>
<a id="schema_RefreshTokenDTO"></a>
<a id="tocSrefreshtokendto"></a>
<a id="tocsrefreshtokendto"></a>

```json
{
  "connectionIds": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|connectionIds|[string]¦null|false|none|none|

<h2 id="tocS_RefreshTrendInstanceDTO">RefreshTrendInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemarefreshtrendinstancedto"></a>
<a id="schema_RefreshTrendInstanceDTO"></a>
<a id="tocSrefreshtrendinstancedto"></a>
<a id="tocsrefreshtrendinstancedto"></a>

```json
{
  "trendTemplateId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|trendTemplateId|string¦null|false|none|If empty refresh trend instances for any trend template that have been changed since the last RefreshTrend controller call|

<h2 id="tocS_RegionInfoDTO">RegionInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemaregioninfodto"></a>
<a id="schema_RegionInfoDTO"></a>
<a id="tocSregioninfodto"></a>
<a id="tocsregioninfodto"></a>

```json
{
  "name": "string",
  "englishName": "string",
  "isMetric": true,
  "currencySymbol": "string",
  "isoCurrencySymbol": "string",
  "dateFormat": "string",
  "timeFormat": "string",
  "firstDayOfWeek": "Sunday"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the culture|
|englishName|string¦null|false|none|English name of the culture|
|isMetric|boolean|false|none|Indicates if the culture uses the metric system|
|currencySymbol|string¦null|false|none|Currency symbol of the culture|
|isoCurrencySymbol|string¦null|false|none|ISO representation of the currency symbol|
|dateFormat|string¦null|false|none|Date format of the culture|
|timeFormat|string¦null|false|none|Time format of the culture|
|firstDayOfWeek|[DayOfWeek](#schemadayofweek)|false|none|none|

<h2 id="tocS_RemoteOrLocal">RemoteOrLocal</h2>
<!-- backwards compatibility -->
<a id="schemaremoteorlocal"></a>
<a id="schema_RemoteOrLocal"></a>
<a id="tocSremoteorlocal"></a>
<a id="tocsremoteorlocal"></a>

```json
"Remote"

```

Defines local or remote connection

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Defines local or remote connection|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Remote|
|*anonymous*|Local|

<h2 id="tocS_RescueModeDetailDTO">RescueModeDetailDTO</h2>
<!-- backwards compatibility -->
<a id="schemarescuemodedetaildto"></a>
<a id="schema_RescueModeDetailDTO"></a>
<a id="tocSrescuemodedetaildto"></a>
<a id="tocsrescuemodedetaildto"></a>

```json
{
  "noUser": true
}

```

Rescue mode detail

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|noUser|boolean|false|none|true if no user are already present in the database else false|

<h2 id="tocS_RescueModeDTO">RescueModeDTO</h2>
<!-- backwards compatibility -->
<a id="schemarescuemodedto"></a>
<a id="schema_RescueModeDTO"></a>
<a id="tocSrescuemodedto"></a>
<a id="tocsrescuemodedto"></a>

```json
{
  "enabled": true,
  "reason": "string"
}

```

Rescue mode

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|enabled|boolean|false|none|Is BOS currently running in rescue mode|
|reason|string¦null|false|none|Rescue mode reason when enabled|

<h2 id="tocS_RetentionPolicyDTO">RetentionPolicyDTO</h2>
<!-- backwards compatibility -->
<a id="schemaretentionpolicydto"></a>
<a id="schema_RetentionPolicyDTO"></a>
<a id="tocSretentionpolicydto"></a>
<a id="tocsretentionpolicydto"></a>

```json
{
  "id": "string",
  "name": "string",
  "duration": "string",
  "downSamplingOptions": [
    {
      "id": "string",
      "name": "string",
      "alignTime": "string",
      "groupedBy": "string",
      "functions": "TimeWeightedAverage",
      "duration": "string"
    }
  ],
  "tags": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the retention policy|
|name|string¦null|false|none|Localized name of the retention policy|
|duration|string(date-span)|false|none|Retention duration of linked trends|
|downSamplingOptions|[[DownSamplingOptionDTO](#schemadownsamplingoptiondto)]¦null|false|none|Options values of downsampling operations running from this retention policy|
|tags|[string]¦null|false|none|List of tag matching the retention policy|

<h2 id="tocS_RoleDTO">RoleDTO</h2>
<!-- backwards compatibility -->
<a id="schemaroledto"></a>
<a id="schema_RoleDTO"></a>
<a id="tocSroledto"></a>
<a id="tocsroledto"></a>

```json
{
  "id": "string",
  "parentId": "string",
  "name": "string",
  "icon": "string",
  "accessRights": [
    "string"
  ],
  "zoneInstanceIds": [
    "string"
  ],
  "overrideRights": "Inherit",
  "overrideZones": "Inherit",
  "tags": [
    "string"
  ],
  "isReadonly": true,
  "notVisibleInCloudMicroSite": true
}

```

User role definition

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the role|
|parentId|string¦null|false|none|Unique identifier of the parent role|
|name|string¦null|false|none|Localized name of the role|
|icon|string¦null|false|none|BOS icon URI|
|accessRights|[string]¦null|false|none|List of access right identifiers enabled for the role|
|zoneInstanceIds|[string]¦null|false|none|List of zones attached to a role|
|overrideRights|[TypeOverride](#schematypeoverride)|false|none|none|
|overrideZones|[TypeOverride](#schematypeoverride)|false|none|none|
|tags|[string]¦null|false|none|List of tags attached to a role|
|isReadonly|boolean|false|none|Readonly role.<br>Readonly role cannot be deleted and only its name can be changed|
|notVisibleInCloudMicroSite|boolean|false|none|If true this role will not be visible in the cloud micro site.<br>Only root roles are visible in cloud micro site.|

<h2 id="tocS_ScheduleActionDTO">ScheduleActionDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleactiondto"></a>
<a id="schema_ScheduleActionDTO"></a>
<a id="tocSscheduleactiondto"></a>
<a id="tocsscheduleactiondto"></a>

```json
{
  "id": "string",
  "name": "string",
  "isCustom": true,
  "color": "string",
  "valuesCanBeEditedInOperation": true,
  "actionElements": [
    {
      "value": null,
      "priority": 0,
      "type": "string",
      "id": "string",
      "scheduleActionElementDescriptionId": "string"
    }
  ]
}

```

Action of a schedule instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the Schedule action description|
|name|string¦null|false|none|Name of the action|
|isCustom|boolean|false|none|???|
|color|string¦null|false|none|Display color of the action on the User Interface|
|valuesCanBeEditedInOperation|boolean|false|none|Wether values can be editing in the operation view|
|actionElements|[oneOf]¦null|false|none|Action elements of the action|

<h2 id="tocS_ScheduleActionElementDescriptionDTO">ScheduleActionElementDescriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleactionelementdescriptiondto"></a>
<a id="schema_ScheduleActionElementDescriptionDTO"></a>
<a id="tocSscheduleactionelementdescriptiondto"></a>
<a id="tocsscheduleactionelementdescriptiondto"></a>

```json
{
  "scheduleActionElementDescriptionId": "string",
  "displayName": "string"
}

```

Descriptor for a schedule action

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|scheduleActionElementDescriptionId|string¦null|false|none|Id of the Schedule action element description|
|displayName|string¦null|false|none|Display name of the action element|

<h2 id="tocS_ScheduleConfigurationDTO">ScheduleConfigurationDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleconfigurationdto"></a>
<a id="schema_ScheduleConfigurationDTO"></a>
<a id="tocSscheduleconfigurationdto"></a>
<a id="tocsscheduleconfigurationdto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "generalSettings": {
    "exceptionsVisible": true,
    "resetOnUpdate": true,
    "resetOnReboot": true,
    "busRepetitionActive": true,
    "busRepetitionOnErrorOnly": true,
    "busRepetitionTimes": 0,
    "busRepetitionInterval": 0,
    "todayTomorrowVisible": true,
    "allowCustomAction": true
  },
  "actions": [
    {
      "id": "string",
      "name": "string",
      "custom": true,
      "color": "string",
      "valuesCanBeEditedInOperation": true,
      "actionElements": [
        {
          "priority": 0,
          "value": null,
          "type": "TemplateDatapointWriteDTO",
          "id": "string"
        }
      ]
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string|true|none|none|
|id|string¦null|false|none|Id of the schedule configuration|
|name|string¦null|false|none|name of the schedule configuration|
|generalSettings|[ScheduleConfigurationGeneralSettingsDTO](#schemascheduleconfigurationgeneralsettingsdto)|false|none|General settings for a schedule configuration (Template or individual)|
|actions|[[ActionDTO](#schemaactiondto)]¦null|false|none|Actions of the schedule configuration|

<h2 id="tocS_ScheduleConfigurationGeneralSettingsDTO">ScheduleConfigurationGeneralSettingsDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleconfigurationgeneralsettingsdto"></a>
<a id="schema_ScheduleConfigurationGeneralSettingsDTO"></a>
<a id="tocSscheduleconfigurationgeneralsettingsdto"></a>
<a id="tocsscheduleconfigurationgeneralsettingsdto"></a>

```json
{
  "exceptionsVisible": true,
  "resetOnUpdate": true,
  "resetOnReboot": true,
  "busRepetitionActive": true,
  "busRepetitionOnErrorOnly": true,
  "busRepetitionTimes": 0,
  "busRepetitionInterval": 0,
  "todayTomorrowVisible": true,
  "allowCustomAction": true
}

```

General settings for a schedule configuration (Template or individual)

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|exceptionsVisible|boolean|false|none|Indicates whether the schedule exception feature is available on front-end|
|resetOnUpdate|boolean|false|none|Indicates whether an update on scheduler instance will recalculate the action for the current time and execute it.|
|resetOnReboot|boolean|false|none|Indicates whether at startup of openBOS the scheduler instance will recalculate the action for the current time and execute it.|
|busRepetitionActive|boolean|false|none|Indicates whether the current action will be repeated after first occurence.|
|busRepetitionOnErrorOnly|boolean|false|none|Indicates that if the current action is repeated it will be repeated ONLY IF an error has occured during execution|
|busRepetitionTimes|integer(int64)|false|none|Indicates the number of times the current action will be repeated after first occurence.|
|busRepetitionInterval|integer(int64)|false|none|Indicates the interval between repetition of the current action (what is the unit ????).|
|todayTomorrowVisible|boolean|false|none|Indicates whether the Today/Tomorrow feature is available on front-end|
|allowCustomAction|boolean|false|none|Indicates whether the schedule instance will support that the end-user can create an action for this scheduler instance from front-end|

<h2 id="tocS_ScheduleConfigurationInfoDTO">ScheduleConfigurationInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleconfigurationinfodto"></a>
<a id="schema_ScheduleConfigurationInfoDTO"></a>
<a id="tocSscheduleconfigurationinfodto"></a>
<a id="tocsscheduleconfigurationinfodto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string|true|none|none|
|id|string¦null|false|none|unique BOS identifier of the schedule configuration|
|name|string¦null|false|none|Name of the schedule configuration|

<h2 id="tocS_ScheduleConfigurationType">ScheduleConfigurationType</h2>
<!-- backwards compatibility -->
<a id="schemascheduleconfigurationtype"></a>
<a id="schema_ScheduleConfigurationType"></a>
<a id="tocSscheduleconfigurationtype"></a>
<a id="tocsscheduleconfigurationtype"></a>

```json
"TemplateScheduleConfiguration"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|TemplateScheduleConfiguration|
|*anonymous*|IndividualScheduleConfiguration|

<h2 id="tocS_ScheduleDateDTO">ScheduleDateDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduledatedto"></a>
<a id="schema_ScheduleDateDTO"></a>
<a id="tocSscheduledatedto"></a>
<a id="tocsscheduledatedto"></a>

```json
{
  "day": 0,
  "dayOfWeek": "Sunday",
  "month": 0,
  "year": 0,
  "weekOfMonth": 0
}

```

Date entry of a schedule

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|day|integer(int64)¦null|false|none|Day of the entry<br>null if not specified<br>1-31, 32 for last day of month, 33 for odd days, 34 for even days|
|dayOfWeek|[DayOfWeek](#schemadayofweek)|false|none|none|
|month|integer(int64)¦null|false|none|null if not specified<br>1-12, 13 for odd months, 14 for even months|
|year|integer(int64)¦null|false|none|Year of the entry<br>null if not specified<br>Offset from 1900|
|weekOfMonth|integer(int64)¦null|false|none|Week of month of the entry<br>null if not specified<br>1-5, 6 for last week of the month|

<h2 id="tocS_ScheduleDateEntryDayOfWeekDTO">ScheduleDateEntryDayOfWeekDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduledateentrydayofweekdto"></a>
<a id="schema_ScheduleDateEntryDayOfWeekDTO"></a>
<a id="tocSscheduledateentrydayofweekdto"></a>
<a id="tocsscheduledateentrydayofweekdto"></a>

```json
{
  "dayOfWeek": 0,
  "dtoType": "string",
  "id": "string",
  "times": [
    {
      "id": "string",
      "configurationActionId": "string",
      "timestamp": 0
    }
  ],
  "priority": 0
}

```

Entry in a schedule for a recurring specific day of week

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|dayOfWeek|integer(int32)|false|none|Day of week for the date entry|
|dtoType|[ScheduleDateEntryType](#schemascheduledateentrytype)|false|none|none|

<h2 id="tocS_ScheduleDateEntryDTO">ScheduleDateEntryDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduledateentrydto"></a>
<a id="schema_ScheduleDateEntryDTO"></a>
<a id="tocSscheduledateentrydto"></a>
<a id="tocsscheduledateentrydto"></a>

```json
{
  "dtoType": "string",
  "id": "string",
  "times": [
    {
      "id": "string",
      "configurationActionId": "string",
      "timestamp": 0
    }
  ],
  "priority": 0
}

```

Data type value definition

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|dtoType|string|true|none|none|
|id|string¦null|false|none|Id of the date entry|
|times|[[ScheduleTimeEntryDTO](#schemascheduletimeentrydto)]¦null|false|none|List of time entries for the date entry|
|priority|integer(int64)|false|none|Priority of this entry relative to other entries|

<h2 id="tocS_ScheduleDateEntryExceptionDTO">ScheduleDateEntryExceptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduledateentryexceptiondto"></a>
<a id="schema_ScheduleDateEntryExceptionDTO"></a>
<a id="tocSscheduledateentryexceptiondto"></a>
<a id="tocsscheduledateentryexceptiondto"></a>

```json
{
  "type": "SingleDate",
  "dayOfWeek": 0,
  "weekOfMonth": 0,
  "name": "string",
  "start": {
    "day": 0,
    "dayOfWeek": "Sunday",
    "month": 0,
    "year": 0,
    "weekOfMonth": 0
  },
  "end": {
    "day": 0,
    "dayOfWeek": "Sunday",
    "month": 0,
    "year": 0,
    "weekOfMonth": 0
  },
  "dtoType": "string",
  "id": "string",
  "times": [
    {
      "id": "string",
      "configurationActionId": "string",
      "timestamp": 0
    }
  ],
  "priority": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ExceptionType](#schemaexceptiontype)|false|none|none|
|dayOfWeek|integer(int32)¦null|false|none|Day of week for the date|
|weekOfMonth|integer(int32)|false|none|Week number within the month|
|name|string¦null|false|none|Name of the entry|
|start|[ScheduleDateDTO](#schemascheduledatedto)|false|none|Date entry of a schedule|
|end|[ScheduleDateDTO](#schemascheduledatedto)|false|none|Date entry of a schedule|
|dtoType|[ScheduleDateEntryType](#schemascheduledateentrytype)|false|none|none|

<h2 id="tocS_ScheduleDateEntryType">ScheduleDateEntryType</h2>
<!-- backwards compatibility -->
<a id="schemascheduledateentrytype"></a>
<a id="schema_ScheduleDateEntryType"></a>
<a id="tocSscheduledateentrytype"></a>
<a id="tocsscheduledateentrytype"></a>

```json
"DayOfWeek"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|DayOfWeek|
|*anonymous*|Exception|

<h2 id="tocS_ScheduledUpdateInformationDTO">ScheduledUpdateInformationDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduledupdateinformationdto"></a>
<a id="schema_ScheduledUpdateInformationDTO"></a>
<a id="tocSscheduledupdateinformationdto"></a>
<a id="tocsscheduledupdateinformationdto"></a>

```json
{
  "scheduledUpdateTime": "2019-08-24T14:15:22Z",
  "updateStatus": "NoUpdateScheduled",
  "newVersion": "string",
  "updateError": {
    "code": "string",
    "message": "string"
  },
  "downloadProgress": 0,
  "downloadRetryDateTime": "2019-08-24T14:15:22Z",
  "automaticReboot": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|scheduledUpdateTime|string(date-time)¦null|false|none|Contains the time for which an update is scheduled<br>Or null, if no update is scheduled|
|updateStatus|[FirmwareUpdateStatus](#schemafirmwareupdatestatus)|false|none|none|
|newVersion|string¦null|false|none|The version for which an update installation is scheduled|
|updateError|[EmbeddedErrorDTO](#schemaembeddederrordto)|false|none|none|
|downloadProgress|integer(int32)|false|none|none|
|downloadRetryDateTime|string(date-time)¦null|false|none|none|
|automaticReboot|boolean|false|none|none|

<h2 id="tocS_ScheduleEffectiveTimelineDTO">ScheduleEffectiveTimelineDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleeffectivetimelinedto"></a>
<a id="schema_ScheduleEffectiveTimelineDTO"></a>
<a id="tocSscheduleeffectivetimelinedto"></a>
<a id="tocsscheduleeffectivetimelinedto"></a>

```json
{
  "times": [
    {
      "id": "string",
      "configurationActionId": "string",
      "timestamp": 0
    }
  ],
  "configurationActions": [
    {
      "id": "string",
      "name": "string",
      "isCustom": true,
      "color": "string",
      "valuesCanBeEditedInOperation": true,
      "actionElements": [
        {
          "value": null,
          "priority": 0,
          "type": "string",
          "id": "string",
          "scheduleActionElementDescriptionId": "string"
        }
      ]
    }
  ],
  "actionElementDescriptions": [
    {
      "scheduleActionElementDescriptionId": "string",
      "displayName": "string"
    }
  ],
  "priority": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|times|[[ScheduleTimeEntryDTO](#schemascheduletimeentrydto)]¦null|false|none|[Time entry on a schedule timeline]|
|configurationActions|[[ScheduleActionDTO](#schemascheduleactiondto)]¦null|false|none|[Action of a schedule instance]|
|actionElementDescriptions|[[ScheduleActionElementDescriptionDTO](#schemascheduleactionelementdescriptiondto)]¦null|false|none|[Descriptor for a schedule action]|
|priority|integer(int64)|false|none|none|

<h2 id="tocS_ScheduleElementDatapointWriteDTO">ScheduleElementDatapointWriteDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleelementdatapointwritedto"></a>
<a id="schema_ScheduleElementDatapointWriteDTO"></a>
<a id="tocSscheduleelementdatapointwritedto"></a>
<a id="tocsscheduleelementdatapointwritedto"></a>

```json
{
  "value": null,
  "priority": 0,
  "type": "string",
  "id": "string",
  "scheduleActionElementDescriptionId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|value|any|false|none|Value to write for the action element|
|priority|integer(int64)|false|none|Priority of the action element|
|type|[ScheduleElementType](#schemascheduleelementtype)|false|none|none|

<h2 id="tocS_ScheduleElementDTO">ScheduleElementDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleelementdto"></a>
<a id="schema_ScheduleElementDTO"></a>
<a id="tocSscheduleelementdto"></a>
<a id="tocsscheduleelementdto"></a>

```json
{
  "type": "string",
  "id": "string",
  "scheduleActionElementDescriptionId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string|true|none|none|
|id|string¦null|false|none|Id of the element|
|scheduleActionElementDescriptionId|string¦null|false|none|Unique id of the action element description|

<h2 id="tocS_ScheduleElementType">ScheduleElementType</h2>
<!-- backwards compatibility -->
<a id="schemascheduleelementtype"></a>
<a id="schema_ScheduleElementType"></a>
<a id="tocSscheduleelementtype"></a>
<a id="tocsscheduleelementtype"></a>

```json
"ScheduleElementDatapointWrite"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|ScheduleElementDatapointWrite|

<h2 id="tocS_ScheduleEnableDTO">ScheduleEnableDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleenabledto"></a>
<a id="schema_ScheduleEnableDTO"></a>
<a id="tocSscheduleenabledto"></a>
<a id="tocsscheduleenabledto"></a>

```json
{
  "enable": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|enable|boolean|false|none|specifies wether we want to enable or disable a schedule|

<h2 id="tocS_ScheduleInstanceDTO">ScheduleInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleinstancedto"></a>
<a id="schema_ScheduleInstanceDTO"></a>
<a id="tocSscheduleinstancedto"></a>
<a id="tocsscheduleinstancedto"></a>

```json
{
  "timeTable": {
    "id": "string",
    "weeklyTimeTable": [
      {
        "dayOfWeek": 0,
        "dtoType": "string",
        "id": "string",
        "times": [
          {
            "id": "string",
            "configurationActionId": "string",
            "timestamp": 0
          }
        ],
        "priority": 0
      }
    ],
    "exceptions": [
      {
        "type": "SingleDate",
        "dayOfWeek": 0,
        "weekOfMonth": 0,
        "name": "string",
        "start": {
          "day": 0,
          "dayOfWeek": "Sunday",
          "month": 0,
          "year": 0,
          "weekOfMonth": 0
        },
        "end": {
          "day": 0,
          "dayOfWeek": "Sunday",
          "month": 0,
          "year": 0,
          "weekOfMonth": 0
        },
        "dtoType": "string",
        "id": "string",
        "times": [
          {
            "id": "string",
            "configurationActionId": "string",
            "timestamp": 0
          }
        ],
        "priority": 0
      }
    ]
  },
  "configurationActions": [
    {
      "id": "string",
      "name": "string",
      "isCustom": true,
      "color": "string",
      "valuesCanBeEditedInOperation": true,
      "actionElements": [
        {
          "value": null,
          "priority": 0,
          "type": "string",
          "id": "string",
          "scheduleActionElementDescriptionId": "string"
        }
      ]
    }
  ],
  "actionElementDescriptions": [
    {
      "scheduleActionElementDescriptionId": "string",
      "displayName": "string"
    }
  ],
  "generalSettings": {
    "exceptionsVisible": true,
    "resetOnUpdate": true,
    "resetOnReboot": true,
    "busRepetitionActive": true,
    "busRepetitionOnErrorOnly": true,
    "busRepetitionTimes": 0,
    "busRepetitionInterval": 0,
    "todayTomorrowVisible": true,
    "allowCustomAction": true
  },
  "timelineDisplaySettings": {
    "startTimelineDisplay": 0,
    "endTimelineDisplay": 0
  },
  "hasChildren": true,
  "name": "string",
  "scheduleId": "string",
  "scheduleConfigurationId": "string",
  "zoneInstanceId": "string",
  "zoneInstanceName": "string",
  "isIndividualSchedule": true,
  "enabled": true,
  "canBeUnlinkedFromParentSchedule": true,
  "canBeLinkedToParentSchedule": true,
  "canBeUpdated": true,
  "linkedToParentSchedule": true,
  "parentSchedules": [
    {
      "zoneInstanceId": "string",
      "zoneInstanceName": "string"
    }
  ],
  "settingsOverriden": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|timeTable|[ScheduleTimeTableDTO](#schemascheduletimetabledto)|false|none|Information about the time table of a schedule|
|configurationActions|[[ScheduleActionDTO](#schemascheduleactiondto)]¦null|false|none|Possible actions configured for the schedule|
|actionElementDescriptions|[[ScheduleActionElementDescriptionDTO](#schemascheduleactionelementdescriptiondto)]¦null|false|none|Description of each action element|
|generalSettings|[ScheduleConfigurationGeneralSettingsDTO](#schemascheduleconfigurationgeneralsettingsdto)|false|none|General settings for a schedule configuration (Template or individual)|
|timelineDisplaySettings|[ScheduleTimelineDisplaySettingsDTO](#schemascheduletimelinedisplaysettingsdto)|false|none|Information about the timeline display settings of a schedule|
|hasChildren|boolean|false|none|Does this schedule instance has children|
|name|string¦null|false|none|Name of the schedule|
|scheduleId|string¦null|false|none|Unique Id of the schedule|
|scheduleConfigurationId|string¦null|false|none|Unique Id of the schedule template related to this instance|
|zoneInstanceId|string¦null|false|none|Unique Id of the zone instance to which this schedule is attached|
|zoneInstanceName|string¦null|false|none|Name of the zone instance|
|isIndividualSchedule|boolean|false|none|Wether or not this schedule is an individual schedule|
|enabled|boolean|false|none|Is the schedule enabled|
|canBeUnlinkedFromParentSchedule|boolean|false|none|Wether or not this schedule can be unlinked from its parent|
|canBeLinkedToParentSchedule|boolean|false|none|True if the schedule can be linked to parent schedule.|
|canBeUpdated|boolean|false|none|Wether or not this schedule can be updated|
|linkedToParentSchedule|boolean|false|none|Wether or not this schedule is linked to its parent|
|parentSchedules|[[ParentScheduleDTO](#schemaparentscheduledto)]¦null|false|none|Parents of the schedule|
|settingsOverriden|boolean|false|none|Indicates if the settings of the schedule template have been overriden for this instance. N/A for an individual schedule.|

<h2 id="tocS_ScheduleInstanceInfoDTO">ScheduleInstanceInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduleinstanceinfodto"></a>
<a id="schema_ScheduleInstanceInfoDTO"></a>
<a id="tocSscheduleinstanceinfodto"></a>
<a id="tocsscheduleinstanceinfodto"></a>

```json
{
  "name": "string",
  "scheduleId": "string",
  "scheduleConfigurationId": "string",
  "zoneInstanceId": "string",
  "zoneInstanceName": "string",
  "isIndividualSchedule": true,
  "enabled": true,
  "canBeUnlinkedFromParentSchedule": true,
  "canBeLinkedToParentSchedule": true,
  "canBeUpdated": true,
  "linkedToParentSchedule": true,
  "parentSchedules": [
    {
      "zoneInstanceId": "string",
      "zoneInstanceName": "string"
    }
  ],
  "settingsOverriden": true
}

```

Minimal information about a schedule instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the schedule|
|scheduleId|string¦null|false|none|Unique Id of the schedule|
|scheduleConfigurationId|string¦null|false|none|Unique Id of the schedule template related to this instance|
|zoneInstanceId|string¦null|false|none|Unique Id of the zone instance to which this schedule is attached|
|zoneInstanceName|string¦null|false|none|Name of the zone instance|
|isIndividualSchedule|boolean|false|none|Wether or not this schedule is an individual schedule|
|enabled|boolean|false|none|Is the schedule enabled|
|canBeUnlinkedFromParentSchedule|boolean|false|none|Wether or not this schedule can be unlinked from its parent|
|canBeLinkedToParentSchedule|boolean|false|none|True if the schedule can be linked to parent schedule.|
|canBeUpdated|boolean|false|none|Wether or not this schedule can be updated|
|linkedToParentSchedule|boolean|false|none|Wether or not this schedule is linked to its parent|
|parentSchedules|[[ParentScheduleDTO](#schemaparentscheduledto)]¦null|false|none|Parents of the schedule|
|settingsOverriden|boolean|false|none|Indicates if the settings of the schedule template have been overriden for this instance. N/A for an individual schedule.|

<h2 id="tocS_ScheduleTimeEntryDTO">ScheduleTimeEntryDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduletimeentrydto"></a>
<a id="schema_ScheduleTimeEntryDTO"></a>
<a id="tocSscheduletimeentrydto"></a>
<a id="tocsscheduletimeentrydto"></a>

```json
{
  "id": "string",
  "configurationActionId": "string",
  "timestamp": 0
}

```

Time entry on a schedule timeline

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the Schedule action description|
|configurationActionId|string¦null|false|none|Id of the action to perform on the entry|
|timestamp|integer(int32)|false|none|Time on which the action is performed (in minutes from midnight)|

<h2 id="tocS_ScheduleTimelineDisplaySettingsDTO">ScheduleTimelineDisplaySettingsDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduletimelinedisplaysettingsdto"></a>
<a id="schema_ScheduleTimelineDisplaySettingsDTO"></a>
<a id="tocSscheduletimelinedisplaysettingsdto"></a>
<a id="tocsscheduletimelinedisplaysettingsdto"></a>

```json
{
  "startTimelineDisplay": 0,
  "endTimelineDisplay": 0
}

```

Information about the timeline display settings of a schedule

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|startTimelineDisplay|integer(int32)|false|none|Start of the timeline display (in minutes)|
|endTimelineDisplay|integer(int32)|false|none|End of the timeline display (in minutes)|

<h2 id="tocS_ScheduleTimeTableDTO">ScheduleTimeTableDTO</h2>
<!-- backwards compatibility -->
<a id="schemascheduletimetabledto"></a>
<a id="schema_ScheduleTimeTableDTO"></a>
<a id="tocSscheduletimetabledto"></a>
<a id="tocsscheduletimetabledto"></a>

```json
{
  "id": "string",
  "weeklyTimeTable": [
    {
      "dayOfWeek": 0,
      "dtoType": "string",
      "id": "string",
      "times": [
        {
          "id": "string",
          "configurationActionId": "string",
          "timestamp": 0
        }
      ],
      "priority": 0
    }
  ],
  "exceptions": [
    {
      "type": "SingleDate",
      "dayOfWeek": 0,
      "weekOfMonth": 0,
      "name": "string",
      "start": {
        "day": 0,
        "dayOfWeek": "Sunday",
        "month": 0,
        "year": 0,
        "weekOfMonth": 0
      },
      "end": {
        "day": 0,
        "dayOfWeek": "Sunday",
        "month": 0,
        "year": 0,
        "weekOfMonth": 0
      },
      "dtoType": "string",
      "id": "string",
      "times": [
        {
          "id": "string",
          "configurationActionId": "string",
          "timestamp": 0
        }
      ],
      "priority": 0
    }
  ]
}

```

Information about the time table of a schedule

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the Schedule action description|
|weeklyTimeTable|[[ScheduleDateEntryDayOfWeekDTO](#schemascheduledateentrydayofweekdto)]¦null|false|none|List of date entries of type 'day of week' of the time table|
|exceptions|[[ScheduleDateEntryExceptionDTO](#schemascheduledateentryexceptiondto)]¦null|false|none|List of date entries of type 'exception' of the time table|

<h2 id="tocS_SecurityValidityDTO">SecurityValidityDTO</h2>
<!-- backwards compatibility -->
<a id="schemasecurityvaliditydto"></a>
<a id="schema_SecurityValidityDTO"></a>
<a id="tocSsecurityvaliditydto"></a>
<a id="tocssecurityvaliditydto"></a>

```json
{
  "isValid": true,
  "secretExpirationDate": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isValid|boolean|false|none|none|
|secretExpirationDate|string(date-time)¦null|false|none|none|

<h2 id="tocS_SelectorDTO">SelectorDTO</h2>
<!-- backwards compatibility -->
<a id="schemaselectordto"></a>
<a id="schema_SelectorDTO"></a>
<a id="tocSselectordto"></a>
<a id="tocsselectordto"></a>

```json
{
  "id": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|

<h2 id="tocS_SelectorType">SelectorType</h2>
<!-- backwards compatibility -->
<a id="schemaselectortype"></a>
<a id="schema_SelectorType"></a>
<a id="tocSselectortype"></a>
<a id="tocsselectortype"></a>

```json
"ManualDatapointSelectorDTO"

```

Discriminator of SelectorType

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Discriminator of SelectorType|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|ManualDatapointSelectorDTO|
|*anonymous*|TemplatedDatapointSelectorDTO|
|*anonymous*|FunctionalBlockInstancesSelectorDTO|
|*anonymous*|FunctionalBlockSelectorDTO|
|*anonymous*|ZoneInstanceSelectorDTO|
|*anonymous*|ZoneTemplateSelectorDTO|

<h2 id="tocS_SignalRMockNotificationDTO">SignalRMockNotificationDTO</h2>
<!-- backwards compatibility -->
<a id="schemasignalrmocknotificationdto"></a>
<a id="schema_SignalRMockNotificationDTO"></a>
<a id="tocSsignalrmocknotificationdto"></a>
<a id="tocssignalrmocknotificationdto"></a>

```json
{
  "body": "string",
  "connectionId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|body|string¦null|false|none|none|
|connectionId|string¦null|false|none|none|

<h2 id="tocS_SiteDTO">SiteDTO</h2>
<!-- backwards compatibility -->
<a id="schemasitedto"></a>
<a id="schema_SiteDTO"></a>
<a id="tocSsitedto"></a>
<a id="tocssitedto"></a>

```json
{
  "image": "string",
  "name": "string",
  "town": "string",
  "address1": "string",
  "address2": "string",
  "country": "string",
  "state": "string",
  "gpslat": "string",
  "gpslon": "string",
  "surfacegross": "string",
  "people": "string",
  "tags": [
    "string"
  ],
  "templateId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|image|string¦null|false|none|none|
|name|string¦null|false|none|none|
|town|string¦null|false|none|none|
|address1|string¦null|false|none|none|
|address2|string¦null|false|none|none|
|country|string¦null|false|none|none|
|state|string¦null|false|none|none|
|gpslat|string¦null|false|none|none|
|gpslon|string¦null|false|none|none|
|surfacegross|string¦null|false|none|none|
|people|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|templateId|string¦null|false|none|none|

<h2 id="tocS_SizeD">SizeD</h2>
<!-- backwards compatibility -->
<a id="schemasized"></a>
<a id="schema_SizeD"></a>
<a id="tocSsized"></a>
<a id="tocssized"></a>

```json
{
  "width": 0,
  "height": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|width|number(double)|false|none|none|
|height|number(double)|false|none|none|

<h2 id="tocS_SmartspaceAlgoGetDTO">SmartspaceAlgoGetDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacealgogetdto"></a>
<a id="schema_SmartspaceAlgoGetDTO"></a>
<a id="tocSsmartspacealgogetdto"></a>
<a id="tocssmartspacealgogetdto"></a>

```json
{
  "parameters": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ]
}

```

Algorithm parameters defined on a zone template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|parameters|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|Algorithm parameters|

<h2 id="tocS_SmartspaceAlgoRunningActivationDTO">SmartspaceAlgoRunningActivationDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacealgorunningactivationdto"></a>
<a id="schema_SmartspaceAlgoRunningActivationDTO"></a>
<a id="tocSsmartspacealgorunningactivationdto"></a>
<a id="tocssmartspacealgorunningactivationdto"></a>

```json
{
  "active": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|active|boolean|false|none|Indicates algo running activation state|

<h2 id="tocS_SmartspaceAlgoSetDTO">SmartspaceAlgoSetDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacealgosetdto"></a>
<a id="schema_SmartspaceAlgoSetDTO"></a>
<a id="tocSsmartspacealgosetdto"></a>
<a id="tocssmartspacealgosetdto"></a>

```json
{
  "parameters": [
    {
      "value": null,
      "id": "string"
    }
  ]
}

```

Algorithm parameters to apply on a zone template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|parameters|[[PropertyDatapointInstanceValueDTO](#schemapropertydatapointinstancevaluedto)]¦null|false|none|Values of the algorithm parameters|

<h2 id="tocS_SmartspaceBuildingGeneralRequestDTO">SmartspaceBuildingGeneralRequestDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacebuildinggeneralrequestdto"></a>
<a id="schema_SmartspaceBuildingGeneralRequestDTO"></a>
<a id="tocSsmartspacebuildinggeneralrequestdto"></a>
<a id="tocssmartspacebuildinggeneralrequestdto"></a>

```json
{
  "connectionId": "string",
  "propertiesTag": [
    "string"
  ]
}

```

Request for general data of a building

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|connectionId|string¦null|false|none|Id of the connection for subscription events|
|propertiesTag|[string]¦null|false|none|Tags of properties requested|

<h2 id="tocS_SmartspaceBuildingGeneralResponseDTO">SmartspaceBuildingGeneralResponseDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacebuildinggeneralresponsedto"></a>
<a id="schema_SmartspaceBuildingGeneralResponseDTO"></a>
<a id="tocSsmartspacebuildinggeneralresponsedto"></a>
<a id="tocssmartspacebuildinggeneralresponsedto"></a>

```json
{
  "buildingName": "string",
  "tags": [
    "string"
  ],
  "subscriptionId": "string",
  "properties": [
    {
      "id": "string",
      "tag": "string",
      "value": null,
      "displayUnit": "string"
    }
  ],
  "numberOfFloors": 0,
  "numberOfBasement": 0,
  "rooms": [
    {
      "name": "string",
      "zoneInstanceId": "string",
      "occupancyState": {
        "occupancy": "Standby",
        "forced": true
      },
      "capacity": 0,
      "presenceCountingDatapointInstanceId": "string"
    }
  ]
}

```

General data of a building

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|buildingName|string¦null|false|none|Name of the building|
|tags|[string]¦null|false|none|Tags of the building|
|subscriptionId|string¦null|false|none|Id of the subscription to be used to close the subscription when window is closed with normal subscription route|
|properties|[[SmartspaceZoneDetailPropDTO](#schemasmartspacezonedetailpropdto)]¦null|false|none|List of requested properties of the building|
|numberOfFloors|integer(int64)|false|none|Number of floors|
|numberOfBasement|integer(int64)|false|none|Number of basement|
|rooms|[[SmartspaceBuildingRoomDTO](#schemasmartspacebuildingroomdto)]¦null|false|none|List of rooms|

<h2 id="tocS_SmartspaceBuildingRoomDTO">SmartspaceBuildingRoomDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacebuildingroomdto"></a>
<a id="schema_SmartspaceBuildingRoomDTO"></a>
<a id="tocSsmartspacebuildingroomdto"></a>
<a id="tocssmartspacebuildingroomdto"></a>

```json
{
  "name": "string",
  "zoneInstanceId": "string",
  "occupancyState": {
    "occupancy": "Standby",
    "forced": true
  },
  "capacity": 0,
  "presenceCountingDatapointInstanceId": "string"
}

```

Room of a building

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the room|
|zoneInstanceId|string¦null|false|none|Id of the zone|
|occupancyState|[SmartspaceOccupancyStateDTO](#schemasmartspaceoccupancystatedto)|false|none|Occupancy state of a room|
|capacity|integer(int64)¦null|false|none|Room capacity (if available)|
|presenceCountingDatapointInstanceId|string¦null|false|none|Id of the datapoint counting people presents in the room|

<h2 id="tocS_SmartSpaceDatabaseGeneratorDTO">SmartSpaceDatabaseGeneratorDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacedatabasegeneratordto"></a>
<a id="schema_SmartSpaceDatabaseGeneratorDTO"></a>
<a id="tocSsmartspacedatabasegeneratordto"></a>
<a id="tocssmartspacedatabasegeneratordto"></a>

```json
{
  "numberOfMeetingRoomPerFloor": 0,
  "numberOfCO2PerMeetingRoom": 1,
  "numberOfAirUnitPerMeetingRoom": 1,
  "numberOfOccupancyPerRoom": 1,
  "minimumDPPerFunctionalBlock": 0,
  "minimumDPPerZone": 0,
  "memorySceneOccupancy": "",
  "memorySceneCountedpeople": "",
  "memorySceneTemperature": "",
  "memorySceneHumidity": "",
  "memorySceneCO2": "",
  "memorySceneVOC": "",
  "memorySceneCalendardchanged": "",
  "trendOccupancy": {
    "name": "string",
    "frequency": 10000,
    "deadband": 0,
    "retention": "",
    "generateDummyValues": false,
    "valuesConfiguration": {
      "from": "2019-08-24T14:15:22Z",
      "to": "2019-08-24T14:15:22Z",
      "min": 0,
      "max": 0,
      "frequency": "string",
      "withBadQuality": true
    }
  },
  "trendCountedPeople": {
    "name": "string",
    "frequency": 10000,
    "deadband": 0,
    "retention": "",
    "generateDummyValues": false,
    "valuesConfiguration": {
      "from": "2019-08-24T14:15:22Z",
      "to": "2019-08-24T14:15:22Z",
      "min": 0,
      "max": 0,
      "frequency": "string",
      "withBadQuality": true
    }
  },
  "trendTemperature": {
    "name": "string",
    "frequency": 10000,
    "deadband": 0,
    "retention": "",
    "generateDummyValues": false,
    "valuesConfiguration": {
      "from": "2019-08-24T14:15:22Z",
      "to": "2019-08-24T14:15:22Z",
      "min": 0,
      "max": 0,
      "frequency": "string",
      "withBadQuality": true
    }
  },
  "trendHumidity": {
    "name": "string",
    "frequency": 10000,
    "deadband": 0,
    "retention": "",
    "generateDummyValues": false,
    "valuesConfiguration": {
      "from": "2019-08-24T14:15:22Z",
      "to": "2019-08-24T14:15:22Z",
      "min": 0,
      "max": 0,
      "frequency": "string",
      "withBadQuality": true
    }
  },
  "trendCO2": {
    "name": "string",
    "frequency": 10000,
    "deadband": 0,
    "retention": "",
    "generateDummyValues": false,
    "valuesConfiguration": {
      "from": "2019-08-24T14:15:22Z",
      "to": "2019-08-24T14:15:22Z",
      "min": 0,
      "max": 0,
      "frequency": "string",
      "withBadQuality": true
    }
  },
  "trendVOC": {
    "name": "string",
    "frequency": 10000,
    "deadband": 0,
    "retention": "",
    "generateDummyValues": false,
    "valuesConfiguration": {
      "from": "2019-08-24T14:15:22Z",
      "to": "2019-08-24T14:15:22Z",
      "min": 0,
      "max": 0,
      "frequency": "string",
      "withBadQuality": true
    }
  },
  "alarmTemperature": {
    "name": "string",
    "frequency": 5000,
    "needAcknowledged": false,
    "deadband": 0,
    "triggers": [
      {
        "type": "string",
        "id": "string",
        "name": "string",
        "description": "string",
        "severity": "Log"
      }
    ],
    "hysteresis": 0
  },
  "alarmHumidity": {
    "name": "string",
    "frequency": 5000,
    "needAcknowledged": false,
    "deadband": 0,
    "triggers": [
      {
        "type": "string",
        "id": "string",
        "name": "string",
        "description": "string",
        "severity": "Log"
      }
    ],
    "hysteresis": 0
  },
  "alarmCO2": {
    "name": "string",
    "frequency": 5000,
    "needAcknowledged": false,
    "deadband": 0,
    "triggers": [
      {
        "type": "string",
        "id": "string",
        "name": "string",
        "description": "string",
        "severity": "Log"
      }
    ],
    "hysteresis": 0
  },
  "alarmVOC": {
    "name": "string",
    "frequency": 5000,
    "needAcknowledged": false,
    "deadband": 0,
    "triggers": [
      {
        "type": "string",
        "id": "string",
        "name": "string",
        "description": "string",
        "severity": "Log"
      }
    ],
    "hysteresis": 0
  },
  "noAlarm": true,
  "noTrend": true,
  "synchronousGeneration": false,
  "numberOfBuildings": 0,
  "numberOfFloorsPerBuilding": 0,
  "generateMapviewForEachFloor": false,
  "mapviewFunctionalBlockWidthAndHeight": 0,
  "mapviewFunctionalBlockSpace": 0,
  "mapviewZoneWidthAndHeight": 0,
  "mapviewZoneSpace": 0,
  "createUserAccessingAll": false,
  "createUserAccessingFloor": false,
  "createUserAccessingRoom": false
}

```

Settings to generate the smart space evaluation project

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|numberOfMeetingRoomPerFloor|integer(int64)|false|none|Number of meeting room<br /> <br>Each room name will be MeetingRoom#x <br />|
|numberOfCO2PerMeetingRoom|integer(int64)|false|none|Number of CO2 functional blocks per meeting room. If zero then 1.|
|numberOfAirUnitPerMeetingRoom|integer(int64)|false|none|Number of air unit functional blocks per meeting room. If zero then 1.|
|numberOfOccupancyPerRoom|integer(int64)|false|none|Number of occupancy functional blocks per meeting room. If zero then 1.|
|minimumDPPerFunctionalBlock|integer(int64)|false|none|Minimum number of datapoints per functional block.<br>Will generate dummy datapoint for missing dp.|
|minimumDPPerZone|integer(int64)|false|none|Minimum number of datapoints per zone.<br>Will generate dummy datapoint for missing dp.|
|memorySceneOccupancy|string¦null|false|none|Format of the scene of the Occupancy.occupancy datapoint. If empty the scene will be : /scene=ana:1000:0:100<br /> <br>Format is : period:min:max like /scene=ana:{periodMs}:{minValue}:{maxValue}|
|memorySceneCountedpeople|string¦null|false|none|Format of the scene of the Occupancy.countedpeople datapoint. If empty the scene will be: /scene=ana:1000:0:100<br /> <br>Format is : period:min:max like /scene=ana:{periodMs}:{minValue}:{maxValue}|
|memorySceneTemperature|string¦null|false|none|Format of the scene of the AirCondUnit.Temperature datapoint. If empty the scene will be: /scene=ana:1000:0:100<br /> <br>Format is : period:min:max like /scene=ana:{periodMs}:{minValue}:{maxValue}|
|memorySceneHumidity|string¦null|false|none|Format of the scene of the AirCondUnit.Humidity datapoint. If empty the scene will be: /scene=ana:1000:0:100<br /> <br>Format is : period:min:max like /scene=ana:{periodMs}:{minValue}:{maxValue}|
|memorySceneCO2|string¦null|false|none|Format of the scene of the CO2.CO2 datapoint. If empty the scene will be: /scene=ana:1000:0:100<br /> <br>Format is : period:min:max like /scene=ana:{periodMs}:{minValue}:{maxValue}|
|memorySceneVOC|string¦null|false|none|Format of the scene of the CO2.VOC datapoint. If empty the scene will be: /scene=ana:1000:0:100<br /> <br>Format is : period:min:max like /scene=ana:{periodMs}:{minValue}:{maxValue}|
|memorySceneCalendardchanged|string¦null|false|none|Format of the scene of the MeetingRoom.calendardchanged datapoint. If empty the scene will be: /scene=ana:1000:0:100<br /> <br>Format is : period:min:max like /scene=ana:{periodMs}:{minValue}:{maxValue}|
|trendOccupancy|[TrendConfigurationDTO](#schematrendconfigurationdto)|false|none|Trend configuration|
|trendCountedPeople|[TrendConfigurationDTO](#schematrendconfigurationdto)|false|none|Trend configuration|
|trendTemperature|[TrendConfigurationDTO](#schematrendconfigurationdto)|false|none|Trend configuration|
|trendHumidity|[TrendConfigurationDTO](#schematrendconfigurationdto)|false|none|Trend configuration|
|trendCO2|[TrendConfigurationDTO](#schematrendconfigurationdto)|false|none|Trend configuration|
|trendVOC|[TrendConfigurationDTO](#schematrendconfigurationdto)|false|none|Trend configuration|
|alarmTemperature|[AlarmConfigurationDTO](#schemaalarmconfigurationdto)|false|none|Alarm configuration|
|alarmHumidity|[AlarmConfigurationDTO](#schemaalarmconfigurationdto)|false|none|Alarm configuration|
|alarmCO2|[AlarmConfigurationDTO](#schemaalarmconfigurationdto)|false|none|Alarm configuration|
|alarmVOC|[AlarmConfigurationDTO](#schemaalarmconfigurationdto)|false|none|Alarm configuration|
|noAlarm|boolean|false|none|If true no alarm generated|
|noTrend|boolean|false|none|If true no trend generated|
|synchronousGeneration|boolean|false|none|If true generation of database will be synchronous (rest call will be blocked during execution)|
|numberOfBuildings|integer(int64)|false|none|Number of buildings (zone instance)<br /> <br>Zone template of all buildings will be named TBuilding<br /> <br>Zone template of the building has a tag bos:building<br /> <br>Each building zone instance will be named Building#x with x from 1 to n<br /> <br>Zone intance of the building has a tag bos:building|
|numberOfFloorsPerBuilding|integer(int64)|false|none|Number of floors per building<br /> <br>Zone template of all floors will be named TFloor<br /> <br>Zone template of the floor has a tag bos:structure:floor<br /> <br>Each floor zone instance will be named Floor#x with x from 1 to n<br /> <br>Zone intance of the floor has a tag bos:structure:floor|
|generateMapviewForEachFloor|boolean|false|none|Indicates if we generate a mapview for each floor|
|mapviewFunctionalBlockWidthAndHeight|number(double)|false|none|Width and height of each functional block on mapview (between 0 and 1)|
|mapviewFunctionalBlockSpace|number(double)|false|none|X and Y space between functional blocks on mapview (between 0 and 1)|
|mapviewZoneWidthAndHeight|number(double)|false|none|Width and height of each zone polygon on mapview between 0 and 1|
|mapviewZoneSpace|number(double)|false|none|X and Y space between zones on mapview (between 0 and 1)|
|createUserAccessingAll|boolean|false|none|Create the user that can access all.<br /> <br>Name of user is : UserALL<br /> <br>Paswword of user is : UserALL(1)|
|createUserAccessingFloor|boolean|false|none|Create the user that can access a floor and all its rooms<br /> <br>Name of user is : User_NameOfFloor with NameOfFloor name of the floor<br /> <br>Paswword of user is : Pass_NameOfFloor(1) with NameOfFloor name of the floor|
|createUserAccessingRoom|boolean|false|none|Create the user that can access only one room<br /> <br>Name of user is : User_NameOfRoom with NameOfRoom name of the room<br /> <br>Paswword of user is : Pass_NameOfRoom(1) with NameOfRoom name of the room|

<h2 id="tocS_SmartspaceDatapointRequestDTO">SmartspaceDatapointRequestDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacedatapointrequestdto"></a>
<a id="schema_SmartspaceDatapointRequestDTO"></a>
<a id="tocSsmartspacedatapointrequestdto"></a>
<a id="tocssmartspacedatapointrequestdto"></a>

```json
{
  "tag": "string",
  "wantSubscription": true,
  "wantTrendInstance": true,
  "frequencyMs": 0,
  "deadBand": 0
}

```

Details of the datapoint needed to have for the view of the zone

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tag|string¦null|false|none|Tag of the datapoint|
|wantSubscription|boolean|false|none|Indicates if a subscription is required|
|wantTrendInstance|boolean|false|none|Indicates if a trend is required|
|frequencyMs|integer(int32)|false|none|Scan rate (in ms) for the datapoint.|
|deadBand|number(double)|false|none|Deadband for the datapoint.|

<h2 id="tocS_SmartspaceFloorGeneralRequestDTO">SmartspaceFloorGeneralRequestDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacefloorgeneralrequestdto"></a>
<a id="schema_SmartspaceFloorGeneralRequestDTO"></a>
<a id="tocSsmartspacefloorgeneralrequestdto"></a>
<a id="tocssmartspacefloorgeneralrequestdto"></a>

```json
{
  "connectionId": "string",
  "propertyTag": "string",
  "datapointTag": "string"
}

```

Request for general data of a floor

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|connectionId|string¦null|false|none|Id of the connection for subscription events, can be null if there is no datapoint to monitor|
|propertyTag|string¦null|false|none|Tag of the property to show for each room, can be null|
|datapointTag|string¦null|false|none|Tag of the datapoint to monitor for each room, can be null|

<h2 id="tocS_SmartspaceFloorGeneralResponseDTO">SmartspaceFloorGeneralResponseDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacefloorgeneralresponsedto"></a>
<a id="schema_SmartspaceFloorGeneralResponseDTO"></a>
<a id="tocSsmartspacefloorgeneralresponsedto"></a>
<a id="tocssmartspacefloorgeneralresponsedto"></a>

```json
{
  "subscriptionId": "string",
  "rooms": [
    {
      "name": "string",
      "zoneInstanceId": "string",
      "property": {
        "id": "string",
        "tag": "string",
        "value": null,
        "displayUnit": "string"
      },
      "datapoint": {
        "id": "string",
        "tag": "string",
        "trendInstanceId": "string",
        "displayUnit": "string",
        "assigned": true
      }
    }
  ]
}

```

General data of a floor

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|subscriptionId|string¦null|false|none|Id of the subscription to be used to close the subscription when window is closed with normal subscription route|
|rooms|[[SmartspaceFloorRoomDTO](#schemasmartspacefloorroomdto)]¦null|false|none|List of rooms|

<h2 id="tocS_SmartspaceFloorRoomDTO">SmartspaceFloorRoomDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacefloorroomdto"></a>
<a id="schema_SmartspaceFloorRoomDTO"></a>
<a id="tocSsmartspacefloorroomdto"></a>
<a id="tocssmartspacefloorroomdto"></a>

```json
{
  "name": "string",
  "zoneInstanceId": "string",
  "property": {
    "id": "string",
    "tag": "string",
    "value": null,
    "displayUnit": "string"
  },
  "datapoint": {
    "id": "string",
    "tag": "string",
    "trendInstanceId": "string",
    "displayUnit": "string",
    "assigned": true
  }
}

```

Room of a floor

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the room|
|zoneInstanceId|string¦null|false|none|Id of the zone|
|property|[SmartspaceZoneDetailPropDTO](#schemasmartspacezonedetailpropdto)|false|none|Property of the zone detail|
|datapoint|[SmartspaceZoneDetailDatapointDTO](#schemasmartspacezonedetaildatapointdto)|false|none|Datapoint of the zone detail|

<h2 id="tocS_SmartspaceForceOccupancy">SmartspaceForceOccupancy</h2>
<!-- backwards compatibility -->
<a id="schemasmartspaceforceoccupancy"></a>
<a id="schema_SmartspaceForceOccupancy"></a>
<a id="tocSsmartspaceforceoccupancy"></a>
<a id="tocssmartspaceforceoccupancy"></a>

```json
"Standby"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Standby|
|*anonymous*|Unoccupied|
|*anonymous*|Occupied|

<h2 id="tocS_SmartspaceFunctionOutputDTO">SmartspaceFunctionOutputDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacefunctionoutputdto"></a>
<a id="schema_SmartspaceFunctionOutputDTO"></a>
<a id="tocSsmartspacefunctionoutputdto"></a>
<a id="tocssmartspacefunctionoutputdto"></a>

```json
{
  "datapointTemplateId": "string",
  "zoneTemplateId": "string",
  "functionalBlockTemplateId": "string",
  "selectionMode": "All",
  "valueOccupied": null,
  "valueUnoccupied": null,
  "valueStandby": null,
  "canBeChangedInOperationalTool": true
}

```

DTO of a programmed datapoint template  for a scene for a zone template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointTemplateId|string¦null|false|none|Id of the programmed datapoint template|
|zoneTemplateId|string¦null|false|none|Id of the zone template that has the datapoint template|
|functionalBlockTemplateId|string¦null|false|none|Id of the functional block template that has the datapoint template|
|selectionMode|[FBTypeOfSelection](#schemafbtypeofselection)|false|none|none|
|valueOccupied|any|false|none|Instruction on the datapoint to be executed when the room is occupied|
|valueUnoccupied|any|false|none|Instruction on the datapoint to be executed when the room is unoccupied|
|valueStandby|any|false|none|Instruction on the datapoint to be executed when the room is unoccupied during building opening hours|
|canBeChangedInOperationalTool|boolean|false|none|Indicates if the configuration can be overriden in operational tool|

<h2 id="tocS_SmartspaceFunctionOutputOverrideDTO">SmartspaceFunctionOutputOverrideDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacefunctionoutputoverridedto"></a>
<a id="schema_SmartspaceFunctionOutputOverrideDTO"></a>
<a id="tocSsmartspacefunctionoutputoverridedto"></a>
<a id="tocssmartspacefunctionoutputoverridedto"></a>

```json
{
  "datapointTemplateId": "string",
  "zoneInstanceId": "string",
  "functionalBlockTemplateId": "string",
  "valueOccupied": null,
  "valueUnoccupied": null,
  "valueStandby": null
}

```

Override of a datapoint in a smartspace.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapointTemplateId|string¦null|false|none|Datapoint affected by the override.|
|zoneInstanceId|string¦null|false|none|Zone of the override.|
|functionalBlockTemplateId|string¦null|false|none|Id of the functional block template that has the datapoint template|
|valueOccupied|any|false|none|Value of the datapoint when the zone enters the "Occupied" state (or null if no value is used).|
|valueUnoccupied|any|false|none|Value of the datapoint when the zone enters the "Free" state (or null if no value is used).|
|valueStandby|any|false|none|Value of the datapoint when the zone enters the "Stand By" state (or null if no value is used).|

<h2 id="tocS_SmartspaceHeatmapDTO">SmartspaceHeatmapDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspaceheatmapdto"></a>
<a id="schema_SmartspaceHeatmapDTO"></a>
<a id="tocSsmartspaceheatmapdto"></a>
<a id="tocssmartspaceheatmapdto"></a>

```json
{
  "totalHours": 0,
  "averageNumberOfPeoplePerHour": 0,
  "capacity": 0,
  "percentDensity": 0,
  "occupancy": [
    {
      "day": "2019-08-24T14:15:22Z",
      "numberOfMinutesOccupied": 0
    }
  ],
  "density": [
    {
      "day": "2019-08-24T14:15:22Z",
      "averageNumberOfPeoplePerHour": 0
    }
  ],
  "buildingOccupancyHoursPerDay": 0
}

```

Represents the heatmap of a room.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|totalHours|integer(int64)|false|none|Number of hours represented by the heatmap.|
|averageNumberOfPeoplePerHour|number(double)|false|none|Average number of people occupying the room.|
|capacity|integer(int32)¦null|false|none|Room capacity (if available).|
|percentDensity|number(double)¦null|false|none|Average percentage of the room used capacity (if the room capacity is available).|
|occupancy|[[OccupancyHeatmapEntryDTO](#schemaoccupancyheatmapentrydto)]¦null|false|none|Occupancy of the room per day.|
|density|[[DensityHeatmapEntryDTO](#schemadensityheatmapentrydto)]¦null|false|none|Occupation density of the room per day.|
|buildingOccupancyHoursPerDay|integer(int64)|false|none|Number of hours per day the building is occupied.|

<h2 id="tocS_SmartspaceHvacAssetMappingDTO">SmartspaceHvacAssetMappingDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacehvacassetmappingdto"></a>
<a id="schema_SmartspaceHvacAssetMappingDTO"></a>
<a id="tocSsmartspacehvacassetmappingdto"></a>
<a id="tocssmartspacehvacassetmappingdto"></a>

```json
{
  "functionalBlockInstanceId": "string",
  "zoneInstanceId": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlockInstanceId|string¦null|false|none|Id of the HVAC asset.|
|zoneInstanceId|[string]¦null|false|none|Zones attached to the HVAC.|

<h2 id="tocS_SmartspaceLicenseStatusDTO">SmartspaceLicenseStatusDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacelicensestatusdto"></a>
<a id="schema_SmartspaceLicenseStatusDTO"></a>
<a id="tocSsmartspacelicensestatusdto"></a>
<a id="tocssmartspacelicensestatusdto"></a>

```json
{
  "numberOfMeetingRooms": 0,
  "numberOfLicensedRooms": 0
}

```

License status for smartspace.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|numberOfMeetingRooms|integer(int64)|false|none|Number of meeting rooms configured for smartspace.|
|numberOfLicensedRooms|integer(int64)|false|none|Number of meeting rooms covered by license.|

<h2 id="tocS_SmartspaceOccupancyStateDTO">SmartspaceOccupancyStateDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspaceoccupancystatedto"></a>
<a id="schema_SmartspaceOccupancyStateDTO"></a>
<a id="tocSsmartspaceoccupancystatedto"></a>
<a id="tocssmartspaceoccupancystatedto"></a>

```json
{
  "occupancy": "Standby",
  "forced": true
}

```

Occupancy state of a room

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|occupancy|[SmartspaceForceOccupancy](#schemasmartspaceforceoccupancy)|false|none|none|
|forced|boolean|false|none|True if the state was forced|

<h2 id="tocS_SmartspaceSettingsDTO">SmartspaceSettingsDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacesettingsdto"></a>
<a id="schema_SmartspaceSettingsDTO"></a>
<a id="tocSsmartspacesettingsdto"></a>
<a id="tocssmartspacesettingsdto"></a>

```json
{
  "buildingOccupancyHoursPerDay": 0,
  "buildingGlobalCalendarAddress": "string"
}

```

Global settings for smartspaces.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|buildingOccupancyHoursPerDay|integer(int64)|false|none|Number of occupancy hours per day for the building.|
|buildingGlobalCalendarAddress|string¦null|false|none|Address of the global calendar used for the building.|

<h2 id="tocS_SmartspaceValidationStatusDTO">SmartspaceValidationStatusDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacevalidationstatusdto"></a>
<a id="schema_SmartspaceValidationStatusDTO"></a>
<a id="tocSsmartspacevalidationstatusdto"></a>
<a id="tocssmartspacevalidationstatusdto"></a>

```json
{
  "countOK": 0,
  "countWarning": 0,
  "countError": 0
}

```

Validation status of a smartspace.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|countOK|integer(int64)|false|none|Number of successful validations.|
|countWarning|integer(int64)|false|none|Number of failed non-blocking validations.|
|countError|integer(int64)|false|none|Number of failed blocking validations.|

<h2 id="tocS_SmartspaceZoneConfigurationDTO">SmartspaceZoneConfigurationDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacezoneconfigurationdto"></a>
<a id="schema_SmartspaceZoneConfigurationDTO"></a>
<a id="tocSsmartspacezoneconfigurationdto"></a>
<a id="tocssmartspacezoneconfigurationdto"></a>

```json
{
  "zoneInstanceId": "string",
  "calendarAddress": "string",
  "selected": true
}

```

Configuration of a smartspace.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneInstanceId|string¦null|false|none|Id of the zone instance.|
|calendarAddress|string¦null|false|none|Calendar address used for the smartspace.|
|selected|boolean|false|none|Indicates if the smartspace is selected to be managed.|

<h2 id="tocS_SmartspaceZoneDetailDatapointDTO">SmartspaceZoneDetailDatapointDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacezonedetaildatapointdto"></a>
<a id="schema_SmartspaceZoneDetailDatapointDTO"></a>
<a id="tocSsmartspacezonedetaildatapointdto"></a>
<a id="tocssmartspacezonedetaildatapointdto"></a>

```json
{
  "id": "string",
  "tag": "string",
  "trendInstanceId": "string",
  "displayUnit": "string",
  "assigned": true
}

```

Datapoint of the zone detail

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id|
|tag|string¦null|false|none|Tag|
|trendInstanceId|string¦null|false|none|Id of the trend if exists, otherwise null|
|displayUnit|string¦null|false|none|Display unit|
|assigned|boolean|false|none|Indicates if the datapoint has a bus address to subscribe to|

<h2 id="tocS_SmartspaceZoneDetailPropDTO">SmartspaceZoneDetailPropDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacezonedetailpropdto"></a>
<a id="schema_SmartspaceZoneDetailPropDTO"></a>
<a id="tocSsmartspacezonedetailpropdto"></a>
<a id="tocssmartspacezonedetailpropdto"></a>

```json
{
  "id": "string",
  "tag": "string",
  "value": null,
  "displayUnit": "string"
}

```

Property of the zone detail

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id|
|tag|string¦null|false|none|Tag|
|value|any|false|none|Value|
|displayUnit|string¦null|false|none|Display unit|

<h2 id="tocS_SmartspaceZoneDetailRequestDTO">SmartspaceZoneDetailRequestDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacezonedetailrequestdto"></a>
<a id="schema_SmartspaceZoneDetailRequestDTO"></a>
<a id="tocSsmartspacezonedetailrequestdto"></a>
<a id="tocssmartspacezonedetailrequestdto"></a>

```json
{
  "connectionId": "string",
  "propertiesTag": [
    "string"
  ],
  "zoneDatapoints": [
    {
      "tag": "string",
      "wantSubscription": true,
      "wantTrendInstance": true,
      "frequencyMs": 0,
      "deadBand": 0
    }
  ],
  "globalDatapoints": [
    {
      "tag": "string",
      "wantSubscription": true,
      "wantTrendInstance": true,
      "frequencyMs": 0,
      "deadBand": 0
    }
  ]
}

```

DTO of a Datapoint with subscription and/or trend

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|connectionId|string¦null|false|none|Id of the connection for subscription events|
|propertiesTag|[string]¦null|false|none|Tags of properties requested|
|zoneDatapoints|[[SmartspaceDatapointRequestDTO](#schemasmartspacedatapointrequestdto)]¦null|false|none|Zone Datapoints to be subscribed and/or to be shown trend|
|globalDatapoints|[[SmartspaceDatapointRequestDTO](#schemasmartspacedatapointrequestdto)]¦null|false|none|Global datapoints to be subscribed and/or to be shown trend|

<h2 id="tocS_SmartspaceZoneDetailResponseDTO">SmartspaceZoneDetailResponseDTO</h2>
<!-- backwards compatibility -->
<a id="schemasmartspacezonedetailresponsedto"></a>
<a id="schema_SmartspaceZoneDetailResponseDTO"></a>
<a id="tocSsmartspacezonedetailresponsedto"></a>
<a id="tocssmartspacezonedetailresponsedto"></a>

```json
{
  "tags": [
    "string"
  ],
  "properties": [
    {
      "id": "string",
      "tag": "string",
      "value": null,
      "displayUnit": "string"
    }
  ],
  "zoneDatapoints": [
    {
      "id": "string",
      "tag": "string",
      "trendInstanceId": "string",
      "displayUnit": "string",
      "assigned": true
    }
  ],
  "globalDatapoints": [
    {
      "id": "string",
      "tag": "string",
      "trendInstanceId": "string",
      "displayUnit": "string",
      "assigned": true
    }
  ],
  "subscriptionId": "string"
}

```

Property of the zone detail

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tags|[string]¦null|false|none|Tags of the zone|
|properties|[[SmartspaceZoneDetailPropDTO](#schemasmartspacezonedetailpropdto)]¦null|false|none|List of requested properties of the zone|
|zoneDatapoints|[[SmartspaceZoneDetailDatapointDTO](#schemasmartspacezonedetaildatapointdto)]¦null|false|none|List of requested datapoints of the zone|
|globalDatapoints|[[SmartspaceZoneDetailDatapointDTO](#schemasmartspacezonedetaildatapointdto)]¦null|false|none|List of global datapoints of the zone|
|subscriptionId|string¦null|false|none|Id of the subscription to be used to close the subscription when window is closed with normal subscription route|

<h2 id="tocS_SourceBoolDestDoubleConverterDTO">SourceBoolDestDoubleConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourcebooldestdoubleconverterdto"></a>
<a id="schema_SourceBoolDestDoubleConverterDTO"></a>
<a id="tocSsourcebooldestdoubleconverterdto"></a>
<a id="tocssourcebooldestdoubleconverterdto"></a>

```json
{
  "type": "Unknown",
  "mappingFromDouble": [
    {
      "min": 0,
      "max": 0,
      "minIncluded": true,
      "maxIncluded": true,
      "value": true
    }
  ],
  "mappingFromBool": {
    "property1": 0,
    "property2": 0
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceBoolDestDoubleDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromDouble|[[DoubleToBoolDTO](#schemadoubletobooldto)]¦null|false|none|Mapping of double value to bool|
|mappingFromBool|object¦null|false|none|Mapping of bool value to double|
|» **additionalProperties**|number(double)|false|none|none|
|id|string¦null|false|none|Unique identifier of the converter object.|
|typeSource|any|false|none|Type of the source (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|typeDest|any|false|none|Type of the destination (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the converter.|

<h2 id="tocS_SourceBoolDestEnumConverterDTO">SourceBoolDestEnumConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourcebooldestenumconverterdto"></a>
<a id="schema_SourceBoolDestEnumConverterDTO"></a>
<a id="tocSsourcebooldestenumconverterdto"></a>
<a id="tocssourcebooldestenumconverterdto"></a>

```json
{
  "type": "string",
  "mappingFromBool": {
    "property1": 0,
    "property2": 0
  },
  "mappingFromEnumeration": {
    "property1": true,
    "property2": true
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceBoolDestEnumDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromBool|object¦null|false|none|Mapping of bool value to enum|
|» **additionalProperties**|integer(int64)|false|none|none|
|mappingFromEnumeration|object¦null|false|none|Mapping of enum value to bool|
|» **additionalProperties**|boolean|false|none|none|

<h2 id="tocS_SourceDoubleDestBoolConverterDTO">SourceDoubleDestBoolConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourcedoubledestboolconverterdto"></a>
<a id="schema_SourceDoubleDestBoolConverterDTO"></a>
<a id="tocSsourcedoubledestboolconverterdto"></a>
<a id="tocssourcedoubledestboolconverterdto"></a>

```json
{
  "type": "string",
  "mappingFromDouble": [
    {
      "min": 0,
      "max": 0,
      "minIncluded": true,
      "maxIncluded": true,
      "value": true
    }
  ],
  "mappingFromBool": {
    "property1": 0,
    "property2": 0
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceDoubleDestBoolDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromDouble|[[DoubleToBoolDTO](#schemadoubletobooldto)]¦null|false|none|Mapping of double value to bool|
|mappingFromBool|object¦null|false|none|Mapping of bool value to double|
|» **additionalProperties**|number(double)|false|none|none|

<h2 id="tocS_SourceDoubleDestEnumConverterDTO">SourceDoubleDestEnumConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourcedoubledestenumconverterdto"></a>
<a id="schema_SourceDoubleDestEnumConverterDTO"></a>
<a id="tocSsourcedoubledestenumconverterdto"></a>
<a id="tocssourcedoubledestenumconverterdto"></a>

```json
{
  "type": "string",
  "mappingFromDouble": [
    {
      "min": 0,
      "max": 0,
      "minIncluded": true,
      "maxIncluded": true,
      "value": 0
    }
  ],
  "mappingFromEnumeration": {
    "property1": 0,
    "property2": 0
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceDoubleDestEnumDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromDouble|[[DoubleToEnumDTO](#schemadoubletoenumdto)]¦null|false|none|Mapping of double value to enum|
|mappingFromEnumeration|object¦null|false|none|Mapping of enum value to double|
|» **additionalProperties**|number(double)|false|none|none|

<h2 id="tocS_SourceEnumDestBoolConverterDTO">SourceEnumDestBoolConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourceenumdestboolconverterdto"></a>
<a id="schema_SourceEnumDestBoolConverterDTO"></a>
<a id="tocSsourceenumdestboolconverterdto"></a>
<a id="tocssourceenumdestboolconverterdto"></a>

```json
{
  "type": "Unknown",
  "mappingFromBool": {
    "property1": 0,
    "property2": 0
  },
  "mappingFromEnumeration": {
    "property1": true,
    "property2": true
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceEnumDestBoolDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromBool|object¦null|false|none|Mapping of bool value to enum|
|» **additionalProperties**|integer(int64)|false|none|none|
|mappingFromEnumeration|object¦null|false|none|Mapping of enum value to bool|
|» **additionalProperties**|boolean|false|none|none|
|id|string¦null|false|none|Unique identifier of the converter object.|
|typeSource|any|false|none|Type of the source (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|typeDest|any|false|none|Type of the destination (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the converter.|

<h2 id="tocS_SourceEnumDestDoubleConverterDTO">SourceEnumDestDoubleConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourceenumdestdoubleconverterdto"></a>
<a id="schema_SourceEnumDestDoubleConverterDTO"></a>
<a id="tocSsourceenumdestdoubleconverterdto"></a>
<a id="tocssourceenumdestdoubleconverterdto"></a>

```json
{
  "type": "Unknown",
  "mappingFromDouble": [
    {
      "min": 0,
      "max": 0,
      "minIncluded": true,
      "maxIncluded": true,
      "value": 0
    }
  ],
  "mappingFromEnumeration": {
    "property1": 0,
    "property2": 0
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceEnumDestDoubleDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromDouble|[[DoubleToEnumDTO](#schemadoubletoenumdto)]¦null|false|none|Mapping of double value to enum|
|mappingFromEnumeration|object¦null|false|none|Mapping of enum value to double|
|» **additionalProperties**|number(double)|false|none|none|
|id|string¦null|false|none|Unique identifier of the converter object.|
|typeSource|any|false|none|Type of the source (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|typeDest|any|false|none|Type of the destination (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the converter.|

<h2 id="tocS_SourceEnumDestEnumConverterDTO">SourceEnumDestEnumConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourceenumdestenumconverterdto"></a>
<a id="schema_SourceEnumDestEnumConverterDTO"></a>
<a id="tocSsourceenumdestenumconverterdto"></a>
<a id="tocssourceenumdestenumconverterdto"></a>

```json
{
  "type": "string",
  "mappingFromSource": {
    "property1": 0,
    "property2": 0
  },
  "mappingFromDest": {
    "property1": 0,
    "property2": 0
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceEnumDestEnumDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromSource|object¦null|false|none|Mapping of enum source to enum dest|
|» **additionalProperties**|integer(int64)|false|none|none|
|mappingFromDest|object¦null|false|none|Mapping of enum dest to enum source|
|» **additionalProperties**|integer(int64)|false|none|none|

<h2 id="tocS_SourceEnumDestLongConverterDTO">SourceEnumDestLongConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourceenumdestlongconverterdto"></a>
<a id="schema_SourceEnumDestLongConverterDTO"></a>
<a id="tocSsourceenumdestlongconverterdto"></a>
<a id="tocssourceenumdestlongconverterdto"></a>

```json
{
  "type": "Unknown",
  "mappingFromLong": [
    {
      "min": 0,
      "max": 0,
      "minIncluded": true,
      "maxIncluded": true,
      "value": 0
    }
  ],
  "mappingFromEnumeration": {
    "property1": 0,
    "property2": 0
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceEnumDestLongDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromLong|[[LongToEnumDTO](#schemalongtoenumdto)]¦null|false|none|Mapping of long value to enum|
|mappingFromEnumeration|object¦null|false|none|Mapping of enum value to long|
|» **additionalProperties**|integer(int64)|false|none|none|
|id|string¦null|false|none|Unique identifier of the converter object.|
|typeSource|any|false|none|Type of the source (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|typeDest|any|false|none|Type of the destination (DoubleType, LongType, BoolType, EnumerationType, [...]).<br>This field should be null when ConverterInfoDTO is used to Update a converter|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the converter.|

<h2 id="tocS_SourceLongDestBoolConverterDTO">SourceLongDestBoolConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourcelongdestboolconverterdto"></a>
<a id="schema_SourceLongDestBoolConverterDTO"></a>
<a id="tocSsourcelongdestboolconverterdto"></a>
<a id="tocssourcelongdestboolconverterdto"></a>

```json
{
  "type": "string",
  "mappingFromLong": [
    {
      "min": 0,
      "max": 0,
      "minIncluded": true,
      "maxIncluded": true,
      "value": true
    }
  ],
  "mappingFromBool": {
    "property1": 0,
    "property2": 0
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceLongDestBoolDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromLong|[[LongToBoolDTO](#schemalongtobooldto)]¦null|false|none|Mapping of long to bool|
|mappingFromBool|object¦null|false|none|Mapping of bool to long|
|» **additionalProperties**|integer(int64)|false|none|none|

<h2 id="tocS_SourceLongDestEnumConverterDTO">SourceLongDestEnumConverterDTO</h2>
<!-- backwards compatibility -->
<a id="schemasourcelongdestenumconverterdto"></a>
<a id="schema_SourceLongDestEnumConverterDTO"></a>
<a id="tocSsourcelongdestenumconverterdto"></a>
<a id="tocssourcelongdestenumconverterdto"></a>

```json
{
  "type": "string",
  "mappingFromLong": [
    {
      "min": 0,
      "max": 0,
      "minIncluded": true,
      "maxIncluded": true,
      "value": 0
    }
  ],
  "mappingFromEnumeration": {
    "property1": 0,
    "property2": 0
  },
  "id": "string",
  "typeSource": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "typeDest": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "name": "string"
}

```

SourceLongDestEnumDTO Converter definition object.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[ConverterType](#schemaconvertertype)|false|none|Discriminator of DataType|
|mappingFromLong|[[LongToEnumDTO](#schemalongtoenumdto)]¦null|false|none|Mapping of long value to enum|
|mappingFromEnumeration|object¦null|false|none|Mapping of enum value to long|
|» **additionalProperties**|integer(int64)|false|none|none|

<h2 id="tocS_SpaceDTO">SpaceDTO</h2>
<!-- backwards compatibility -->
<a id="schemaspacedto"></a>
<a id="schema_SpaceDTO"></a>
<a id="tocSspacedto"></a>
<a id="tocsspacedto"></a>

```json
{
  "spaceType": "string",
  "structureParents": "string",
  "zoneChildren": "string",
  "zoneParents": "string",
  "spaceChildren": "string",
  "spaceParents": "string",
  "tenants": "string",
  "owners": "string",
  "propertyManagers": "string",
  "facilityManagers": "string",
  "visitors": "string",
  "datapoints": [
    {
      "stationId": "string",
      "networkId": "string",
      "busUnitId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "converterId": "string",
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "properties": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "functionalBlocks": [
    {
      "functionalBlockId": "string",
      "group": "string",
      "masterMode": "None",
      "inZone": true
    }
  ],
  "authorized": true,
  "parentIds": [
    "string"
  ],
  "childrenIds": [
    "string"
  ],
  "hasMapView": true,
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "type": "Physical",
  "tags": [
    "string"
  ],
  "propertyZoneType": "Property",
  "isExternal": true
}

```

Represents a space

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|spaceType|string¦null|false|none|Type of space (last part of tag bos:space:)|
|structureParents|string¦null|false|none|Resource path to query the parent structure of the space|
|zoneChildren|string¦null|false|none|Resource path to query the children zones of the space|
|zoneParents|string¦null|false|none|Resource path to query the children zones of the space|
|spaceChildren|string¦null|false|none|Resource path to query the children spaces of the space|
|spaceParents|string¦null|false|none|Resource path to query the parent spaces of the space|
|tenants|string¦null|false|none|Resource path to query the tenants of the space|
|owners|string¦null|false|none|Resource path to query the owners of the space|
|propertyManagers|string¦null|false|none|Resource path to query the property managers of the space|
|facilityManagers|string¦null|false|none|Resource path to query the facility managers of the space|
|visitors|string¦null|false|none|Resource path to query the visitors of the space|
|datapoints|[[DatapointInstanceDTO](#schemadatapointinstancedto)]¦null|false|none|List of dataPoint instances inherited from datapoint template|
|properties|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|List of properties inherited from property template|
|functionalBlocks|[[FunctionalBlockInstanceOfZoneDTO](#schemafunctionalblockinstanceofzonedto)]¦null|false|none|List of functional block instances attached to the zone|
|authorized|boolean|false|none|If true access is granted to this zone.|
|parentIds|[string]¦null|false|none|List of parent zones attached to the zone|
|childrenIds|[string]¦null|false|none|List of children zone instance definition attached to the created zone<br>(information only)|
|hasMapView|boolean|false|none|True if zone has a mapview attached to it|
|id|string¦null|false|none|Unique identifier of the zone instance|
|name|string¦null|false|none|Localized name of the zone instance|
|icon|string¦null|false|none|Optional image representing the zoneInstance<br>This field is readonly and ignored during a put/post for a zone instance attached to a zone template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the zone instance template (if any)|
|type|[ZoneType](#schemazonetype)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the zone|
|propertyZoneType|[PropertyZoneType](#schemapropertyzonetype)|false|none|Type of a property area|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_SshServiceStatus">SshServiceStatus</h2>
<!-- backwards compatibility -->
<a id="schemasshservicestatus"></a>
<a id="schema_SshServiceStatus"></a>
<a id="tocSsshservicestatus"></a>
<a id="tocssshservicestatus"></a>

```json
{
  "status": "stopped",
  "allocatedPort": 0
}

```

Shows the status of the tunnel plus the allocated port used on the relay server

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|status|[SshStatus](#schemasshstatus)|false|none|none|
|allocatedPort|integer(int32)|false|none|Which port has been allocated on the relay server for this device|

<h2 id="tocS_SshStatus">SshStatus</h2>
<!-- backwards compatibility -->
<a id="schemasshstatus"></a>
<a id="schema_SshStatus"></a>
<a id="tocSsshstatus"></a>
<a id="tocssshstatus"></a>

```json
"stopped"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|stopped|
|*anonymous*|connecting|
|*anonymous*|connected|
|*anonymous*|error|
|*anonymous*|stalled|

<h2 id="tocS_StationDTO">StationDTO</h2>
<!-- backwards compatibility -->
<a id="schemastationdto"></a>
<a id="schema_StationDTO"></a>
<a id="tocSstationdto"></a>
<a id="tocsstationdto"></a>

```json
{
  "id": "string",
  "name": "string",
  "address": {
    "address": "string",
    "port": 0
  },
  "disabled": true,
  "isLocal": true,
  "automaticSynchro": true,
  "floorIds": [
    "string"
  ],
  "hardwareLayoutId": "string",
  "needFullSynchro": true,
  "stopAutomaticSynchroAfterErrors": 0,
  "synchroPeriodAfterChange": 0,
  "synchroPeriodAfterError": 0,
  "networkIds": [
    "string"
  ],
  "driverIds": [
    "string"
  ],
  "reconnectionInterval": "string",
  "reconnectionIntervalOnInternalError": "string"
}

```

Information about a station

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique database identifier of the station|
|name|string¦null|false|none|Name of the station|
|address|[IPEndPointDTO](#schemaipendpointdto)|false|none|none|
|disabled|boolean|false|none|Indicates if the station is enabled or disabled.<br>If it is disabled, it is not possible to write datapoint values on it.|
|isLocal|boolean|false|none|Indicates if the station is the local one.|
|automaticSynchro|boolean|false|none|Indicates if automatic BOS to middleware synchronization is activated.|
|floorIds|[string]¦null|false|none|List of unique database identifiers of the floors managed by the station.|
|hardwareLayoutId|string¦null|false|none|Unique database identifier of the hardware layout of the station.|
|needFullSynchro|boolean|false|none|Indicates if the station needs a full BOS to middleware synchronization.|
|stopAutomaticSynchroAfterErrors|integer(int32)|false|none|Number of BOS to middleware synchronization errors from which to disable automatic synchronization on the station.|
|synchroPeriodAfterChange|integer(int64)|false|none|Period of time in milliseconds before to start a BOS to middleware synchronization after a change in BOS entity.|
|synchroPeriodAfterError|integer(int64)|false|none|Period of time in milliseconds before to retry a BOS to middleware synchronization after a synchronization error.|
|networkIds|[string]¦null|false|none|List of unique database identifiers of the networks linked to the station.|
|driverIds|[string]¦null|false|none|List of unique database identifiers of the drivers available on the station.|
|reconnectionInterval|string(date-span)|false|none|Period of time in seconds before to retry to reconnect to the station.|
|reconnectionIntervalOnInternalError|string(date-span)|false|none|Period of time in minutes before to retry to reconnect to the station after an error.|

<h2 id="tocS_StationInfoDTO">StationInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemastationinfodto"></a>
<a id="schema_StationInfoDTO"></a>
<a id="tocSstationinfodto"></a>
<a id="tocsstationinfodto"></a>

```json
{
  "trendRecentValueEventDateTime": "2019-08-24T14:15:22Z",
  "trendLatestPurgeDateTime": "2019-08-24T14:15:22Z",
  "id": "string",
  "name": "string",
  "address": {
    "address": "string",
    "port": 0
  },
  "disabled": true,
  "isLocal": true,
  "automaticSynchro": true,
  "floorIds": [
    "string"
  ],
  "hardwareLayoutId": "string",
  "needFullSynchro": true,
  "stopAutomaticSynchroAfterErrors": 0,
  "synchroPeriodAfterChange": 0,
  "synchroPeriodAfterError": 0,
  "networkIds": [
    "string"
  ],
  "driverIds": [
    "string"
  ],
  "reconnectionInterval": "string",
  "reconnectionIntervalOnInternalError": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|trendRecentValueEventDateTime|string(date-time)|false|none|none|
|trendLatestPurgeDateTime|string(date-time)|false|none|none|
|id|string¦null|false|none|Unique database identifier of the station|
|name|string¦null|false|none|Name of the station|
|address|[IPEndPointDTO](#schemaipendpointdto)|false|none|none|
|disabled|boolean|false|none|Indicates if the station is enabled or disabled.<br>If it is disabled, it is not possible to write datapoint values on it.|
|isLocal|boolean|false|none|Indicates if the station is the local one.|
|automaticSynchro|boolean|false|none|Indicates if automatic BOS to middleware synchronization is activated.|
|floorIds|[string]¦null|false|none|List of unique database identifiers of the floors managed by the station.|
|hardwareLayoutId|string¦null|false|none|Unique database identifier of the hardware layout of the station.|
|needFullSynchro|boolean|false|none|Indicates if the station needs a full BOS to middleware synchronization.|
|stopAutomaticSynchroAfterErrors|integer(int32)|false|none|Number of BOS to middleware synchronization errors from which to disable automatic synchronization on the station.|
|synchroPeriodAfterChange|integer(int64)|false|none|Period of time in milliseconds before to start a BOS to middleware synchronization after a change in BOS entity.|
|synchroPeriodAfterError|integer(int64)|false|none|Period of time in milliseconds before to retry a BOS to middleware synchronization after a synchronization error.|
|networkIds|[string]¦null|false|none|List of unique database identifiers of the networks linked to the station.|
|driverIds|[string]¦null|false|none|List of unique database identifiers of the drivers available on the station.|
|reconnectionInterval|string(date-span)|false|none|Period of time in seconds before to retry to reconnect to the station.|
|reconnectionIntervalOnInternalError|string(date-span)|false|none|Period of time in minutes before to retry to reconnect to the station after an error.|

<h2 id="tocS_StationSynchroStatusDTO">StationSynchroStatusDTO</h2>
<!-- backwards compatibility -->
<a id="schemastationsynchrostatusdto"></a>
<a id="schema_StationSynchroStatusDTO"></a>
<a id="tocSstationsynchrostatusdto"></a>
<a id="tocsstationsynchrostatusdto"></a>

```json
{
  "stationId": "string",
  "lastSynchroDate": "2019-08-24T14:15:22Z",
  "lastSynchroResult": "string",
  "lastSynchroType": "Full",
  "numberOfConsecutiveSynchroErrors": 0,
  "alarmSynchroErrors": [
    {
      "id": "string",
      "error": "string"
    }
  ],
  "networkSynchroErrors": [
    {
      "stationId": "string",
      "id": "string",
      "error": "string"
    }
  ],
  "trendSynchroErrors": [
    {
      "id": "string",
      "error": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|stationId|string¦null|false|none|none|
|lastSynchroDate|string(date-time)|false|none|none|
|lastSynchroResult|string¦null|false|none|none|
|lastSynchroType|[SynchroType](#schemasynchrotype)|false|none|none|
|numberOfConsecutiveSynchroErrors|integer(int32)|false|none|none|
|alarmSynchroErrors|[[AlarmSynchroErrorDTO](#schemaalarmsynchroerrordto)]¦null|false|none|none|
|networkSynchroErrors|[[NetworkSynchroErrorDTO](#schemanetworksynchroerrordto)]¦null|false|none|none|
|trendSynchroErrors|[[TrendSynchroErrorDTO](#schematrendsynchroerrordto)]¦null|false|none|none|

<h2 id="tocS_StringAnimationDTO">StringAnimationDTO</h2>
<!-- backwards compatibility -->
<a id="schemastringanimationdto"></a>
<a id="schema_StringAnimationDTO"></a>
<a id="tocSstringanimationdto"></a>
<a id="tocsstringanimationdto"></a>

```json
{
  "animationType": "Float",
  "defaultValue": "string",
  "id": "string",
  "datapointTemplateId": "string",
  "functionalBlockTemplateId": "string",
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "selectionModeForZone": "All",
  "complexDataTypeFieldName": "string"
}

```

Base for all string animations.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|animationType|[AnimationType](#schemaanimationtype)|true|none|Types of animation.|
|defaultValue|string¦null|false|none|Default value (may be not used).|
|id|string¦null|false|none|Id of the animation.|
|datapointTemplateId|string¦null|false|none|Datapoint template id.|
|functionalBlockTemplateId|string¦null|false|none|Functional block template containing the datapoint template (if exists) (read only).|
|type|any|false|none|Type of the datapoint template (read only).|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|selectionModeForZone|[FBTypeOfSelection](#schemafbtypeofselection)|false|none|none|
|complexDataTypeFieldName|string¦null|false|none|Name of the field of the complex data type of the datapoint to use<br>Ignored if the datapoint data type is not a complex data type|

<h2 id="tocS_StringAnimationRangeDTO">StringAnimationRangeDTO</h2>
<!-- backwards compatibility -->
<a id="schemastringanimationrangedto"></a>
<a id="schema_StringAnimationRangeDTO"></a>
<a id="tocSstringanimationrangedto"></a>
<a id="tocsstringanimationrangedto"></a>

```json
{
  "value": "string",
  "min": 0,
  "minIncluded": true,
  "max": 0,
  "maxIncluded": true
}

```

Definition of a range for a string animation.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|value|string¦null|false|none|String value for the range.|
|min|number(double)¦null|false|none|Lower bound of the range.|
|minIncluded|boolean|false|none|True if the the range contains the lower bound.|
|max|number(double)¦null|false|none|Upper bound of the range.|
|maxIncluded|boolean|false|none|True if the upper bound belongs to the range.|

<h2 id="tocS_StringDataTypeDTO">StringDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schemastringdatatypedto"></a>
<a id="schema_StringDataTypeDTO"></a>
<a id="tocSstringdatatypedto"></a>
<a id="tocsstringdatatypedto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

String data type value definition. (type:"string")

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|

<h2 id="tocS_StringStringValueTuple">StringStringValueTuple</h2>
<!-- backwards compatibility -->
<a id="schemastringstringvaluetuple"></a>
<a id="schema_StringStringValueTuple"></a>
<a id="tocSstringstringvaluetuple"></a>
<a id="tocsstringstringvaluetuple"></a>

```json
{
  "item1": "string",
  "item2": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|item1|string¦null|false|none|none|
|item2|string¦null|false|none|none|

<h2 id="tocS_StructureDTO">StructureDTO</h2>
<!-- backwards compatibility -->
<a id="schemastructuredto"></a>
<a id="schema_StructureDTO"></a>
<a id="tocSstructuredto"></a>
<a id="tocsstructuredto"></a>

```json
{
  "surfaceGross": "string",
  "surfaceNet": "string",
  "people": "string",
  "structureType": "string",
  "building": "string",
  "structureChildren": "string",
  "structureParents": "string",
  "zoneChildren": "string",
  "zoneParents": "string",
  "spaceChildren": "string",
  "mapview": "string",
  "tenants": "string",
  "owners": "string",
  "propertyManagers": "string",
  "facilityManagers": "string",
  "visitors": "string",
  "administrators": "string",
  "datapoints": [
    {
      "stationId": "string",
      "networkId": "string",
      "busUnitId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "converterId": "string",
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "properties": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "functionalBlocks": [
    {
      "functionalBlockId": "string",
      "group": "string",
      "masterMode": "None",
      "inZone": true
    }
  ],
  "authorized": true,
  "parentIds": [
    "string"
  ],
  "childrenIds": [
    "string"
  ],
  "hasMapView": true,
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "type": "Physical",
  "tags": [
    "string"
  ],
  "propertyZoneType": "Property",
  "isExternal": true
}

```

Represents a structure

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|surfaceGross|string¦null|false|none|Gross surface|
|surfaceNet|string¦null|false|none|Net surface|
|people|string¦null|false|none|Number of people|
|structureType|string¦null|false|none|Type of structure|
|building|string¦null|false|none|Resource path to query the buildings of the structure|
|structureChildren|string¦null|false|none|Resource path to query the children structure of the structure|
|structureParents|string¦null|false|none|Resource path to query the parent structure of the structure|
|zoneChildren|string¦null|false|none|Resource path to query the children zone of the structure|
|zoneParents|string¦null|false|none|Resource path to query the parent zones of the structure|
|spaceChildren|string¦null|false|none|Resource path to query the children spaces of the structure|
|mapview|string¦null|false|none|Resource path to query the map view of the structure|
|tenants|string¦null|false|none|Resource path to query the tenants of the structure|
|owners|string¦null|false|none|Resource path to query the owners of the structure|
|propertyManagers|string¦null|false|none|Resource path to query the property managers of the structure|
|facilityManagers|string¦null|false|none|Resource path to query the facility managers of the structure|
|visitors|string¦null|false|none|Resource path to query the visitors of the structure|
|administrators|string¦null|false|none|Resource path to query the administrators of the structure|
|datapoints|[[DatapointInstanceDTO](#schemadatapointinstancedto)]¦null|false|none|List of dataPoint instances inherited from datapoint template|
|properties|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|List of properties inherited from property template|
|functionalBlocks|[[FunctionalBlockInstanceOfZoneDTO](#schemafunctionalblockinstanceofzonedto)]¦null|false|none|List of functional block instances attached to the zone|
|authorized|boolean|false|none|If true access is granted to this zone.|
|parentIds|[string]¦null|false|none|List of parent zones attached to the zone|
|childrenIds|[string]¦null|false|none|List of children zone instance definition attached to the created zone<br>(information only)|
|hasMapView|boolean|false|none|True if zone has a mapview attached to it|
|id|string¦null|false|none|Unique identifier of the zone instance|
|name|string¦null|false|none|Localized name of the zone instance|
|icon|string¦null|false|none|Optional image representing the zoneInstance<br>This field is readonly and ignored during a put/post for a zone instance attached to a zone template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the zone instance template (if any)|
|type|[ZoneType](#schemazonetype)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the zone|
|propertyZoneType|[PropertyZoneType](#schemapropertyzonetype)|false|none|Type of a property area|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_StructureInitializationDTO">StructureInitializationDTO</h2>
<!-- backwards compatibility -->
<a id="schemastructureinitializationdto"></a>
<a id="schema_StructureInitializationDTO"></a>
<a id="tocSstructureinitializationdto"></a>
<a id="tocsstructureinitializationdto"></a>

```json
{
  "site": {
    "image": "string",
    "name": "string",
    "town": "string",
    "address1": "string",
    "address2": "string",
    "country": "string",
    "state": "string",
    "gpslat": "string",
    "gpslon": "string",
    "surfacegross": "string",
    "people": "string",
    "tags": [
      "string"
    ],
    "templateId": "string"
  },
  "users": [
    {
      "name": "string",
      "initials": "string",
      "icon": "string",
      "email": "string",
      "company": "string",
      "firstname": "string",
      "lastname": "string",
      "phone": "string",
      "preferences": {
        "property1": "string",
        "property2": "string"
      },
      "hasAccessFromCloud": true,
      "password": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|site|[SiteDTO](#schemasitedto)|false|none|none|
|users|[[InitUserDTO](#schemainituserdto)]¦null|false|none|none|

<h2 id="tocS_SubscriptionDTO">SubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemasubscriptiondto"></a>
<a id="schema_SubscriptionDTO"></a>
<a id="tocSsubscriptiondto"></a>
<a id="tocssubscriptiondto"></a>

```json
{
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_SynchronizationStateDTO">SynchronizationStateDTO</h2>
<!-- backwards compatibility -->
<a id="schemasynchronizationstatedto"></a>
<a id="schema_SynchronizationStateDTO"></a>
<a id="tocSsynchronizationstatedto"></a>
<a id="tocssynchronizationstatedto"></a>

```json
{
  "synchronizationState": "Done",
  "receivedSynchronizationDate": "2019-08-24T14:15:22Z",
  "appliedSynchronizationDate": "2019-08-24T14:15:22Z",
  "buildingNeedResolution": true,
  "functionalBlockTemplatesNeedResolution": true,
  "mapsNeedResolution": true,
  "networksNeedResolution": true,
  "networksOfMapNeedSynchronization": true,
  "zoneTemplatesNeedResolution": true,
  "dataToApply": true,
  "userLevel": "Integrator",
  "projectAvailable": true,
  "dateLastStep": "2019-08-24T14:15:22Z",
  "lastStep": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|synchronizationState|[PendingSynchronization](#schemapendingsynchronization)|false|none|none|
|receivedSynchronizationDate|string(date-time)¦null|false|none|none|
|appliedSynchronizationDate|string(date-time)¦null|false|none|none|
|buildingNeedResolution|boolean|false|none|none|
|functionalBlockTemplatesNeedResolution|boolean|false|none|none|
|mapsNeedResolution|boolean|false|none|none|
|networksNeedResolution|boolean|false|none|none|
|networksOfMapNeedSynchronization|boolean|false|none|none|
|zoneTemplatesNeedResolution|boolean|false|none|none|
|dataToApply|boolean|false|none|none|
|userLevel|[ImportUserLevel](#schemaimportuserlevel)|false|none|none|
|projectAvailable|boolean|false|none|none|
|dateLastStep|string(date-time)¦null|false|none|none|
|lastStep|string¦null|false|none|none|

<h2 id="tocS_SynchronizationStateSetDTO">SynchronizationStateSetDTO</h2>
<!-- backwards compatibility -->
<a id="schemasynchronizationstatesetdto"></a>
<a id="schema_SynchronizationStateSetDTO"></a>
<a id="tocSsynchronizationstatesetdto"></a>
<a id="tocssynchronizationstatesetdto"></a>

```json
{
  "dateLastStep": "2019-08-24T14:15:22Z",
  "lastStep": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|dateLastStep|string(date-time)¦null|false|none|none|
|lastStep|string¦null|false|none|none|

<h2 id="tocS_SynchroState">SynchroState</h2>
<!-- backwards compatibility -->
<a id="schemasynchrostate"></a>
<a id="schema_SynchroState"></a>
<a id="tocSsynchrostate"></a>
<a id="tocssynchrostate"></a>

```json
"Idle"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Idle|
|*anonymous*|Modified|
|*anonymous*|Deleted|
|*anonymous*|SyncModified|
|*anonymous*|SyncDeleted|
|*anonymous*|TimeTableModified|
|*anonymous*|TimeTableSyncModified|

<h2 id="tocS_SynchroType">SynchroType</h2>
<!-- backwards compatibility -->
<a id="schemasynchrotype"></a>
<a id="schema_SynchroType"></a>
<a id="tocSsynchrotype"></a>
<a id="tocssynchrotype"></a>

```json
"Full"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Full|
|*anonymous*|Partial|

<h2 id="tocS_SyncMethodLaunchDTO">SyncMethodLaunchDTO</h2>
<!-- backwards compatibility -->
<a id="schemasyncmethodlaunchdto"></a>
<a id="schema_SyncMethodLaunchDTO"></a>
<a id="tocSsyncmethodlaunchdto"></a>
<a id="tocssyncmethodlaunchdto"></a>

```json
{
  "parameters": [
    {
      "id": "string",
      "value": null,
      "identifier": "string"
    }
  ]
}

```

DTO that hold data for a synchronous driver method call.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|parameters|[[DriverPropertyValueDTO](#schemadriverpropertyvaluedto)]¦null|false|none|Parameters for the call.|

<h2 id="tocS_TemplatedDatapointSelectorDTO">TemplatedDatapointSelectorDTO</h2>
<!-- backwards compatibility -->
<a id="schematemplateddatapointselectordto"></a>
<a id="schema_TemplatedDatapointSelectorDTO"></a>
<a id="tocStemplateddatapointselectordto"></a>
<a id="tocstemplateddatapointselectordto"></a>

```json
{
  "type": "ManualDatapointSelectorDTO",
  "datapointTemplateId": "string",
  "selector": {
    "id": "string"
  },
  "displayName": "string",
  "id": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[SelectorType](#schemaselectortype)|false|none|Discriminator of SelectorType|
|datapointTemplateId|string¦null|false|none|none|
|selector|[SelectorDTO](#schemaselectordto)|false|none|none|
|displayName|string¦null|false|none|none|
|id|string¦null|false|none|none|

<h2 id="tocS_TemplateScheduleConfigurationDTO">TemplateScheduleConfigurationDTO</h2>
<!-- backwards compatibility -->
<a id="schematemplatescheduleconfigurationdto"></a>
<a id="schema_TemplateScheduleConfigurationDTO"></a>
<a id="tocStemplatescheduleconfigurationdto"></a>
<a id="tocstemplatescheduleconfigurationdto"></a>

```json
{
  "zoneTemplateIds": [
    "string"
  ],
  "datapoints": [
    {
      "type": "ManualDatapointSelectorDTO",
      "datapointTemplateId": "string",
      "selector": {
        "id": "string"
      },
      "displayName": "string",
      "id": "string"
    }
  ],
  "overridableZoneInstanceIds": [
    "string"
  ],
  "type": "string",
  "id": "string",
  "name": "string",
  "generalSettings": {
    "exceptionsVisible": true,
    "resetOnUpdate": true,
    "resetOnReboot": true,
    "busRepetitionActive": true,
    "busRepetitionOnErrorOnly": true,
    "busRepetitionTimes": 0,
    "busRepetitionInterval": 0,
    "todayTomorrowVisible": true,
    "allowCustomAction": true
  },
  "actions": [
    {
      "id": "string",
      "name": "string",
      "custom": true,
      "color": "string",
      "valuesCanBeEditedInOperation": true,
      "actionElements": [
        {
          "priority": 0,
          "value": null,
          "type": "TemplateDatapointWriteDTO",
          "id": "string"
        }
      ]
    }
  ]
}

```

Complete information about a template schedule configuration.
It is configured based on dataPoint templates.
It will be processed inside the system to calculate the schedule instances that are auto-generated from this template.
The datapoint instances on which the auto-generated schedules will write are calculated from the list of TemplatedDataPointSelector that have been configured in the template scheduler configuration.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneTemplateIds|[string]¦null|false|none|List of unique BOS identifiers of the zone templates managed by the template schedule configuration.<br>This list must contains at least on item.<br>The datapoint templates managed by this template schedule configuration and linked to zone templates must belong to a zone template of this list.|
|datapoints|[[TemplatedDatapointSelectorDTO](#schematemplateddatapointselectordto)]¦null|false|none|List of datapoint templates managed by the template schedule configuration.<br>TemplatedDatapointSelectorDTO.Selector may be:<br>- a ZoneTemplateSelectorDTO if the datapoint template is linked to a zone template<br>    In this case, the zone template must be configured in ZoneTemplateIds list<br>- a FunctionalBlockSelectorDTO if the datapoint template is linked to a functional block template<br>    In this case, the functional block template can be any functional block template of the project (no limitation)|
|overridableZoneInstanceIds|[string]¦null|false|none|List of unique BOS identifiers of the zone instances for which an auto-generated schedule instance will be configured.<br>These zone instances must be either a zone instance based on a zone template configured in ZoneTemplateIds list or a hierarchical parent of such kind of zone instance.|
|type|[ScheduleConfigurationType](#schemascheduleconfigurationtype)|false|none|none|

<h2 id="tocS_TemplateScheduleConfigurationInfoDTO">TemplateScheduleConfigurationInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schematemplatescheduleconfigurationinfodto"></a>
<a id="schema_TemplateScheduleConfigurationInfoDTO"></a>
<a id="tocStemplatescheduleconfigurationinfodto"></a>
<a id="tocstemplatescheduleconfigurationinfodto"></a>

```json
{
  "zoneTemplateNames": [
    "string"
  ],
  "needToBeRefreshed": true,
  "zoneInstanceNames": [
    "string"
  ],
  "type": "string",
  "id": "string",
  "name": "string"
}

```

Template schedule configuration info DTO

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneTemplateNames|[string]¦null|false|none|List of names of the zone templates managed by the schedule configuration|
|needToBeRefreshed|boolean|false|none|Indicates if a modification of schedule configuration must be applied to schedule instances|
|zoneInstanceNames|[string]¦null|false|none|List of names of the zone instances managed by the schedule configuration|
|type|[ScheduleConfigurationType](#schemascheduleconfigurationtype)|false|none|none|

<h2 id="tocS_TextAnimationDTO">TextAnimationDTO</h2>
<!-- backwards compatibility -->
<a id="schematextanimationdto"></a>
<a id="schema_TextAnimationDTO"></a>
<a id="tocStextanimationdto"></a>
<a id="tocstextanimationdto"></a>

```json
{
  "id": "string",
  "datapointTemplateId": "string",
  "functionalBlockTemplateId": "string",
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "selectionModeForZone": "All",
  "complexDataTypeFieldName": "string"
}

```

Text animation in a functional block animation (may be enriched in the future).

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id of the animation.|
|datapointTemplateId|string¦null|false|none|Datapoint template id.|
|functionalBlockTemplateId|string¦null|false|none|Functional block template containing the datapoint template (if exists) (read only).|
|type|any|false|none|Type of the datapoint template (read only).|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|selectionModeForZone|[FBTypeOfSelection](#schemafbtypeofselection)|false|none|none|
|complexDataTypeFieldName|string¦null|false|none|Name of the field of the complex data type of the datapoint to use<br>Ignored if the datapoint data type is not a complex data type|

<h2 id="tocS_TimeSpanDataTypeDTO">TimeSpanDataTypeDTO</h2>
<!-- backwards compatibility -->
<a id="schematimespandatatypedto"></a>
<a id="schema_TimeSpanDataTypeDTO"></a>
<a id="tocStimespandatatypedto"></a>
<a id="tocstimespandatatypedto"></a>

```json
{
  "type": "string",
  "id": "string",
  "name": "string",
  "tag": "string",
  "transport": "none"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|[DataTypeType](#schemadatatypetype)|false|none|Discriminator of DataType|

<h2 id="tocS_ToggleRescueModeDTO">ToggleRescueModeDTO</h2>
<!-- backwards compatibility -->
<a id="schematogglerescuemodedto"></a>
<a id="schema_ToggleRescueModeDTO"></a>
<a id="tocStogglerescuemodedto"></a>
<a id="tocstogglerescuemodedto"></a>

```json
{
  "reason": "string",
  "enabled": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|reason|string¦null|false|none|none|
|enabled|boolean|false|none|none|

<h2 id="tocS_TransportType">TransportType</h2>
<!-- backwards compatibility -->
<a id="schematransporttype"></a>
<a id="schema_TransportType"></a>
<a id="tocStransporttype"></a>
<a id="tocstransporttype"></a>

```json
"none"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|none|
|*anonymous*|BACnet|
|*anonymous*|KNXIP|
|*anonymous*|Lonworks|
|*anonymous*|ModbusSerial|
|*anonymous*|ModbusIP|
|*anonymous*|MBus|
|*anonymous*|xDriver|
|*anonymous*|Memory|

<h2 id="tocS_TrendConfigurationDTO">TrendConfigurationDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendconfigurationdto"></a>
<a id="schema_TrendConfigurationDTO"></a>
<a id="tocStrendconfigurationdto"></a>
<a id="tocstrendconfigurationdto"></a>

```json
{
  "name": "string",
  "frequency": 10000,
  "deadband": 0,
  "retention": "",
  "generateDummyValues": false,
  "valuesConfiguration": {
    "from": "2019-08-24T14:15:22Z",
    "to": "2019-08-24T14:15:22Z",
    "min": 0,
    "max": 0,
    "frequency": "string",
    "withBadQuality": true
  }
}

```

Trend configuration

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the trendtemplate|
|frequency|integer(int64)¦null|false|none|Frequency of the trend in milliseconds.<br>If not present it is will be 10 seconds, if zero disable the trend|
|deadband|number(double)¦null|false|none|Deadband<br>If not present it is will be 0|
|retention|string¦null|false|none|Retention policy name<br>If empty it is use the default retention policy|
|generateDummyValues|boolean|false|none|Generate dummy values<br>If true, random trend values are generated|
|valuesConfiguration|[TrendValuesConfigurationDTO](#schematrendvaluesconfigurationdto)|false|none|Configuration of trend values|

<h2 id="tocS_TrendInstanceAdvancedDTO">TrendInstanceAdvancedDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendinstanceadvanceddto"></a>
<a id="schema_TrendInstanceAdvancedDTO"></a>
<a id="tocStrendinstanceadvanceddto"></a>
<a id="tocstrendinstanceadvanceddto"></a>

```json
{
  "zoneName": "string",
  "zoneTemplateName": "string",
  "zoneParentName": "string",
  "functionalBlockName": "string",
  "functionalBlockTemplateName": "string",
  "datapointInstanceName": "string",
  "icon": "string",
  "iconFillColor": "string",
  "type": {
    "type": "string",
    "id": "string",
    "name": "string",
    "tag": "string",
    "transport": "none"
  },
  "unitShortString": "string",
  "unitID": "string",
  "id": "string",
  "override": true,
  "templateId": "string",
  "datapoint": {
    "identifier": {
      "type": 0,
      "busDatapointId": "string",
      "networkId": "string",
      "id": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    },
    "displayName": "string"
  },
  "datapointId": "string",
  "retentionPolicyId": "string",
  "deadband": 0,
  "frequency": 0,
  "display": "Curve",
  "defaultColor": "string",
  "active": true,
  "store": {
    "name": "string",
    "durationDays": 0
  },
  "realTimeValueAligned": true,
  "useIfExist": true,
  "applicationSource": "string",
  "functionalBlockId": "string",
  "zoneId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneName|string¦null|false|none|Name of the zone of the datapoint instance or empty|
|zoneTemplateName|string¦null|false|none|Name of the zone template of the datapoint instance or empty|
|zoneParentName|string¦null|false|none|Name of the zone parent of the zone of the datapoint instance or empty|
|functionalBlockName|string¦null|false|none|Name of the functionalBlock of the datapoint instance or empty|
|functionalBlockTemplateName|string¦null|false|none|Name of the functionalBlock template of the datapoint instance or empty|
|datapointInstanceName|string¦null|false|none|Name of the datapoint instance|
|icon|string¦null|false|none|Icon of functional block if datapoint of the trend attached to a functional block<br>Icon of zone if datapoint of the trend attached to a zone<br>Empty in other case|
|iconFillColor|string¦null|false|none|Fillcolor (if any) of Icon|
|type|any|false|none|Data type of the datapoint.|

oneOf - discriminator: DataTypeDTO.type

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DataTypeDTO](#schemadatatypedto)|false|none|Data type value definition|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[LongDataTypeDTO](#schemalongdatatypedto)|false|none|Long data type value definition. (type:"long")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DoubleDataTypeDTO](#schemadoubledatatypedto)|false|none|Double data type value definition.  (type:"double")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BoolDataTypeDTO](#schemabooldatatypedto)|false|none|Bool data type value definition.  (type:"bool")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[StringDataTypeDTO](#schemastringdatatypedto)|false|none|String data type value definition. (type:"string")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumerationDataTypeDTO](#schemaenumerationdatatypedto)|false|none|Enumeration data type value definition. (type:"Enum")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ComplexDataTypeDTO](#schemacomplexdatatypedto)|false|none|Complex data type value definition. (type:"Complex")|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[DateTimeOffsetDataTypeDTO](#schemadatetimeoffsetdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[TimeSpanDataTypeDTO](#schematimespandatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPAddressDataTypeDTO](#schemaipaddressdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[IPEndPointDataTypeDTO](#schemaipendpointdatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ArrayDataTypeDTO](#schemaarraydatatypedto)|false|none|none|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[ByteDataTypeDTO](#schemabytedatatypedto)|false|none|none|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|unitShortString|string¦null|false|none|Small unit string|
|unitID|string¦null|false|none|ID of the unit.|
|id|string¦null|false|none|Identifier of the trend instance|
|override|boolean|false|none|True if trend instance data override its template|
|templateId|string¦null|false|none|Identifier of the template of the trend instance|
|datapoint|[DatapointIdentifierWithNameDTO](#schemadatapointidentifierwithnamedto)|false|none|Common data for all datapoint identifier dtos with display name|
|datapointId|string¦null|false|none|Alternate definition of datapoint for compatibility.|
|retentionPolicyId|string¦null|false|none|Identifier of the retention policy used by this trend instance|
|deadband|number(double)|false|none|Deadband of the trend instance|
|frequency|integer(int64)¦null|false|none|Trend values transmission frequency|
|display|[DisplayType](#schemadisplaytype)|false|none|none|
|defaultColor|string¦null|false|none|Default color used to display trends|
|active|boolean|false|none|Trend instance should be active to retrieve trend values|
|store|[TrendStoreDTO](#schematrendstoredto)|false|none|none|
|realTimeValueAligned|boolean|false|none|True when timestamp of real time trend's value will be aligned with trend's frequency|
|useIfExist|boolean|false|none|if True, the creation returns the existing trend instance if the trend instance is linked to the same datapoint and the same store<br>else the creation raize an error when a trend is already present<br>False by default|
|applicationSource|string¦null|false|none|Name of the application responsible for alarm instance creation/update. May be null|
|functionalBlockId|string¦null|false|none|Id of asset. For individual alarms only.|
|zoneId|string¦null|false|none|Id of zone. For individual alarms only.|

<h2 id="tocS_TrendInstanceCreationDTO">TrendInstanceCreationDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendinstancecreationdto"></a>
<a id="schema_TrendInstanceCreationDTO"></a>
<a id="tocStrendinstancecreationdto"></a>
<a id="tocstrendinstancecreationdto"></a>

```json
{
  "datapoint": {
    "identifier": {
      "type": 0,
      "busDatapointId": "string",
      "networkId": "string",
      "id": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    },
    "displayName": "string"
  },
  "datapointId": "string",
  "retentionPolicyId": "string",
  "deadband": 0,
  "frequency": 0,
  "display": "Curve",
  "defaultColor": "string",
  "active": true,
  "store": {
    "name": "string",
    "durationDays": 0
  },
  "realTimeValueAligned": true,
  "useIfExist": true,
  "applicationSource": "string",
  "functionalBlockId": "string",
  "zoneId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapoint|[DatapointIdentifierWithNameDTO](#schemadatapointidentifierwithnamedto)|false|none|Common data for all datapoint identifier dtos with display name|
|datapointId|string¦null|false|none|Alternate definition of datapoint for compatibility.|
|retentionPolicyId|string¦null|false|none|Identifier of the retention policy used by this trend instance|
|deadband|number(double)|false|none|Deadband of the trend instance|
|frequency|integer(int64)¦null|false|none|Trend values transmission frequency|
|display|[DisplayType](#schemadisplaytype)|false|none|none|
|defaultColor|string¦null|false|none|Default color used to display trends|
|active|boolean|false|none|Trend instance should be active to retrieve trend values|
|store|[TrendStoreDTO](#schematrendstoredto)|false|none|none|
|realTimeValueAligned|boolean|false|none|True when timestamp of real time trend's value will be aligned with trend's frequency|
|useIfExist|boolean|false|none|if True, the creation returns the existing trend instance if the trend instance is linked to the same datapoint and the same store<br>else the creation raize an error when a trend is already present<br>False by default|
|applicationSource|string¦null|false|none|Name of the application responsible for alarm instance creation/update. May be null|
|functionalBlockId|string¦null|false|none|Id of asset. For individual alarms only.|
|zoneId|string¦null|false|none|Id of zone. For individual alarms only.|

<h2 id="tocS_TrendInstanceDTO">TrendInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendinstancedto"></a>
<a id="schema_TrendInstanceDTO"></a>
<a id="tocStrendinstancedto"></a>
<a id="tocstrendinstancedto"></a>

```json
{
  "id": "string",
  "override": true,
  "templateId": "string",
  "datapoint": {
    "identifier": {
      "type": 0,
      "busDatapointId": "string",
      "networkId": "string",
      "id": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    },
    "displayName": "string"
  },
  "datapointId": "string",
  "retentionPolicyId": "string",
  "deadband": 0,
  "frequency": 0,
  "display": "Curve",
  "defaultColor": "string",
  "active": true,
  "store": {
    "name": "string",
    "durationDays": 0
  },
  "realTimeValueAligned": true,
  "useIfExist": true,
  "applicationSource": "string",
  "functionalBlockId": "string",
  "zoneId": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Identifier of the trend instance|
|override|boolean|false|none|True if trend instance data override its template|
|templateId|string¦null|false|none|Identifier of the template of the trend instance|
|datapoint|[DatapointIdentifierWithNameDTO](#schemadatapointidentifierwithnamedto)|false|none|Common data for all datapoint identifier dtos with display name|
|datapointId|string¦null|false|none|Alternate definition of datapoint for compatibility.|
|retentionPolicyId|string¦null|false|none|Identifier of the retention policy used by this trend instance|
|deadband|number(double)|false|none|Deadband of the trend instance|
|frequency|integer(int64)¦null|false|none|Trend values transmission frequency|
|display|[DisplayType](#schemadisplaytype)|false|none|none|
|defaultColor|string¦null|false|none|Default color used to display trends|
|active|boolean|false|none|Trend instance should be active to retrieve trend values|
|store|[TrendStoreDTO](#schematrendstoredto)|false|none|none|
|realTimeValueAligned|boolean|false|none|True when timestamp of real time trend's value will be aligned with trend's frequency|
|useIfExist|boolean|false|none|if True, the creation returns the existing trend instance if the trend instance is linked to the same datapoint and the same store<br>else the creation raize an error when a trend is already present<br>False by default|
|applicationSource|string¦null|false|none|Name of the application responsible for alarm instance creation/update. May be null|
|functionalBlockId|string¦null|false|none|Id of asset. For individual alarms only.|
|zoneId|string¦null|false|none|Id of zone. For individual alarms only.|

<h2 id="tocS_TrendPeriodType">TrendPeriodType</h2>
<!-- backwards compatibility -->
<a id="schematrendperiodtype"></a>
<a id="schema_TrendPeriodType"></a>
<a id="tocStrendperiodtype"></a>
<a id="tocstrendperiodtype"></a>

```json
"Auto"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Auto|
|*anonymous*|RealTime|
|*anonymous*|DownSampling|

<h2 id="tocS_TrendStoreDTO">TrendStoreDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendstoredto"></a>
<a id="schema_TrendStoreDTO"></a>
<a id="tocStrendstoredto"></a>
<a id="tocstrendstoredto"></a>

```json
{
  "name": "string",
  "durationDays": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|durationDays|integer(int32)|false|none|none|

<h2 id="tocS_TrendSubscriptionCreationDTO">TrendSubscriptionCreationDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendsubscriptioncreationdto"></a>
<a id="schema_TrendSubscriptionCreationDTO"></a>
<a id="tocStrendsubscriptioncreationdto"></a>
<a id="tocstrendsubscriptioncreationdto"></a>

```json
{
  "trendInstanceIds": [
    "string"
  ],
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|trendInstanceIds|[string]¦null|false|none|none|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_TrendSubscriptionDTO">TrendSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendsubscriptiondto"></a>
<a id="schema_TrendSubscriptionDTO"></a>
<a id="tocStrendsubscriptiondto"></a>
<a id="tocstrendsubscriptiondto"></a>

```json
{
  "interval": 0,
  "trendInstanceIds": [
    "string"
  ],
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|interval|integer(int32)|false|none|none|
|trendInstanceIds|[string]¦null|false|none|none|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_TrendSubscriptionResultDTO">TrendSubscriptionResultDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendsubscriptionresultdto"></a>
<a id="schema_TrendSubscriptionResultDTO"></a>
<a id="tocStrendsubscriptionresultdto"></a>
<a id="tocstrendsubscriptionresultdto"></a>

```json
{
  "id": "string",
  "interval": 0,
  "invalidTrendInstanceIds": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|interval|integer(int32)|false|none|none|
|invalidTrendInstanceIds|[string]¦null|false|none|none|

<h2 id="tocS_TrendSynchroErrorDTO">TrendSynchroErrorDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendsynchroerrordto"></a>
<a id="schema_TrendSynchroErrorDTO"></a>
<a id="tocStrendsynchroerrordto"></a>
<a id="tocstrendsynchroerrordto"></a>

```json
{
  "id": "string",
  "error": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|error|string¦null|false|none|none|

<h2 id="tocS_TrendTemplateDTO">TrendTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendtemplatedto"></a>
<a id="schema_TrendTemplateDTO"></a>
<a id="tocStrendtemplatedto"></a>
<a id="tocstrendtemplatedto"></a>

```json
{
  "id": "string",
  "name": "string",
  "datapointSelector": {
    "id": "string"
  },
  "retentionPolicyId": "string",
  "deadband": 0,
  "frequency": 0,
  "display": "Curve",
  "defaultColor": "string",
  "needRefreshInstances": true,
  "complexDataTypeFieldName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Id|
|name|string¦null|false|none|Name of the trend template|
|datapointSelector|[DatapointSelectorDTO](#schemadatapointselectordto)|false|none|none|
|retentionPolicyId|string¦null|false|none|Unique identifier of the retention policy|
|deadband|number(double)|false|none|Deadband of the trend template|
|frequency|integer(int64)¦null|false|none|Frequency of the trend template|
|display|[DisplayType](#schemadisplaytype)|false|none|none|
|defaultColor|string¦null|false|none|Default Color of trend template<br>Must be an hexa color, ex : #FFFFFF|
|needRefreshInstances|boolean|false|none|Need refresh instance indicator of trend template.<br> If true indicates that after an update of a trend template, you must call RefreshInstances rest API <br> to regenerate trend instance of this trend template|
|complexDataTypeFieldName|string¦null|false|none|Name of the field of the complex data type of the datapoint to use<br>Ignored if the datapoint data type is not a complex data type|

<h2 id="tocS_TrendToDatapointSubscriptionCreateDTO">TrendToDatapointSubscriptionCreateDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendtodatapointsubscriptioncreatedto"></a>
<a id="schema_TrendToDatapointSubscriptionCreateDTO"></a>
<a id="tocStrendtodatapointsubscriptioncreatedto"></a>
<a id="tocstrendtodatapointsubscriptioncreatedto"></a>

```json
{
  "ignoreErrors": true,
  "items": [
    {
      "scanRate": 0,
      "deadBand": 0,
      "datapointClientId": "string",
      "trendInstanceId": "string",
      "tags": [
        "string"
      ]
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|ignoreErrors|boolean|false|none|none|
|items|[[TrendToDatapointSubscriptionCreateItemDTO](#schematrendtodatapointsubscriptioncreateitemdto)]¦null|false|none|none|

<h2 id="tocS_TrendToDatapointSubscriptionCreateItemDTO">TrendToDatapointSubscriptionCreateItemDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendtodatapointsubscriptioncreateitemdto"></a>
<a id="schema_TrendToDatapointSubscriptionCreateItemDTO"></a>
<a id="tocStrendtodatapointsubscriptioncreateitemdto"></a>
<a id="tocstrendtodatapointsubscriptioncreateitemdto"></a>

```json
{
  "scanRate": 0,
  "deadBand": 0,
  "datapointClientId": "string",
  "trendInstanceId": "string",
  "tags": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|scanRate|integer(int32)|false|none|none|
|deadBand|number(double)|false|none|none|
|datapointClientId|string¦null|false|none|none|
|trendInstanceId|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|

<h2 id="tocS_TrendValueRowDTO">TrendValueRowDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendvaluerowdto"></a>
<a id="schema_TrendValueRowDTO"></a>
<a id="tocStrendvaluerowdto"></a>
<a id="tocstrendvaluerowdto"></a>

```json
{
  "quality": "Uncertain",
  "min": 0,
  "max": 0,
  "timeStamp": "2019-08-24T14:15:22Z",
  "totalPoints": 0,
  "value": null
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|quality|[Quality](#schemaquality)|false|none|none|
|min|number(double)¦null|false|none|none|
|max|number(double)¦null|false|none|none|
|timeStamp|string(date-time)|false|none|none|
|totalPoints|integer(int32)¦null|false|none|none|
|value|any|false|none|none|

<h2 id="tocS_TrendValuesConfigurationDTO">TrendValuesConfigurationDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendvaluesconfigurationdto"></a>
<a id="schema_TrendValuesConfigurationDTO"></a>
<a id="tocStrendvaluesconfigurationdto"></a>
<a id="tocstrendvaluesconfigurationdto"></a>

```json
{
  "from": "2019-08-24T14:15:22Z",
  "to": "2019-08-24T14:15:22Z",
  "min": 0,
  "max": 0,
  "frequency": "string",
  "withBadQuality": true
}

```

Configuration of trend values

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|from|string(date-time)|false|none|Start of date time interval for trend values timestamp|
|to|string(date-time)|false|none|End of date time interval for trend values timestamp|
|min|number(double)|false|none|Minimum value for generated values|
|max|number(double)|false|none|Maximum value for generated values|
|frequency|string(date-span)|false|none|Frequency between 2 values|
|withBadQuality|boolean|false|none|Randomly generate bad quality value|

<h2 id="tocS_TrendValuesGenerationDTO">TrendValuesGenerationDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendvaluesgenerationdto"></a>
<a id="schema_TrendValuesGenerationDTO"></a>
<a id="tocStrendvaluesgenerationdto"></a>
<a id="tocstrendvaluesgenerationdto"></a>

```json
{
  "trendInstanceId": "string",
  "refreshDownsamplings": true,
  "clearValues": true,
  "generateLongValues": true,
  "valuesConfiguration": {
    "from": "2019-08-24T14:15:22Z",
    "to": "2019-08-24T14:15:22Z",
    "min": 0,
    "max": 0,
    "frequency": "string",
    "withBadQuality": true
  },
  "synchronousGeneration": false
}

```

Settings to generate the trend values

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|trendInstanceId|string¦null|false|none|Trend instance identifier for trend values|
|refreshDownsamplings|boolean|false|none|Enable downsampling refreshing after trend values are generated and inserted|
|clearValues|boolean|false|none|True to clear all values of the trend instance before injecting new values|
|generateLongValues|boolean|false|none|Generate long values and not double|
|valuesConfiguration|[TrendValuesConfigurationDTO](#schematrendvaluesconfigurationdto)|false|none|Configuration of trend values|
|synchronousGeneration|boolean|false|none|If true generation of database will be synchronous (rest call will be blocked during execution)|

<h2 id="tocS_TrendValuesHeatmapInjectionDTO">TrendValuesHeatmapInjectionDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendvaluesheatmapinjectiondto"></a>
<a id="schema_TrendValuesHeatmapInjectionDTO"></a>
<a id="tocStrendvaluesheatmapinjectiondto"></a>
<a id="tocstrendvaluesheatmapinjectiondto"></a>

```json
{
  "trendInstanceId": "string",
  "timeStamp": "2019-08-24T14:15:22Z",
  "value": 0
}

```

Settings to generate the trend values

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|trendInstanceId|string¦null|false|none|Trend instance identifier for trend values|
|timeStamp|string(date-time)|false|none|none|
|value|number(double)|false|none|none|

<h2 id="tocS_TrendValuesResultDTO">TrendValuesResultDTO</h2>
<!-- backwards compatibility -->
<a id="schematrendvaluesresultdto"></a>
<a id="schema_TrendValuesResultDTO"></a>
<a id="tocStrendvaluesresultdto"></a>
<a id="tocstrendvaluesresultdto"></a>

```json
{
  "downSamplingId": "string",
  "values": [
    {
      "quality": "Uncertain",
      "min": 0,
      "max": 0,
      "timeStamp": "2019-08-24T14:15:22Z",
      "totalPoints": 0,
      "value": null
    }
  ],
  "displayUnitShortString": "string",
  "downSamplingPeriod": "string",
  "cannotMatchMaximumCount": true,
  "valuesCount": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|downSamplingId|string¦null|false|none|Id of downsampling (null if realtime values)|
|values|[[TrendValueRowDTO](#schematrendvaluerowdto)]¦null|false|none|Trend value data|
|displayUnitShortString|string¦null|false|none|Display unit.|
|downSamplingPeriod|string(date-span)¦null|false|none|Downsampling period (if available).|
|cannotMatchMaximumCount|boolean|false|none|True means the route was not able to find a downsampling to match the maximumCount of request.<br>If true Values is always empty.|
|valuesCount|integer(int64)|false|none|Number of values.<br>If CannotMatchMaximumCount is false then it is equal to the number of element in Values.<br>If CannotMatchMaximumCount is true then it is equal to the number of found elements.|

<h2 id="tocS_TrustedAppDTO">TrustedAppDTO</h2>
<!-- backwards compatibility -->
<a id="schematrustedappdto"></a>
<a id="schema_TrustedAppDTO"></a>
<a id="tocStrustedappdto"></a>
<a id="tocstrustedappdto"></a>

```json
{
  "id": "string",
  "friendlyName": "string",
  "contactEmail": "string"
}

```

This defines a trusted application that can be enabled on the edge device

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|The unique identifier of the application (i.e. AAD app registration client id)|
|friendlyName|string¦null|false|none|The name of the application|
|contactEmail|string¦null|false|none|Contact person email address for this application|

<h2 id="tocS_TrustedAppEnableDTO">TrustedAppEnableDTO</h2>
<!-- backwards compatibility -->
<a id="schematrustedappenabledto"></a>
<a id="schema_TrustedAppEnableDTO"></a>
<a id="tocStrustedappenabledto"></a>
<a id="tocstrustedappenabledto"></a>

```json
{
  "tags": [
    "string"
  ],
  "roleIds": [
    "string"
  ],
  "accessRights": [
    "string"
  ],
  "id": "string",
  "friendlyName": "string",
  "contactEmail": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tags|[string]¦null|false|none|List of tags attached to the application|
|roleIds|[string]¦null|false|none|List of unique identifiers of roles to be assigned to the application|
|accessRights|[string]¦null|false|none|Read-only list of access right identifiers enabled for the application|
|id|string¦null|false|none|The unique identifier of the application (i.e. AAD app registration client id)|
|friendlyName|string¦null|false|none|The name of the application|
|contactEmail|string¦null|false|none|Contact person email address for this application|

<h2 id="tocS_TypeOverride">TypeOverride</h2>
<!-- backwards compatibility -->
<a id="schematypeoverride"></a>
<a id="schema_TypeOverride"></a>
<a id="tocStypeoverride"></a>
<a id="tocstypeoverride"></a>

```json
"Inherit"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Inherit|
|*anonymous*|Override|
|*anonymous*|Excluded|

<h2 id="tocS_UnitConversionDTO">UnitConversionDTO</h2>
<!-- backwards compatibility -->
<a id="schemaunitconversiondto"></a>
<a id="schema_UnitConversionDTO"></a>
<a id="tocSunitconversiondto"></a>
<a id="tocsunitconversiondto"></a>

```json
{
  "unitFrom": "string",
  "unitTo": "string",
  "value": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|unitFrom|string¦null|false|none|Id of unit of Value|
|unitTo|string¦null|false|none|Id of unit to convert.|
|value|number(double)|false|none|Value to convert|

<h2 id="tocS_UnitConversionExtendedDTO">UnitConversionExtendedDTO</h2>
<!-- backwards compatibility -->
<a id="schemaunitconversionextendeddto"></a>
<a id="schema_UnitConversionExtendedDTO"></a>
<a id="tocSunitconversionextendeddto"></a>
<a id="tocsunitconversionextendeddto"></a>

```json
{
  "unit": "string",
  "displayUnit": "string",
  "displayUnitToDisplayUnit": true,
  "floatValue": 0,
  "longValue": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|unit|string¦null|false|none|Id of unit|
|displayUnit|string¦null|false|none|Id of display unit.<br>If empty, display unit based on user culture info will be used|
|displayUnitToDisplayUnit|boolean|false|none|If true value is based on DisplayUnit. Returned value is based too on DisplayUnit but with rounding conversion (if any).<br>If false, value is based on Unit. Returned value is based on DisplayUnit.|
|floatValue|number(double)¦null|false|none|Value to convert|
|longValue|integer(int64)¦null|false|none|Value to convert|

<h2 id="tocS_UnitConversionExtendedResultDTO">UnitConversionExtendedResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemaunitconversionextendedresultdto"></a>
<a id="schema_UnitConversionExtendedResultDTO"></a>
<a id="tocSunitconversionextendedresultdto"></a>
<a id="tocsunitconversionextendedresultdto"></a>

```json
{
  "displayUnit": "string",
  "displayUnitShortString": "string",
  "floatValue": 0,
  "longValue": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|displayUnit|string¦null|false|none|Id of display unit that has been used for conversion.|
|displayUnitShortString|string¦null|false|none|Short string of display unit that has been used for conversion.|
|floatValue|number(double)¦null|false|none|Converted value|
|longValue|integer(int64)¦null|false|none|Converted value|

<h2 id="tocS_UnitDTO">UnitDTO</h2>
<!-- backwards compatibility -->
<a id="schemaunitdto"></a>
<a id="schema_UnitDTO"></a>
<a id="tocSunitdto"></a>
<a id="tocsunitdto"></a>

```json
{
  "displayName": "string",
  "unitShortString": "string",
  "resolution": 0,
  "category": "string",
  "preferredMin": 0,
  "preferredMax": 0
}

```

Unit description

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|displayName|string¦null|false|none|Localized name of the unit|
|unitShortString|string¦null|false|none|Small unit string|
|resolution|number(double)|false|none|Resolution of the unit|
|category|string¦null|false|none|Unique identifier of the family of the unit (electricity, weight, ...)|
|preferredMin|number(double)¦null|false|none|Preferred minimum value supported if any|
|preferredMax|number(double)¦null|false|none|Preferred maximum value supported if any|

<h2 id="tocS_UpdateInformationDTO">UpdateInformationDTO</h2>
<!-- backwards compatibility -->
<a id="schemaupdateinformationdto"></a>
<a id="schema_UpdateInformationDTO"></a>
<a id="tocSupdateinformationdto"></a>
<a id="tocsupdateinformationdto"></a>

```json
{
  "newVersion": "string",
  "currentVersion": "string",
  "slot0IsOk": true,
  "slot1IsOk": true,
  "lastUpdateCheckTime": "2019-08-24T14:15:22Z",
  "nextUpdateCheckTime": "2019-08-24T14:15:22Z",
  "updateError": {
    "code": "string",
    "message": "string"
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|newVersion|string¦null|false|none|The newest version that can be installed on the device|
|currentVersion|string¦null|false|none|The current version of the device|
|slot0IsOk|boolean|false|none|True if the boot slot 0 is ok|
|slot1IsOk|boolean|false|none|True if the boot slot 1 is ok|
|lastUpdateCheckTime|string(date-time)|false|none|The last time it was checked if an update is available|
|nextUpdateCheckTime|string(date-time)|false|none|The next time the device will check for an update|
|updateError|[EmbeddedErrorDTO](#schemaembeddederrordto)|false|none|none|

<h2 id="tocS_UserCreationDTO">UserCreationDTO</h2>
<!-- backwards compatibility -->
<a id="schemausercreationdto"></a>
<a id="schema_UserCreationDTO"></a>
<a id="tocSusercreationdto"></a>
<a id="tocsusercreationdto"></a>

```json
{
  "password": "string",
  "firstTimeConnection": true,
  "authenticationProviderId": "string",
  "roleIds": [
    "string"
  ],
  "company": "string",
  "firstname": "string",
  "lastname": "string",
  "phone": "string",
  "accessRights": [
    "string"
  ],
  "preferences": {
    "property1": "string",
    "property2": "string"
  },
  "active": true,
  "hasAccessFromCloud": true,
  "cloudRegistrationStatus": "None",
  "culture": "string",
  "timeZone": "string",
  "kind": "string",
  "id": "string",
  "name": "string",
  "initials": "string",
  "icon": "string",
  "tags": [
    "string"
  ],
  "isReadonly": true,
  "email": "string"
}

```

Definition of a user for creation

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|password|string¦null|false|none|none|
|firstTimeConnection|boolean|false|none|Indicates if the user connects for the first time|
|authenticationProviderId|string¦null|false|none|Unique identifier of the user provider|
|roleIds|[string]¦null|false|none|List of unique identifier of roles the user is member of|
|company|string¦null|false|none|Company|
|firstname|string¦null|false|none|First name|
|lastname|string¦null|false|none|Last name|
|phone|string¦null|false|none|Phone|
|accessRights|[string]¦null|false|none|List of access right identifiers enabled for the user|
|preferences|object¦null|false|none|List of access right identifiers enabled for the user|
|» **additionalProperties**|string|false|none|none|
|active|boolean|false|none|Define if user is currently active|
|hasAccessFromCloud|boolean¦null|false|none|Define if user has access to the edge device from the cloud|
|cloudRegistrationStatus|[CloudRegistrationStatus](#schemacloudregistrationstatus)|false|none|none|
|culture|string¦null|false|none|Culture of the user|
|timeZone|string¦null|false|none|Timezone of the user|
|kind|string¦null|false|none|What kind of security principal this is: interactive user or application|
|id|string¦null|false|none|Unique identifier of the user|
|name|string¦null|false|none|Localized name of the user|
|initials|string¦null|false|none|Initials of the user|
|icon|string¦null|false|none|Icon of the user|
|tags|[string]¦null|false|none|List of tags attached to user|
|isReadonly|boolean|false|none|Readonly user.<br>Readonly user cannot be deleted and its roles cannot be changed|
|email|string¦null|false|none|Email|

<h2 id="tocS_UserDTO">UserDTO</h2>
<!-- backwards compatibility -->
<a id="schemauserdto"></a>
<a id="schema_UserDTO"></a>
<a id="tocSuserdto"></a>
<a id="tocsuserdto"></a>

```json
{
  "firstTimeConnection": true,
  "authenticationProviderId": "string",
  "roleIds": [
    "string"
  ],
  "company": "string",
  "firstname": "string",
  "lastname": "string",
  "phone": "string",
  "accessRights": [
    "string"
  ],
  "preferences": {
    "property1": "string",
    "property2": "string"
  },
  "active": true,
  "hasAccessFromCloud": true,
  "cloudRegistrationStatus": "None",
  "culture": "string",
  "timeZone": "string",
  "kind": "string",
  "id": "string",
  "name": "string",
  "initials": "string",
  "icon": "string",
  "tags": [
    "string"
  ],
  "isReadonly": true,
  "email": "string"
}

```

Definition of a user

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|firstTimeConnection|boolean|false|none|Indicates if the user connects for the first time|
|authenticationProviderId|string¦null|false|none|Unique identifier of the user provider|
|roleIds|[string]¦null|false|none|List of unique identifier of roles the user is member of|
|company|string¦null|false|none|Company|
|firstname|string¦null|false|none|First name|
|lastname|string¦null|false|none|Last name|
|phone|string¦null|false|none|Phone|
|accessRights|[string]¦null|false|none|List of access right identifiers enabled for the user|
|preferences|object¦null|false|none|List of access right identifiers enabled for the user|
|» **additionalProperties**|string|false|none|none|
|active|boolean|false|none|Define if user is currently active|
|hasAccessFromCloud|boolean¦null|false|none|Define if user has access to the edge device from the cloud|
|cloudRegistrationStatus|[CloudRegistrationStatus](#schemacloudregistrationstatus)|false|none|none|
|culture|string¦null|false|none|Culture of the user|
|timeZone|string¦null|false|none|Timezone of the user|
|kind|string¦null|false|none|What kind of security principal this is: interactive user or application|
|id|string¦null|false|none|Unique identifier of the user|
|name|string¦null|false|none|Localized name of the user|
|initials|string¦null|false|none|Initials of the user|
|icon|string¦null|false|none|Icon of the user|
|tags|[string]¦null|false|none|List of tags attached to user|
|isReadonly|boolean|false|none|Readonly user.<br>Readonly user cannot be deleted and its roles cannot be changed|
|email|string¦null|false|none|Email|

<h2 id="tocS_UserInfoDTO">UserInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemauserinfodto"></a>
<a id="schema_UserInfoDTO"></a>
<a id="tocSuserinfodto"></a>
<a id="tocsuserinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "initials": "string",
  "icon": "string",
  "tags": [
    "string"
  ],
  "isReadonly": true,
  "email": "string"
}

```

Basic information of a user

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the user|
|name|string¦null|false|none|Localized name of the user|
|initials|string¦null|false|none|Initials of the user|
|icon|string¦null|false|none|Icon of the user|
|tags|[string]¦null|false|none|List of tags attached to user|
|isReadonly|boolean|false|none|Readonly user.<br>Readonly user cannot be deleted and its roles cannot be changed|
|email|string¦null|false|none|Email|

<h2 id="tocS_UserLocalizationDataDTO">UserLocalizationDataDTO</h2>
<!-- backwards compatibility -->
<a id="schemauserlocalizationdatadto"></a>
<a id="schema_UserLocalizationDataDTO"></a>
<a id="tocSuserlocalizationdatadto"></a>
<a id="tocsuserlocalizationdatadto"></a>

```json
{
  "culture": "string",
  "timeZone": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|culture|string¦null|false|none|Culture of the user|
|timeZone|string¦null|false|none|Time zone of the user|

<h2 id="tocS_UserType">UserType</h2>
<!-- backwards compatibility -->
<a id="schemausertype"></a>
<a id="schema_UserType"></a>
<a id="tocSusertype"></a>
<a id="tocsusertype"></a>

```json
"Tenant"

```

Type of user

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|Type of user|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Tenant|
|*anonymous*|Owner|
|*anonymous*|PropertyManager|
|*anonymous*|FacilityManager|
|*anonymous*|Visitor|
|*anonymous*|Administrator|

<h2 id="tocS_VersionInformationDTO">VersionInformationDTO</h2>
<!-- backwards compatibility -->
<a id="schemaversioninformationdto"></a>
<a id="schema_VersionInformationDTO"></a>
<a id="tocSversioninformationdto"></a>
<a id="tocsversioninformationdto"></a>

```json
{
  "name": "string",
  "version": "string"
}

```

Version information of a software part

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Software name.<br>Can be bos, middleware, ui, firmware|
|version|string¦null|false|none|Version. Empty indicates undefined.|

<h2 id="tocS_WebServerConfigDTO">WebServerConfigDTO</h2>
<!-- backwards compatibility -->
<a id="schemawebserverconfigdto"></a>
<a id="schema_WebServerConfigDTO"></a>
<a id="tocSwebserverconfigdto"></a>
<a id="tocswebserverconfigdto"></a>

```json
{
  "useHttps": true
}

```

Object with configuration of the webserver

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|useHttps|boolean|false|none|Indicates whether or not the https protocol is activated or not|

<h2 id="tocS_WizardSubscriptionDTO">WizardSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemawizardsubscriptiondto"></a>
<a id="schema_WizardSubscriptionDTO"></a>
<a id="tocSwizardsubscriptiondto"></a>
<a id="tocswizardsubscriptiondto"></a>

```json
{
  "applicationName": "string",
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|applicationName|string¦null|false|none|none|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_ZoneAnimationDTO">ZoneAnimationDTO</h2>
<!-- backwards compatibility -->
<a id="schemazoneanimationdto"></a>
<a id="schema_ZoneAnimationDTO"></a>
<a id="tocSzoneanimationdto"></a>
<a id="tocszoneanimationdto"></a>

```json
{
  "zoneTemplateId": "string",
  "backgroundColorAnimation": {
    "ranges": [
      {
        "value": "string",
        "min": 0,
        "minIncluded": true,
        "max": 0,
        "maxIncluded": true
      }
    ],
    "animationType": "Float",
    "defaultValue": "string",
    "id": "string",
    "datapointTemplateId": "string",
    "functionalBlockTemplateId": "string",
    "type": {
      "type": "string",
      "id": "string",
      "name": "string",
      "tag": "string",
      "transport": "none"
    },
    "selectionModeForZone": "All",
    "complexDataTypeFieldName": "string"
  },
  "borderColorAnimation": {
    "ranges": [
      {
        "value": "string",
        "min": 0,
        "minIncluded": true,
        "max": 0,
        "maxIncluded": true
      }
    ],
    "animationType": "Float",
    "defaultValue": "string",
    "id": "string",
    "datapointTemplateId": "string",
    "functionalBlockTemplateId": "string",
    "type": {
      "type": "string",
      "id": "string",
      "name": "string",
      "tag": "string",
      "transport": "none"
    },
    "selectionModeForZone": "All",
    "complexDataTypeFieldName": "string"
  },
  "name": "string",
  "showAlarms": true,
  "active": true,
  "id": "string"
}

```

Zone animation.

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneTemplateId|string¦null|false|none|Zone template id.|
|backgroundColorAnimation|any|false|none|Animation for background color (if exists).|

oneOf

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[FloatStringAnimationDTO](#schemafloatstringanimationdto)|false|none|Definition of a datapoint animation for a numeric datapoint.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumStringAnimationDTO](#schemaenumstringanimationdto)|false|none|Datapoint animation of an enumeration typed datapoint.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BooleanStringAnimationDTO](#schemabooleanstringanimationdto)|false|none|Animation of a boolean datapoint.|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|borderColorAnimation|any|false|none|Animation color (if exists).|

oneOf

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[FloatStringAnimationDTO](#schemafloatstringanimationdto)|false|none|Definition of a datapoint animation for a numeric datapoint.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[EnumStringAnimationDTO](#schemaenumstringanimationdto)|false|none|Datapoint animation of an enumeration typed datapoint.|

xor

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|» *anonymous*|[BooleanStringAnimationDTO](#schemabooleanstringanimationdto)|false|none|Animation of a boolean datapoint.|

continued

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the animation.|
|showAlarms|boolean|false|none|Are alarms displayed ?.|
|active|boolean|false|none|Is the animation active.|
|id|string¦null|false|none|none|

<h2 id="tocS_ZoneAnimationRuntimeDTO">ZoneAnimationRuntimeDTO</h2>
<!-- backwards compatibility -->
<a id="schemazoneanimationruntimedto"></a>
<a id="schema_ZoneAnimationRuntimeDTO"></a>
<a id="tocSzoneanimationruntimedto"></a>
<a id="tocszoneanimationruntimedto"></a>

```json
{
  "animationId": "string",
  "zoneId": "string",
  "backgroundDatapointId": "string",
  "borderDatapointId": "string",
  "functionalBlocks": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|animationId|string¦null|false|none|none|
|zoneId|string¦null|false|none|none|
|backgroundDatapointId|string¦null|false|none|none|
|borderDatapointId|string¦null|false|none|none|
|functionalBlocks|[string]¦null|false|none|none|

<h2 id="tocS_ZoneInstanceControlPanelDTO">ZoneInstanceControlPanelDTO</h2>
<!-- backwards compatibility -->
<a id="schemazoneinstancecontrolpaneldto"></a>
<a id="schema_ZoneInstanceControlPanelDTO"></a>
<a id="tocSzoneinstancecontrolpaneldto"></a>
<a id="tocszoneinstancecontrolpaneldto"></a>

```json
{
  "datapoints": [
    {
      "datapointInstanceId": "string",
      "datapointTemplateId": "string",
      "direction": "Feedback",
      "displayName": "string",
      "displayUnit": "string",
      "dataType": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ],
  "properties": [
    {
      "propertyInstanceId": "string",
      "propertyTemplateId": "string",
      "propertyInstanceValue": null,
      "direction": "Feedback",
      "displayName": "string",
      "displayUnit": "string",
      "dataType": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ],
  "functionalBlocks": [
    {
      "functionalBlockInstanceId": "string",
      "functionalBlockInstanceName": "string",
      "functionalBlockInstanceIcon": "string",
      "functionalBlockTemplateId": "string",
      "functionalBlockTemplateName": "string",
      "masterMode": "None",
      "tags": [
        "string"
      ],
      "datapoints": [
        {
          "datapointInstanceId": "string",
          "datapointTemplateId": "string",
          "direction": "Feedback",
          "displayName": "string",
          "displayUnit": "string",
          "dataType": {
            "type": "string",
            "id": "string",
            "name": "string",
            "tag": "string",
            "transport": "none"
          }
        }
      ],
      "properties": [
        {
          "propertyInstanceId": "string",
          "propertyTemplateId": "string",
          "propertyInstanceValue": null,
          "direction": "Feedback",
          "displayName": "string",
          "displayUnit": "string",
          "dataType": {
            "type": "string",
            "id": "string",
            "name": "string",
            "tag": "string",
            "transport": "none"
          }
        }
      ]
    }
  ]
}

```

Detailed information about the control panel of a zone instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapoints|[[AdvancedDatapointInstanceDTO](#schemaadvanceddatapointinstancedto)]¦null|false|none|List of datapoint instances to display in the control panel|
|properties|[[AdvancedPropertyInstanceDTO](#schemaadvancedpropertyinstancedto)]¦null|false|none|List of property instances to display in the control panel|
|functionalBlocks|[[FunctionalBlockInstanceControlPanelDTO](#schemafunctionalblockinstancecontrolpaneldto)]¦null|false|none|List of functional block instances control panels to display in the control panel|

<h2 id="tocS_ZoneInstanceDTO">ZoneInstanceDTO</h2>
<!-- backwards compatibility -->
<a id="schemazoneinstancedto"></a>
<a id="schema_ZoneInstanceDTO"></a>
<a id="tocSzoneinstancedto"></a>
<a id="tocszoneinstancedto"></a>

```json
{
  "datapoints": [
    {
      "stationId": "string",
      "networkId": "string",
      "busUnitId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "converterId": "string",
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "properties": [
    {
      "value": null,
      "userId": "string",
      "roleId": "string",
      "isOverride": true,
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "typeId": "string",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "functionalBlockId": "string",
      "zoneId": "string",
      "displayUnitId": "string",
      "unitId": "string"
    }
  ],
  "functionalBlocks": [
    {
      "functionalBlockId": "string",
      "group": "string",
      "masterMode": "None",
      "inZone": true
    }
  ],
  "authorized": true,
  "parentIds": [
    "string"
  ],
  "childrenIds": [
    "string"
  ],
  "hasMapView": true,
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "type": "Physical",
  "tags": [
    "string"
  ],
  "propertyZoneType": "Property",
  "isExternal": true
}

```

Zone instance definition

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|datapoints|[[DatapointInstanceDTO](#schemadatapointinstancedto)]¦null|false|none|List of dataPoint instances inherited from datapoint template|
|properties|[[PropertyDatapointInstanceDTO](#schemapropertydatapointinstancedto)]¦null|false|none|List of properties inherited from property template|
|functionalBlocks|[[FunctionalBlockInstanceOfZoneDTO](#schemafunctionalblockinstanceofzonedto)]¦null|false|none|List of functional block instances attached to the zone|
|authorized|boolean|false|none|If true access is granted to this zone.|
|parentIds|[string]¦null|false|none|List of parent zones attached to the zone|
|childrenIds|[string]¦null|false|none|List of children zone instance definition attached to the created zone<br>(information only)|
|hasMapView|boolean|false|none|True if zone has a mapview attached to it|
|id|string¦null|false|none|Unique identifier of the zone instance|
|name|string¦null|false|none|Localized name of the zone instance|
|icon|string¦null|false|none|Optional image representing the zoneInstance<br>This field is readonly and ignored during a put/post for a zone instance attached to a zone template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the zone instance template (if any)|
|type|[ZoneType](#schemazonetype)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the zone|
|propertyZoneType|[PropertyZoneType](#schemapropertyzonetype)|false|none|Type of a property area|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_ZoneInstanceHierarchyDTO">ZoneInstanceHierarchyDTO</h2>
<!-- backwards compatibility -->
<a id="schemazoneinstancehierarchydto"></a>
<a id="schema_ZoneInstanceHierarchyDTO"></a>
<a id="tocSzoneinstancehierarchydto"></a>
<a id="tocszoneinstancehierarchydto"></a>

```json
{
  "authorized": true,
  "parentIds": [
    "string"
  ],
  "childrenIds": [
    "string"
  ],
  "hasMapView": true,
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "type": "Physical",
  "tags": [
    "string"
  ],
  "propertyZoneType": "Property",
  "isExternal": true
}

```

Basic information on a zone instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|authorized|boolean|false|none|If true access is granted to this zone.|
|parentIds|[string]¦null|false|none|List of parent zones attached to the zone|
|childrenIds|[string]¦null|false|none|List of children zone instance definition attached to the created zone<br>(information only)|
|hasMapView|boolean|false|none|True if zone has a mapview attached to it|
|id|string¦null|false|none|Unique identifier of the zone instance|
|name|string¦null|false|none|Localized name of the zone instance|
|icon|string¦null|false|none|Optional image representing the zoneInstance<br>This field is readonly and ignored during a put/post for a zone instance attached to a zone template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the zone instance template (if any)|
|type|[ZoneType](#schemazonetype)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the zone|
|propertyZoneType|[PropertyZoneType](#schemapropertyzonetype)|false|none|Type of a property area|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_ZoneInstanceInfoDTO">ZoneInstanceInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemazoneinstanceinfodto"></a>
<a id="schema_ZoneInstanceInfoDTO"></a>
<a id="tocSzoneinstanceinfodto"></a>
<a id="tocszoneinstanceinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "type": "Physical",
  "tags": [
    "string"
  ],
  "propertyZoneType": "Property",
  "isExternal": true
}

```

Basic information on a zone instance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the zone instance|
|name|string¦null|false|none|Localized name of the zone instance|
|icon|string¦null|false|none|Optional image representing the zoneInstance<br>This field is readonly and ignored during a put/post for a zone instance attached to a zone template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the zone instance template (if any)|
|type|[ZoneType](#schemazonetype)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the zone|
|propertyZoneType|[PropertyZoneType](#schemapropertyzonetype)|false|none|Type of a property area|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_ZoneInstanceTreeDisplayDTO">ZoneInstanceTreeDisplayDTO</h2>
<!-- backwards compatibility -->
<a id="schemazoneinstancetreedisplaydto"></a>
<a id="schema_ZoneInstanceTreeDisplayDTO"></a>
<a id="tocSzoneinstancetreedisplaydto"></a>
<a id="tocszoneinstancetreedisplaydto"></a>

```json
{
  "functionalBlocks": [
    {
      "datapoints": [
        {
          "id": "string",
          "name": "string",
          "direction": "Feedback",
          "tags": [
            "string"
          ],
          "templateId": "string",
          "displayUnitId": "string",
          "protocolArguments": {
            "property1": null,
            "property2": null
          },
          "networkId": "string",
          "driverDescriptorId": "string"
        }
      ],
      "id": "string",
      "name": "string",
      "icon": "string",
      "iconFillColor": "string",
      "templateId": "string",
      "specializationType": "string",
      "specializationId": "string",
      "tags": [
        "string"
      ],
      "deviceInstanceId": "string",
      "deviceFunctionalBlockTemplateId": "string",
      "assignationDone": true,
      "isExternal": true
    }
  ],
  "datapoints": [
    {
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "tags": [
        "string"
      ],
      "templateId": "string",
      "displayUnitId": "string",
      "protocolArguments": {
        "property1": null,
        "property2": null
      },
      "networkId": "string",
      "driverDescriptorId": "string"
    }
  ],
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "templateId": "string",
  "type": "Physical",
  "tags": [
    "string"
  ],
  "propertyZoneType": "Property",
  "isExternal": true
}

```

Zone instance definition for tree display

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|functionalBlocks|[[FunctionalBlockInstanceTreeDisplayDTO](#schemafunctionalblockinstancetreedisplaydto)]¦null|false|none|List of functional block instances attached to the zone|
|datapoints|[[DatapointInstanceTreeDisplayDTO](#schemadatapointinstancetreedisplaydto)]¦null|false|none|List of dataPoint instances attached to the zone|
|id|string¦null|false|none|Unique identifier of the zone instance|
|name|string¦null|false|none|Localized name of the zone instance|
|icon|string¦null|false|none|Optional image representing the zoneInstance<br>This field is readonly and ignored during a put/post for a zone instance attached to a zone template|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|templateId|string¦null|false|none|Unique identifier of the zone instance template (if any)|
|type|[ZoneType](#schemazonetype)|false|none|none|
|tags|[string]¦null|false|none|List of tag matching the zone|
|propertyZoneType|[PropertyZoneType](#schemapropertyzonetype)|false|none|Type of a property area|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_ZoneLiveAlarmSubscriptionDTO">ZoneLiveAlarmSubscriptionDTO</h2>
<!-- backwards compatibility -->
<a id="schemazonelivealarmsubscriptiondto"></a>
<a id="schema_ZoneLiveAlarmSubscriptionDTO"></a>
<a id="tocSzonelivealarmsubscriptiondto"></a>
<a id="tocszonelivealarmsubscriptiondto"></a>

```json
{
  "zoneId": "string",
  "id": "string",
  "tags": [
    "string"
  ],
  "webhookURL": "string",
  "webhookRetryCount": 0,
  "webhookRetryDelay": 0,
  "webhookPersist": true,
  "connectionId": "string",
  "returnInternalFormat": true,
  "webhookLeaseTime": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneId|string¦null|false|none|none|
|id|string¦null|false|none|none|
|tags|[string]¦null|false|none|none|
|webhookURL|string¦null|false|none|none|
|webhookRetryCount|integer(int32)|false|none|none|
|webhookRetryDelay|integer(int32)|false|none|none|
|webhookPersist|boolean|false|none|none|
|connectionId|string¦null|false|none|none|
|returnInternalFormat|boolean|false|none|none|
|webhookLeaseTime|integer(int32)¦null|false|none|none|

<h2 id="tocS_ZoneOfFunctionalBlockDTO">ZoneOfFunctionalBlockDTO</h2>
<!-- backwards compatibility -->
<a id="schemazoneoffunctionalblockdto"></a>
<a id="schema_ZoneOfFunctionalBlockDTO"></a>
<a id="tocSzoneoffunctionalblockdto"></a>
<a id="tocszoneoffunctionalblockdto"></a>

```json
{
  "zoneId": "string",
  "inZone": true
}

```

Definition of a zone linked to functionalBlockInstance

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|zoneId|string¦null|false|none|Unique identifier of Zone|
|inZone|boolean|false|none|Weither the functionalblock belongs to this zone or a child zone|

<h2 id="tocS_ZoneTemplateControlPanelDTO">ZoneTemplateControlPanelDTO</h2>
<!-- backwards compatibility -->
<a id="schemazonetemplatecontrolpaneldto"></a>
<a id="schema_ZoneTemplateControlPanelDTO"></a>
<a id="tocSzonetemplatecontrolpaneldto"></a>
<a id="tocszonetemplatecontrolpaneldto"></a>

```json
{
  "name": "string",
  "active": true,
  "zoneTemplateId": "string",
  "datapoints": [
    {
      "datapointTemplateId": "string",
      "direction": "Feedback",
      "displayName": "string",
      "displayUnit": "string",
      "dataType": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ],
  "properties": [
    {
      "propertyDatapointTemplateId": "string",
      "direction": "Feedback",
      "displayName": "string",
      "displayUnit": "string",
      "dataType": {
        "type": "string",
        "id": "string",
        "name": "string",
        "tag": "string",
        "transport": "none"
      }
    }
  ],
  "functionalBlocks": [
    {
      "name": "string",
      "active": true,
      "functionalBlockTemplateId": "string",
      "selectionMode": "All",
      "supportMasterSlave": true,
      "datapoints": [
        {
          "datapointTemplateId": "string",
          "direction": "Feedback",
          "displayName": "string",
          "displayUnit": "string",
          "dataType": {
            "type": "string",
            "id": "string",
            "name": "string",
            "tag": "string",
            "transport": "none"
          }
        }
      ],
      "properties": [
        {
          "propertyDatapointTemplateId": "string",
          "direction": "Feedback",
          "displayName": "string",
          "displayUnit": "string",
          "dataType": {
            "type": "string",
            "id": "string",
            "name": "string",
            "tag": "string",
            "transport": "none"
          }
        }
      ]
    }
  ]
}

```

Definition of the configuration of the control panel of a zone template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|Name of the configuration of the control panel, may be null or empty|
|active|boolean|false|none|Indicates if the configuration of the control panel is active or not|
|zoneTemplateId|string¦null|false|none|Unique identifier of the zone template|
|datapoints|[[AdvancedDatapointTemplateDTO](#schemaadvanceddatapointtemplatedto)]¦null|false|none|List of datapoint templates of the zone template to display in the control panel|
|properties|[[AdvancedPropertyTemplateDTO](#schemaadvancedpropertytemplatedto)]¦null|false|none|List of property templates of the zone template to display in the control panel|
|functionalBlocks|[[FunctionalBlockTemplateControlPanelDTO](#schemafunctionalblocktemplatecontrolpaneldto)]¦null|false|none|List of functional block templates to display in the control panel|

<h2 id="tocS_ZoneTemplateDTO">ZoneTemplateDTO</h2>
<!-- backwards compatibility -->
<a id="schemazonetemplatedto"></a>
<a id="schema_ZoneTemplateDTO"></a>
<a id="tocSzonetemplatedto"></a>
<a id="tocszonetemplatedto"></a>

```json
{
  "usages": [
    "string"
  ],
  "datapoints": [
    {
      "busUnitId": "string",
      "id": "string",
      "name": "string",
      "description": "string",
      "tags": [
        "string"
      ],
      "direction": "Feedback",
      "typeId": "string",
      "displayUnitId": "string",
      "publicId": "string"
    }
  ],
  "properties": [
    {
      "defaultValue": null,
      "id": "string",
      "name": "string",
      "description": "string",
      "tags": [
        "string"
      ],
      "direction": "Feedback",
      "typeId": "string",
      "displayUnitId": "string",
      "publicId": "string"
    }
  ],
  "optionalFunctionalBlocks": [
    "string"
  ],
  "mandatoryFunctionalBlocks": [
    "string"
  ],
  "supportAllFunctionalBlocks": true,
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "tags": [
    "string"
  ],
  "parentId": "string",
  "version": "string",
  "instancesCount": 0,
  "publicId": "string",
  "isExternal": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|usages|[string]¦null|false|none|ZoneTemplate usages (information only)|
|datapoints|[[DatapointTemplateDTO](#schemadatapointtemplatedto)]¦null|false|none|[Definition of datapoint template]|
|properties|[[PropertyDatapointTemplateDTO](#schemapropertydatapointtemplatedto)]¦null|false|none|[Definition of property datapoint template]|
|optionalFunctionalBlocks|[string]¦null|false|none|Optional functional block identifiers (must be empty if SupportAllFunctionalBlocks is true).|
|mandatoryFunctionalBlocks|[string]¦null|false|none|Mandatory functional block identifiers (must be empty if SupportAllFunctionalBlocks is true).|
|supportAllFunctionalBlocks|boolean|false|none|If true, any functional block can be added.|
|id|string¦null|false|none|Unique identifier of the zone template|
|name|string¦null|false|none|Localized name of the zone template|
|icon|string¦null|false|none|Image uri|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|tags|[string]¦null|false|none|List of tags atached to the template|
|parentId|string¦null|false|none|ZoneTemplate parent of this zonetemplate.<br>Null if root. Not null for a zonetemplate usage.|
|version|string¦null|false|none|ZoneTemplate version.<br>Information only. Readonly.|
|instancesCount|integer(int64)|false|none|Number of zone instances using this template.<br>Information only. Readonly.|
|publicId|string¦null|false|none|Unique public identifier of the zone template|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_ZoneTemplateDuplicateDTO">ZoneTemplateDuplicateDTO</h2>
<!-- backwards compatibility -->
<a id="schemazonetemplateduplicatedto"></a>
<a id="schema_ZoneTemplateDuplicateDTO"></a>
<a id="tocSzonetemplateduplicatedto"></a>
<a id="tocszonetemplateduplicatedto"></a>

```json
{
  "icon": "string",
  "iconFillColor": "string",
  "name": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|icon|string¦null|false|none|Base64 string of the new icon|
|iconFillColor|string¦null|false|none|Icon fill color|
|name|string¦null|false|none|New name of duplicate item|

<h2 id="tocS_ZoneTemplateImportResultDTO">ZoneTemplateImportResultDTO</h2>
<!-- backwards compatibility -->
<a id="schemazonetemplateimportresultdto"></a>
<a id="schema_ZoneTemplateImportResultDTO"></a>
<a id="tocSzonetemplateimportresultdto"></a>
<a id="tocszonetemplateimportresultdto"></a>

```json
{
  "id": "string",
  "name": "string",
  "added": true,
  "uptodate": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|none|
|name|string¦null|false|none|none|
|added|boolean|false|none|none|
|uptodate|boolean|false|none|none|

<h2 id="tocS_ZoneTemplateInfoDTO">ZoneTemplateInfoDTO</h2>
<!-- backwards compatibility -->
<a id="schemazonetemplateinfodto"></a>
<a id="schema_ZoneTemplateInfoDTO"></a>
<a id="tocSzonetemplateinfodto"></a>
<a id="tocszonetemplateinfodto"></a>

```json
{
  "id": "string",
  "name": "string",
  "icon": "string",
  "iconFillColor": "string",
  "tags": [
    "string"
  ],
  "parentId": "string",
  "version": "string",
  "instancesCount": 0,
  "publicId": "string",
  "isExternal": true
}

```

Basic information on a zone template

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string¦null|false|none|Unique identifier of the zone template|
|name|string¦null|false|none|Localized name of the zone template|
|icon|string¦null|false|none|Image uri|
|iconFillColor|string¦null|false|none|Icon fill color. null for none|
|tags|[string]¦null|false|none|List of tags atached to the template|
|parentId|string¦null|false|none|ZoneTemplate parent of this zonetemplate.<br>Null if root. Not null for a zonetemplate usage.|
|version|string¦null|false|none|ZoneTemplate version.<br>Information only. Readonly.|
|instancesCount|integer(int64)|false|none|Number of zone instances using this template.<br>Information only. Readonly.|
|publicId|string¦null|false|none|Unique public identifier of the zone template|
|isExternal|boolean|false|none|True when the entity has been created by an external tool<br>eg : migration of a ETS MoovNGroup project|

<h2 id="tocS_ZoneTemplateWizardDTO">ZoneTemplateWizardDTO</h2>
<!-- backwards compatibility -->
<a id="schemazonetemplatewizarddto"></a>
<a id="schema_ZoneTemplateWizardDTO"></a>
<a id="tocSzonetemplatewizarddto"></a>
<a id="tocszonetemplatewizarddto"></a>

```json
{
  "tags": [
    "string"
  ],
  "doNotImport": true,
  "applied": true,
  "iconChanged": true,
  "id": "string",
  "name": "string",
  "isLogic": true,
  "icon": "string",
  "iconExtension": "string",
  "optionalFunctionalBlocks": [
    "string"
  ],
  "mandatoryFunctionalBlocks": [
    "string"
  ],
  "version": 0,
  "datapoints": [
    {
      "id": "string",
      "name": "string",
      "direction": "Feedback",
      "protocolArguments": {
        "property1": null,
        "property2": null
      }
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|tags|[string]¦null|false|none|none|
|doNotImport|boolean|false|none|none|
|applied|boolean|false|none|none|
|iconChanged|boolean|false|none|none|
|id|string¦null|false|none|none|
|name|string¦null|false|none|none|
|isLogic|boolean|false|none|none|
|icon|string¦null|false|none|none|
|iconExtension|string¦null|false|none|none|
|optionalFunctionalBlocks|[string]¦null|false|none|none|
|mandatoryFunctionalBlocks|[string]¦null|false|none|none|
|version|integer(int64)|false|none|none|
|datapoints|[[DatapointTemplateDesc](#schemadatapointtemplatedesc)]¦null|false|none|none|

<h2 id="tocS_ZoneType">ZoneType</h2>
<!-- backwards compatibility -->
<a id="schemazonetype"></a>
<a id="schema_ZoneType"></a>
<a id="tocSzonetype"></a>
<a id="tocszonetype"></a>

```json
"Physical"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|Physical|
|*anonymous*|Logical|
|*anonymous*|Technical|

