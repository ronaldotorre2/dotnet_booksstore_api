/****************************************************************
 * Projeto:.....: Projeto BooksStore                           	*
 * Titulo:......: Script Criar esquema BooksStore              	*
 * Autor........: Ronaldo Torre                                 *
 * Referencia...: Release 1.0.0                                 *
 *--------------------------------------------------------------*
  ***************************************************************/
  
-- Banco de dados
-- ---------------------------------------------------------------
Drop database if exists BooksStore;

-- Criar banco de dados
Create database if not exists BooksStore DEFAULT CHARACTER SET utf8;

Use BooksStore;


Create table Book
(
	IdBook				 	integer      	not null auto_increment,
    Name					varchar(100)  	not null,
    Edition 				varchar(25) 	not null,
    Year 					integer 		not null,
    Publishing 				varchar(50) 	not null,
    Author 					varchar(50) 	not null,
    Price 					decimal(12,2)   not null,
    Constraint Pk_Book primary key(IdBook)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

Insert into Book(Name,Edition,Year,Author,Publishing,Price)values('Engenharia de Software','9 Edição',2011,'Sommerville,Ian','Editora Person', '188.90');
Insert into Book(Name,Edition,Year,Author,Publishing,Price)values('Gerenciamento de Projetos (Guia PMBOK)','6 Edição',2015,'PMI Group','Editora PMI Institute', '439.99');


