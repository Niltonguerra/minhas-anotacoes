create database saves_jogo


use saves_jogo


create table tb_historico(
id int identity,
pontuacao varchar(3),
nome varchar(30),
);



select * from tb_historico;



drop table tb_historico


insert into tb_historico values('5','nilton')
insert into tb_historico values('4','pedro')
insert into tb_historico values('3','joaquim')
insert into tb_historico values('2','Anderson')
insert into tb_historico values('1','silva')






