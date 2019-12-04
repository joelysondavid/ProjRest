CREATE DATABASE Restaurante;

USE Restaurante;

CREATE TABLE Usuario(
	Id INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(30) NOT NULL,
	CPF VARCHAR(15),
	Login VARCHAR(15) NOT NULL,
	Senha VARCHAR(10) NOT NULL,
	Tipo VARCHAR(15) NOT NULL CHECK(Tipo IN ('Cozinha', 'Atendimento'))
);
GO
-- check funciona como um enum a gente passa o campo que será do tipo ou atendimento ou cozinha no login do user
INSERT INTO Usuario(Nome, CPF, Login, Senha, Tipo) VALUES ('User Teste', '123654', 'Admin', 'admin', 'Atendimento');

GO
-- A tabela cardápio será usada para cadastro de produtos e devera ser constantemente atualizada pois esta tabela alimentará o menu de itens do sitema
CREATE TABLE Cardapio (
	Id INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(100) NOT NULL,
	Detalhes VARCHAR(100),
	TempoPrep INT NOT NULL,
	Preco DECIMAL(10,2) NOT NULL,
	Disponivel  BIT NOT NULL, -- campo que verifica se o produco está disponivel
	URLImagem VARCHAR(250)
); 
GO
SELECT * FROM Cardapio;
-- delete from cardapio
INSERT INTO Cardapio(Descricao, Detalhes, TempoPrep, Preco) VALUES('Teste', 'Detalhes', 15, 75.80);
GO
-- SELECT Id, Descricao, Detalhes, TempoPrep, Preco, URLImagem FROM Cardapio WHERE Descricao LIKE '%%'
-- select top 1 Id, Descricao from Cardapio order by Id desc;
--- SELECT TOP 1 Id, Descricao, Detalhes, TempoPrep, Preco, URLImagem FROM Cardapio ORDER BY Id DESC;


-- Tabela de pedidos será utilizada para cadastro de pedidos de clientes
CREATE TABLE Pedidos(
	Id INT PRIMARY KEY IDENTITY,
	NumMesa VARCHAR(5),
	NomeCliente VARCHAR(50) NOT NULL,
	CpfCliente VARCHAR(15),
	ValorTotal DECIMAL(10,2) NOT NULL,
	DataPed DATE, -- Data do fechamento do pedido -- falta aplicar
	Status VARCHAR(12) NOT NULL CHECK(Status IN ('Em andamento', 'Finalizado')),-- falta uma flag para identificar pedidos "em andamento" e "finaliziado"
	-- CHAVES ESTRANGEIRAS
	FOREIGN KEY (NumMesa) REFERENCES Mesas(Numero)
);
GO
SELECT * FROM Pedidos;

GO
CREATE TABLE ItensPedido(
	Id INT IDENTITY, -- caso haja um novo pedido do mesmo item ele entrará no ciclo novamente
	PedidoId INT NOT NULL,
	ItemId INT NOT NULL,
	Quantidade INT NOT NULL,
	ValorItens DECIMAL(10,2) NOT NULL,
	Status VARCHAR(20) NOT NULL CHECK(Status IN('Preparando', 'Pronto', 'Entregue', 'Aguardando', 'Cancelado')),
	-- chave primaria composta
	PRIMARY KEY (Id, PedidoId, ItemId),
	-- chaves estrangeiras
	FOREIGN KEY (PedidoId) REFERENCES Pedidos(Id),
	FOREIGN KEY (ItemId) REFERENCES Cardapio(Id)
);
GO
 -- DELETE Pedidos;

SELECT * FROM ItensPedido ORDER BY id DESC;

GO
-- TABELA MESA Que será usada para gerenciamento de mesas e reservas de mesas
CREATE TABLE Mesas(
	Numero VARCHAR(5) PRIMARY KEY NOT NULL,
	Descricao VARCHAR(200),
	Disponivel BIT NOT NULL -- 0 OU 1  Equivalente ao boolean
);
/*alter table mesas
alter column descricao varchar(200)*/
GO
SELECT * FROM Mesas;
GO
-- SELECT GETDATE();
-- DELETE Mesas
INSERT INTO MESAS VALUES 
('G5A3', 'Teste', 1),
('G5A1', 'Ao lado da janela',1),
('G5A2', 'De frente ao Aquário',1),
('B5A2', 'De frente ao Aquário',1),
('B5A3', 'De frente ao Aquário',1);

-- UPDATE Mesas SET Disponivel=1 WHERE Numero='G5A1'

/*SELECT M.* FROM Mesas AS M LEFT JOIN Reservas AS R
	ON M.Numero = R.NumMesa WHERE R.ReservaFim='True' OR M.Disponivel='True'*/

GO
CREATE TABLE Reservas(
	Id INT PRIMARY KEY IDENTITY,
	NomeCliente VARCHAR(50) NOT NULL,
	CpfCliente VARCHAR(15),
	NumMesa VARCHAR(5) NOT NULL,	
	ReservaInicio DATETIME NOT NULL,
	Finalizada BIT NOT NULL,

	FOREIGN KEY (NumMesa) REFERENCES Mesas(Numero)
);

GO
SELECT Id, NomeCliente, CpfCliente, NumMesa, ReservaInicio, Finalizada FROM Reservas;
GO
INSERT INTO Reservas (NomeCliente,CpfCliente, NumMesa, ReservaInicio, Finalizada) VALUES(
'Joe', '456987', 'G5A2', '29/11/2019 12:30', 0);
INSERT INTO Reservas (NomeCliente,CpfCliente, NumMesa, ReservaInicio, Finalizada) VALUES(
'Joe', '456987', 'G5A1', '29/11/2019 12:30', 1);
INSERT INTO Reservas (NomeCliente,CpfCliente, NumMesa, ReservaInicio, Finalizada) VALUES(
'Joe', '456987', 'G5A3', '29/11/2019 12:30', 0);
INSERT INTO Reservas (NomeCliente,CpfCliente, NumMesa, ReservaInicio, Finalizada) VALUES(
'Joe', '456987', 'B5A2', '29/11/2019 12:30', 1);
SELECT NumMesa FROM Reservas
 -- DELETE Reservas
-- select * from Reservas order by id desc;

 -- SELECT * FROM Reservas WHERE ReservaInicio < DATEADD(HOUR, -2, getdate());

