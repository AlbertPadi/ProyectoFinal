create database ProyectoDB
use ProyectoDB
drop table RegistroUsuarios
create table RegistroUsuarios(UsuarioId int identity, Nombre varchar(50), Apellido varchar(50), Telefono numeric, Direccion varchar(50),
								Cedula numeric, sexo int, Clave varchar(100))

select *from RegistroUsuarios
