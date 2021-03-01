CREATE TABLE Cliente
(
Id_Cliente int NOT NULL,
Nome_Cliente varchar(40),
CONSTRAINT Cliente_Id_Cliente_pk Primary Key (Id_Cliente) 

)

CREATE TABLE Viagem 
(
Id_Cliente int,
Saida float,
ValorNota float,
QEntregue int,
Dia date,
CONSTRAINT Viagem_Id_Cliente_fk FOREIGN KEY (Id_Cliente) references Cliente (Id_Cliente) 
)
