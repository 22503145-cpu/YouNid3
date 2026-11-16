create database SushiRestaurant;

use SushiRestaurant;

create table tblClientes(
   id int not null primary key auto_increment,
   nome varchar(60) not null,
   email varchar(80) not null unique,
   cpf varchar(14) not null,
   telefone varchar(15) not null,
   dtnasc date not null,
   cep varchar(9) not null,
   rua varchar(80) not null,
   numero varchar(6) not null,
   complemento varchar(40),
   bairro varchar(50) not null,
   cidade varchar(50) not null,
   uf char(2) not null
);

create table tblPedidos(
   id int not null primary key auto_increment,
   numero int not null,
   idCliente int not null,
   data datetime not null,
   pagamento varchar(20) not null,
   total decimal(10,2) not null,
   foreign key (idCliente) references tblClientes(id)
);

create table tblItensPedido(
   id int not null primary key auto_increment,
   idPedido int not null,
   produto varchar(60) not null,
   preco decimal(10,2) not null,
   quantidade int not null,
   foreign key (idPedido) references tblPedidos(id)
);

select * from tblClientes;
select * from tblPedidos;
select * from tblItensPedido;
