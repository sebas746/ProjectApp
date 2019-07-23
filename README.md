# ProjectApp

Base project for study purposes.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

.Net Framework 4.6.2
SQL Server 2014 or above.
Visual Studio 2017
Node.js (Minimum For angular 7)

### Installing

1. Restore Database Backup

- Restore the backup file named WebApp_Backup. Database name: WebApp.

2. Modify values of connection strings on config files in the WebApi Visual Studio Project.

- WebApp project 
  In the Web.Config file section ConnectionStrings please update the values for an appropiate connection parameters such as you have configured in your local environment.
  
  Test Project
  In the App.Config file section ConnectionStrings please update the values for an appropiate connection parameters such as you have configured in your local environment.

3. Restore FrontEnd Angular project 

- Please run the "npm install" command in the FrontEnd root folder.
- Update the file name params.js located at "src\assets\params" and update the Web Api address for consuming the services.

4. Run both projects at the same time

- Web Api

After you configure the connection strings please run the project.

## Running the tests

- Please update the connection string value for your local environment.
- Run the test cases using the Visual Studio Test Explorer Tool.


