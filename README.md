# Zepto Clone (.NET 8)

This project is a lightweight **Zepto-style grocery storefront clone** built with ASP.NET Core MVC targeting **.NET 8**.

## Features

- Zepto-inspired landing page and colors
- Category filtering for products
- Add-to-cart flow
- Session-backed cart state
- Quantity updates and checkout summary card

## Prerequisites

- .NET 8 SDK (`dotnet --version` should return `8.x`)
- (Optional) VS Code + C# extension for one-click Run/Debug

## Run in VS Code

1. Open this folder in VS Code.
2. Press `Ctrl+Shift+B` and choose **build**.
3. Press `F5` and choose **.NET 8 Launch (Zepto Clone)**.
4. Your browser will open automatically when the app starts.

> Preconfigured files are available in `.vscode/launch.json` and `.vscode/tasks.json`.

## Run from terminal

```bash
dotnet restore
dotnet run --project Clone-Zepto.csproj
```

Then open the URL shown in the console (`http://localhost:xxxx` or `https://localhost:xxxx`).
