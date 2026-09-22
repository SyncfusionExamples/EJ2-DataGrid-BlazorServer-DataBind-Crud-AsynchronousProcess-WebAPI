# Syncfusion Blazor DataGrid with Asynchronous Web API CRUD Operations

## Overview

This sample demonstrates how to bind a Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) to data retrieved asynchronously from a Web API service within a Blazor Server application. The implementation showcases loading remote data through asynchronous requests and performing Create, Read, Update, and Delete operations through external actions. This approach is useful when business logic, validation workflows, or custom processing must be handled outside the default grid editing lifecycle. The sample illustrates how a Blazor Server application can coordinate API communication and grid updates while maintaining responsive user interactions.

## Key Features

- Displays data in a Syncfusion Blazor DataGrid loaded asynchronously from a Web API endpoint.
- Demonstrates Create, Read, Update, and Delete operations initiated through external button actions.
- Separates UI rendering, controller logic, and data models into dedicated project folders.
- Provides a Blazor Server implementation that communicates with backend services asynchronously.
- Includes controller-based processing for CRUD requests.

## Prerequisites

* Visual Studio 2022 or Visual Studio Code
* .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Open the verified solution file: `CrudAsynchronousSample.sln`.
3. Restore NuGet packages.
4. Ensure the startup project is `CrudAsynchronousSample` if multiple startup projects are present.
5. Build the solution.
6. Run the application using `Ctrl+F5`.
7. Access the application at the local URL displayed by the ASP.NET Core launch output. `[VERIFY: local development URL]`

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the project directory that contains `CrudAsynchronousSample.csproj`.

```bash
dotnet restore
dotnet run
```
## Project Structure

`Pages/` — contains the Blazor page implementation that hosts the DataGrid and user interaction logic.

`Controllers/` — contains the Web API controller responsible for asynchronous data retrieval and CRUD request processing.

`Data/` — contains sample data models and supporting data-related classes used by the application.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Blazor DataGrid documentation: https://help.syncfusion.com/grid-sdk/blazor/data-grid/connecting-to-adaptors/web-api-adaptor#handling-crud-operations

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
