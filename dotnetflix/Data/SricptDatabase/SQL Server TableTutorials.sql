use dotnetflix;

create table Tutorials(

Id int identity(1,1) primary key,
LinkVideo varchar(100),
LinkThumbnailVideo varchar(100),
Title varchar(100),
Description varchar(100),
Language varchar(100),
Duration float,
Categorie int,

)

