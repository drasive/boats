# boats
Simple webapp for managing boats.

## Components
API: ASP.NET Core REST API  running on .NET 5 and using MS SQL as data store.
Web App: A Vue.js app accessing the API over HTTP.

## Development Environment
Compatible versions may also work. Developed and tested on Windows 10.0.19042.

API:
* .NET 5 SDK
* Visual Studio 2019
* SQL Server 2019 Express

Web app:
* Yarn v1.16

## Getting Started
API:
1. Copy the file `/src/API/Boats.API/appsettings.example.json` to `/src/API/Boats.API/appsettings.json`
2. Update the configuration values in `/src/API/Boats.API/appsettings.json` to match your environment
3. Open the Visual Studio solution `/src/API/Boats.sln`
4. Restore NuGet packages
5. Start the launch profile "IIS Express"

A browser tab with the Swagger UI for the now running web server should open.

Web app:
1. Open a terminal in `/src/WebApp/`
2. Run `yarn install --frozen-lockfile`
3. Run `yarn run vue-cli-service serve`

The web app should be available at http://localhost:8080/.
