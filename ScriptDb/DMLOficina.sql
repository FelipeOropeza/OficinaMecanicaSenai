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
create procedure spInsertEstoque(in vNome varchar(100), in vTipoEst boolean)
begin
	if vTipoEst = 0 then
		if not exists (select nm_pos from tbl_posicao where nm_pos = vNome) then
			insert into tbl_posicao values (default, vNome);
		else
			select "Posição já cadastrada" as "Erro"; 
		end if;
    elseif vTipoEst = 1 then
		if not exists (select desc_arm from tbl_armazem where desc_arm = vNome) then
			insert into tbl_armazem values (default, vNome);
		else
			select "Armazenamento já cadastrado" as "Erro"; 
		end if;
	else
		select "A opção não existe" as "Erro"; 
    end if;
end $$
delimiter ;

-- 0 = Posicao
-- 1 = Armazem
call spInsertEstoque('D', 0);
call spInsertEstoque('E', 0);
call spInsertEstoque('F', 0);
call spInsertEstoque('Prateleira 3', 1);
call spInsertEstoque('Prateleira 4', 1);

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
create procedure spInsertMovimentacao(in vTipoMov boolean, in vQtdMov int, in vCodSap varchar(8), in vEst int, in vProf int, in vTurma int)
begin
	set @idMat = (select id_mat from tbl_material where cod_sap = vCodSap);
	
    insert into tbl_movimentacao values (default, vTipoMov, now(), vQtdMov, @idMat, vEst, vProf, vTurma);
end $$
delimiter ;

-- 0 = Entrada
-- 1 = Saida
call spInsertMovimentacao(0, 20, '123wqs23', 1, 1, 1);
call spInsertMovimentacao(0, 20, '123wqs23', 2, 1, 1);
call spInsertMovimentacao(1, 10, '123wqs23', 1, 1, 1);

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
