create database Farma
go

use Farma
 
create schema farm authorization dbo
go

create table farm.funcionarios
(
Fun_cd         int primary key identity(1,1),
Fun_nome       varchar(40) not null,
Fun_sobrenme   varchar(40) not null,
Fun_cpf        varchar(20) not null,
Fun_rg         varchar(20) not null,
Fun_dtNasc     date not null,
Fun_end        varchar(50) not null,
Fun_numcasa    varchar(20) not null,
Fun_telefone   varchar(20) not null,
Fun_celular    varchar(15) not null,
Fun_email      varchar(60) not null,
Fun_bairro     varchar(40) not null,    
Fun_cidade     varchar(30) not null,
Fun_uf         varchar(40) not null,
Fun_cep        varchar(20) not null,
Fun_cargo      varchar(30) not null, 
Fun_user       varchar(40) not null,
Fun_senha      varchar(20) not null,
)
drop table farm.funcionarios

insert into farm.funcionarios values('mario','fabi','12321','121','12/03/2005','nas','4','432','1121','3213','mario','pdp','jaca','sp','adm','admi','123')
insert into farm.funcionarios values('mario','fabi','12321','121','12/03/2005','nas','4','432','1121','3213','mario','pdp','jaca','sp','ceutico','farma','123')

create table farm.medicamento
(
Med_cod       int primary key identity(1,1),
Med_nmMed     varchar(40) not null,
Med_NMed      varchar(20) not null,
Med_desc      varchar(50) not null,
Med_categoria varchar(50) not null,
Med_marca     varchar(50) not null,
Med_DtFabri   date not null,
Med_DtVali    date not null,
Med_qtde      varchar(100) not null,
Med_PreçUnid  money not null,
Med_PreçVen   money not null,
med_Lucro     varchar(10) not null
)

select * from farm.medicamentos


create table farm.estoque
(
Est_cd          int primary key identity(1,1),
Med_cd          int foreign key references farm.medicamentos,
Med_desc        varchar(50) not null,
Est_DtEntrada   date not null,
Est_Saida       date not null,
Est_QtEntrada   varchar(50)not null,
Est_QtSaida     varchar(50) not null,
Fabri_cd        int foreign key references farm.fabricante,
Fabri_RSocial   varchar(40) not null,
)

create table farm.fabricante
(
fabri_cd          int primary key identity(1,1),
fabri_nmfan       varchar(40) not null,
fabri_RSocail     varchar(40) not null,
fabri_cnpj        varchar(50) not null,
fabri_IscEst      varchar(50) not null,
fabri_IsMunicipal varchar(50) not null,
fabri_repre       varchar(30) not null,
fabri_end         varchar(30) not null,
fabri_num         varchar(20) not null,
fabri_cep         varchar not null,
fabri_complemento varchar(20) not null,
fabri_bairro      varchar(60) not null,
fabri_cidade      varchar(30) not null,
fabri_estado      varchar(30) not null,
fabri_tel1        varchar(20) not null,
fabri_tel2        varchar(20) not null,
fabri_email       varchar(60) not null
)

select * from farm.fabricante

create table farm.cliente
(
clie_cd        int primary key identity(1,1),
clie_nm        varchar(40) not null,
clie_snm       varchar(30) not null,
clie_cpf       varchar(50) not null,
clie_rg        varchar(18) not null,
clie_dtnasc    date  not null,
clie_end       varchar(30) not null,
clie_email     varchar(60) not null,
clie_telefone  varchar(20) not null,
clie_celular   varchar(20) not null,
clie_numcasa   varchar(8)  not null,
clie_bairro    varchar(30) not null,
clie_cidade    varchar(30) not null,
clie_cep       varchar(25) not null,
clie_uf        varchar(30) not null,
clie_sexo      varchar(10) not null
)

select * from farm.cliente


create table farm.venda
(
vend_cd           int primary key identity(1,1),
Fun_cd            int foreign key references farm.funcionarios,
vend_DtdVend      date not null,
vend_FormPag      varchar(15) not null,
vend_valorTotal   money not null,
)

create table farm.historico
(
hist_cd  int primary key identity(1,1),
vend_cd  int foreign key references farm.venda,
Fun_cd   int foreign key references farm.funcionarios,
)

select * from farm.funcionarios