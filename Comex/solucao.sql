-- Active: 1724335766924@@localhost@5432@alura@public
CREATE DATABASE bemol_semana7
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    LOCALE_PROVIDER = 'libc'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;

/*Tabela clientes*/
CREATE TABLE clientes(
	id serial PRIMARY KEY NOT NULL,
	nome TEXT,
	email TEXT,
	data_nascimento DATE,
	cidade TEXT
);
/*Inserção de dados na tabela clientes*/
INSERT INTO clientes(nome, email, data_nascimento, cidade) VALUES ('Diego Simas', 'diegori21@gmail.com', '2000-11-10', 'Manaus')

INSERT INTO clientes(nome, email, data_nascimento, cidade) VALUES ('Thiago Silva', 'thiagosilva@gmail.com', '1995-05-25', 'Rio de Janeiro')

INSERT INTO clientes(nome, email, data_nascimento, cidade) VALUES ('Maria Gonsalves', 'marigonsalves200@gmail.com', '2007-02-10', 'São Paulo')

INSERT INTO clientes(nome, email, data_nascimento, cidade) VALUES ('Ana Cristina', 'anacriscuccittini@gmail.com', '2993-09-10', 'Manaus')

SELECT * FROM clientes

/*Consulta Nome e Email*/
SELECT nome AS "Nome",
	   email AS "Email"
	   FROM clientes

/*Tabela pedido*/
CREATE TABLE pedido(
	pedido_id serial PRIMARY KEY NOT NULL,
	data_pedido DATE,
	valor_total DECIMAL,
	cliente_id INTEGER,
	FOREIGN KEY (pedido_id)
	REFERENCES clientes (id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

/*Inserção de dados na tabela clientes*/
INSERT INTO pedido(data_pedido, valor_total, cliente_id) VALUES ('2024-08-10', 125.50, 3)

INSERT INTO pedido(data_pedido, valor_total, cliente_id) VALUES ('2024-08-18', 95.88, 1)

INSERT INTO pedido(data_pedido, valor_total, cliente_id) VALUES ('2024-08-21', 185.90, 2)
/*
teste inválido para id que não existe na tabela clientes
INSERT INTO pedido(data_pedido, valor_total, cliente_id) VALUES ('2024-08-21', 185.90, 7)
*/

SELECT * FROM pedido

SELECT * FROM clientes

UPDATE clientes
	SET email = 'diegosimas20002gmail.com'
	WHERE id=1

DELETE FROM pedido
	WHERE pedido_id = 4

/*Filtrar por cidade*/
SELECT * FROM clientes
	WHERE cidade = 'Manaus'

/*Filtrar pedido por preço maior que 100,00*/
SELECT * FROM pedido
	WHERE valor_total > 100.00

/*Filtrar pedido por nome*/
SELECT * FROM clientes
	ORDER BY nome ASC

/*Filtrar pedido por preço maior que 100,00*/
SELECT * FROM pedido
	ORDER BY valor_total DESC

/*Junção de tabelas clientes e pedido*/
SELECT clientes.nome AS "Nome",
	   pedido.valor_total AS "Valor Total"
	FROM clientes
	JOIN pedido ON pedido.pedido_id = clientes.id

/*Junção de tabelas clientes e pedido. Mostrar todos os clientes com pedido_id e valor_total*/
SELECT clientes.nome AS "Nome",
	   pedido.pedido_id AS "PedidoID",
	   pedido.valor_total AS "Valor Total"
	FROM clientes
	LEFT JOIN pedido ON pedido.pedido_id = clientes.id