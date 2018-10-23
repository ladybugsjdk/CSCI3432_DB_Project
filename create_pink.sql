USE master;
GO

IF  DB_ID('Pink') IS NOT NULL
    DROP DATABASE Pink;
GO

CREATE DATABASE Pink;
GO

USE Pink;

-- create the tables for the database
CREATE TABLE Residents(
  ResidentID           INT            PRIMARY KEY   IDENTITY,
  EmailAddress         VARCHAR(255)   NOT NULL      UNIQUE,
  FirstName            VARCHAR(60)    NOT NULL,
  LastName             VARCHAR(60)    NOT NULL,
  AptNumber    INT                          DEFAULT NULL
);

CREATE TABLE Invoices (
  InvoiceID         INT            PRIMARY KEY  IDENTITY,
  ResidentID        INT            REFERENCES Residents (ResidentID),
  InvoiceDate       DATETIME       NOT NULL,
  PaymentDate		DATETIME	   NOT NULL,
  RentAmount        MONEY          NOT NULL,
  CreditAmount      MONEY          NOT NULL,
  DueDate           DATETIME       DEFAULT NULL,
  CardType          VARCHAR(50)    NOT NULL,
  CardNumber        CHAR(16)       NOT NULL,
  CardExpires       CHAR(7)        NOT NULL   
);

CREATE TABLE Employees (
  EmployeeID           INT         PRIMARY KEY   IDENTITY,
  EmailAddress      VARCHAR(255)   NOT NULL,
  JobTitle			CHAR(20)	   NOT NULL,
  FirstName         VARCHAR(255)   NOT NULL,
  LastName          VARCHAR(255)   NOT NULL,
  HireDate			DATETIME		   NOT NULL,
  Salary			DECIMAL(9,2)   NOT NULL
);

CREATE TABLE ResidentVehicles (
  LicensePlate         INT    PRIMARY KEY IDENTITY,
  ResidentID           INT			  REFERENCES 	Residents(ResidentID),
  Make				   VARCHAR(60)	  NOT NULL,
  Model				   VARCHAR(60)	  NOT NULL,
  Color				   VARCHAR(60)	  NOT NULL,
  RegistrationDate	   DATETIME			  NOT NULL
);


-- Insert data into the tables

SET IDENTITY_INSERT Residents ON;

INSERT INTO Residents (ResidentID, EmailAddress, FirstName, LastName, AptNumber) VALUES
(1, 'allan.sherwood@yahoo.com', 'Allan', 'Sherwood', 102),
(2, 'barryz@gmail.com', 'Barry', 'Zimmer', 103),
(3, 'christineb@solarone.com', 'Christine', 'Brown', 104),
(4, 'david.goldstein@hotmail.com', 'David', 'Goldstein', 106),
(5, 'erinv@gmail.com', 'Erin', 'Valentino', 107),
(6, 'frankwilson@sbcglobal.net', 'Frank Lee', 'Wilson', 108),
(7, 'gary_hernandez@yahoo.com', 'Gary', 'Hernandez', 109),
(8, 'heatheresway@mac.com', 'Heather', 'Esway', 110),
(9, 'jbutt@gmail.com', 'James', 'Butt', 111),
(10, 'josephine_darakjy@darakjy.org', 'Josephine', 'Darakjy', 112);

SET IDENTITY_INSERT Residents OFF;

SET IDENTITY_INSERT ResidentVehicles ON;

INSERT INTO ResidentVehicles (LicensePlate, ResidentID, Make, Model, Color, RegistrationDate) VALUES
(111111, 1, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000'),
(222222, 2, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000'),
(333333, 3, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000'),
(454545, 4, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000'),
(565656, 5, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000'),
(575757, 6, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000'),
(212352, 7, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000'),
(365235, 8, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000'),
(454241, 9, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000'),
(120325, 10, 'Dodge', 'Ram1500', 'Black', '2016-03-28 09:40:28.000');

SET IDENTITY_INSERT ResidentVehicles OFF;


SET IDENTITY_INSERT Invoices ON;

INSERT INTO Invoices (InvoiceID, ResidentID, InvoiceDate, PaymentDate, RentAmount, CreditAmount, DueDate, CardType, CardNumber, CardExpires) VALUES
(1, 1, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 588.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '4111111111111111', '04/2018'), 
(2, 2, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 600.75, 0.0, '2016-03-31 09:41:11.000', 'American Express', '3782822463100005', '02/2017'), 
(3, 3, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 475.75, 0.0, '2016-03-31 09:41:11.000', 'Discover', '6011111111111117', '04/2020'), 
(4, 4, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 999.75, 0.0, '2016-03-31 09:41:11.000', 'MasterCard', '5555555555554444', '12/2018'), 
(5, 5, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 475.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '101010101010', '04/2019'), 
(6, 6, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 588.75, 0.0, '2016-03-31 09:41:11.000', 'MasterCard', '999999999999', '12/2019'), 
(7, 7, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 500.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '98989898989898', '04/2019'), 
(8, 8, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 475.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '4111111111111111', '04/2018'), 
(9, 9, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 588.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '4111111111111111', '04/2018'), 
(10, 10, '2016-03-28 09:40:28.000', '2016-03-28 09:40:28.000', 588.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '4111111111111111', '04/2018');

SET IDENTITY_INSERT Invoices OFF;


SET IDENTITY_INSERT Employees ON;

INSERT INTO Employees(EmployeeID, EmailAddress, JobTitle, FirstName, LastName, HireDate, Salary) VALUES
(1, 'joe@pinkapartments.com', 'Groundsman', 'Joe', 'Davis', '2016-05-07 03:53:06.000', '50000.00'),
(2, 'mark@pinkapartments.com', 'Groundsman', 'Mark', 'Davis', '2016-05-07 03:53:06.000', '25000.00'),
(3, 'jerry@pinkapartments.com', 'Leaser', 'Jerry', 'Davis', '2016-05-07 03:53:06.000', '30000.00'),
(4, 'julie@pinkapartments.com', 'Leaser', 'Julie', 'Davis', '2016-05-07 03:53:06.000', '30000.00'),
(5, 'amy@myguitarshop.com', 'Leaser', 'Amy', 'Davis', '2016-05-07 03:53:06.000', '30000.00'),
(6, 'veronica@myguitarshop.com', 'Property Manager', 'Veronica', 'Davis', '2016-05-07 03:53:06.000', '30000.00'),
(7, 'david@pinkapartments.com', 'Security', 'David', 'Davis', '2016-05-07 03:53:06.000', '30000.00'),
(8, 'mary@pinkapartments.com', 'Security', 'Mary', 'Davis', '2016-05-07 03:53:06.000', '30000.00'),
(9, 'andy@myguitarshop.com', 'Electrician', 'Andy', 'Davis', '2016-05-07 03:53:06.000', '30000.00'),
(10, 'wilson@myguitarshop.com', 'Groundsman', 'Wilson', 'Davis', '2016-05-07 03:53:06.000', '30000.00');

SET IDENTITY_INSERT Employees OFF;