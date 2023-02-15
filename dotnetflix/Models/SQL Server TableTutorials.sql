use dotnetflix;


CREATE TABLE Tutorials(
Id int IDENTITY (1,1) PRIMARY KEY,
LinkVideo varchar(100),
LinkThumbnailVideo varchar(100),
Title varchar(100),
Description varchar(100),
Language varchar(100),
Duration float(5),
Categorie int,
)
