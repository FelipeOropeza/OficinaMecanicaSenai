create database db_oficina;
use db_oficina;

create table tbl_turma(
id_tur int auto_increment primary key,
nm_tur varchar(255) not null
);

create table tbl_professor(
id_prof int auto_increment primary key,
nm_prof varchar(255) not null
);

create table tbl_armazem(
id_arm int auto_increment primary key,
desc_arm varchar(255) not null,
qtd_arm int not null
);

create table tbl_meterial(
id_mat int auto_increment primary key,
desc_mat varchar(255) not null,
uni_mat varchar(50) not null,
fk_arm int,
foreign key (fk_arm) references tbl_armazem (id_arm)
);

create table tbl_profmatarm(
tipo_mov boolean,
data_mov date,
qtd_mov int,
fk_mat int, 
fk_arm int,
fk_prof int,
foreign key (fk_mat) references tbl_meterial (id_mat),
foreign key (fk_arm) references tbl_armazem (id_arm),
foreign key (fk_prof) references tbl_professor (id_prof)
);

create table tbl_mattur(
data_res date,
qtd_res int,
fk_mat int,
fk_tur int,
foreign key (fk_mat) references tbl_meterial (id_mat),
foreign key (fk_tur) references tbl_turma (id_tur)
);

