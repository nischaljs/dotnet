This repo holds all the codes of dotnet subject that I did in  fifth semester BCA (TU) 


# .NET Project Setup and Commands Guide

This guide provides essential commands for working with .NET projects, including console and web applications.

## 🚀 Creating a New .NET Console Project

```sh
dotnet new console -n MyApp  # -n specifies the project name
cd MyApp
```

## 🏃 Running the Console Project
```sh
dotnet run
```

## 📝 Running an Individual .cs File (Without a Project)
Compile the C# file (Windows only, requires .NET Framework):
```sh
csc Program.cs  # Produces Program.exe
```

Run the compiled executable:
```sh
./Program.exe    # Windows
mono Program.exe # Linux/macOS (if using Mono)
```

> ⚠️ Note: csc (C# Compiler) is available only on Windows. On Linux/macOS, it's better to use dotnet projects.

## 🛠️ Running a Cloned .NET Project

1. Restore dependencies (equivalent to npm install):
```sh
dotnet restore
```

2. Run the project:
```sh
dotnet run
```

## 🌐 Running a .NET Web Project
```sh
dotnet run --project MyWebApp  # Replace 'MyWebApp' with your project folder
```

## 📦 Database Operations
Apply migrations (Entity Framework Core):
```sh
dotnet ef database update  # Similar to 'npx prisma migrate dev'
```

## 🔨 Additional Useful Commands

### Building Projects
```sh
dotnet build  # Compiles the project
```re)

### Version Management
```sh
dotnet --version      # Check SDK version
dotnet --list-sdks   # List installed SDKs
dotnet --list-runtimes # List installed runtimes
```ands
lding a .NET Project
### Creating Web Applications
```sh
dotnet new web -n MyWebApp
cd MyWebAppcking Installed .NET SDK Version
dotnet run
```

### installing packages like MySql.Data
`dotnet add package MySql.Data`



###  🎯 Node.js to .NET Command Referenceating a New ASP.NET Web App

| Node.js Command | .NET Equivalent |
|----------------|-----------------|web -n MyWebApp
| npm install | dotnet restore |p
| npm run dev | dotnet run |
| npm start | dotnet run |ting Installed .NET SDKs
| npx prisma migrate dev | dotnet ef database update |
