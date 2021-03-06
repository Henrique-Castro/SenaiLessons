CREATE DATABASE T_Ekips;

USE T_Ekips;

CREATE TABLE Permissoes(
	IdPermissao INT PRIMARY KEY IDENTITY,
	Nome TEXT NOT NULL
);
CREATE TABLE Departamentos(
	IdDepartamento INT PRIMARY KEY IDENTITY,
	Nome TEXT NOT NULL
);
CREATE TABLE Cargos(
	IdCargo INT PRIMARY KEY IDENTITY,
	Nome TEXT NOT NULL
);


CREATE TABLE Usuarios(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Email VARCHAR(150) UNIQUE NOT NULL,
	Senha VARCHAR(30) NOT NULL,
	IdPermissao INT FOREIGN KEY REFERENCES Permissoes(IdPermissao) NOT NULL
);
CREATE TABLE Funcionarios(
	IdFuncionario INT PRIMARY KEY IDENTITY,
	Nome TEXT NOT NULL,
	Cpf varchar(11) NOT NULL UNIQUE,
	DataNascimento DATE NOT NULL,
	Salario MONEY NOT NULL,
	IdDepartamento INT FOREIGN KEY REFERENCES Departamentos(IdDepartamento),
	IdCargo INT FOREIGN KEY REFERENCES Cargos(IdCargo),
	IdUsuarioVinculado INT FOREIGN KEY REFERENCES Usuarios(IdUsuario)
);

SELECT * FROM Usuarios
SELECT * FROM Funcionarios
SELECT * FROM Cargos