# SerapisPatientAPI
Webservice API for mobile Application

Walkthrough blog post - 

This is the first blog post, presenting the backend associated with a sample application: SerapisPatient.

It is a quick walkthrough on using .NET Core 2 to build a Web API layer using MongoDB .NET Driver version 2. All the calls to the database are asynchronous.
Topics Covered

    Technology stack
    Configuration model
    Options model
    Dependency injection
    MongoDb – Installation and configuration using MongoDB C# Driver v.2
    Make a full ASP.NET WebApi project, connected async to MongoDB
    Allowing Cross Domain Calls (CORS)
    Update entire MongoDB documents
    Exception management

How to run it

    Download or clone this project locally
    Install the tools - see here more details: 
    Run first the MongoDB server (details in the article)
    Then in the console, within the current project folder, run the next two commands: dotnet restore, and then dotnet run
    The ASP.NET Core WebAPI will run using IIS (default settings: http://localhost:5000)

