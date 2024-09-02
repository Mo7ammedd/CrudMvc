
# CompanyMvc

CompanyMvc is a simple ASP.NET MVC application for managing company employees and departments. This project demonstrates basic CRUD (Create, Read, Update, Delete) operations and provides a straightforward example of how to use ASP.NET MVC to build a web application.

## Features

- **Employee Management**: Create, view, edit, and delete employee records.
- **Department Management**: Manage company departments and associate employees with departments.
- **Validation**: Form validation for employee and department data.
- **Database Integration**: Use Entity Framework for database interactions.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following software installed on your machine:

- [.NET Core](https://dotnet.microsoft.com/download/dotnet-framework) (version 5 or higher)
- [Visual Studio](https://visualstudio.microsoft.com/) (2019 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or SQL Server Express

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Mo7ammedd/CompanyMvc.git
   cd CompanyMvc
   ```

2. **Open the solution**:
   - Open `CompanyMvc.sln` in Visual Studio.

3. **Restore NuGet packages**:
   - Visual Studio should automatically restore the required NuGet packages. If not, go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution...` and restore the packages.

4. **Update the database connection string**:
   - In `Web.config`, update the connection string to point to your SQL Server instance.

5. **Run the migrations** (if needed):
   - Open the Package Manager Console in Visual Studio and run the following commands:
     ```bash
     Update-Database
     ```

6. **Build and run the application**:
   - Press `F5` in Visual Studio to build and run the application.

### Usage

- **Employee Management**: Navigate to `/Employees` to manage employees.
- **Department Management**: Navigate to `/Departments` to manage departments.

### Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

### License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
