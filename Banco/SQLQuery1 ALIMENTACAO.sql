use petshop

select *from Cliente
select *from TelefoneCliente


insert into Cliente (Nome, CPF, Logradouro, Numero,Cidade,UF,Pais,CEP, DataNascimento,Foto,Ativo)
values ('Cleo Pires','111.111.111-11','Rua Assun��o, Bairro S�o Jo�o', '11', 'Aragua�na','TO','Brasil', '77800-000','01/01/2023',null,1);

insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-2222',2)
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-2211',2)

select C.Nome,TC.Telefone From Cliente C, TelefoneCliente TC where C.Id = 2 ;

update Cliente set Email = 'administrador@hotmail.com' where Id = 1= 

/********************************************* Permiss�o********************************************************/
select *from Permissao

insert into Permissao (Nome) values ('Buscar Usu�rio');
insert into Permissao (Nome) values ('Buscar Cliente');
insert into Permissao (Nome) values ('Buscar Animal');
insert into Permissao (Nome) values ('Buscar Agendamento');
insert into Permissao (Nome) values ('Buscar Ra�a');
insert into Permissao (Nome) values ('Buscar Servi�os');
insert into Permissao (Nome) values ('Buscar Profissional');
insert into Permissao (Nome) values ('Buscar Permiss�o');

insert into Permissao (Nome) values ('Cadastrar Usu�rio');
insert into Permissao (Nome) values ('Cadastrar Cliente');
insert into Permissao (Nome) values ('Cadastrar Animal');
insert into Permissao (Nome) values ('Cadastrar Agendamento');
insert into Permissao (Nome) values ('Cadastrar Ra�a');
insert into Permissao (Nome) values ('Cadastrar Servi�os');
insert into Permissao (Nome) values ('Cadastrar Profissional');
insert into Permissao (Nome) values ('Cadastrar Permiss�o');

insert into Permissao (Nome) values ('Alterar Usu�rio');
insert into Permissao (Nome) values ('Alterar Cliente');
insert into Permissao (Nome) values ('Alterar Animal');
insert into Permissao (Nome) values ('Alterar Agendamento');
insert into Permissao (Nome) values ('Alterar Ra�a');
insert into Permissao (Nome) values ('Alterar Servi�os');
insert into Permissao (Nome) values ('Alterar Profissional');
insert into Permissao (Nome) values ('Alterar Permiss�o');

insert into Permissao (Nome) values ('Excluir Usu�rio');
insert into Permissao (Nome) values ('Excluir Cliente');
insert into Permissao (Nome) values ('Excluir Animal');
insert into Permissao (Nome) values ('Excluir Agendamento');
insert into Permissao (Nome) values ('Excluir Ra�a');
insert into Permissao (Nome) values ('Excluir Servi�os');
insert into Permissao (Nome) values ('Excluir Profissional');
insert into Permissao (Nome) values ('Excluir Permiss�o');

/**********************************************************************************************************************/

/**********************************FUN��O *****************************************************************************/
select *from Funcao
insert into Funcao (Nome) values ('Gerente');
insert into Funcao (Nome) values ('Atendente');
insert into Funcao (Nome) values ('Veterin�rio');
insert into Funcao (Nome) values ('Pet Stylist');

/**********************************************************************************************************************/
select *from FuncaoPermissao
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
/* inserir permiss�o na fun��o Atendente */
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,1);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,2);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,3);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,4);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,5);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,6);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,7);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,8);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,10);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,11);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,12);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,13);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,18);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,19);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,20);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (2,21);

/****************************************************************************************************************/
/****************************** INSERIR PROFISSIONAL ***********************************************************/
select *from Profissional

insert into Profissional (Nome,DataNascimento,CPF,Celular,Email,Endereco,IdFuncao,Ativo,Foto)
values ('Administrador', '01/01/2000','000.000.000-00','(63)99111-1111','administrador@hotmail.com','Rua Administrador, n 00,Bairro Administrador, Cidade Aragua�na-TO',1, 1 ,null);

insert into Profissional (Nome,DataNascimento,CPF,Celular,Email,Endereco,IdFuncao,Ativo,Foto)
values ('Adriana Lopes', '11/01/2000','111.111.111-11','(63)99222-2222','adriana@hotmail.com','Rua Canvas, n 00,Bairro Lago Sul, Cidade Aragua�na-TO',2, 1 ,null);

insert into Profissional (Nome,DataNascimento,CPF,Celular,Email,Endereco,IdFuncao,Ativo,Foto)
values ('Lucas Sampaio', '02/02/2002','222.222.222-11','(63)99333-3333','lucas@hotmail.com','Rua Lima, n 00,Bairro C�u Azul, Cidade Aragua�na-TO',3, 1 ,null);

insert into Profissional (Nome,DataNascimento,CPF,Celular,Email,Endereco,IdFuncao,Ativo,Foto)
values ('Camem Lucia Aguiar', '03/03/1999','333.333.333-33','(63)99444-4444','carmem@hotmail.com','Rua Anhaguera, n 645,Bairro Eldorado, Cidade Aragua�na-TO',4, 1 ,null);

/***********************************************************************************************************************************************************************************/

/**************************************INSERIR USU�RIO **************************************************************/























