USE T_Gufos;
SELECT * FROM Categorias, Eventos, Usuarios;
SELECT E.*, C.* 
FROM Eventos AS E 
JOIN Categorias AS C 
ON E.IdCategoria = C.IdCategoria JOIN Presenca AS P ON P.IdEvento = E.IdEvento JOIN Usuarios AS U ON U.IdUsuario = P.IdUsuario;