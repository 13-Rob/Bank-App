

## Description

Create a simple web application (MVC .Net Framework) based on the following details.

- Use Entity framework

- Stored procedures

Need/Problem

User needs to keep track of his payments.

## End Result/Goal

Create a simple web application that would allow users to add, view, edit, and remove payments they made.

Additional requirements

- Allow the user to remove payments in bulk (the users should be able to choose the records they want to remove)

- Don't allow the user to repeat payments (You're free to choose the fields to make the data unique)

## Additional details

You will have 120 minutes to complete this challenge (or get as much done as possible). You should try to resolve user needs as best as possible. Feel free to add any features you think may be necessary beyond the requirements listed in the goal. Also, you are allowed to use Google or any other online resources while coding.

We will review your application and let you explain how it works after you are done or at the 120-minute mark.
Use Microsoft SQL Server as a DB administrator

---

# ASP.NET Movie App

---

## Commands

### Create app

```
dotnet new mvc -o <app-name>
```

### HTTPS developer certificate

```
dotnet dev-certs https --trust
```

### NuGet packages

```
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator <--- Scaffolding
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### Local dotnet-ef

```
dotnet new tool-manifest
dtnet tool install --local dotnet-ef
```