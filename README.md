
## Introduction

This project is designed based on the classic n-tier architecture approach and consists of three main layers: API, Services, and Repositories. The API layer handles communication with clients by processing HTTP requests and returning responses, while the Services layer contains the business logic and manages business rules. The Repositories layer abstracts the database operations and manages data access. This structure ensures clear separation of concerns, making the code more understandable and maintainable. Additionally, it allows each layer to be developed and tested independently.

## Start

To get the application up and running, the appropriate .NET 8 SDK version must be installed, and a suitable database should be created using migrations.

## Dependencies

| Name                                 | Category           | Version     |
|--------------------------------------|--------------------|-------------|
| AutoMapper                           | Mapping            | 13.0.1      |
| FluentValidation.AspNetCore          | Validation         | 11.3.0      |
| Microsoft.EntityFrameworkCore        | ORM                | 8.0.0       |
| Microsoft.EntityFrameworkCore.Design | ORM                | 8.0.0       |
| Microsoft.EntityFrameworkCore.SqlServer | ORM              | 8.0.0       |
| Microsoft.EntityFrameworkCore.Tools  | ORM                | 8.0.0       |
| Swashbuckle.AspNetCore               | API Documentation  | 6.6.2       |
