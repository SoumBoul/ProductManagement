# Product Management

Desktop sales management application built with C# Windows Forms. The project helps manage products, categories, customers, users, and sales using a simple layered architecture.

## Features

- Product management
- Category management
- Customer management
- User management
- Orders and order details management
- User authentication
- Database backup and restore
- Document display and printing
- Windows Forms user interface

## Technologies

- C#
- .NET Framework 4.7.2
- Windows Forms
- SQL Server
- ADO.NET
- Crystal Reports
- Visual Studio

## Project Structure

```text
Projet Product Management/
├── BL/                    # Business Layer: business logic
├── DAL/                   # Data Access Layer: database access
├── PresentationLayer/     # Windows Forms screens
├── Properties/            # Project settings and resources
├── Resources/             # Images and graphic resources
├── App.config
├── Program.cs
├── Project_Sales_Management.csproj
└── Project_Sales_Management.sln
```

## Requirements

Before running the project, install:

- Visual Studio with .NET Framework support
- .NET Framework 4.7.2
- SQL Server
- Crystal Reports Runtime if required

## Database Configuration

The project uses a SQL Server database named `Product_DB`.

The database connection is configured in:

```text
DAL/DataAccessLayer.cs
```

If your SQL Server configuration is different, update the connection string in this file to match your local environment.

## Getting Started

1. Clone the repository:

```bash
git clone https://github.com/SoumBoul/ProductManagement.git
```

2. Open the solution in Visual Studio:

```text
Project_Sales_Management.sln
```

3. Check the SQL Server connection.

4. Build and run the application from Visual Studio.

## Author

Developed by SoumBoul.
