create database DoacaoBD;
use DoacaoBD;

create table Cliente(
codigoCliente int not null auto_increment primary key,
CPF bigint (11) not null,
nome varchar(100) not null,
telefone varchar(12) not null,
CEP varchar (100) not null
)Engine = InnoDB;
