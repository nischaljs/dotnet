---

# 💻 Backend Development in .NET (MV Pattern, API-First, EF Core) with MySQL and SQL Server

> **Goal**: Learn backend development from scratch using the **Model-View (MV) Pattern** in a **.NET console app**, setting up databases using **EF Core** with both **MySQL** and **SQL Server**. Also includes a clear **MERN stack comparison** and **command-by-command explanation**.

---

## 🔄 Project Overview

We'll build a console-based backend in .NET:

- Using **Entity Framework Core (EF Core)**
- Connecting to **MySQL** and **SQL Server**
- Following **Model-View (MV)** (No controller, but View is console I/O)
- Command-line driven setup (no Visual Studio GUI)
- Explaining every command and configuration

We'll also contrast this with MERN stack equivalents.

---

## 🔎 Understanding EF Core

**EF Core** is an ORM (Object-Relational Mapper). Think of it as the C# equivalent of Mongoose (MongoDB ODM) or Sequelize (SQL ORM in JS).

It helps you:

- Map database tables to C# classes
- Avoid writing raw SQL queries
- Focus on logic using LINQ (Language Integrated Query)

---

## 🔄 .NET Console App Setup

```bash
# Create a new console app
> dotnet new console -n MicroBackendApp
> cd MicroBackendApp
```

### What it does:

- Creates a new C# project with `Program.cs`
- Generates a `.csproj` file to manage dependencies

---

## 📂 Add EF Core Packages

### Required in _all_ EF Core projects:

```bash
> dotnet add package Microsoft.EntityFrameworkCore --version 8.0.8
```

- Core library: Enables ORM functionality

```bash
> dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.8
```

- Enables CLI tools like `dotnet ef` for migrations, scaffolding
- Required for _both_ MySQL and SQL Server

---

## 🕐 MySQL Setup (with Pomelo)

```bash
> dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.0
```

- Pomelo is a 3rd-party EF Core provider for MySQL
- Version must match EF Core (e.g., both 8.0)

### Scaffold DB into Models

```bash
> dotnet ef dbcontext scaffold "Server=localhost;Port=3306;Database=LoginSystem;User=root;Password=;SslMode=None;" Pomelo.EntityFrameworkCore.MySql --output-dir Models
```

What this does:

- Reads the DB schema from MySQL
- Generates C# model classes (Student.cs, etc.)
- Creates `LoginSystemContext.cs` (your `DbContext`)

---

## 🕐 SQL Server Setup (Built-in Provider)

```bash
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.8
```

Scaffold command (SQL Server):

```bash
> dotnet ef dbcontext scaffold "Server=localhost;Database=LoginSystem;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models
```

Key Differences:

| MySQL                   | SQL Server                      |
| ----------------------- | ------------------------------- |
| Uses Pomelo package     | Uses Microsoft official package |
| `SslMode=None`          | `Trusted_Connection=True`       |
| Common on Linux/Mac too | Common in enterprise Windows    |

---

## 🔍 Understanding Each File

- `Student.cs` – Maps to `Student` table
- `LoginSystemContext.cs` – Main bridge between your code and DB

```csharp
public class LoginSystemContext : DbContext {
    public DbSet<Student> Students { get; set; }
}
```

---

## 🚀 Sample Code in `Program.cs`

```csharp
using var context = new LoginSystemContext();

foreach (var student in context.Students) {
    Console.WriteLine(student.Name);
}
```

You can also add:

```csharp
var s = new Student { Name = "Nischal" };
context.Students.Add(s);
context.SaveChanges();
```

---

## 🚧 Build and Run

```bash
# Restore NuGet packages
> dotnet restore

# Compile
> dotnet build

# Run
> dotnet run
```

---

## 📈 Comparison with MERN Stack

| Concept         | .NET (EF Core)            | MERN Stack (Node.js + MongoDB) |
| --------------- | ------------------------- | ------------------------------ |
| ORM/ODM         | EF Core                   | Mongoose                       |
| Language        | C#                        | JavaScript / TypeScript        |
| Querying        | LINQ                      | JS query syntax                |
| Schema Handling | Scaffolding / Annotations | Manual in Mongoose             |
| View            | Console I/O               | React                          |
| API             | ASP.NET (if web)          | Express.js                     |
| CLI Tooling     | `dotnet ef`               | npm, nodemon, Postman          |
| DB Support      | Relational (SQL)          | NoSQL (MongoDB)                |
| Type Safety     | Strong                    | Optional (TS needed)           |
| Best For        | Enterprise, Banking       | Startups, Real-time apps       |

---

## 🧲 What is `dotnet ef`?

You installed this with:

```bash
> dotnet tool install --global dotnet-ef
```

- It's a CLI tool to manage EF migrations, scaffolding, and DB updates
- Needed for:

  - `dotnet ef migrations add <name>`
  - `dotnet ef database update`
  - `dotnet ef dbcontext scaffold`

It's required **regardless of MySQL or SQL Server**.

---

## 🤔 Code-First vs Database-First

You used **Database-First**:

- You had an existing DB
- Used `scaffold` to generate code

**Code-First** (Alternative Approach):

1. Create model classes in C#
2. Run `dotnet ef migrations add Initial`
3. Run `dotnet ef database update` to generate schema

---

## 🌐 Optional: Use `appsettings.json` Instead of Hardcoded Strings

For maintainability:

```json
{
  "ConnectionStrings": {
    "Default": "Server=localhost;Database=LoginSystem;..."
  }
}
```

And read it using ConfigurationBuilder. Recommended for Web APIs.

---

## 🚀 Next Steps: Move to Web API

- Convert Console App ➔ ASP.NET Web API
- Use Controllers and Routes
- Host on Kestrel / IIS / Docker
- Add JWT Authentication

---

## 📁 Summary of Commands

| Command                                  | Purpose                                    |
| ---------------------------------------- | ------------------------------------------ |
| `dotnet new console -n NAME`             | Create a new console project               |
| `dotnet add package`                     | Add dependencies like EF Core, MySQL, etc. |
| `dotnet tool install --global dotnet-ef` | Enables `dotnet ef` CLI                    |
| `dotnet ef dbcontext scaffold`           | Reverse-engineer DB into code              |
| `dotnet restore`                         | Fetches packages from NuGet                |
| `dotnet build`                           | Compiles the app                           |
| `dotnet run`                             | Runs the app                               |

---

## 🌐 Want More?

Would you like:

- A full ASP.NET API version of this?
- Docker containerization?
- LINQ deep dive?
- Clean Architecture structure?

Let me know and I’ll expand this guide!

---
