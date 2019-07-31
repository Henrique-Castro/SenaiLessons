	-- criar um banco de dados
CREATE DATABASE T_PSales;
	--colocar o banco de dados em uso
	USE T_PSales;

	--DDL - DATA DEFINITION LANGUAGE (ESTRUTURA)
	--DML - DATA MANIPULATION LANGUAGE (REGISTROS)
	--DQL - DATA QUERY LANGUAGE (QUERY)

	--criar tabela de cursos
	CREATE TABLE Cursos
	(
	--tipos de dados pk, fk
		IdCurso INT PRIMARY KEY IDENTITY
		,Nome	VARCHAR(200)  NOT NULL UNIQUE
	);
	--criar tabela de disciplinas
	CREATE TABLE Disciplinas(
		IdDisciplina INT PRIMARY KEY IDENTITY
		,Nome	VARCHAR(250) NOT NULL
		,IdCurso INT FOREIGN KEY REFERENCES Cursos (IdCurso)
	);
	CREATE TABLE Alunos(
		IdAluno INT PRIMARY KEY IDENTITY
		,Nome	VARCHAR(250) NOT NULL
	);
	--criar tabela intermediária de alunos e cursos (vincular)
	CREATE TABLE AlunosCursos(
		IdAluno INT FOREIGN KEY REFERENCES Alunos (IdAluno)
		,IdCurso INT FOREIGN KEY REFERENCES Cursos (IdCurso)
	);
	--Inserir registros
	--insert into nome_tabela(nome_coluna) values (valor)
	--INSERT INTO Cursos (Nome) VALUES ('Técnico em Dev. Sistemas');
	--INSERT INTO Cursos (Nome) VALUES ('Técnico em Redes');
	--INSERIR DIFERENTES VALORES NA MESMA COLUNA
	INSERT INTO Cursos (Nome) VALUES ('CURSO A')
									,('CURSO B')
									,('CURSO C');
	SELECT IdCurso, Nome FROM Cursos ORDER BY IdCurso ASC;
	--update tabela set qual_coluna = novo_valor condicao
	--Não atualizar ID
	UPDATE Cursos SET Nome = 'Design'  WHERE IdCurso = 6;
	INSERT INTO Disciplinas (Nome	,	IdCurso) VALUES ('HTML'	,	1);
	INSERT INTO Disciplinas (Nome	,	IdCurso) VALUES ('CSS'	,	1)
														,('Hardware', 1);
	INSERT INTO Disciplinas (Nome	,	IdCurso) VALUES ('Fios'	,	2)
														,('Cabos', 2);
	SELECT * FROM Disciplinas;
	DELETE FROM Cursos WHERE IdCurso = 2;