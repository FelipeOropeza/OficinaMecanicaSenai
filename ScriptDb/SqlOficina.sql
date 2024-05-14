create database db_oficina;
use db_oficina;

CREATE TABLE tbl_posicao (
    id_pos INT AUTO_INCREMENT PRIMARY KEY,
    nm_pos CHAR(1)
);

CREATE TABLE tbl_professor (
    id_prof INT AUTO_INCREMENT PRIMARY KEY,
    nm_prof VARCHAR(255) NOT NULL,
    sn_prof VARCHAR(7) UNIQUE
);

CREATE TABLE tbl_turma (
    id_tur INT AUTO_INCREMENT PRIMARY KEY,
    nm_tur VARCHAR(255) NOT NULL,
    fk_prof INT,
    FOREIGN KEY (fk_prof)
        REFERENCES tbl_professor (id_prof)
);

CREATE TABLE tbl_armazem (
    id_arm INT AUTO_INCREMENT PRIMARY KEY,
    desc_arm VARCHAR(255) NOT NULL
);

CREATE TABLE tbl_material (
    id_mat INT AUTO_INCREMENT PRIMARY KEY,
    cod_sap VARCHAR(18) UNIQUE NOT NULL,
    desc_mat VARCHAR(255) NOT NULL,
    uni_mat VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_matposarm (
    id_est INT AUTO_INCREMENT,
    data_est DATE,
    qtd_est INT,
    fk_mat INT,
    fk_arm INT,
    fk_pos INT,
    FOREIGN KEY (fk_mat)
        REFERENCES tbl_material (id_mat),
    FOREIGN KEY (fk_arm)
        REFERENCES tbl_armazem (id_arm),
    FOREIGN KEY (fk_pos)
        REFERENCES tbl_posicao (id_pos),
    PRIMARY KEY (id_est , fk_mat , fk_arm , fk_pos)
);

CREATE TABLE tbl_movimentacao (
    tipo_mov BOOLEAN,
    data_mov DATE,
    qtd_mov INT,
    fk_mat INT,
    fk_est INT,
    fk_prof INT,
    fk_tur INT,
    FOREIGN KEY (fk_mat)
        REFERENCES tbl_material (id_mat),
    FOREIGN KEY (fk_est)
        REFERENCES tbl_matposarm (id_est),
    FOREIGN KEY (fk_prof)
        REFERENCES tbl_professor (id_prof),
    FOREIGN KEY (fk_tur)
        REFERENCES tbl_turma (id_tur),
    PRIMARY KEY (fk_mat , fk_est , fk_prof , fk_tur)
);
