USE master
GO
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'db_Arduino_Casa')
	DROP DATABASE db_Arduino_Casa
GO
CREATE DATABASE db_Arduino_Casa
GO
USE db_Arduino_Casa
GO

CREATE TABLE utilizadoresCasa(
	id							INT IDENTITY(1, 1),
		CONSTRAINT					pkutilizadores PRIMARY KEY(id),
	utilizador						NVARCHAR(50) NOT NULL,
	password						NVARCHAR(50) NOT NULL,
	admin							NVARCHAR(10) DEFAULT 'no',
	online							NVARCHAR(10) DEFAULT 'no',
	agendamento						DATETIME,
	sala_pedido						NVARCHAR(25) DEFAULT 'wait',
	corredor_pedido					NVARCHAR(25) DEFAULT 'wait',
	cozinha_pedido					NVARCHAR(25) DEFAULT 'wait',
	quarto_1_pedido					NVARCHAR(25) DEFAULT 'wait',
	quarto_2_pedido					NVARCHAR(25) DEFAULT 'wait',
	quarto_3_pedido					NVARCHAR(25) DEFAULT 'wait',
	casa_de_banho_1_pedido			NVARCHAR(25) DEFAULT 'wait',
	casa_de_banho_2_pedido			NVARCHAR(25) DEFAULT 'wait',
	sala_autorizacao				NVARCHAR(10) DEFAULT 'yes',
	corredor_autorizacao			NVARCHAR(10) DEFAULT 'yes',
	cozinha_autorizacao				NVARCHAR(10) DEFAULT 'yes',
	quarto_1_autorizacao			NVARCHAR(10) DEFAULT 'yes',
	quarto_2_autorizacao			NVARCHAR(10) DEFAULT 'yes',
	quarto_3_autorizacao			NVARCHAR(10) DEFAULT 'yes',
	casa_de_banho_1_autorizacao		NVARCHAR(10) DEFAULT 'yes',
	casa_de_banho_2_autorizacao		NVARCHAR(10) DEFAULT 'yes'
);

CREATE TABLE estadoArduino(
	sala_resposta				NVARCHAR(25), 
	corredor_resposta			NVARCHAR(25), 
	cozinha_resposta			NVARCHAR(25), 
	quarto_1_resposta			NVARCHAR(25),
	quarto_2_resposta			NVARCHAR(25), 
	quarto_3_resposta			NVARCHAR(25), 
	casa_de_banho_1_resposta	NVARCHAR(25),
	casa_de_banho_2_resposta	NVARCHAR(25)
);

INSERT INTO estadoArduino (sala_resposta, corredor_resposta, cozinha_resposta, quarto_1_resposta, quarto_2_resposta, quarto_3_resposta, casa_de_banho_1_resposta, casa_de_banho_2_resposta)
VALUES ('espera', 'espera', 'espera', 'espera', 'espera', 'espera', 'espera','espera')

CREATE TABLE divisoes(
	id					INT IDENTITY(1, 1),
		CONSTRAINT			pkdivisoes PRIMARY KEY(id),
	utilizador			NVARCHAR(50) NOT NULL,
	password			NVARCHAR(50) NOT NULL,
	admin				NVARCHAR(10) DEFAULT 'no',
	online				NVARCHAR(10) DEFAULT 'no',
	pedidos				NVARCHAR(25) DEFAULT 'no',
	resposta			NVARCHAR(25) DEFAULT 'no'
);

CREATE TABLE systemOp(
	systemDown		NVARCHAR(10)
);
INSERT INTO systemOp(systemDown) VALUES('no')


----------------------- PROCEDURES ------------------------------
-----------------------------------------------------------------
-- SYSTEM STATUS
-------------------------------------------------

CREATE PROCEDURE usp_systemStatus
AS
SELECT systemDown FROM systemOp
GO


CREATE PROCEDURE usp_systemDown
@estado NVARCHAR(10)
AS
UPDATE systemOp SET systemDown = @estado
GO


-------------------------------------------------
-- APP 
-------------------------------------------------

CREATE PROCEDURE usp_confirmAdmin
AS
SELECT admin from divisoes
GO


CREATE PROCEDURE usp_registerAdmin 
@username NVARCHAR(50), 
@password NVARCHAR(50)
AS
INSERT INTO divisoes(utilizador, password, admin) VALUES(@username, @password, 'yes')
GO


CREATE PROCEDURE usp_logInApp
@username NVARCHAR(50)
AS
SELECT password FROM divisoes WHERE utilizador = @username
GO


CREATE PROCEDURE usp_selectAdmin
AS
SELECT utilizador FROM divisoes WHERE admin = 'yes'
GO


CREATE PROCEDURE usp_adminStatus
@username NVARCHAR(50),
@online NVARCHAR(25)
AS
UPDATE divisoes SET online = @online WHERE utilizador = @username
GO

-------------------------------------------------
-- PEDIDOS E RESPOSTAS APP CASA ARDUINO
-------------------------------------------------

CREATE PROCEDURE usp_ArdAppAnswer
@estado NVARCHAR(25),
@username NVARCHAR(50)
AS
UPDATE divisoes SET resposta = @estado, pedidos = 'no' WHERE utilizador = @username
GO


CREATE PROCEDURE usp_ArdAppRequest
@username NVARCHAR(50)
AS
SELECT pedidos FROM divisoes WHERE utilizador = @username 
GO


CREATE PROCEDURE usp_UpdateArdAppRequest
@estado NVARCHAR(25),
@username NVARCHAR(50)
AS
UPDATE divisoes SET pedidos = @estado WHERE utilizador = @username
GO


CREATE PROCEDURE usp_selectArdAppAnswer
@username NVARCHAR(50)
AS
SELECT resposta FROM divisoes WHERE utilizador = @username 
GO


CREATE PROCEDURE usp_UpdateArdAppAnswer
@estado NVARCHAR(50),
@username NVARCHAR(50)
AS
UPDATE divisoes SET pedidos = @estado, resposta = 'no' WHERE utilizador = @username
GO


CREATE PROCEDURE usp_estadoARD
AS
SELECT * FROM estadoArduino
GO



-------------------------------------------------
--AGENDAMENTOS
-------------------------------------------------

CREATE PROCEDURE usp_agendamentos
AS
SELECT utilizador, agendamento, sala_pedido 'sala', corredor_pedido 'corredor', cozinha_pedido 'cozinha', quarto_1_pedido 'quarto1', quarto_2_pedido 'quarto2', quarto_3_pedido 'quarto3', casa_de_banho_1_pedido 'casaDeBanho1', casa_de_banho_2_pedido 'casaDeBanho2'
FROM utilizadoresCasa
GO


CREATE PROCEDURE usp_agendamentosIndividuais
@utilizador	NVARCHAR(50)
AS
SELECT agendamento, sala_pedido 'sala', corredor_pedido 'corredor', cozinha_pedido 'cozinha', quarto_1_pedido 'quarto1', quarto_2_pedido 'quarto2', quarto_3_pedido 'quarto3', casa_de_banho_1_pedido 'casaDeBanho1', casa_de_banho_2_pedido 'casaDeBanho2'
FROM utilizadoresCasa WHERE utilizador = @utilizador
GO


CREATE PROCEDURE usp_agendamentosUpdate 
@agend			NVARCHAR(50),
@sala			NVARCHAR(25),
@corredor		NVARCHAR(25),
@cozinha		NVARCHAR(25),
@quarto1		NVARCHAR(25),
@quarto2		NVARCHAR(25),
@quarto3		NVARCHAR(25),
@casaDeBanho1	NVARCHAR(25),
@casaDeBanho2	NVARCHAR(25),
@utilizador		NVARCHAR(50)
AS
UPDATE utilizadoresCasa SET agendamento = @agend, sala_pedido = @sala, corredor_pedido = @corredor, 
cozinha_pedido = @cozinha, quarto_1_pedido = @quarto1, quarto_2_pedido = @quarto2, quarto_3_pedido = @quarto3,
casa_de_banho_1_pedido = @casaDeBanho1, casa_de_banho_2_pedido = @casaDeBanho2
WHERE utilizador = @utilizador
GO


CREATE PROCEDURE usp_dataAgendamento
AS
SELECT agendamento FROM utilizadoresCasa
GO

-------------------------------------------------
-- AUTORIZACOES
-------------------------------------------------

CREATE PROCEDURE usp_usersAutorizacao
As
SELECT utilizador 'Utilizador', sala_autorizacao 'Sala', corredor_autorizacao 'Corredor', cozinha_autorizacao 'Cozinha', quarto_1_autorizacao 'Quarto1',
		quarto_2_autorizacao 'Quarto2', quarto_3_autorizacao 'Quarto3', casa_de_banho_1_autorizacao 'Casa de banho1', casa_de_banho_2_autorizacao 'Casa de banho2',
		admin 'Admin'
FROM utilizadoresCasa
GO


CREATE PROCEDURE usp_usersAutorizacaoUpdate
@sala			NVARCHAR(10),
@corredor		NVARCHAR(10),
@cozinha		NVARCHAR(10),
@quarto1		NVARCHAR(10),
@quarto2		NVARCHAR(10),
@quarto3		NVARCHAR(10),
@casaDeBanho1	NVARCHAR(10),
@casaDeBanho2	NVARCHAR(10),
@admin			VARCHAR(10),
@utilizador		NVARCHAR(50)
As
UPDATE utilizadoresCasa SET sala_autorizacao = @sala, corredor_autorizacao = @corredor, 
	cozinha_autorizacao = @cozinha, quarto_1_autorizacao = @quarto1, quarto_2_autorizacao = @quarto2, quarto_3_autorizacao = @quarto3,
	casa_de_banho_1_autorizacao = @casaDeBanho1, casa_de_banho_2_autorizacao = @casaDeBanho2, admin = @admin
WHERE utilizador = @utilizador
GO


-------------------------------------------------
-- WEB
-------------------------------------------------

CREATE PROCEDURE usp_usersRegistados
As
SELECT utilizador FROM utilizadoresCasa
GO


CREATE PROCEDURE usp_usersOnline
As
SELECT utilizador, online, admin FROM utilizadoresCasa
GO


CREATE PROCEDURE usp_registerUsers
@username	NVARCHAR(50),
@password	NVARCHAR(50),
@admin		NVARCHAR(10)
AS
INSERT INTO utilizadoresCasa(utilizador, password, admin) VALUES(@username, @password, @admin)
GO


CREATE PROCEDURE usp_changeInfo
@username NVARCHAR(50),
@password NVARCHAR(50)
AS
UPDATE utilizadoresCasa SET utilizador = @username, password = @password
GO


CREATE PROCEDURE usp_logInWeb
@username NVARCHAR(50)
AS
SELECT password FROM utilizadoresCasa WHERE utilizador = @username
GO


CREATE PROCEDURE usp_userStatus
@username NVARCHAR(50),
@online NVARCHAR(25)
AS
UPDATE utilizadoresCasa SET online = @online WHERE utilizador = @username
GO


