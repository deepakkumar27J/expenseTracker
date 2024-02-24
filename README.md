# expenseTracker
This app is for expense tracking

# Probelms and the answers

First on running Add-Migration, but the error comes on not found, so have to add "dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.5"
next one is on "Update-Database the error comes for invariantGlobal, so make sure in .csproj file it is set to false.
Also make sure in .json file it is ConnectionStrings not ConnectionsStrings.
Also make sure there is primary key in every table.


