CREATE DATABASE ESTUDO
USE Estudo

CREATE TABLE PESSOA(
	ID int PRIMARY KEY NOT NULL IDENTITY(1,1),
	nome varchar(50) NOT NULL,
	idade int NOT NULL,
	email varchar(50) NOT NULL,
	login varchar(20) NOT NULL,
	senha varchar (50) NOT NULL
)

select * from pessoa;

insert into pessoa values ('Pedro', 20,'pedro20', 'pedro20', 'pedro20')

delete from pessoa

SELECT COUNT(Id) FROM PESSOA WHERE Login = 'Pedro20'

Drop Table Pessoa

" UPDATE Pessoa SET  Nome = 'Pedro',  Idade = '20',  Email = 'pedro20'  Login = 'pedro22'  Senha = '11111111'  WHERE AlunoId = 1 "