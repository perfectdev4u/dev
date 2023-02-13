
## Getting Started
Use these instructions to get the project up and running.

Prerequisites
You will need the following tools:

Visual Studio 2022(https://visualstudio.microsoft.com/downloads/)

Technologies:-

NET Core 6.0



Entity Framework Core 



Identity

Jwt Authentication

AutoMapper


#       DotNetCore  DemoStructure

This is Five layer Structure.

1. API
2. Application 
3. Core
4. Domain
5. Infrastructure







## API

This is the first layer of Structure it's contains.

•	Controllers

•	Connected Services

•	Program.cs 

•	Appsetting.json

## Application  

•	This is the service layer  for project 

•	All the business logic are here

## Core

•	All the core requirements 

•	Helpers ( Payment Gateway)

•	Configuration 

## Domain
•	Domain layer contains …


•	Entities (Tables )



•	Enums 

•	Interfaces  

## Infrastructure
•	Infrastructure layer contains ….

•	Migrations 

•	DatabaseContext

•	Dependency Injection 

## Installing

Follow these steps to get your development environment set up:

Clone the repository
At the root directory, restore required packages by running:
dotnet restore
Next, build the solution by running:
dotnet build

Next, within the AspnetRun.Web directory, launch the back end by running:
dotnet run


Launch http://localhost:5400/ in your browser to view the Web UI.


If you have Visual Studio after cloning Open solution with your IDE, AspnetRun.Web should be the start-up project. 

Directly run this project on Visual Studio with F5 or Ctrl+F5. You will see index page of project, 
you can navigate product and category pages and you can perform crud operations on your browser.





Give a Star! ⭐


If you liked the project or if AspnetRun helped you, please give a star. And also please fork this repository and send us pull-requests. If you find any problem please open issue.
