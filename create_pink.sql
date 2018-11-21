USE master;
GO

IF  DB_ID('Pink') IS NOT NULL
    DROP DATABASE Pink;
GO

CREATE DATABASE Pink;
GO

USE Pink;

-- create the tables for the database

CREATE TABLE Employees (
  EmployeeID           INT         PRIMARY KEY   IDENTITY,
  EmailAddress      VARCHAR(255)   NOT NULL,
  JobTitle			CHAR(20)	   NOT NULL,
  FirstName         VARCHAR(255)   NOT NULL,
  LastName          VARCHAR(255)   NOT NULL,
  HireDate			DATETIME		   NOT NULL,
  Salary			DECIMAL(9,2)   NOT NULL
);

CREATE TABLE Residents(
  ResidentID           INT            PRIMARY KEY   IDENTITY,
  EmployeeID		INT					FOREIGN KEY REFERENCES Employees(EmployeeID) DEFAULT NULL,
  EmailAddress         VARCHAR(255)   NOT NULL      UNIQUE,
  FirstName            VARCHAR(60)    NOT NULL,
  LastName             VARCHAR(60)    NOT NULL,
  PhoneNumber			VARCHAR(20)		NOT NULL
);

CREATE TABLE Payments (
  PaymentID         INT            IDENTITY,
  ResidentID        INT				NOT NULL,
  PaymentDate		DATETIME	   NOT NULL,
  RentAmount        MONEY          NOT NULL,
  CreditAmount      MONEY          NOT NULL,
  DueDate           DATETIME       DEFAULT NULL,
  CardType          VARCHAR(50)    NOT NULL,
  CardNumber        CHAR(16)       NOT NULL, 
  constraint PK_Payments primary key (PaymentID, ResidentID),
  constraint FK_Payments foreign key (ResidentID) references Residents(ResidentID)
);



CREATE TABLE Pets (
	ResidentID	int NOT NULL,
	Species	varchar(60),
	Breed		varchar(60),
	RegistrationDate DateTime,
	PaymentDate DateTime,
	constraint PK_PETS primary key (ResidentID),
	constraint FK_PETS_ResidentID	foreign key (ResidentID) references Residents(ResidentID)
);

CREATE TABLE ResidentVehicles (
	LicensePlate varchar(60) NOT NULL,
	ResidentID	int NOT NULL,
	Make		varchar(20),
	Model		varchar(20),
	Color		varchar(20),
	RegistrationDate	DateTime,
	DecalSticker		varchar(20),
	constraint PK_RESIDENT_VEHICLES primary key (LicensePlate),
	constraint FK_RESIDENT_VEHICLES foreign key (ResidentID) REFERENCES Residents(ResidentID)
);

CREATE TABLE EventsLog (
EventID		INT		Not Null IDENTITY,
EmployeeID	INT		Foreign key References Employees (EmployeeID) Not Null,
ResidentID	INT		Foreign Key References Residents (ResidentID) Not Null,
EDate		DateTime	Not Null,
ELocation	VARCHAR(50)	Not Null,
EDesc	VARCHAR(50) Not Null
constraint PK_Events primary key (EventID)
);

CREATE TABLE Apartments (
ApartmentNum	INT		NOT NULL PRIMARY KEY IDENTITY,
NumBeds			INT		NOT NULL,
NumBaths		INT		NOT NULL,
Sqft			INT		NOT NULL
);

CREATE TABLE Contracts (
ContractID		INT		NOT NULL IDENTITY,
ResidentID		INT		FOREIGN KEY REFERENCES Residents(ResidentID) NOT NULL,
ApartmentNum	INT		FOREIGN KEY REFERENCES Apartments(ApartmentNum)	NOT NULL,
Price			MONEY		NOT NULL,
StartDate		DATE	NOT NULL,
EndDate			DATE	NOT NULL,
PetsAllowed		BIT		NOT NULL,
SmokingAllowed	BIT		NOT NULL,
Specials		VARCHAR(60)	DEFAULT NULL,
constraint PK_Contracts primary key (ContractID, ResidentID, ApartmentNum)
);



-- Insert data into the tables

SET IDENTITY_INSERT Apartments ON;
INSERT INTO Apartments(ApartmentNum, NumBeds, NumBaths, Sqft) VALUES
(100, 4, 4, 1000),
(101, 4, 4, 1000),
(102, 4, 4, 1000),
(103, 4, 4, 1000),
(104, 4, 4, 1000),
(105, 4, 4, 1000),
(106, 4, 4, 1000),
(107, 4, 4, 1000),
(108, 4, 4, 1000),
(109, 4, 4, 1000),
(110, 4, 4, 1000);
SET IDENTITY_INSERT Apartments OFF;

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

SET IDENTITY_INSERT Residents ON;

INSERT INTO Residents(ResidentID, EmployeeID, EmailAddress, FirstName, LastName, PhoneNumber) VALUES
(1, 1, 'allan.sherwood@yahoo.com', 'Allan', 'Sherwood', '555-555-5551'),
(2, NULL, 'barryz@gmail.com', 'Barry', 'Zimmer', '555-555-5552'),
(3, NULL, 'christineb@solarone.com', 'Christine', 'Brown', '555-555-5553'),
(4, NULL, 'david.goldstein@hotmail.com', 'David', 'Goldstein', '555-555-5554'),
(5, 2, 'erinv@gmail.com', 'Erin', 'Valentino', '555-555-5555'),
(6, NULL, 'frankwilson@sbcglobal.net', 'Frank Lee', 'Wilson', '555-555-5556'),
(7, NULL, 'gary_hernandez@yahoo.com', 'Gary', 'Hernandez', '555-555-5557'),
(8, NULL, 'heatheresway@mac.com', 'Heather', 'Esway', '555-555-5558'),
(9, 3, 'jbutt@gmail.com', 'James', 'Butt', '555-555-5559'),
(10, 4, 'josephine_darakjy@darakjy.org', 'Josephine', 'Darakjy', '555-555-5510');

SET IDENTITY_INSERT Residents OFF;

SET IDENTITY_INSERT Contracts ON;
INSERT INTO Contracts(ContractID, ResidentID, ApartmentNum, Price, StartDate, EndDate, PetsAllowed, SmokingAllowed, Specials) VALUES
(1, 1, 100, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(2, 2, 101, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(3, 3, 102, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(4, 4, 103, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(5, 5, 104, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(6, 6, 105, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(7, 7, 106, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(8, 8, 107, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(9, 9, 108, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(10, 10, 109, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox'),
(10, 10, 110, 1000.00, '2015-9-5', '2016-9-5', 1, 1, 'Free XBox');
SET IDENTITY_INSERT Contracts OFF;


SET IDENTITY_INSERT EventsLog ON;
INSERT INTO EventsLog(EventID, EmployeeID, ResidentID, EDate, ELocation, EDesc) VALUES
(1, 1, 1, '2015-9-5', 'Theater', 'Watched a movie'),
(2, 1, 1, '2015-10-5', 'Pool', 'Swimming Match'),
(3, 1, 1, '2015-9-8', 'Pool', 'Swimming Match'),
(4, 1, 1, '2015-9-12', 'Grill', 'BBQ'),
(5, 1, 1, '2015-10-31', 'Pool', 'Swimming Match'),
(6, 1, 1, '2016-9-10', 'Theater', 'Watched a movie'),
(7, 1, 1, '2015-12-5', 'Lounge', 'Watched a movie'),
(8, 1, 1, '2015-11-15', 'Bar', 'Drank'),
(9, 1, 1, '2015-9-15', 'Tennis Courts', 'Played tennis'),
(10, 1, 1, '2015-9-15', 'Bar', 'Drank'),
(11, 1, 1, '2015-9-16', 'Pool', 'Swimming Match');

SET IDENTITY_INSERT EventsLog OFF;


INSERT INTO Pets (ResidentID, Species, Breed, RegistrationDate, PaymentDate)
VALUES (1, 'Dog', 'German Shepherd', '2016-5-5', '2016-5-10'),
	    (2, 'Cat', 'Calico', '2015-8-1', '2015-9-5'),
	    (3, 'Dog', 'Tibby', '2016-1-5', '2016-1-30'),
	    (4, 'Cat', 'Alley', '2017-3-3', '2017-4-20'),
	    (5, 'Dog', 'Pug', '2016-10-10', '2016-11-12');


INSERT INTO ResidentVehicles (LicensePlate, ResidentID, Make, Model, Color, RegistrationDate, DecalSticker)
VALUES ( 'abc-123', 1, 'Honda', 'Civic', 'Black', '2016-5-5', 'a0sijf'),
	    ( 'zbd-14d', 2, 'Ford', 'F-150', 'Grey', '2015-1-30', 'asoihf'),
	    ( 'bdb-322', 3, 'Tesla', 'Model 3', 'Red', '2018-5-3', 'memes'),
	    ( 'asd-fgh', 4, 'Nissan', 'GTR', 'Black', '2013-9-4', 'zxcvgr'),
	    ( 'jkhdgfg', 5, 'Volkswagen', 'Beatle', 'Blue', '2018-2-3', 'qwertyu');



SET IDENTITY_INSERT Payments ON;

INSERT INTO Payments(PaymentID, ResidentID, PaymentDate, RentAmount, CreditAmount, DueDate, CardType, CardNumber) VALUES
(1, 1, '2016-03-28 09:40:28.000', 588.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '4111111111111111'), 
(2, 2, '2016-03-28 09:40:28.000', 600.75, 0.0, '2016-03-31 09:41:11.000', 'American Express', '3782822463100005'), 
(3, 3, '2016-03-28 09:40:28.000', 475.75, 0.0, '2016-03-31 09:41:11.000', 'Discover', '6011111111111117'), 
(4, 4, '2016-03-28 09:40:28.000', 999.75, 0.0, '2016-03-31 09:41:11.000', 'MasterCard', '5555555555554444'), 
(5, 5, '2016-03-28 09:40:28.000', 475.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '101010101010'), 
(6, 6, '2016-03-28 09:40:28.000', 588.75, 0.0, '2016-03-31 09:41:11.000', 'MasterCard', '999999999999'), 
(7, 7, '2016-03-28 09:40:28.000', 500.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '98989898989898'), 
(8, 8, '2016-03-28 09:40:28.000', 475.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '4111111111111111'), 
(9, 9, '2016-03-28 09:40:28.000', 588.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '4111111111111111'), 
(10, 10, '2016-03-28 09:40:28.000', 588.75, 0.0, '2016-03-31 09:41:11.000', 'Visa', '4111111111111111');

SET IDENTITY_INSERT Payments OFF;


