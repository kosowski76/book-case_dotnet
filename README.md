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

 **Requirements**

• Endpoint 1: /api/books, GET method.
• Returns a list of books in JSON format.
• Endpoint 2: /api/orders, GET method.
• Returns a list of orders in JSON format.
 - Pagination should be used to handle large amounts of data.
• Endpoint 3: /api/books, POST method.
• Adds a new book, accepting payload in JSON format.


 **Introduction**

I used the Domain Driven Design (DDD) and Test Driven Development (TDD) approach.
The proposed solution will include domain, application and infrastructure layers.


 01. [x] Application architecture

 02. [x] Dependencies between projects

 03. [x] Projekt for tests (xUnit)

 04. [x] Domain and entity

 05. [x] User model

 05. [x] Order model

 05. [x] OrderLine model


 ## 02. Library implementation

### 02.01. Implementation of repositories

 01. [x] Repositories


### 02.02. Registration of Services

 01. [x] Registration of Services in the DI Container


### 02.03. Implementation of Controllers

 01. [x] Implementation of Controllers in Web API

 ## 03. Tests

### 03.01. Unit tests

 01. [x] Unit tests
