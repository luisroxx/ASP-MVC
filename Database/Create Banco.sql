USE master;

GO

IF EXISTS (SELECT name FROM master.sys.databases WHERE name = 'Escola')
BEGIN
   EXEC('DROP DATABASE Escola')
END

GO
-- Crir Banco de dados
CREATE DATABASE Escola

GO

USE Escola;

GO

CREATE TABLE Aula(
	idAula int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	nmCurso varchar(20) not null,
	nmTurma varchar(10) not null,

	HoraAulaInicio Time not null,
	HoraAulaFim Time not null,
	nmDiaSemana varchar(10) not null,

	HoraAulaInicio2 Time not null,
	HoraAulaFim2 Time not null,
	nmDiaSemana2 varchar(10) not null,

	HoraAtendimentoInicio Time not null,
	HoraAtendimentoFim Time not null,
	nmDiaSemanaAtendimento varchar(10) not null,

	HoraAtendimentoInicio2 Time not null,
	HoraAtendimentoFim2 Time not null,
	nmDiaSemanaAtendimento2 varchar(10) not null,
);