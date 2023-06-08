# Unique app for local and cloud use

openBOS&reg; offers a single API that may run locally on the Building edge as well as within the ABB Ability&trade; Cloud. You as a developer only need to develop a single application on the top of the openBOS&reg; API.

Afterwards, the customers have several options to deploy and run their application:
-	 Locally on the Building edge device, connecting locally with the openBOS&reg; API.
-	 From within their own cloud infrastructure, connecting to buildings equipped with openBOS&reg; via the ABB Ability&trade; Cloud.

The authentication only changes when the customers deploy their applications:
-	Inside a Building edge. In this case they use local authentication with Secure Web tokens.
-	Within their own cloud which connects to the ABB Ability&trade; Cloud API. In this case, they use secure OAuth authentication. 

This API documentation refers mostly to the cloud solution, but also covers the majority of the local API use cases.


