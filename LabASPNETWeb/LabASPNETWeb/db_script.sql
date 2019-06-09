-- #0: Create database
CREATE DATABASE LabWebAppAspNet
GO

ALTER DATABASE LabWebAppAspNet
SET RECOVERY SIMPLE
GO

-- #1: Add wpUsers
CREATE TABLE dbo.wpUsers (
  username varchar(100) NOT NULL,
  email varchar(200) NOT NULL,
  name nvarchar(255) NULL,
  createdt datetime DEFAULT getdate() NULL,
  lastupddt datetime NULL,
  activeyn bit DEFAULT 1 NULL,
  lastlogindt datetime NULL,
  pwd varchar(255) NULL,
  PRIMARY KEY CLUSTERED (username),
  UNIQUE (email)
)
GO

--#2: Add wpNews
CREATE TABLE dbo.wpNews (
  id int IDENTITY NOT NULL,
  title nvarchar(200) NULL,
  content ntext NULL,
  tags varchar(255) NULL,
  usr_create varchar(100) NULL,
  createdt datetime DEFAULT getdate() NULL,
  lastupdt datetime NULL,
  activeyn bit DEFAULT 1 NULL,
  homepageyn bit DEFAULT 0 NULL,
  PRIMARY KEY CLUSTERED (id)
)
GO

--#3: Add foreign key
ALTER TABLE dbo.wpNews
ADD CONSTRAINT wpNews_fk FOREIGN KEY (usr_create) 
  REFERENCES dbo.wpUsers (username) 
  ON UPDATE CASCADE
  ON DELETE NO ACTION
GO

