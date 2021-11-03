# Check users

```
NOTE:
Sample are written in C# and uses nuget package RestSharp for convenience.
baseUrl for local access : http://<ipaddress>
baseUrl for cloud access : `https://api.electrification.ability.abb/buildings/openbos/apiproxy/v1/gateway/<edgeid>`
```

## How to display property users? 

This example collects the users that are configured as "owner" in the project.
For each owner the sample displays the list of AccessRights the user is allowed and the list of roles to which the user is related to.

```csharp
    // Set Authentication token
    var client = new RestSharp.RestClient();
    client.AddDefaultHeader("Authorization", $"Bearer {bearerToken}");

    // Collect users with role owner (UserInfoDTO[])
    dynamic owners = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/user&type=Owner")).Data;

    // Display the rights of the first owner user (UserDTO)
    dynamic userDetail = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/user/{owners[0]["id"]}")).Data;
    // Display user AccessRights
    Console.WriteLine("AccessRights are : " + userDetail["accessRights"]);
    // Display user roles
    void DisplayRoleParent(string roleId)
    {
      if ( string.IsNullOrEmpty(roleId)) return;
      dynamic roleDetail = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/role/{roleId}")).Data; // (RoleDTO)
      Console.WriteLine("Role Name : " + roleDetail["name"]);
      DisplayRoleParent(roleDetail["parentId"]);
    }
    foreach (var role in userDetail["roleIds"])
    {
        DisplayRoleParent(role);
    }

    // Collect property manager users
    dynamic propertyManager = client.Execute<dynamic>(new RestRequest($"{baseUrl}/api/v1/ontology/user&type=PropertyManager")).Data;

```
