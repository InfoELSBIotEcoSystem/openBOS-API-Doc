# How to connect a Building edge?

## Prerequisites
These steps have to be performed before starting to use the openBOS&reg; APIs:

1.	Register for a free myABB account
    - Directly here: <a href="https://www.usermanagement.abb.com/account/Register" target="_blank">https://www.usermanagement.abb.com/account/Register</a>
    - Or on <a href="https://developers.connect.abb.com/getting-started" target="_blank">https://developers.connect.abb.com/getting-started</a> following the “Register” button
2.	Ensure you have an openBOS&reg; Building edge gateway which is
    - set up physically in your building
    - commissioned via the local web interface / tool
    - connected to a myABB account
3.	Create a local user on your Building edge device
    - which has the rights to use the Cloud and API
    - which has the same email address as the myABB account you are using
4.	Make sure that your Building edge device is registered and equipped with the right licenses here: <a href="https://buildings.ability.abb" target="_blank">https://buildings.ability.abb</a>

Visit <a href="https://buildings.ability.abb/portfolio" target="_blank">https://buildings.ability.abb/portfolio</a> by logging into the page via your myABB account.

![Postman](assets/openbos-documentation/static/images/startDeviceMap.png)

Here you find your openBOS&reg; Building edge / gateway and you may configure and manage it.

## Create a new application in the ABB Developer Portal
Log into the ABB Developer Portal with your myABB credentials
 - <a href="https://developers.connect.abb.com/getting-started" target="_blank">https://developers.connect.abb.com/getting-started</a>

- Click on Applications and press Create Application

![Postman](assets/openbos-documentation/static/images/startLogin.png)

- Enter the necessary data for your application and your preferred redirect URLs
  - Be sure that you select the option "Building Management"
  - Press Create Application

![Postman](assets/openbos-documentation/static/images/startApplicationDetails.png)

 - After the application has been successfully created, you can find your required data to access the API for the first time

![Postman](assets/openbos-documentation/static/images/startAccessAPI.png)

 - You can try out our API right away inside our ABB Developer Portal in section “API reference”
   - Click on “Building Management“ tag at the bottom of the left side
   - Select an endpoint to be called on the left side
   - Set the edge identifier to communicate with.(NOTE : Use `demonstrationEdge1` to Try Out against the demonstration edge)
   - Click “Try out”

![Postman](assets/openbos-documentation/static/images/startTryOut.png)

Start using your first calls to get data from openBOS&reg;.
