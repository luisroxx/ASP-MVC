USE master;

GO

IF EXISTS (SELECT name FROM master.sys.databases WHERE name = 'ESTUDO')
BEGIN
   EXEC('DROP DATABASE ESTUDO')
END

GO
-- Crir Banco de dados
CREATE DATABASE ESTUDO

GO

USE ESTUDO;

GO
CREATE TABLE Login(
	LoginID [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	LoginUsernane [varchar](20) NOT NULL,
	LoginSenha [varchar](50) NOT NULL,
);

GO

CREATE TABLE PESSOA(
	PessoaId [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	LoginID [int] NOT NULL FOREIGN KEY REFERENCES Login(LoginID),
	PessoaNome [varchar](50) NOT NULL,
	PessoaIdade [int] NOT NULL,
	PessoaEmail [varchar](50) NOT NULL,
	PessoaLogin [varchar](20) NOT NULL,
	PessoaSenha [varchar](50) NOT NULL,
)


insert into Login Values ('root','root')

INSERT INTO Pessoa (LoginID, PessoaNome, PessoaIdade, PessoaEmail, PessoaLogin, PessoaSenha)  VALUES (1,'123123',25,'12312','123123','123123') 

select * from pessoa
delete from pessoa