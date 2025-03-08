CREATE DATABASE restaurant_management
GO

USE restaurant_management
GO

CREATE TABLE users(
	idUser INT IDENTITY(1,1) PRIMARY KEY,
	userName varchar(50) UNIQUE NOT NULL,
	email VARCHAR(150) UNIQUE NOT NULL,
	phone varchar(20),
	userPassword varchar(50) NOT NULL,
    rol VARCHAR(20) NOT NULL,
    state_User VARCHAR(10) NOT NULL,
);
GO


INSERT INTO users values ('admin1', 'example@email.com', '+109456743', 'password123', 'admin', 'active' )
GO

SELECT * FROM users
GO