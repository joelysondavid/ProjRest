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
-- check funciona como um enum a gente passa o campo que será do tipo ou atendimento ou cozinha no login do user
INSERT INTO Usuario(Nome, CPF, Login, Senha, Tipo) VALUES ('Joelyson', '1234', 'Joe123', 'senha', 'Atendimento');
SELECT * FROM Usuario;

-- A tabela cardápio será usada para cadastro de produtos e devera ser constantemente atualizada pois esta tabela alimentará o menu de itens do sitema
CREATE TABLE Cardapio (
	Id INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(100) NOT NULL,
	Detalhes VARCHAR(100),
	TempoPrep INT NOT NULL,
	Preco DECIMAL(10,2) NOT NULL,
	URLImagem VARCHAR(250)
);

-- Tabela de pedidos será utilizada para cadastro de pedidos de clientes
CREATE TABLE Pedidos(
	Id INT PRIMARY KEY IDENTITY,
	NumMesa VARCHAR(5),
	NomeCliente VARCHAR(50) NOT NULL,
	CpfCliente VARCHAR(15),
	ValorTotal DECIMAL(10,2) NOT NULL,
	-- CHAVES ESTRANGEIRAS
	FOREIGN KEY (NumMesa) REFERENCES Mesas(Numero)
);

CREATE TABLE ItensPedido(
	Id INT IDENTITY, -- caso haja um novo pedido do mesmo item ele entrará no ciclo novamente
	PedidoId INT NOT NULL,
	ItemId INT NOT NULL,
	Quantidade INT NOT NULL,
	ValorItens DECIMAL(10,2) NOT NULL,
	Status VARCHAR(20) NOT NULL CHECK(Status IN('Preparando', 'Pronto', 'Entregue', 'Aguardando')),
	-- chave primaria composta
	PRIMARY KEY (/*Id,*/ PedidoId, ItemId),
	-- chaves estrangeiras
	FOREIGN KEY (PedidoId) REFERENCES Pedidos(Id),
	FOREIGN KEY (ItemId) REFERENCES Cardapio(Id)
);

-- TABELA MESA Que será usada para gerenciamento de mesas e reservas de mesas
CREATE TABLE Mesas(
	Numero VARCHAR(5) PRIMARY KEY NOT NULL,
	Descricao VARCHAR(50),
	ReservaInicio DATETIME NOT NULL,
);

SELECT * FROM Mesas;
INSERT INTO MESAS VALUES ('G5A3', 'Teste', '30-11-2019');
INSERT INTO MESAS VALUES ('G5A1', 'Ao lado da janela', '15-10-2019');
INSERT INTO MESAS VALUES ('G5A2', 'De frente ao Aquário', '10-09-2019');

CREATE TABLE Reservas(
	Id INT PRIMARY KEY IDENTITY,
	NomeCliente VARCHAR(50) NOT NULL,
	CpfCliente VARCHAR(15),
	NumMesa VARCHAR(5) NOT NULL,

	FOREIGN KEY (NumMesa) REFERENCES Mesas(Numero)
);


