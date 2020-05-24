create database exemplo;

use exemplo;
create table contatos(
id int primary key not null AUTO_INCREMENT,
nome varchar(50) not null,
email varchar(30)	DEFAULT NULL,
telefone varchar(15) DEFAULT NULL);

insert into contatos values
	(1, "Nome", "Email", "Telefone"),
	(2,"Lucas","lucasanselmo@gmail.com","(22)40981759"),
	(3,"Lukinha","lukinha@gmail.com","(20)40981785"),
	(4,"Igor","igor@gmail.com","(30)40581759"),
	(5,"Victor","victor@gmail.com","(50)55881759"),
	(6,"Marco","marco@gmail.com","(52)22331759");