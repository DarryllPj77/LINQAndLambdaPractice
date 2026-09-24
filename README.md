# [LINQAndLambdaPractice]

Summary
-------
This is a small .NET console project demonstrating LINQ and lambda expressions. It targets .NET 10 (net10.0) and contains a single Program.cs example plus the project (.csproj) and solution files.

Requirements
------------
- .NET 10 SDK (dotnet) installed: https://dotnet.microsoft.com
- Recommended: Visual Studio 2026 (Community/Professional/Enterprise) or VS Code with C# extension

Quick start
-----------
1. Restore and build:

   dotnet restore
   dotnet build

2. Run:

   dotnet run --project LINQAndLambdaPractice\LINQAndLambdaPractice.csproj

Project structure
-----------------
- LINQAndLambdaPractice.slnx - Visual Studio solution
- LINQAndLambdaPractice/ - project folder
  - LINQAndLambdaPractice.csproj - project file (TargetFramework: net10.0)
  - Program.cs - sample console app demonstrating LINQ and lambda usage

Dependencies
------------
This project uses only the .NET runtime and the base class libraries. There are no external NuGet package dependencies.

Repository setup (example)
-------------------------
After creating a GitHub repository, run the commands provided by the assistant (you will be prompted to paste the HTTPS URL) to initialize the local git repository and push the initial commit.

Notes
-----
- If you later add packages, list them in the csproj and update this README accordingly.
- For CI, add a workflow (e.g., GitHub Actions) to restore, build, and test on push.
