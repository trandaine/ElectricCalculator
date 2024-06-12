CREATE DATABASE ElectricCalculator;
USE ElectricCalculator;
CREATE TABLE Customers(
    ID char(12) NOT NULL PRIMARY KEY,
    FullName char(75) not NULL,
    Name char(20),
    DateofBirth date check(DateofBirth between '1900-01-01' and '2024-12-31')
);

CREATE TABLE CustomerInfo(
    Id CHAR(36) NOT NULL PRIMARY KEY,
    CustomerID CHAR(12) NOT NULL FOREIGN key REFERENCES Customers(Id),
    Address VARCHAR(255),
    Phone VARCHAR(20),
    Email VARCHAR(255)
)

CREATE TABLE ElectricPrice(
Id TINYINT NOT NULL PRIMARY KEY,
Range TINYINT NOT NULL,
Price FLOAT(10) NOT NULL
);

CREATE TABLE CustomerIndies(
    Id CHAR(36) not NULL PRIMARY KEY,
    CustomerID CHAR(12) NOT NULL FOREIGN key REFERENCES Customers(Id),
    CurrentIndex SMALLINT NOT NULL,
    ConsumerIndex SMALLINT NOT NULL,
    Cost Float(10),
    DateRecorded DATE NOT NULL,
    DateCreated DATE NOT NULL,
    Month TINYINT,
    Year TINYINT
);

CREATE TABLE EmployeeID(
    Id CHAR(12) NOT NULL PRIMARY KEY,
    Name CHAR(75)
);

ALTER TABLE CustomerIndies add FOREIGN KEY (EmployeeID) REFERENCES Employee (Id);


