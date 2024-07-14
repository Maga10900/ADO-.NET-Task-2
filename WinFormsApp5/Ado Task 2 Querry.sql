CREATE DATABASE DBCars

GO

USE DBCars

GO

CREATE TABLE Cars
(
[Id] int NOT NULL PRIMARY KEY IDENTITY(1,1),
[Marka] nvarchar(50) NOT NULL,
[Model] nvarchar(50) NOT NULL,
)

Insert into Cars (Marka,Model)
			Values ('Tesla','Model 3')

Insert into Cars (Marka,Model)
			Values ('Tesla','Model S')

		
Insert into Cars (Marka,Model)
			Values ('Toyota','Corolla')

Insert into Cars (Marka,Model)
			Values ('Chevrolet','Aveo')