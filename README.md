# Sales Web MVC Project

### A comprehensive web-based management system for sales teams, departments, and performance reporting. This project was developed as part of a C# specialization and upgraded to the latest .NET 9 standards to showcase modern full-stack development skills.

### Key Features
Full CRUD Management: Complete control over Sellers and Departments.

Business Intelligence Reports: Filterable sales records with "Simple Search" and "Grouping Search" (by department) using optimized LINQ queries.

Robust Architecture: Implementation of the Service Layer pattern to decouple business logic from Controllers.

Custom Exception Handling: Graceful management of database integrity and concurrency errors (e.g., preventing the deletion of departments with active sellers).

Auto-Seeding: Integrated SeedingService to automatically populate the database with test data upon first run.

Responsive UI: Styled with Bootstrap 5 and the Flatly theme for a clean, modern user experience.


# 🛠️ Tech Stack

Backend: C# 13, .NET 9.0, ASP.NET Core MVC.

ORM: Entity Framework Core (Code-First approach).

Database: MySQL 8.4 LTS.

Frontend: Razor Views, HTML5, CSS3, JavaScript, Bootstrap 5.


# 🚀 How to Run Locally

## Prerequisites:

  .NET 9 SDK
	
## 1.Clone the repository

  git clone https://github.com/HayziVV/SalesSystem-AspNetCore
	
  cd SalesWebMVCProject

## 2.Start the Database

Start your own MySQL Database and configure appsettings.json


## 3. Apply Migrations
Create the database schema and tables using package manager console:

Update-Database

## 4. Run the Application

Ctrl+F5 (Start without debugging) or F5 (Start Debugging)
	

# 👤 Author

Vitor Henrique Vercezi

LinkedIn: vítor-vercezi-b7917335b

GitHub: @HayziVV
