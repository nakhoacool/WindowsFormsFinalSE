# Supplement Facts Product Management App

A Windows Forms application for managing and organizing supplement facts product data.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Database Design](#database-design)
- [Getting Started](#getting-started)
- [Dependencies](#dependencies)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This Windows Forms application is designed to assist in the management and organization of supplement facts product information. It provides an intuitive user interface for adding, editing, and searching for supplement facts products.

## Features

- User-friendly interface for product data entry and management.
- Store essential product information such as product name, ingredients, nutritional facts, serving size, and more.
- Search and filter products based on various criteria.
- Export product data to various formats (e.g., CSV, Excel).
- Backup and restore data for data security.

## Database Design
![Database](https://github.com/nakhoacool/WindowsFormsFinalSE/assets/77623180/23f45db0-806b-4d18-9dee-85c5c297209a)
## Getting Started

To get started with this project, follow these steps:
1. Clone the repository
2. Open the project in Visual Studio (or your preferred IDE).
3. Build and run the application.
- **Winform:**

  - Change the connection string `"data source"` to your SQL Server in `App.config`.

  **Warning**: If you encounter a problem, it's probably missing some NuGet package. Right-click on the solution, choose "Manage NuGet Packages," and click "Restore."

## Dependencies

List the key dependencies your project relies on. For example:

- Windows Forms (part of the .NET Framework)
- Entity Framework (for database interaction)
- ...

## Contributing

If you'd like to contribute to this project, please follow the standard GitHub flow:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and submit a pull request.

## License
This project is licensed under the [MIT License](LICENSE).
