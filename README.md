# E2E Type Safety with .NET 8 Minimal API and TypeScript

Demo screen cast:

![Demo](./docs/demo.gif)

The video is sped up 2x-4x. The actual time after the .NET code changes and affect the TypeScript code is around 10-15 seconds.

## Setup

```
cd frontend && npm install
```

## How to run

```
cd WeatherApi && dotnet watch run
cd frontend && npm run dev
```

## Manual

## Run .NET API

```
dotnet dev-certs https --trust
dotnet run --launch-profile https
```

## Watch Mode (Hot Reload)

```
dotnet watch run --launch-profile https
```

This openapi.json will not be generated on watch mode. You can run the following command to generate it.

```
dotnet watch build  -- --configuration Gen
```

## Ref
- https://chrlschn.dev/blog/2023/10/end-to-end-type-safety-with-dotnet7-webapis-typescript-openapi/
- Generate OpenApi.json on build from ASP.NET 8 Minimal API: https://gist.github.com/VincentH-Net/a950fb18363111ccac8e1fb64123647e

## Other TypeScript Client Options
- ~~https://github.com/ferdikoomen/openapi-typescript-codegen~~ https://github.com/hey-api/openapi-ts
- Convert to Zodios Client: https://github.com/astahmer/openapi-zod-client

  ```
  pnpx openapi-zod-client "openapi.json" -o "./client.ts" 
  ```
- https://github.com/astahmer/typed-openapi
- https://github.com/astahmer/openapi-zod-client/blob/HEAD/examples/basic/petstore-generator.ts
