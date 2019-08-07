
INSERT INTO Colaboradores (NomeFantasia, Cnpj, RazaoSocial, Endereco)
VALUES ('Fake Company' , '47285045000113', 'Not a fake company ltda', 'Groelandia') , 
('Mask Company' , '433285045000113', 'Not a masked company ltda', 'Russia');


INSERT INTO Servicos (IdColaborador, Comodo, Tipo, Preco, Inicio, Termino) 
VALUES (1, 'Garagem', 'Manutencao de maquina agricola', 1000.50, '20-10-2019', '20-10-2019') , 
(1, 'Sala de estar', 'Troca do pé da mesa' , 2 , '20-10-2019', '20-10-2019') ,
(2, 'Cozinha' , 'Manutencao de mascaras', 3000, '20-10-2019', '20-10-2019');

SELECT IdServico, IdColaborador FROM Servicos;