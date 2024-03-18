Software Requirements :
     1.Visual studio 2022
     2.Sql Server Management studio
step 1 : Download the project at ziped folder.
stpe 2 : Extract that zipped folder.
step 3 : Open the project in visual studio.
step 4 : Install packages go to->tool->NuGet package manager->Manage NuGet Packages for solution->Install below Two Packages
      1. Microsoft.EnitityFrameworkCore.SqlServer
      2. Microsoft.EnitityFrameworkCore.Tools
step 5 : Delete Migration Folder.
step 6 : Go to appsettings.json->Change the server name in the connection string.
step 7 : Go to->tool->NuGet package manager->Package Manager Control->type the below commands one by one
      1. add-migration AnyName
      2. update-database
step 8 : Run the project.

