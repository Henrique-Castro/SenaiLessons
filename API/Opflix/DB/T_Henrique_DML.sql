INSERT INTO PerfisUsuarios(Tipo) VALUES ('Cliente') , ('Administrador');
--
--CÓDIGO SUBSTITUIDO POR PROCEDURES E FUNCTIONS
--INSERT INTO Usuarios (Tipo , Nome , Email , Senha) VALUES (2 , 'Erik' , 'erik@email.com' , '123456') ,
-- (2 , 'Cassiana' , 'cassiana@email.com' , '123456') , (1 , 'Helena' , 'helena@email.com' , '123456') , 
-- (2 , 'Roberto' , 'rob@email.com' , '3110');
--INSERT INTO FotosUsuarios(IdUsuario , Imagem) VALUES ( 1 , CONVERT(VARBINARY(MAX) , 'aHR0cHM6Ly90cmVsbG8tYXZhdGFycy5zMy5hbWF6b25hd3MuY29tL2ZhNGZiZmI3NzU4MzBmNjk1NjYxZmE5MWE0MDdjMzEwL29yaWdpbmFsLnBuZw=='))
--, ( 2 , 'aHR0cDovL3d3dy5jb2xlZ2lvcGF1bG9mcmVpcmVzai5jb20uYnIvd3AtY29udGVudC91cGxvYWRzLzIwMTkvMDEvY2Fzc2lhbmEucG5n')
--, ( 3 , 'YmxvYjpodHRwczovL3dlYi53aGF0c2FwcC5jb20vNDEzMWE3NWEtM2UyMi00NzIwLWI5MjMtZTE2M2QzYmU1NDQ3')
--, ( 4 , 'YmxvYjpodHRwczovL3dlYi53aGF0c2FwcC5jb20vNDEzMWE3NWEtM2UyMi00NzIwLWI5MjMtZTE2M2QzYmU1NDQ3');

EXECUTE InserirImagem @IdUsuario = 1 , @CodigoImagem = 'aHR0cHM6Ly90cmVsbG8tYXZhdGFycy5zMy5hbWF6b25hd3MuY29tL2ZhNGZiZmI3NzU4MzBmNjk1NjYxZmE5MWE0MDdjMzEwL29yaWdpbmFsLnBuZw=='
EXECUTE InserirImagem @IdUsuario = 2 , @CodigoImagem = 'aHR0cDovL3d3dy5jb2xlZ2lvcGF1bG9mcmVpcmVzai5jb20uYnIvd3AtY29udGVudC91cGxvYWRzLzIwMTkvMDEvY2Fzc2lhbmEucG5n'
EXECUTE InserirImagem @IdUsuario = 3 , @CodigoImagem = 'YmxvYjpodHRwczovL3dlYi53aGF0c2FwcC5jb20vNDEzMWE3NWEtM2UyMi00NzIwLWI5MjMtZTE2M2QzYmU1NDQ3'
EXECUTE InserirImagem @IdUsuario = 4 , @CodigoImagem = 'YmxvYjpodHRwczovL3dlYi53aGF0c2FwcC5jb20vNDEzMWE3NWEtM2UyMi00NzIwLWI5MjMtZTE2M2QzYmU1NDQ3'

--DROP PROCEDURE AlterarCategoria , AlterarDescricaoCategoria , AlterarLancamentos , AlterarNomeCategoria , CadastrarCategoria , CadastrarLancamento , CadastrarPlataforma , InserirImagem , InserirUsuario , ListarFilmesCategorias


UPDATE Usuarios SET Tipo = 2 WHERE IdUsuario = 3;
EXECUTE CadastrarCategoria @IdAdmin = 2 , @Nome = 'Terror' , @Descricao = 'Pra ficar com medo';
EXECUTE CadastrarCategoria @IdAdmin = 2 , @Nome = 'Ação' , @Descricao = 'Pra ficar bobo e animado';
EXECUTE CadastrarCategoria @IdAdmin = 2 , @Nome = 'Comédia' , @Descricao = 'Pra ficar rindo';
EXECUTE CadastrarCategoria @IdAdmin = 2 , @Nome = 'Documentário' , @Descricao = 'Pra ficar sabido';
EXECUTE CadastrarCategoria @IdAdmin = 2 , @Nome = 'Drama' , @Descricao = 'Pra ficar sentido';
EXECUTE CadastrarCategoria @IdAdmin = 2 , @Nome = 'Ficção Científica' , @Descricao = 'Pra ficar vislumbrado';

EXECUTE CadastrarLancamento @IdAdmin = 2 , @Titulo = 'Deuses Americanos' , @Sinopse = 'Até os deuses precisam ser americanos' , @Categoria = 5 , @Duracao = 999 , @Formato = 

SELECT * FROM FormatosLancamentos;
EXECUTE CadastrarPlataforma @IdAdmin = 2 , @Nome = 'Netflix';
EXECUTE CadastrarPlataforma @IdAdmin = 2 , @Nome = 'Amazon';
EXECUTE CadastrarPlataforma @IdAdmin = 2 , @Nome = 'VHS';



