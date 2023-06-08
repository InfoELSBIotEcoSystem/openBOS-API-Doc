
# Connect to the API from the cloud (oBaaS)

OpenBOS API is available via the ABB Ability cloud. Product is oBaaS: openBOS as a Service. That is a pure cloud to cloud connection needing authentication between clouds.  

In a cloud perspective workflow, you will already have registered as a developer on the <a href="https://developers.connect.abb.com/" target="_blank">ABB Developer Portal</a>. From there you will already have created your application.

The application you have created gives you all the information needed to authenticate via cloud.

## Building edge openBOS via OAuth 2.0 Grant type Authorization code

The Authentication workflow that will be used is OAuth2.0 with Grant type Authorization code.

<u>Parameters used for OAuth 2.0:</u>

Click on the collection title on the left side menu and enter your credentials and data as follows:
- **Auth Grant Type**: 	Authorization Code Grant.
- **AuthUrl**: `https://login.microsoftonline.com/372ee9e0-9ce0-4033-a64a-c07073a91ecd/oauth2/v2.0/authorize`
- **TokenUrl**: 	`https://login.microsoftonline.com/372ee9e0-9ce0-4033-a64a-c07073a91ecd/oauth2/v2.0/token`
- **ClientId**: 			your ClientID created in the ABB Developer Portal.
- **ClientSecret**: 		your Client Secret created in the ABB Developer Portal.
- **Callback URL**:     your Redirect URL entered in your application inside the ABB Developer Portal.
- **Scopes (each separated by a space)**:  The valid values for scope are given below.

## Building edge openBOS via OAuth 2.0 Grant type with PKCE Authorization code

The Authentication workflow that will be used is OAuth2.0 with Grant type with PKCE Authorization code.

<u>Parameters used for OAuth 2.0 with PKCE:</u>

- **Auth Grant Type**: 	Authorization Code Grant.
- **Authentication URL**:	`https://login.microsoftonline.com/372ee9e0-9ce0-4033-a64a-c07073a91ecd/oauth2/v2.0/authorize`
- **Token URL**:	`https://login.microsoftonline.com/372ee9e0-9ce0-4033-a64a-c07073a91ecd/oauth2/v2.0/token`
- **Client ID**:	The client ID obtained via the app registration in the ABB Developer Portal.
- **Callback URL**:	The callback URL for receiving the access token.
- **Code Challenge Method**:	SHA-256.
- ** Scopes**:	The list of scopes to be requested by the application separated by a space. Please see the section about scopes.
- **State**:	An opaque value used by the client to maintain the state between the request and callback.  The authorization         
server includes this value when redirecting the user-agent back to the client.  The parameter _should_ be used for preventing 
cross-site request forgery.

## List of scopes

The following table lists scopes which are supported by the Building Ecosystem platform.

| Scope| Purpose |
| :--| :------------------------------------------|
| api://openbos/Relation.Read | Allows the app to read relations with Building edge devices  |
| api://openbos/Relation.ReadWrite | Allows the app to read and delete relations with Building edge devices |
| api://openbos/BosApi.Proxy | Allows the app to remotely access the Building edge device |
| api://openbos/User.Delete | Allows the app to delete a user account |
| offline_access | Scope for requesting a refresh token which can be used to periodically request a fresh access-token to keep the user signed in. |
| openid | By using this permission, an app can receive a unique identifier for the user in the form of the subclaim. The permission also gives the app access to the UserInfo endpoint. The openid scope can be used at the Microsoft&reg; identity platform token endpoint to acquire ID tokens. The app can use these tokens for authentication. |

## Refresh tokens

The openBOS&reg; platform supports fetching refresh tokens to keep a user logged in. For obtaining a refresh token, the offline_access scope needs 
to be provided during the authentication steps when obtaining an access token. 
The following lifetime settings apply for refresh tokens. In case a refresh token is not used for a period of 90 days, it will expire. 
In case a refresh-token is used to get a new access token, the refresh token is valid until it is revoked meaning that the user explicitly logs out by calling the logout endpoint.

Result of authentication will generate an access-token as well as a refresh-token.
The access-token will have to be appended to every underlying call to the openBOS&reg; API by providing the token in the Authorization header in this format:
  "Authorization" : "Bearer YOUR_ACCESS_TOKEN"

The refresh-token will have to be used in requests to the TokenUrl route in order to get a valid new access-token.
Please note the following:
 - access-token is valid for 3600 seconds
 - refresh-token is valid for 90 days

## A sample code in C# on how to acquire a token using MSAL

Create a new .Net application

Add the package reference:
```csharp
    <PackageReference Include="Microsoft.AspNet.WebApi.Client" Version="5.2.7" />    
    <PackageReference Include="Microsoft.Identity.Client" Version="4.36.1" />
```

In Program.cs:

```csharp
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IPublicClientApplication app;

            app = PublicClientApplicationBuilder.Create(your_application_id_created_from_developer_portal)
                    .WithRedirectUri(your_mobile_desktop_redirect_uri_set_in_developer_portal)
                    .WithAuthority(AzureCloudInstance.AzurePublic, "372ee9e0-9ce0-4033-a64a-c07073a91ecd")
                    .Build();


            IEnumerable<IAccount> accounts = await app.GetAccountsAsync();
            IAccount firstAccount = accounts.FirstOrDefault();
            AuthenticationResult authResult;

            try
            {
                authResult = await app.AcquireTokenSilent(new List<string>() { "api://openbos/BosApi.Proxy" }, firstAccount).ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                authResult = await app.AcquireTokenInteractive(new List<string>() { "api://openbos/BosApi.Proxy" }).ExecuteAsync();
            }

            Console.WriteLine($"Acquired token {authResult.AccessToken}");           

            Console.ReadLine();
        }
    }
}
```

You then have acquired the Bearer token you can use for subsequent calls

