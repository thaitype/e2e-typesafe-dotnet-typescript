https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio-code

- Generate OpenApi.json on build from ASP.NET 8 Minimal API
https://gist.github.com/VincentH-Net/a950fb18363111ccac8e1fb64123647e

## Run

```
dotnet dev-certs https --trust
dotnet run --launch-profile https
```

## Watch Mode (Hot Reload)

```
dotnet watch run --launch-profile https
```

This openapi.json will not be generated on watch mode. You need to stop the watch mode and run the app again.

## Watch Mode without Hot Reload
https://stackoverflow.com/a/76222973

```
dotnet watch run --no-hot-reload --launch-profile https
```