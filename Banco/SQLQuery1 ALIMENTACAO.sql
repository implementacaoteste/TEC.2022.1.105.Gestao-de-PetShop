use petshop



/************************************************** INSERT TABELA CLIENTE *********************************************************/
select *from Cliente
select *from TelefoneCliente
select *from EmailCliente

insert into Cliente (Nome, CPF, Logradouro, Numero,Bairro,Cidade,UF,Pais,CEP, DataNascimento,Foto,Ativo)
values ('Cleo Pires','111.111.111-11','Rua Assunção', '11','Bairro São João', 'Araguaína','TO','Brasil', '77800-000','01/01/2023',null,1);

insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-2222',1)
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-2211',1)
insert into EmailCliente(Email,IdCliente) values ('cleopires', 1)

select C.Nome,TC.Telefone From Cliente C, TelefoneCliente TC where C.Id = 1 ;

/******************************************************************************************************************************************************/

/***************************************************************CADASTRAR RAÇA *****************************************************************/
select *From Raca

insert into (Nome, Especie,RacaPaisOrigem) values ('Mimí','Gato',

/********************************************* Permissão********************************************************/
select *from Permissao

insert into Permissao (Nome) values ('Buscar Usuário');
insert into Permissao (Nome) values ('Buscar Cliente');
insert into Permissao (Nome) values ('Buscar Animal');
insert into Permissao (Nome) values ('Buscar Agendamento');
insert into Permissao (Nome) values ('Buscar Raça');
insert into Permissao (Nome) values ('Buscar Serviços');
insert into Permissao (Nome) values ('Buscar Profissional');
insert into Permissao (Nome) values ('Buscar Permissão');

insert into Permissao (Nome) values ('Cadastrar Usuário');
insert into Permissao (Nome) values ('Cadastrar Cliente');
insert into Permissao (Nome) values ('Cadastrar Animal');
insert into Permissao (Nome) values ('Cadastrar Agendamento');
insert into Permissao (Nome) values ('Cadastrar Raça');
insert into Permissao (Nome) values ('Cadastrar Serviços');
insert into Permissao (Nome) values ('Cadastrar Profissional');
insert into Permissao (Nome) values ('Cadastrar Permissão');

insert into Permissao (Nome) values ('Alterar Usuário');
insert into Permissao (Nome) values ('Alterar Cliente');
insert into Permissao (Nome) values ('Alterar Animal');
insert into Permissao (Nome) values ('Alterar Agendamento');
insert into Permissao (Nome) values ('Alterar Raça');
insert into Permissao (Nome) values ('Alterar Serviços');
insert into Permissao (Nome) values ('Alterar Profissional');
insert into Permissao (Nome) values ('Alterar Permissão');

insert into Permissao (Nome) values ('Excluir Usuário');
insert into Permissao (Nome) values ('Excluir Cliente');
insert into Permissao (Nome) values ('Excluir Animal');
insert into Permissao (Nome) values ('Excluir Agendamento');
insert into Permissao (Nome) values ('Excluir Raça');
insert into Permissao (Nome) values ('Excluir Serviços');
insert into Permissao (Nome) values ('Excluir Profissional');
insert into Permissao (Nome) values ('Excluir Permissão');

/**********************************************************************************************************************/

/**********************************FUNÇÃO *****************************************************************************/
select *from Funcao
insert into Funcao (Nome) values ('Gerente');
insert into Funcao (Nome) values ('Atendente');
insert into Funcao (Nome) values ('Veterinário');
insert into Funcao (Nome) values ('Pet Stylist');

/**********************************************************************************************************************/
select *from FuncaoPermissao
/* inserir permissão na função Gerente tem todas as permissões */
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
/* inserir permissão na função Atendente */
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
/****************************** INSERIR PROFISSIONAL telefone e Email ***********************************************************/
select *from Profissional
select *from TelefoneProfissional
select *from EmailProfissional 

insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (1,'Administrador','000.000.000-00','Rua Administrador','01','Bairro Administrador','Araguaína','TO','Brasil','77800-000', '01/01/2000',null, 1);
insert into TelefoneProfissional(IdProfissional,Telefone) values (1,'6399200-0000')
insert into TelefoneProfissional(IdProfissional,Telefone) values (1,'6399200-0001')
insert into EmailProfissional(Email,IdProfissional) values ('administrador@gmail.com',1)

insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (2,'Ana Paula Santos','000.000.000-01','Rua Carvalhães','308','Bairro Céu azul','Araguaína','TO','Brasil','77800-000', '02/01/2000',null, 1);
insert into TelefoneProfissional(IdProfissional,Telefone) values (2,'6399200-1111')
insert into EmailProfissional(Email,IdProfissional) values ('anapaula@gmail.com',2)

insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (3,'Lucas Sampaio','000.000.000-02','Rua Zâmbia','s/n','Bairro Lago Azul IV','Araguaína','TO','Brasil','77800-000', '03/01/2000',null, 1);
insert into TelefoneProfissional(IdProfissional,Telefone) values (3,'6399200-2222')
insert into EmailProfissional(Email,IdProfissional) values ('sampoio@gmail.com',3)

insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (4,'Carmem Aguiar','000.000.000-03','Rua Colinas','s/n','Bairro Patrocionio','Araguaína','TO','Brasil','77800-000', '04/01/2000',null, 1);
insert into TelefoneProfissional(IdProfissional,Telefone) values (4,'6399200-3333')
insert into EmailProfissional(Email,IdProfissional) values ('aguiar@gmail.com',4)

select P.Nome, TP.Telefone, EP.Email, F.Nome  from Profissional P inner join TelefoneProfissional TP on P.Id = TP.IdProfissional inner join EmailProfissional EP on P.Id = EP.IdProfissional inner join Funcao F on F.Id = P.IdFuncao and P.Id = 1
/***********************************************************************************************************************************************************************************/

/**************************************INSERIR USUÁRIO **************************************************************/
use petshop
select *from Usuario

insert into Usuario(Login,Senha,IdProfissional) values ('administrador','adm1234',1);
insert into Usuario(Login,Senha,IdProfissional) values ('AnaPaula','aten1234',2);

/*******************************************************************************************************************************/


















