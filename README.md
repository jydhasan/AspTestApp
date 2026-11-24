# AspTestApp

A simple ASP.NET Core Hello World web application.

## Requirements

- .NET 10 SDK
- Visual Studio 2022 (with ASP.NET and web development workload) or VS Code

## Run locally

From the repository folder:

```bash
dotnet restore
dotnet run
```

Open the URL printed in the terminal. The app displays a Hello World page.

Health endpoint:

```
/health
```

## Publish for deployment

```bash
dotnet publish -c Release -o ./publish
```

You can deploy the published output to an Azure App Service configured for .NET 10, or publish directly from Visual Studio using **Publish > Azure > Azure App Service**.
