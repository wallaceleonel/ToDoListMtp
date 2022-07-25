# ToDoListMtp


## Layers used


- Business Layer which implements all the business functionalities

- Repository Layer which composes the SQL 

- Data Layer which contains the data from the database using SQL provided by the
  Repository layer


## Design Patterns Used


- Factory pattern for creation of the layers

- Bridge pattern for decoupling an abstraction from its implementation

## Design Principle Used

S.O.L.I.D 

S -> Separation of Concern or Single Responsibility Principle

O -> Open Closed Principle

L -> Liskov's Substitution Principle

I -> Interface Segregation Principle

D -> Dependency Injection for loosely coupled architecture


## How to run this project

Configure connection strings in appsettings.json
```sh
 "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=InformarData;Persist Security Info=True;User ID=Informar use; Initial Catalog= NomdeDB; Password=Informar senha"
  }

```
## How to do migrations

```sh
add-migration nome da migration
update-database
```
## Tools used

C#

.net Core

Html

Css

Javascript

Sql Server

Docker
