delimiter $$
create procedure spInsertTurmaProf(in vNome varchar(255), in vSN varchar(7))
begin
	set @idProf = (select id_prof from tbl_professor where sn_prof = vSN);
	if not exists (select nm_tur from tbl_turma where nm_tur = vNome) then 
		insert into tbl_turma values (default, vNome, @idProf);
	else
		select "Turma já cadastrada" as "Erro"; 
    end if;
end $$
delimiter ;

call spInsertTurmaProf("Mecatronica", "ewwewew");

delimiter $$
create procedure spInsertProfessor(in vNome varchar(255), in vSN varchar(7))
begin
	if not exists (select sn_prof from tbl_professor where sn_prof = vSN) then 
		insert into tbl_professor values (default, vNome, vSN);
	else
		select "Professor já cadastrado" as "Erro"; 
    end if;
end $$
delimiter ;

call spInsertProfessor("Felipe Carvalho", "2323222");
call spInsertProfessor("José Carlos", "ewwewew");

delimiter $$
create procedure spInsertPosicao(in vNome char(1))
begin
	if not exists (select nm_pos from tbl_posicao where nm_pos = vNome) then
		insert into tbl_posicao values (default, vNome);
	else
		select "Posição já cadastrada" as "Erro"; 
    end if;
end $$
delimiter ;

call spInsertPosicao('A');
call spInsertPosicao('B');
call spInsertPosicao('C');

delimiter $$
create procedure spInsertArmazem(in vNome varchar(255))
begin
	if not exists (select desc_arm from tbl_armazem where desc_arm = vNome) then
		insert into tbl_armazem values (default, vNome);
	else
		select "Armazenamento já cadastrado" as "Erro"; 
    end if;
end $$
delimiter ;

call spInsertArmazem('Prateleira 1');
call spInsertArmazem('Prateleira 2');

delimiter $$
create procedure spInsertMateiral(in vCodSap varchar(8), in vDesc varchar(255), in vUni varchar(50))
begin
	if not exists (select cod_sap from tbl_material where cod_sap = vCodSap) then
		insert into tbl_material values (default, vCodSap, vDesc, vUni);
	else
		select "Material já cadastrado" as "Erro"; 
    end if;
end $$
delimiter ;

call spInsertMateiral('123wqs23', 'Teste1', 'Metro');
call spInsertMateiral('123w2s24', 'Teste2', 'Peça');
call spInsertMateiral('123w3223', 'Teste3', 'Peça');
call spInsertMateiral('1214qs53', 'Teste4', 'Metro');


delimiter $$
create procedure spInsertLocaliza(in vCodSap varchar(8), in vCodArm int, in vCodPos int ,in vQtd int)
begin
	set @idMat = (select id_mat from tbl_material where cod_sap = vCodSap);

	if not exists (
        select *
        from tbl_matposarm
        where fk_mat = @idMat
        and fk_arm = vCodArm
        and fk_pos = vCodPos
    )then
		insert into tbl_matposarm values(default, now(), vQtd, @idMat, vCodArm, vCodPos);
	else
		select "Opção não disponivel" as "Erro"; 
    end if;
end $$
delimiter ;

call spInsertLocaliza('123wqs23', 1, 1,30);
call spInsertLocaliza('123wqs23', 1, 2,40);
call spInsertLocaliza('123w2s24', 2, 3,20);
call spInsertLocaliza('123w3223', 1, 1,60);
call spInsertLocaliza('1214qs53', 1, 2,50);

delimiter $$
create procedure spInsertMovimentacao(in vTipoMov boolean, in vQtdMov int, in vCodSap varchar(8), in vPos int, in vArm int, in vProf int, in vTurma int)
begin
	declare idMat int;
    declare idEst int;
	set idMat = (select id_mat from tbl_material where cod_sap = vCodSap);
	set idEst = (select id_est from tbl_matposarm where fk_mat = idMat and fk_arm = vArm and fk_pos = vPos);
    
    insert into tbl_movimentacao values (default, vTipoMov, now(), vQtdMov, idMat, idEst, vProf, vTurma);
end $$
delimiter ;

-- 0 = Entrada
-- 1 = Saida
call spInsertMovimentacao(1, 50, '123wqs23', 2, 1, 2, 4);

delimiter $$
create trigger trgEntrada after insert on tbl_movimentacao
for each row
begin
	if new.tipo_mov = 0 then
		update tbl_matposarm set tbl_matposarm.qtd_est = tbl_matposarm.qtd_est + new.qtd_mov where tbl_matposarm.id_est = new.fk_est;
    end if;
end $$
delimiter ;

delimiter $$
create trigger trgSaida after insert on tbl_movimentacao
for each row
begin
	if new.tipo_mov = 1 then
		update tbl_matposarm set tbl_matposarm.qtd_est = tbl_matposarm.qtd_est - new.qtd_mov where tbl_matposarm.id_est = new.fk_est;
    end if;
end $$
delimiter ;

create view vwMatLocaliza as
select
	tbl_matposarm.id_est,
	tbl_material.cod_sap,
    tbl_material.desc_mat,
    tbl_matposarm.qtd_est,
    tbl_armazem.id_arm,
    tbl_armazem.desc_arm,
    tbl_posicao.id_pos,
    tbl_posicao.nm_pos
from tbl_material
inner join tbl_matposarm on tbl_matposarm.fk_mat = tbl_material.id_mat
inner join tbl_armazem on tbl_armazem.id_arm = tbl_matposarm.fk_arm
inner join tbl_posicao on tbl_posicao.id_pos = tbl_matposarm.fk_pos;

select cod_sap, desc_arm, nm_pos, qtd_est from vwMatLocaliza where desc_mat like '%teste1%';
select distinct desc_arm from vwMatLocaliza where desc_mat like '%mm%' and cod_sap = '93821';
select distinct id_pos, nm_pos from vwMatLocaliza where desc_mat like '%mm%' and cod_sap = '93821';

select cod_sap, desc_arm, nm_pos, qtd_est from vwMatLocaliza where desc_mat like '%mm%';

select cod_sap, desc_mat, desc_arm, nm_pos from vwMatLocaliza;

select * from vwmatlocaliza where cod_sap = '123wqs23' and id_arm = 1 and id_pos = 3;

create view vwProfTurma as
select
	tbl_professor.id_prof,
	tbl_professor.nm_prof,
    tbl_professor.sn_prof,
    tbl_turma.id_tur,
    tbl_turma.nm_tur
from tbl_turma
inner join tbl_professor on tbl_professor.id_prof = tbl_turma.fk_prof;

select *, count(id_prof) as "Qtd" from vwProfTurma group by id_prof;
select id_tur, nm_tur from vwProfTurma where sn_prof = "1232113";

create view vwMovimenta as
select
	if(tbl_movimentacao.tipo_mov = 0, "Entrada", "Saida") as "Movimentação",
    tbl_material.cod_sap,
    tbl_professor.nm_prof,
    tbl_turma.nm_tur,
    tbl_movimentacao.qtd_mov,
    tbl_movimentacao.data_mov
from tbl_movimentacao
inner join tbl_professor on tbl_professor.id_prof = tbl_movimentacao.fk_prof
inner join tbl_turma on tbl_turma.id_tur = tbl_movimentacao.fk_tur
inner join tbl_material on tbl_material.id_mat = tbl_movimentacao.fk_mat;

select * from vwMovimenta order by data_mov desc;
