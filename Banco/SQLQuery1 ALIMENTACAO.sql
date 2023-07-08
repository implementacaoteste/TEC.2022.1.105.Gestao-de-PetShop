use petshop
/*ANTES DE INSERIR VERIFICAR OS CADASTROS*/

/*---ORDEM DE CADASTRO---
	1 - Cliente
	2 - Email do Cliente
	3 - Telefone do Cliente
	4 - Ra�a
	5 - Animal
	6 - Fun��o
	7 - Permiss�o
	8 - Fun��o/Permiss�o
	9 - Profissional
	10- Email do Profissional
	11- Telefone do Profissional
	12- Usu�rio
	13- Agendamento
	14- Servi�o
	15- Agendamento/Servi�os
*/


/************************************************** INSERT TABELA CLIENTE *********************************************************/
--select *from Cliente
--select *from TelefoneCliente
--select *from EmailCliente

-- cliente numero 1
insert into Cliente (Nome, CPF, Logradouro, Numero,Bairro,Cidade,UF,Pais,CEP, DataNascimento,Foto,Ativo)
values ('Cleo Pires','111.111.111-11','Rua Assun��o', '11','Bairro S�o Jo�o', 'Aragua�na','TO','Brasil', '77800-000','01/01/2000',null,1);
-- telefone do cliente/email 1
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-2222',1)
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-2211',1)
insert into EmailCliente(Email,IdCliente) values ('cleopires@globo.com', 1)

-- cliente numero 2
insert into Cliente (Nome, CPF, Logradouro, Numero,Bairro,Cidade,UF,Pais,CEP, DataNascimento,Foto,Ativo)
values ('Marcos Pasquim','111.111.111-22','Rua Pedreira', '1234','Presidente Lula', 'Aragua�na','TO','Brasil', '77800-000','01/01/1990',null,1);
-- telefone do cliente/email 2
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-3333',2)
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-3311',2)
insert into EmailCliente(Email,IdCliente) values ('marcospasquim@hotmail.com', 1)

--select C.Nome,TC.Telefone From Cliente C, TelefoneCliente TC where C.Id = 1 ;

/******************************************************************************************************************************************************/

/***************************************************************CADASTRAR RA�A *****************************************************************/
--select *From Raca
-- cadastro das ra�as
insert into Raca(Nome, Especie,PaisOrigem) values ('Siberiano','Gato', 'R�ssia');
insert into Raca(Nome, Especie,PaisOrigem) values ('Ragdoll','Gato', 'Estados Unidos');
insert into Raca(Nome, Especie,PaisOrigem) values ('Bombay','Gato', 'Asi�tico');
insert into Raca(Nome, Especie,PaisOrigem) values ('Buldogue-campeiro','Cachorro', 'BrasilDogue brasileiro');
insert into Raca(Nome, Especie,PaisOrigem) values ('Dogue brasileiro','Cachorro', 'Brasil');
insert into Raca(Nome, Especie,PaisOrigem) values ('Dobermann','Cachorro', 'Alemanha');
insert into Raca(Nome, Especie,PaisOrigem) values ('Poodle','Cachorro', 'Fran�a');
insert into Raca(Nome, Especie,PaisOrigem) values ('Vira-Lata','Cachorro', 'Brasil');


/************************************************************************************************************************************/

/********************************************** CADASTRAR ANIMAL *******************************************************************/
--select *from Animal
--cadastro dos animais
insert into Animal(Nome, Sexo, Agressivo, Cor, Idade, Alergia, IdCLiente, IdRaca, Foto, DataNascimento, Ativo)
values('Mini', 'F', 'N','Branca',2,'N�o tem',1,1,null,'01/01/2021',1);

insert into Animal(Nome, Sexo, Agressivo, Cor, Idade, Alergia, IdCLiente, IdRaca, Foto, DataNascimento, Ativo)
values('Lesse', 'F', 'N','Marrom',3,'N�o tem',2,4,null,'01/01/2020',1);

insert into Animal(Nome, Sexo, Agressivo, Cor, Idade, Alergia, IdCLiente, IdRaca, Foto, DataNascimento, Ativo)
values('Michele', 'F', 'N','Preta',1,'N�o tem',2,3,null,'01/01/2022',1);

/********************************************* Permiss�o********************************************************/
--select *from Permissao
--cadastro das permiss�es
insert into Permissao (Nome) values ('Buscar Usu�rio');--1
insert into Permissao (Nome) values ('Buscar Cliente');--2
insert into Permissao (Nome) values ('Buscar Animal');--3
insert into Permissao (Nome) values ('Buscar Agendamento');--4
insert into Permissao (Nome) values ('Buscar Ra�a');--5
insert into Permissao (Nome) values ('Buscar Servi�os');--6
insert into Permissao (Nome) values ('Buscar Profissional');--7
insert into Permissao (Nome) values ('Buscar Permiss�o');--8
insert into Permissao (Nome) values ('Buscar Fun��o');--9

insert into Permissao (Nome) values ('Cadastrar Usu�rio');--10
insert into Permissao (Nome) values ('Cadastrar Cliente');--11
insert into Permissao (Nome) values ('Cadastrar Animal');--12
insert into Permissao (Nome) values ('Cadastrar Agendamento');--13
insert into Permissao (Nome) values ('Cadastrar Ra�a');--14
insert into Permissao (Nome) values ('Cadastrar Servi�os');--15
insert into Permissao (Nome) values ('Cadastrar Profissional');--16
insert into Permissao (Nome) values ('Cadastrar Permiss�o');--17
insert into Permissao (Nome) values ('Cadastrar Fun��o');--18

insert into Permissao (Nome) values ('Alterar Usu�rio');--19
insert into Permissao (Nome) values ('Alterar Cliente');--20
insert into Permissao (Nome) values ('Alterar Animal');--21
insert into Permissao (Nome) values ('Alterar Agendamento');--22
insert into Permissao (Nome) values ('Alterar Ra�a');--23
insert into Permissao (Nome) values ('Alterar Servi�os');--24
insert into Permissao (Nome) values ('Alterar Profissional');--25
insert into Permissao (Nome) values ('Alterar Permiss�o');--26
insert into Permissao (Nome) values ('Alterar Fun��o');--27

insert into Permissao (Nome) values ('Excluir Usu�rio');--28
insert into Permissao (Nome) values ('Excluir Cliente');--29
insert into Permissao (Nome) values ('Excluir Animal');--30
insert into Permissao (Nome) values ('Excluir Agendamento');--31
insert into Permissao (Nome) values ('Excluir Ra�a');--32
insert into Permissao (Nome) values ('Excluir Servi�os');--33
insert into Permissao (Nome) values ('Excluir Profissional');--34
insert into Permissao (Nome) values ('Excluir Permiss�o');--35
insert into Permissao (Nome) values ('Excluir Fun��o');--36

/**********************************************************************************************************************/

/**********************************FUN��O *****************************************************************************/
--select *from Funcao
--cadastro das fun��es
insert into Funcao (Nome) values ('Gerente');
insert into Funcao (Nome) values ('Atendente');
insert into Funcao (Nome) values ('Veterin�rio');
insert into Funcao (Nome) values ('Pet Stylist');

/**********************************************************************************************************************/
--select *from FuncaoPermissao
/* inserir permiss�o na fun��o Gerente tem todas as permiss�es */
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,1);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,2);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,3);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,4);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,5);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,6);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,7);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,8);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,9);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,10);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,11);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,12);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,13);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,14);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,15);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,16);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,17);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,18);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,19);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,20);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,21);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,22);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,23);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,24);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,25);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,26);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,27);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,28);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,29);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,30);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,31);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,32);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,33);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,34);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,35);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,36);
/* inserir permiss�o na fun��o Atendente */
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,1);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,2);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,3);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,4);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,5);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,6);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,7);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,8);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,9);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,10);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,11);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,12);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,13);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,14);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,19);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,20);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,21);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,22);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,23);

/****************************************************************************************************************/
/****************************** INSERIR PROFISSIONAL telefone e Email ***********************************************************/
--select *from Profissional
--select *from TelefoneProfissional
--select *from EmailProfissional 
--cadastro dos profissionais
insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (1,'Administrador','000.000.000-00','Rua Administrador','01','Bairro Administrador','Aragua�na','TO','Brasil','77800-000', '01/01/2000',null, 1);
insert into TelefoneProfissional(IdProfissional,Telefone) values (1,'6399200-0000')
insert into TelefoneProfissional(IdProfissional,Telefone) values (1,'6399200-0001')
insert into EmailProfissional(Email,IdProfissional) values ('administrador@gmail.com',1)

insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (2,'Ana Paula Santos','000.000.000-01','Rua Carvalh�es','308','Bairro C�u azul','Aragua�na','TO','Brasil','77800-000', '02/01/2000',null, 1);
insert into TelefoneProfissional(IdProfissional,Telefone) values (2,'6399200-1111')
insert into EmailProfissional(Email,IdProfissional) values ('anapaula@gmail.com',2)

insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (3,'Lucas Sampaio','000.000.000-02','Rua Z�mbia','s/n','Bairro Lago Azul IV','Aragua�na','TO','Brasil','77800-000', '03/01/2000',null, 1);
insert into TelefoneProfissional(IdProfissional,Telefone) values (3,'6399200-2222')
insert into EmailProfissional(Email,IdProfissional) values ('sampoio@gmail.com',3)

insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (4,'Carmem Aguiar','000.000.000-03','Rua Colinas','s/n','Bairro Patrocionio','Aragua�na','TO','Brasil','77800-000', '04/01/2000',null, 1);
insert into TelefoneProfissional(IdProfissional,Telefone) values (4,'6399200-3333')
insert into EmailProfissional(Email,IdProfissional) values ('aguiar@gmail.com',4)

--select P.Nome, TP.Telefone, EP.Email, F.Nome  from Profissional P inner join TelefoneProfissional TP on P.Id = TP.IdProfissional inner join EmailProfissional EP on P.Id = EP.IdProfissional inner join Funcao F on F.Id = P.IdFuncao and P.Id = 1
/***********************************************************************************************************************************************************************************/

/**************************************INSERIR USU�RIO **************************************************************/
--use petshop
--select *from Usuario
--cadastro dos usu�rios
insert into Usuario(UsuarioLogin,Senha,IdProfissional) values ('administrador','adm1234',1);
insert into Usuario(UsuarioLogin,Senha,IdProfissional) values ('AnaPaula','aten1234',2);

/*******************************************************************************************************************************/


















