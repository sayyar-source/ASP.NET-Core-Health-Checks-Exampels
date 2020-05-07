# ASP.NET-Core-Health-Checks-Exampels
Health Checks to the rescue! Before trying out the code yourself

# Entity Framework Core DbContext probe

The DbContext check confirms that the app can communicate with the database configured for an EF Core DbContext. 
The DbContext check is supported in apps that:
- Use Entity Framework (EF) Core.
- Include a package reference to: 
  - Microsoft.Extensions.Diagnostics.HealthChecks.EntityFrameworkCore.
  
After the app is running, check the health status by making a request to the /health endpoint in a browser. 

The database and CatalogContext don't exist, so app provides the following response:

:-1: Unhealthy

 if CatalogContext exist, so app provides the following response:
 
:thumbsup: healthy
