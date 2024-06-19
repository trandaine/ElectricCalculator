create DATABASE ElectricCalculator
use ElectricCalculator

create table Customers
(
    ID          char(12) not null
        primary key,
    FullName    char(75) not null,
    Name        char(20),
    DateofBirth date
        check ([DateofBirth] >= '1900-01-01' AND [DateofBirth] <= '2024-12-31')
)
go

create table CustomerInfo
(
    Id         char(36) not null
        primary key,
    CustomerID char(12) not null
        references Customers,
    Address    varchar(255),
    Phone      varchar(20),
    Email      varchar(255)
)
go

create table ElectricPrice
(
    Id    tinyint not null
        primary key,
    Range tinyint not null,
    Price real    not null
)
go

create table EmployeeID
(
    Id   char(12) not null
        primary key,
    Name char(75)
)
go

create table CustomerIndies
(
    Id            int identity
        primary key,
    CustomerID    char(12) not null
        references Customers,
    CurrentIndex  smallint not null,
    ConsumerIndex smallint not null,
    Cost          real,
    DateRecorded  date     not null,
    DateCreated   date     not null,
    Month         tinyint,
    Year          tinyint,
    EmployeeId    char(12) not null
        references EmployeeID
)
go

