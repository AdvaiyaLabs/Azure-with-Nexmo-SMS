# Azure with NexmoSMS
[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

## Introduction

**Azure with Nexmo SMS** will allow developers to provide SMS capability in their Azure Apps. While developing the Azure App, they can provide SMS capability in their Azure Apps through this Azure with Nexmo SMS  (Azure API app).

Developers can consume Azure API App in Azure Logic Apps. Azure Logic Apps are a part of Azure App Service (a fully managed PaaS) for developer’s suite and allow developers to automate business process execution and workflow. With Azure with Nexmo SMS , users can connect to their Nexmo account in Azure Logic App to send SMSs. Logic apps can trigger, based on a variety of data sources and offer s to get and process data as a part of the flow.

## Use Case

Build Nexmo SMS , which can be integrated or consumed with Azure Logic Apps to send SMS using Nexmo Messaging APIs.

## Prerequisite

-   Nexmo subscription and, corresponding Nexmo API key and Secret key to consume Nexmo services. To access the Nexmo’s API keys, see appendix section.

-   Azure subscription to deploy this Azure with Nexmo SMS .

## Features

-   Use this  to send SMS using Nexmo Messaging APIs.

-   Enable and disable SMS functionality as per the need.

## Steps to deploy Azure with Nexmo SMS 

1.  Open the below GitHub repository link:

    <https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS>

2.  Click on the **Deploy to Azure** button.

    [![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

    You can create new resources or reference existing ones (resource group, gateway, service plan, etc.). 
    Site Name and Gateway must be unique URL hostnames. 
    The deployment process will deploy the following:
    - Resource Group (if you don't reference the existing one)
    - Service Plan (if you don't reference the existing one)
    - Gateway (if you don't reference the existing one)
    - API App (AzurewithNexmoSMS)
    - API App Host 
	(this is the site behind the API app which the github code deploys to)

3.  It will ask for your Azure credentials if not already logged in.

4.  After the successful login, it will return to the deployment process.

5.  Fill all the required details in the form:

    -   **Resource group:** Specify a new Resource name or select existing Resource group from the list displayed, in which you want to place your API app.

    -   **Resource Group Name**: If creating a new Resource Group, specify the name in Resource Group Name.

    -   **Site Name**: Specify the name to be given to the website.

    -   **API App Name**: Specify the name to be given to the API App.

    -   **Gateway Name**: Specify an existing Gateway Name or write a new Gateway Name to create a new gateway.

    -   **Svc Plan Name**: Specify an existing Plan Name or write a new Plan Name to create a new plan.

    <img src="https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS/blob/master/docs/image5.png" width=600>

6.  Click on **Next.**

7.  On the next page, click on the **Deploy** button.

	<img src="https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS/blob/master/docs/image6.png" width=600>

8.  It will start the deployment process and display the progress step by step as shown below:

	<img src="https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS/blob/master/docs/image7.png" width=600>

9.  The API App is now successfully deployed to your Azure account, you can check it on Azure Portal.

10. Open Azure Portal <https://portal.azure.com/>. Use the same Azure credentials used to publish the API App.

	<img src="https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS/blob/master/docs/image8.png" width=600>

11. Now here you can use published API app in any Logic App you are creating on your Azure account. This API App will be listed in the Resource group in which it is published.

## Steps to use the Azure with Nexmo SMS 

1.  To Create a Logic App on Azure dashboard, click on **+ New** in the left section of the screen.

2.  Select **Web + Mobile** and click on **Logic App**. It displays the **Create logic app** form, where you can provide some basic settings to get started.

	<img src="https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS/blob/master/docs/image9-1.png" width=600>

3.  Click Triggers and actions, select Template or create it from scratch

	<img src="https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS/blob/master/docs/image10.png" width=600>

1.  Create your logic app workflow by using API Apps displayed in the right panel.

	<img src="https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS/blob/master/docs/image11.png" width=600>

2.  Use Azure with Nexmo SMS in the workflow where you need to send some information in the SMS.

3.  Select the action and specify Nexmo Key, Nexmo Secret, Recipient number (ex. 919999999999) and the Message Text. The text can be selected from previous ’s result. You can enable/disable the SMS sending, by default it is considered ‘enabled’.

	<img src="https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS/blob/master/docs/image12.png" width=600>

1.  Click the green tick to save the action.

2.  Click on **Save** button to save the Logic app.

3.  Now whenever the trigger will be fired, the workflow will be executed to perform the specified action. The specified user (Recipient Number) will get an SMS with the dynamic text message whenever the logic app is triggered.

# Appendix

## Nexmo API Keys

-   To access Nexmo keys, go to <https://www.nexmo.com/> and Sign-in.

-   On the top right corner, click on the “**Api Settings**”.

-   Key and Secret will display in the top bar as shown in the below image:

	<img src="https://github.com/AdvaiyaLabs/Azure-with-Nexmo-SMS/blob/master/docs/image13.png" width=600>