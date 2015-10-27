create database ProyectoDB
use ProyectoDB
create table RegistroUsuarios(UsuarioId int identity, Nombre varchar(50), Apellido varchar(50), Telefono int, Direccion varchar(50),
								FechaNacimiento varchar(8), Cedula int, sexo int, Clave int,)
