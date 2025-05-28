create table vendas(
ID_NF int,
ID_ITEM int,
COD_PROD int,
VALOR_UNIT float,
qnt int,
desconto int null,
);

INSERT INTO vendas (ID_NF,ID_ITEM,COD_PROD,VALOR_UNIT,qnt,desconto) VALUES
(1, 1, 1, 25, 10, 5),
(1, 2, 2, 13.50, 3, null),
(1, 3, 3, 15, 2, null),
(1, 4, 4, 10, 1, null),
(1, 5, 5, 30, 1, null),
(2, 1, 3, 15, 4, null),
(2, 2, 4, 10, 5, null),
(2, 3, 5, 30, 7, null),
(3, 1, 1, 25, 5, null),
(3, 2, 4, 10, 4, null),
(3, 3, 5, 30, 5, null),
(3, 4, 2, 13.50, 7, null),
(4, 1, 5, 30, 10, 15),
(4, 2, 4, 10, 12, 5),
(4, 3, 1, 25, 13, 5),
(4, 4, 2, 13.50, 15, 5),
(5, 1, 3, 15, 3, null),
(5, 2, 5, 30, 6, null),
(6, 1, 1, 25, 22, 15),
(6, 2, 3, 15, 25, 20),
(7, 1, 1, 25, 10, 3),
(7, 2, 2, 13.50, 10, 4),
(7, 3, 3, 15, 10, 4),
(7, 4, 5, 30, 10, 1)
;

select * from vendas;
drop table vendas;

/*a)Pesquise   os   itens   que   foram   vendidos   sem   desconto.   
As colunas   presentes   no resultado da consulta são: ID_NF, ID_ITEM, COD_PROD E VALOR_UNIT.*/
select ID_NF,ID_ITEM,COD_PROD,VALOR_UNIT from vendas where desconto is null;



/*b)Pesquise  os   itens   que   foram  vendidos  com   desconto.   As   colunas   
presentes   no resultado  da  consulta  são:  ID_NF,  ID_ITEM,  COD_PROD,  VALOR_UNIT  E  O  VALOR VENDIDO. 
OBS: O valor vendido é igual ao VALOR_UNIT -(VALOR_UNIT*(DESCONTO/100)).*/
	alter table vendas add VALOR_VENDIDO float null;

	update vendas set VALOR_VENDIDO = VALOR_UNIT-VALOR_UNIT*desconto/100 where desconto is not null;

	update vendas set VALOR_VENDIDO = VALOR_UNIT where desconto is null;

	select ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT,VALOR_VENDIDO from vendas  where desconto is not null;

	ALTER TABLE vendas DROP COLUMN VALOR_VENDIDO;




/*c)Altere o valor do desconto (para zero) de todos os registros onde este campo é nulo.*/
UPDATE vendas SET desconto = 0 where desconto is null;
select * from vendas;



/*d)Pesquise os itens que  foram vendidos. As colunas presentes no resultado da consulta são:    
ID_NF,    ID_ITEM,    COD_PROD,    VALOR_UNIT,    VALOR_TOTAL,    DESCONTO, VALOR_VENDIDO.  OBS:    O  VALOR_TOTAL  é  
obtido  pela  fórmula:  QUANTIDADE  * VALOR_UNIT. O VALOR_VENDIDO é igual a VALOR_UNIT -(VALOR_UNIT*(DESCONTO/100)).*/

	alter table vendas add VALOR_VENDIDO float null;
	alter table vendas add VALOR_TOTAL float null;

	update vendas set VALOR_VENDIDO = VALOR_UNIT-VALOR_UNIT*desconto/100 where desconto is not null;
	update vendas set VALOR_VENDIDO = VALOR_UNIT where desconto is null;

	update vendas set VALOR_TOTAL = VALOR_UNIT*qnt where COD_PROD is not null;

	select ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT,VALOR_TOTAL,desconto,VALOR_VENDIDO from vendas  where COD_PROD is not null;

	ALTER TABLE vendas DROP COLUMN VALOR_VENDIDO;
	ALTER TABLE vendas DROP COLUMN VALOR_TOTAL;




/*e)Pesquise  o  valor  total  das  NF  e  ordene  o  resultado  do  maior  valor  para  o  menor.  As colunas  presentes  no  
resultado  da  consulta  são:  ID_NF,  VALOR_TOTAL.  OBS:    O VALOR_TOTAL  é  obtido  pela  fórmula:  ∑  QUANTIDADE  *  VALOR_UNIT.
Agrupe  o resultado da consulta por ID_NF.*/

	alter table vendas add VALOR_TOTAL float null;

	
	update vendas set VALOR_TOTAL = VALOR_UNIT*qnt where COD_PROD is not null;

	select ID_NF,VALOR_TOTAL from vendas  where COD_PROD is not null ORDER BY  ID_NF DESC;



/*f)Pesquise o valor vendido das NF e ordene o resultado do maior valor para o menor. As colunas  
presentes  no  resultado  da  consulta  são:  ID_NF,  VALOR_VENDIDO.  OBS:    O VALOR_TOTAL    é    obtido    pela    
fórmula:    ∑    QUANTIDADE    *    VALOR_UNIT.    O VALOR_VENDIDO  é  igual  a  ∑  VALOR_UNIT -(VALOR_UNIT*(DESCONTO/100)).
Agrupe o resultado da consulta por ID_NF.*/

	alter table vendas add VALOR_TOTAL float null;
	alter table vendas add VALOR_VENDIDO float null;

	
	update vendas set VALOR_TOTAL = VALOR_UNIT*qnt where COD_PROD is not null;

	update vendas set VALOR_VENDIDO = VALOR_UNIT-VALOR_UNIT*desconto/100 where desconto is not null;
	update vendas set VALOR_VENDIDO = VALOR_UNIT where desconto is null;


	select ID_NF,VALOR_VENDIDO from vendas  where COD_PROD is not null ORDER BY  ID_NF DESC;



/*g)Consulte  o  produto  que  mais  vendeu  no  geral.  As  colunas  presentes  no  
resultado  da consulta   são: COD_PROD,   QUANTIDADE.Agrupe   o   resultado   da   consulta   por COD_PROD*/

select COD_PROD,qnt from vendas where qnt=(select max(qnt) from vendas);



/*h)Consulte as NF que  foram vendidas mais de  10 unidades  de  pelo menos um produto. 
As colunas presentes no resultado da consulta são: ID_NF, COD_PROD, QUANTIDADE.Agrupe o resultado 
da consulta por ID_NF, COD_PROD.*/

select ID_NF,COD_PROD,qnt from vendas where qnt>10;


/*i)Pesquise  o  valor  total  das  NF,  onde  esse  valor  seja  maior  que  500,  e  ordene  o resultado do
maior valor para o menor. As colunas presentes no resultado da consulta são: ID_NF, VALOR_TOT. OBS: O VALOR_TOTAL é 
obtido pela fórmula: ∑ QUANTIDADE * VALOR_UNIT.Agrupe o resultado da consulta por ID_NF.*/

	alter table vendas add VALOR_VENDIDO float null;
	update vendas set VALOR_TOTAL = VALOR_UNIT*qnt where COD_PROD is not null;

	select ID_NF, VALOR_TOTAL from vendas where VALOR_TOTAL>500;


/*j)Qual  o  valor  médio  dos  descontos  dados  por  produto.  As  colunas  
presentes  no resultado  da  consulta  são: COD_PROD,  MEDIA.Agrupe  o  resultado  da  consulta 
por COD_PROD.*/
	UPDATE vendas SET desconto = 0 where desconto is null;
	select COD_PROD,avg(desconto) as media from vendas where COD_PROD is not null;
	


/*k)Qual  o  menor,  maior  e  o  valor  médio  dos  descontos  dados  por  produto.  
As  colunas presentes no resultado da consulta são: COD_PROD, MENOR, MAIOR, MEDIA.Agrupe o 
resultado da consulta por COD_PROD.*/
	select COD_PROD, MIN(desconto) as MENOR, MAX(desconto) as MAIOR, AVG(desconto) as MEDIA from vendas GROUP BY COD_PROD;



/*l)Quais as NF que possuem mais de 3 itens vendidos. As colunas presentes no resultado da  consulta  
são:  ID_NF,  QTD_ITENS.  OBS::  NÃO  ESTÁ  RELACIONADO  A  QUANTIDADE VENDIDA  DO  ITEM  E  SIM  A  QUANTIDADE  
DE  ITENS  POR  NOTA  FISCAL.Agrupe  o resultado da consulta por ID_NF.*/

	select ID_NF,count(ID_NF) as QTD_ITENS from vendas group by ID_NF;






/*Crie uma base de dados Universidade com as tabelas a seguir:*/

create database db_universidade
on primary(
name=universidade,
filename='C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_universidade.MDF',
SIZE=6MB,
MAXSIZE=10MB,
FILEGROWTH=10%
)

USE master ;  
GO  
DROP DATABASE universidade ;  
GO 

sp_helpdb universidade


		create table Alunos(
		MAT int not null,
		nome char(50) not null,
		endereco varchar(150) not null,
		cidade varchar(50) not null,
		constraint cli1 primary key (MAT)
	 );




	 	create table Disciplinas(
		COD_DISC varchar(7) not null,
		nome_disc varchar(50) not null,
		carga_hor int not null,

		constraint cli2 primary key (COD_DISC)
	 );



	 	create table Professores(
		COD_PROF int not null,
		nome varchar(50) not null,
		endereco varchar(150) not null,
		cidade varchar(50) not null,

		constraint cli3 primary key (COD_PROF)
	 );




	 	create table Turma(
		COD_DISC varchar(7) not null,
		COD_Turma int not null,
		COD_PROF int not null,
		ANO int not null,
		horário varchar(10) not null,
		CONSTRAINT cli4 FOREIGN KEY (COD_DISC) REFERENCES Disciplinas (COD_DISC),
		CONSTRAINT cli5  FOREIGN KEY (COD_PROF) REFERENCES Professores (COD_PROF),
		CONSTRAINT chave_composta PRIMARY KEY CLUSTERED (COD_PROF,COD_DISC,COD_Turma,ANO),
	 );





	 select * from Histórico;


	 	create table Histórico(
		MAT int not null,
		COD_DISC varchar(7) not null,
		COD_Turma int not null,
		COD_PROF int not null,
		ANO int not null,
		frequência int not null,
		nota int not null,
		CONSTRAINT cli6 FOREIGN KEY (MAT) REFERENCES Alunos (MAT),
		Constraint FK_CD  FOREIGN KEY (COD_PROF,COD_DISC,COD_Turma,ANO) REFERENCES  Turma (COD_PROF,COD_DISC,COD_Turma,ANO),
		CONSTRAINT chave_composta2 PRIMARY KEY CLUSTERED (MAT,COD_PROF,COD_DISC,COD_Turma,ANO),
	 );



	 INSERT into Alunos values
	 (2015010101, 'JOSE DE ALENCAR', 'RUA DAS ALMAS', 'NATAL'),
	 (2015010102, 'JOÃO JOSÉ', 'AVENIDA RUY CARNEIRO', 'JOÃO PESSOA'),
	 (2015010103, 'MARIA JOAQUINA', 'RUA CARROSSEL', 'RECIFE'),
	 (2015010104, 'MARIA DAS DORES', 'RUA DAS LADEIRAS', 'FORTALEZA'),
	 (2015010105, 'JOSUÉ CLAUDINO DOS SANTOS', 'CENTRO', 'NATAL'),
	 (2015010106, 'JOSUÉLISSON CLAUDINO DOS SANTOS', 'CENTRO', 'NATAL');

	 INSERT into Disciplinas values
	 ('BD', 'BANCO DE DADOS', 100),
	('POO', 'PROGRAMAÇÃO COM ACESSO A BANCO DE DADOS', 100),
	('WEB', 'AUTORIA WEB', 50),
	('ENG', 'ENGENHARIA DE SOFTWARE', 80);

	INSERT into Professores values
	(212131, 'CARLOS ALBERTO VAZ', 'RUA MANAÍRA', 'JOÃO PESSOA'),
	(122135, 'LUCIANA SILVA ZAPPAROLLI', 'AVENIDA SALGADO FILHO', 'NATAL'),
	(192011, 'RENATO AUGUSTO', 'AVENIDA ROBERTO FREIRE', 'NATAL');


	INSERT into Turma values
	('BD', 1, 212131, 2015, '11H-12H'),
	('BD', 2, 212131, 2015, '13H-14H'),
	('POO', 1, 192011, 2015, '08H-09H'),
	('WEB', 1, 192011, 2015, '07H-08H'),
	('ENG', 1, 122135, 2015, '10H-11H');

	insert into Histórico values
	(2015010101,'BD',1,212131,2015,70,4),
	(2015010102,'BD', 1, 212131, 2015, 70,8),
	(2015010103,'BD', 2, 212131, 2015, 70,9),
	(2015010104,'POO', 1, 192011, 2015,70,10),
	(2015010105,'WEB', 1, 192011, 2015,70,10),
	(2015010106,'ENG', 1, 122135, 2015,70,10);





/*a) Encontre a MAT dos alunos com nota em BD em 2015 menor que 5 (obs: BD =
código da disciplinas).*/
Select MAT from Histórico where COD_DISC like 'BD' and ANO like 2015 and nota<5;

/*b) Encontre a MAT e calcule a média das notas dos alunos na disciplina de POO
em 2015.*/
select MAT from Histórico;
select AVG(nota) from Histórico where COD_DISC like 'POO';

/*c) Encontre a MAT e calcule a média das notas dos alunos na disciplina de POO
em 2015 e que esta média seja superior a 6.*/
select MAT from Histórico;
select AVG(nota) from Histórico where COD_DISC like 'POO' and nota>6;

/*d) Encontre quantos alunos não são de Natal.*/
select count(*) from Alunos where cidade not like 'Natal';

