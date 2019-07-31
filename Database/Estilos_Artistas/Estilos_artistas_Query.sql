CREATE DATABASE T_SStop;
--FAZER OS CAMPOS DATA DE CRIAÇÃO DA BANDA/ARTISTA DESCRIÇÃO COM TEXTO AUMENTADO E SE O ARTISTA ESTÁ ATIVO OU NÃO (BOOL)
USE T_SStop;
CREATE TABLE EstilosMusicais(
	IdEstiloMusical INT PRIMARY KEY IDENTITY
	,Nome VARCHAR(100) NOT NULL UNIQUE
);
CREATE TABLE Artistas(
	IdArtista INT PRIMARY KEY IDENTITY
	,IdEstiloMusical INT FOREIGN KEY REFERENCES EstilosMusicais(IdEstiloMusical)
	,Nome VARCHAR(100) NOT NULL
);
INSERT INTO Artistas(Nome	,	IdEstiloMusical) VALUES ('David Bowie' , 2);
SELECT * FROM Artistas ORDER BY IdEstiloMusical DESC;
SELECT * FROM EstilosMusicais;
ALTER TABLE EstilosMusicais DROP COLUMN Descricao;
ALTER TABLE Artistas ADD DataCriacao date;
--UPDATE Artistas SET DataCriacao = '1967-06-1' WHERE Nome = 'David Bowie'; 
--UPDATE Artistas SET DataCriacao = '2012-04-8' WHERE Nome = 'Jaden Smith'; 
ALTER TABLE Artistas ADD Descricao text;
--UPDATE Artistas SET Descricao = 'David Bowie é muito bom' WHERE Nome = 'David Bowie';
--UPDATE Artistas SET Descricao = 'Mas o Jaden é muito bom também' WHERE Nome = 'Jaden Smith';
ALTER TABLE Artistas ADD EmAtividade bit;
--UPDATE Artistas SET EmAtividade = 1 WHERE Nome = 'Jaden Smith';
--UPDATE Artistas SET EmAtividade = 0 WHERE Nome = 'David Bowie';
--SELECT CASE WHEN EmAtividade = 0 THEN 'Não' ELSE 'Sim' END     (NOT WORKING YET)
