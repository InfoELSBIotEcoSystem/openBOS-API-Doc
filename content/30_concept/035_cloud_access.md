# Accessing a Building edge via the Cloud API
The Building Ecosystem cloud platform offers the functionality to manage the access to the collection of  Building edge devices the different users of the platform have access to.
The respective service for managing relations between users and the connected Building edge devices is called Ownership Service which exposes an API that allows an authenticated user to query for the Building edge devices that it has access to. 
For this purpose, the Ownership Service maintains a table of user-to-Building edge relations.
A user in this context is identified by its unique email address that was used when registering an MyABB account under <a href="https://usermanagement.abb.com/account/Register" target="_blank">https://usermanagement.abb.com/account/Register</a>.
The Building edge device is identified by its GUID that it has obtained during the manufacturing process from the ABB Ability PKI.
For creating a relation between a user identified via its email address and a  Building edge device, the  Building edge configuration tool needs to be used. 
For each local Building edge user account the option for "cloud access" can be activated and once the respective user email address has been entered, the Building edge device will automatically sync this information with the Ownership service, hereby creating a new user-Building edge relation.

## Ownership Service API
The API of the ownership service can be reached via the following URL:
`https://api.electrification.ability.abb/buildings/openbos/ownership/v1`

### Retrieving relations
To retrieve the user-Building edge relations that are currently stored in the ownership table, the following endpoint can be used.
`GET https://api.electrification.ability.abb/buildings/openbos/ownership/v1/relations`

The API will answer with a JSON format that looks as follows, hereby listing all the relations that the current user has access to.


    [
        {
            "id": "24653",
            "gatewayId": "55775cea-bf03-11eb-b48f-0242ac110002",
            "userId": "john.doe@de.abb.com",
            "firstName": "John",
            "lastName": "Doe",
            "friendlyName": "MyBuildingEdgeDevice",
            "permissions": "CanManageLicense, CanConfigureBESpaceEfficient"
        }
    ]


Among other fields each relation contains the information about the `gatewayId` which is required to access a given Building edge device via the openBOS&reg; API proxy.

### Deleting relations
To delete a given relation the following endpoint needs to be used.
`DELETE https://api.electrification.ability.abb/buildings/openbos/ownership/v1/relations/{id}`. 
The `{id}` in the path here refers to the `id` field mentioned in the above example response (not to be confused with the `gatewayId`).
In case of a successful deletion, the service will respond with HTTP code 204.

## openBOS&reg; API proxy
Besides the Ownership Service mentioned above, the  Building Ecosystem platform allows authenticated users to connect to a given Building edge device. Therefore, each Building edge device is identified via the `gatewayId` which can can be obtained using the Ownership Service described in the section above.

### Connect to Building edge via the openBOS&reg; API proxy
To connect to a Building edge device with a given `gatewayId` via the openBOS&reg; API proxy, the following base URL needs to be used.
`https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1`

To invoke an API on a given Building edge device the following base URL schema needs to be used.
`https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/gateway/{gatewayId}/...`

The different APIs and endpoints that are exposed via the  Building  edge device are described in the subsequent chapters of this documentation.

