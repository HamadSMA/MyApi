# ASP.NET Core Web API – Starter

A clean ASP.NET Core Web API starter project created using the .NET CLI.  
Includes **two controllers**, each exposing **three endpoints**, ready for extension.

## Requirements

- .NET SDK 8.0+
- Terminal / CLI
- Any code editor

Check SDK:

```bash
dotnet --version
```

## Project Structure

```
MyApi/
├── Controllers/
│   ├── WeatherController.cs
│   └── ProductsController.cs
├── Program.cs
└── MyApi.csproj
```

## API Endpoints

### Weather

- `GET /api/weather`
- `GET /api/weather/today`
- `GET /api/weather/{city}`

### Products

- `GET /api/products`
- `GET /api/products/{id}`
- `POST /api/products`

## Run

```bash
dotnet run
```

Swagger UI (dev):

```
https://localhost:{port}/swagger
```
