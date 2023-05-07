create database sistemabcnfjlje;
use sistemabcnfjlje;

create table doctor(

ID_doctor int NOT NULL primary key AUTO_INCREMENT,
NombreDoc char(20) NULL,
ApellidoDoc char(20) NULL,
TelefonoDoc char(10) NULL,
EmailDoc char(30) NULL,
clave varchar(50)
);

create table paciente(
ID_paciente int NOT NULL primary key AUTO_INCREMENT,
NombrePaciente char(20) NULL,
ApellidoPaciente char(20) NULL,
EmailPaciente char(25) NULL,
GeneroPaciente char(10) NULL,
TelefonoPaciente char(10) NULL,
Estado bit
);

create table tratamiento(
ID_tratamiento int NOT NULL primary key AUTO_INCREMENT,
ID_paciente int references paciente(ID_paciente),
ID_doctor int references doctor(ID_doctor),
Descripcion varchar(50),
Costo decimal(10,2),
FechaCreacion datetime default now()

);

create table detalle_tratamiento(
ID_DetalleTratamiento int NOT NULL primary key AUTO_INCREMENT,
ID_tratamiendo int references tratamiento(ID_tratamiento),
ID_paciente int references paciente(ID_paciente),
ID_doctor int references doctor(ID_doctor),
Descripcion varchar(50),
Costo decimal(10,2),
FechaCreacion datetime default now()

);







#borrar tabla, cuidado
drop  table doctor ;
drop  table paciente
 