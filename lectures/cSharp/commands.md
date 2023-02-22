# C-Sharp Commands and Set ups

## Basic Project Commands

### Console App Commands
- Create a new project
```
dotnet new console -o ProjectName
```
- Running the project
```
dotnet run
```
- Everything is written in the Progam.cs file

### Web App
- Create a new project
```
dotnet new web --no-https -o ProjectName
```
- Running the project
```
dotnet watch run
```
#### Folders
- Controllers folder
    - Each main section of the application should gets it's own controller.  (each class)
- Views folder
    - Inside this folder will contain 1 folder for every Controller
    - HomeController.cs gets a Home folder
- wwwroot
    - Contains our static content like JS, CSS, and images
    - Each getting their own folder
#### Files
- Controller Files
    - Each should be named for their content if possible
    - UserController - contains all the user routes
- CSHTML Files
    - Located in the Views/ControllerName folders
    - Should be named after the function calling them

### MVC Application (Full Stack)
- This will be used for Full Stack applications or any that include the database
```
dotnet new mvc --no-https -o ProjectName
```

## Project / Tool Commands
- These are typically installed once and globally.  Here for reference and in the order installed

### Entity dotnet-ef Tool
- Installed once
```
dotnet tool install --global dotnet-ef
```
### Developer Tooling

#### Windows Command Line / Bash
```
    setx ASPNETCORE_ENVIRONMENT Development
```
#### Windows power shell
```
    [Environment]::SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT","Development","User")
```
#### Mac / Linux
```
    export ASPNETCORE_ENVIRONMENT=Development
```