# Azure with NexmoSMS
[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)
## Introduction
Azure with [Nexmo SMS](https://www.nexmo.com/sms) will allow developers to provide SMS capability in their Azure Apps. While developing the Azure App, they can provide SMS capability in their Azure Apps through this Azure with [Nexmo SMS](https://www.nexmo.com/sms). 

Developers can consume Azure API App in Azure Logic Apps. Azure Logic Apps are a part of Azure App Service (a fully managed PaaS) for developers’ suite and allow developers to automate business process execution and workflow. With Azure with Nexmo SMS, users can connect to their Nexmo account in Azure Logic App to send SMSs. Logic apps can trigger, based on a variety of data sources and offer connectors to get and process data as a part of the flow.

## Features
- Use this connector to send SMS using Nexmo Messaging APIs.
- Enable and disable SMS functionality as per the need.

## Steps to Deploy

Deploy the app using above button. You can create new resources or reference existing ones (resource group, gateway, service plan, etc.) Site Name and Gateway must be unique URL hostnames. The deployment process will deploy the following:

- Resource Group (optional)
- Service Plan (if you don't reference exisiting one)
- Gateway (if you don't reference existing one)
- API App (Azure Azure with Nexmo SMS)
- API App Host (this is the site behind the api app that this github code deploys to)

Assumptions:
-	User has created Nexmo account and have apikey & apisecret to consume Nexmo services
-	User has Azure account subscription to Deploy the API App in his account

Process to Deploy API App to Azure:

1.	Click on the Deploy to Azure button
2.	Provide your Azure credentials if not already logged in
3.	After successful login it will return to the Deployment process
5.	Select Resource group in which you want to place your API app and fill other required details in the form displayed then click Next
6.	Click on the Deploy button in the next screen
7.	It will start the deployment process and display the progress step by step
8.	The API App is now successfully deployed to your Azure account, you can check it on Azure Portal.
9.	Open Azure Portal https://portal.azure.com/ use the same azure credentials used to publish the API App
10.	Click Browse all button, you can see the API App listed there. You can click on the App to see the details
11.	Now you can use this API app in any Logic App you are creating on your Azure account. The API App will be listed in the Resource group in which it is published.

Process to use the Azure with NexmoSMS app:

1.	Create a logic app 
2.	Now use Azure with NexmoSMS app in the workflow from the Apps displayed in the right panel. 
3.  Select the action and specify Nexmo Key(apikey), Nexmo Secret(apisecret), Recipient number(ex. 919999999999) and the Message text. The text can be selected from previous connector’s result. 
4.	Save the Logic app.
5.	Now whenever the trigger will be fired the workflow will be executed to perform the specified action. The specified user will get an SMS with the dynamic text message whenever the logic app triggered. 