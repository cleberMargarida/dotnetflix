use dotnetflix;

create table Usuarios(

Id int identity(1,1) primary key,
Nome varchar(100),
Idade int,
Email varchar(100),
TempoExperiencia int,
MeusFavoritos int,
LinkFotoPerfil varchar,

)