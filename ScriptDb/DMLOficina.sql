delimiter $$
create procedure spInsertTurma(in vNome varchar(255))
begin
	if not exists (select nm_tur from tbl_turma where nm_tur = vNome) then 
		insert into tbl_turma values (default, vNome, null);
	else
		select "Turma já cadastrada" as "Erro"; 
    end if;
end $$
delimiter ;

call spInsertTurma("Tornearia Mecânica");

select * from tbl_turma;

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
create procedure spInsertMateiral(in vCodSap varchar(8), in vDesc varchar(255), in vUni varchar(50),
in vQtd int, in vAr int, in vPos int)
begin
	if not exists (select cod_sap from tbl_material where cod_sap = vCodSap) then
		insert into tbl_material values (default, vCodSap, vDesc, vUni);
    end if;
end $$
delimiter ;

--        if not exists (select id_pos from tbl_posicao where id_pos = vPos) then
-- 	 		if not exists (select id_arm from tbl_armazem where id_arm = vArm) then
-- 				insert into tbl_matposarm 
--                 values(default, now(), vQtd, (select id_mat from tbl_material where cod_sap = vCodSap), vArm, vPos);
--             else
-- 				select "Armazenamento não existe" as "Erro"; 
--             end if;
-- 		else
-- 			select "Posição não existe" as "Erro"; 
--        end if;
--    else
-- 		select "Material já cadastrado" as "Erro"; 
--     end if;