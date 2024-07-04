# book-case_dotnet


 **Technologies**
  <ul>
    <li>ASP.net Core 8</li>
    <li>Debian 10/11 with Makefile</li>
    <li>Makefile for Windows 10/11(current is in testing)</li>
    <li>Docker</li>
    <li>MS Sql</li>
  </ul>


## Integrate with your

- [ ] [Set up project](https://gitlab.com/devkosowski76/book-case_dotnet/)


 ## 01. Application core

### 01.01. Application architecture setup

 **Wymagania**

• Endpoint 1: /api/books, metoda GET.
• Zwraca listę książek w formacie JSON.
• Endpoint 2: /api/orders, metoda GET.
• Zwraca listę zamówień w formacie JSON.
  - Należy zastosować paginację do obsługi dużej ilości danych.
• Endpoint 3: /api/books, metoda POST.
• Dodaje nową książkę, przyjmując payload w formacie JSON.


 **Introduction**

Wykorzystałem podejście Domain Driven Design (DDD) i Test Driven Development (TDD).
Proponowane rozwiązanie będzie obejmowało warstwy domeny, aplikacji oraz infrastruktury.


 01. [x] Application architecture

  $ mkdir BookLibrary.Core && cd BookLibrary.Core && dotnet new classlib && cd .. && \
mkdir BookLibrary.Infrastructure && cd BookLibrary.Infrastructure && dotnet new classlib && cd .. && \
mkdir BookLibrary.Api && cd BookLibrary.Api && dotnet new webapi --use-controllers --no-openapi && cd ..

  in src/
  $ dotnet new webapi --use-controllers --no-openapi -o BookLibrary.Api

  $ cd BookLibrary.Api && dotnet add package Microsoft.EntityFrameworkCore.InMemory && \
code -r ../BookLibrary.Api

$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design && \
  dotnet add package Microsoft.EntityFrameworkCore.Design && \
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer && \
  dotnet add package Microsoft.EntityFrameworkCore.Tools && \
  dotnet tool uninstall -g dotnet-aspnet-codegenerator && \
  dotnet tool install -g dotnet-aspnet-codegenerator && \
  dotnet tool update -g dotnet-aspnet-codegenerator

  $ dotnet aspnet-codegenerator controller -name BookLibraryItemsController -async -api -outDir Controllers


 02. [x] Dependencies between projects

  in src/

  $ dotnet add BookLibrary.Infrastructure/BookLibrary.Infrastructure.csproj reference BookLibrary.Core/BookLibrary.Core.csproj
  $ dotnet add BookLibrary.Api/BookLibrary.Api.csproj reference BookLibrary.Infrastructure/BookLibrary.Infrastructure.csproj

  $ dotnet sln add BookLibrary.Api/BookLibrary.Api.csproj && \
dotnet sln add BookLibrary.Core/BookLibrary.Core.csproj && \
dotnet sln add BookLibrary.Infrastructure/BookLibrary.Infrastructure.csproj


 03. [x] Projekt for tests (xUnit)

  $ dotnet new xunit -o BookLibrary.Tests && \
dotnet sln add BookLibrary.Tests/BookLibrary.Tests.csproj


 04. [x] Domain and entity

 05. [x] User model

 05. [x] Order model

 05. [x] OrderLine model


 ## 02. Library implementation

### 02.01. Implementation of repositories

 01. [x] Repositories


### 02.02. Registration of Services in the DI Container

 01. [x] Rejestracja Serwisów w Kontenerze DI


### 02.03. Implementation of Controllers in Web API

 01. [x] Implementacja Kontrolerów w Web API

 ## 03. Tests

### 03.01. Unit tests

 01. [x] Testy Jednostkowe
