# Connection and authentication

To access the openBOS&reg; API, there are two ways:
-	Via the cloud using oBaas.
-	Via the local network (e.g. http\:\/\/192\.168\.1\.123) 

## How to authenticate to the openBOS&reg; API

### Accessing Building edge openBOS&reg; via ABB Cloud

In a cloud perspective workflow, you will already have registered as a developer on the ABB Developer Portal (<a href="https://developers.connect.abb.com/" target="_blank">https://developers.connect.abb.com/). From there you will already have created your application. [How to connect to a Building edge?](/README.md#create-a-new-application-in-the-abb-developer-portal)

Available authentication workflow are:
 - OAuth 2.0 Grant type Authorization code
 - OAuth 2.0 Grant type with PKCE Authorization code
 - OAuth 2.0 Grant type ClientId/Client secret

NOTE: 
To be able to use OAuth 2.0 Grant type ClientId/Client secret it is required that you first [contact us](mailto:it.el.electrification.digital@abb.com) to request a partnership enrollment that would lead in creating a new Trusted application on ABB side.

#### Building edge openBOS&reg; via OAuth 2.0 Grant type Authorization code

In this workflow, the application you have created in the [How to connect to a Building edge?](/content/20_prerequisites/20_howToStart.md) will already have all the information needed to authenticate via cloud.

**NOTE : This authentication will be done On behalf of a user. As aconsequence the authentication will always trigger a web dialog for the user to be able to logged in by entering his username/password.**

<u>Parameters used for OAuth 2.0:</u>

Click on the collection title on the left side menu and enter your credentials and data as follows:
- **Auth Grant Type**: 	Authorization Code Grant.
- **AuthUrl**: `https://login.microsoftonline.com/372ee9e0-9ce0-4033-a64a-c07073a91ecd/oauth2/v2.0/authorize`
- **TokenUrl**: 	`https://login.microsoftonline.com/372ee9e0-9ce0-4033-a64a-c07073a91ecd/oauth2/v2.0/token`
- **ClientId**: 			your ClientID created in the ABB Developer Portal.
- **ClientSecret**: 		your Client Secret created in the ABB Developer Portal.
- **Callback URL**:     your Redirect URL entered in your application inside the ABB Developer Portal.
- **Scopes (each separated by a space)**:  The valid values for scope are given below.

#### Building edge openBOS&reg; via OAuth 2.0 Grant type with PKCE Authorization code

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

#### List of scopes

The following table lists scopes which are supported by the Building Ecosystem platform.

| Scope| Purpose |
| :--| :------------------------------------------|
| api://openbos/Relation.Read | Allows the app to read relations with Building edge devices  |
| api://openbos/Relation.ReadWrite | Allows the app to read and delete relations with Building edge devices |
| api://openbos/BosApi.Proxy | Allows the app to remotely access the Building edge device |
| api://openbos/User.Delete | Allows the app to delete a user account |
| offline_access | Scope for requesting a refresh token which can be used to periodically request a fresh access-token to keep the user signed in. |
| openid | By using this permission, an app can receive a unique identifier for the user in the form of the subclaim. The permission also gives the app access to the UserInfo endpoint. The openid scope can be used at the Microsoft&reg; identity platform token endpoint to acquire ID tokens. The app can use these tokens for authentication. |

#### Refresh tokens

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

### Accessing openBOS&reg; from local network
For the local workflow, which means, you access the openBOS&reg; directly on the Building edge 
that is on your local network (that is, http\:\/\/192\.168\.x\.y), 
you will use a standard  JSON Web Token (JWT) workflow.
 - Collect your login/password (either the account you have created on the Building edge yourself or the login/password the Building edge owner passes on to you)
 - Authenticate on the API endpoint `[POST] {{baseUrl}}/api/v1/ontology/authentication`
   - Store the resulting access_token retrieved

```json
    {
      "access_token": **"XXXXX"**, 
    }
```
 - The access token will have to be appended to every underlying call to the openBOS&reg; API by providing the token in the Authorization header  in this format:
  "Authorization" : "Bearer YOUR_ACCESS_TOKEN"

In this workflow, all the calls included in the samples will be done using {{baseUrl}}=http://\<IP_ADDRESS\>.