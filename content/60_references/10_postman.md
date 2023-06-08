# Postman environment

Postman is an API platform for building and using APIs. It makes it useful to test API.
You will find below a link to Postman environment.
NOTE: default values are to target the "demonstrationEdge1" edge.

[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/14996509-540942d1-78aa-45de-80c3-e854616aeae4?action=collection%2Ffork&collection-url=entityId%3D14996509-540942d1-78aa-45de-80c3-e854616aeae4%26entityType%3Dcollection%26workspaceId%3Dea90c3d1-21af-4177-8e72-f21b5ed12326)

## How-to

 - Retrieve the gwid of your edge from the cloud portal
   - Connect to <a href="https://buildings.ability.abb/portfolio" target="_blank">https://buildings.ability.abb/portfolio</a>
   - Click on the detail of an edge to extract its unique identifier (aka: `gwid`)
 - Click on the Run in Postman button
 - It will fork in your workspace the openBOS postman collection
 - Click on `...` next to the imported collection and select `Edit`
   - Select the `Authorization` tab
   - Set the Client ID to the one that matches the application you have created in the cloud developer portal. (Refers to chapter "How to connect a Building Edge?" for more details)
   - Select the Variable tab
   - Set the `gwid` to the id you retrieved from the step above.
   - Comeback to the `Authorization` tab
   - Scroll down and press `Get New Access Token`
   - Follow the authentication step
 - You can then select other routes to test them