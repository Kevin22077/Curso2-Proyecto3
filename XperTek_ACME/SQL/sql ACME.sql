create database ACME
use ACME
create table TipoEmpresa (IDTipoEmpresa int not null primary key, TipoEmpresa varchar(100), Descripcion varchar(1000), Sigla varchar(10), activo bit not null)
create table Empresa (IDEmpresa int not null primary key, IDTipoEmpresa int not null, Empresa varchar(50) not null, Direccion varchar(100)not null,
RUC varchar(15)not null, FechaCreacion date not null, Presupuesto decimal(18,2)not null, activo bit not null constraint FK_Empresa_TipoEmpresa FOREIGN key (IDTipoEmpresa) references TipoEmpresa (IDTipoEmpresa) )
