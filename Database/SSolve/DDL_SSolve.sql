CREATE DATABASE T_SSolve;
USE T_SSolve;
CREATE TABLE Colaboradores (
	IdColaborador INT PRIMARY KEY IDENTITY NOT NULL,
	NomeFantasia VARCHAR(100) NOT NULL UNIQUE,
	Cnpj VARCHAR(15) NOT NULL UNIQUE,
	RazaoSocial VARCHAR(100) NOT NULL,
	Endereco VARCHAR(255) NOT NULL
);
CREATE TABLE Servicos(
	IdServico INT PRIMARY KEY IDENTITY NOT NULL,
	IdColaborador INT FOREIGN KEY REFERENCES Colaboradores(IdColaborador) NOT NULL,
	Comodo VARCHAR(255) NOT NULL,
	Tipo VARCHAR(255) NOT NULL,
	Preco FLOAT NOT NULL,
	Inicio DATETIME NOT NULL,
	Termino DATETIME NOT NULL
);
CREATE TABLE ServicosFuncionarios(
	IdServico INT FOREIGN KEY REFERENCES Servicos(IdServico) NOT NULL,
	IdColaborador INT FOREIGN KEY REFERENCES Colaboradores(IdColaborador) NOT NULL,
);


