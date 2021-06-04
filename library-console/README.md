# library-console

dotnet new sln
dotnet new classlib -o Animal
dotnet new console -o LibraryConsole
dotnet sln add Animal/Animal.csproj
dotnet sln add LibraryConsole/LibraryConsole.csproj
dotnet add LibraryConsole/LibraryConsole.csproj reference Animal/Animal.csproj
dotnet run
