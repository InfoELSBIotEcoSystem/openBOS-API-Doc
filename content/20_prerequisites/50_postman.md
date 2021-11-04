# Postman environment

You will find below Postman environments.
One configured to target a local edge and one configured to target an edge through the cloud.

## Local environment

 <a href="assets/openbos-documentation/static/images/openBOS Ontology Local Api.postman_collection.json" target="_blank">Download openBOS Postman API collection for local</a>

 - Open Postman and import the collection
 - Select the imported collection
 - Click on `...` and select `Edit`
 - Navigates to the Variables definition tab
 - Change the `{{baseUrl}}` to the address of your edge locally accessible
 - Select the route POST - Get Authentication token
   - Edit the body and set your credentials
   - Press Send
     - If OK then the token will be stored for subsequent calls
 - You can then select other routes to test them

 ## Cloud environment

 <a href="assets/openbos-documentation/static/images/openBOS Ontology Cloud Api.postman_collection.json" target="_blank">Download openBOS Postman API collection for cloud</a>

 - Retrieve the gwid of your edge from the cloud portal
   - Connect to <a href="https://buildings.ability.abb/portfolio" target="_blank">https://buildings.ability.abb/portfolio</a>
   - Click on the detail of an edge to extract its unique identifier (aka: `gwid`)
 - Open Postman and import the collection
 - Select the new imported collection
 - Click on `...` and select `Edit`
   - Select the `Authorization` tab
   - Set the Client ID to the one that matches the application you have created in the cloud developer portal. (Refers to documentation "How to connect a SmartEdge openBOS device to ABB cloud and get ready to using the open APIs?" for more details)
   - Select the Variable tab
   - Set the `gwid` to the id you retrieved from the step above.
   - Comeback to the `Authorization` tab
   - Scroll down and press `Get New Access Token`
   - Follow the authentication step
 - You can then select other routes to test them