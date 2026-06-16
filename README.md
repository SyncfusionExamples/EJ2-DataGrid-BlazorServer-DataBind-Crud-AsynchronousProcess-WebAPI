# Blazor Server DataGrid — Asynchronous WebAPI

A minimal Blazor Server sample that demonstrates binding the [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) to data loaded asynchronously from an external WebAPI and performing CRUD operations from external controls.

## Overview

This sample shows how a Blazor Server page requests data from a WebAPI endpoint and how external UI controls (buttons) can invoke CRUD operations that update the DataGrid asynchronously. This provides a simple in-memory data store for demonstration.

## Features

- Asynchronous data binding from a WebAPI.
- External (non-row) CRUD button handling.
- Simple, minimal project to study DataGrid integration patterns.
- Built-in paging, sorting and filtering support in the DataGrid.

## Prerequisites

* [.NET SDK 10.0](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) or later
* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
* [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/SyncfusionExamples/EJ2-DataGrid-BlazorServer-DataBind-Crud-AsynchronousProcess-WebAPI.git
cd EJ2-DataGrid-BlazorServer-DataBind-Crud-AsynchronousProcess-WebAPI
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## Resources

**Documentation**: https://blazor.syncfusion.com/documentation/datagrid/getting-started-with-server-app

**Demo**: https://blazor.syncfusion.com/demos/datagrid/overview?theme=fluent2