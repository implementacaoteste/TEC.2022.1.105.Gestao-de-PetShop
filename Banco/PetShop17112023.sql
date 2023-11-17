USE [master]
GO
/****** Object:  Database [petshop]    Script Date: 13/07/2023 10:31:42 ******/
IF EXISTS(SELECT 1 FROM SYSDATABASES WHERE NAME = 'PETSHOP')
BEGIN
	ALTER DATABASE petshop SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE petshop
END
GO
CREATE DATABASE [petshop]
GO
ALTER DATABASE [petshop] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [petshop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [petshop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [petshop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [petshop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [petshop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [petshop] SET ARITHABORT OFF 
GO
ALTER DATABASE [petshop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [petshop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [petshop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [petshop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [petshop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [petshop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [petshop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [petshop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [petshop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [petshop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [petshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [petshop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [petshop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [petshop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [petshop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [petshop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [petshop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [petshop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [petshop] SET  MULTI_USER 
GO
ALTER DATABASE [petshop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [petshop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [petshop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [petshop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [petshop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [petshop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [petshop] SET QUERY_STORE = OFF
GO
USE [petshop]
GO
/****** Object:  Table [dbo].[AgendamentoServicos]    Script Date: 12/10/2023 15:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgendamentoServicos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAgendamento] [int] NOT NULL,
	[IdProfissional] [int] NULL,
	[IdServico] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [decimal](5, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servico]    Script Date: 12/10/2023 15:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servico](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Preco] [decimal](5, 2) NOT NULL,
	[Tempo] [int] NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_ServicosAgendamento]    Script Date: 12/10/2023 15:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ServicosAgendamento]
AS
SELECT        dbo.AgendamentoServicos.Id, dbo.AgendamentoServicos.IdAgendamento, dbo.AgendamentoServicos.IdServico, dbo.Servico.Descricao, dbo.Servico.Tempo, dbo.AgendamentoServicos.Quantidade, 
                         dbo.AgendamentoServicos.ValorUnitario, dbo.AgendamentoServicos.Quantidade * dbo.AgendamentoServicos.ValorUnitario AS SubTotal
FROM            dbo.AgendamentoServicos INNER JOIN
                         dbo.Servico ON dbo.AgendamentoServicos.IdServico = dbo.Servico.Id
GO
/****** Object:  Table [dbo].[Agendamento]    Script Date: 12/10/2023 15:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agendamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAnimal] [int] NOT NULL,
	[IdSituacao] [int] NOT NULL,
	[DataAg] [date] NOT NULL,
	[Horario] [time](7) NOT NULL,
	[Total] [numeric](5, 2) NOT NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 12/10/2023 15:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdRaca] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Sexo] [varchar](50) NOT NULL,
	[Agressivo] [varchar](50) NOT NULL,
	[Cor] [varchar](25) NOT NULL,
	[Idade] [int] NOT NULL,
	[Alergia] [varchar](50) NULL,
	[Foto] [image] NULL,
	[DataNascimento] [date] NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[CPF] [char](14) NOT NULL,
	[Logradouro] [varchar](100) NULL,
	[Numero] [varchar](6) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[UF] [char](2) NULL,
	[Pais] [varchar](50) NULL,
	[CEP] [varchar](9) NULL,
	[DataNascimento] [date] NULL,
	[Foto] [image] NULL,
	[Ativo] [bit] NULL,
 CONSTRAINT [PK__Cliente__3214EC07063AA2F8] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailCliente]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailCliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailProfissional]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailProfissional](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProfissional] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcao]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FuncaoPermissao]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FuncaoPermissao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdFuncao] [int] NOT NULL,
	[IdPermissao] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissao]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profissional]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profissional](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdFuncao] [int] NULL,
	[Nome] [varchar](50) NOT NULL,
	[CPF] [char](14) NULL,
	[Logradouro] [varchar](100) NULL,
	[Numero] [varchar](6) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[UF] [char](2) NULL,
	[Pais] [varchar](50) NULL,
	[CEP] [varchar](9) NULL,
	[DataNascimento] [date] NULL,
	[Foto] [image] NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raca]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Especie] [varchar](50) NOT NULL,
	[PaisOrigem] [varchar](50) NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Situacao]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Situacao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelefoneCliente]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefoneCliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Telefone] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelefoneProfissional]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefoneProfissional](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProfissional] [int] NOT NULL,
	[Telefone] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/10/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProfissional] [int] NOT NULL,
	[UsuarioLogin] [varchar](15) NOT NULL,
	[Senha] [varchar](100) NOT NULL,
	[Ativo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Agendamento] ADD  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((1)) FOR [Ativo]
GO
ALTER TABLE [dbo].[Agendamento]  WITH CHECK ADD FOREIGN KEY([IdAnimal])
REFERENCES [dbo].[Animal] ([Id])
GO
ALTER TABLE [dbo].[Agendamento]  WITH CHECK ADD FOREIGN KEY([IdSituacao])
REFERENCES [dbo].[Situacao] ([Id])
GO
ALTER TABLE [dbo].[AgendamentoServicos]  WITH CHECK ADD FOREIGN KEY([IdAgendamento])
REFERENCES [dbo].[Agendamento] ([Id])
GO
ALTER TABLE [dbo].[AgendamentoServicos]  WITH CHECK ADD FOREIGN KEY([IdProfissional])
REFERENCES [dbo].[Profissional] ([Id])
GO
ALTER TABLE [dbo].[AgendamentoServicos]  WITH CHECK ADD FOREIGN KEY([IdServico])
REFERENCES [dbo].[Servico] ([Id])
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK__Animal__IdClient__3C69FB99] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK__Animal__IdClient__3C69FB99]
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD FOREIGN KEY([IdRaca])
REFERENCES [dbo].[Raca] ([Id])
GO
ALTER TABLE [dbo].[EmailCliente]  WITH CHECK ADD  CONSTRAINT [FK__EmailClie__IdCli__46E78A0C] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[EmailCliente] CHECK CONSTRAINT [FK__EmailClie__IdCli__46E78A0C]
GO
ALTER TABLE [dbo].[EmailProfissional]  WITH CHECK ADD FOREIGN KEY([IdProfissional])
REFERENCES [dbo].[Profissional] ([Id])
GO
ALTER TABLE [dbo].[FuncaoPermissao]  WITH CHECK ADD FOREIGN KEY([IdFuncao])
REFERENCES [dbo].[Funcao] ([Id])
GO
ALTER TABLE [dbo].[FuncaoPermissao]  WITH CHECK ADD FOREIGN KEY([IdPermissao])
REFERENCES [dbo].[Permissao] ([Id])
GO
ALTER TABLE [dbo].[Profissional]  WITH CHECK ADD FOREIGN KEY([IdFuncao])
REFERENCES [dbo].[Funcao] ([Id])
GO
ALTER TABLE [dbo].[TelefoneCliente]  WITH CHECK ADD  CONSTRAINT [FK__TelefoneC__IdCli__45F365D3] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[TelefoneCliente] CHECK CONSTRAINT [FK__TelefoneC__IdCli__45F365D3]
GO
ALTER TABLE [dbo].[TelefoneProfissional]  WITH CHECK ADD FOREIGN KEY([IdProfissional])
REFERENCES [dbo].[Profissional] ([Id])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([IdProfissional])
REFERENCES [dbo].[Profissional] ([Id])
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- UTILIZANDO UMA PROCEDURE
CREATE PROCEDURE [dbo].[SP_CAD_USUARIO]
	@IdProfissional INT,
	@UsuarioLogin VARCHAR(15),
	@Senha VARCHAR(100)
AS
BEGIN
	INSERT INTO USUARIO(IdProfissional,UsuarioLogin,Senha)
	VALUES(@IdProfissional,@UsuarioLogin,@Senha)
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "AgendamentoServicos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 167
               Right = 213
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Servico"
            Begin Extent = 
               Top = 6
               Left = 251
               Bottom = 163
               Right = 421
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ServicosAgendamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ServicosAgendamento'
GO
--Populando o Banco--
-- cliente numero 1
insert into Cliente (Nome, CPF, Logradouro, Numero,Bairro,Cidade,UF,Pais,CEP, DataNascimento,Foto,Ativo)
values ('Cleo Pires','111.111.111-11','Rua Assunção', '11','Bairro São João', 'Araguaína','TO','Brasil', '77800-000','01/01/2000',null,1);
GO
-- telefone do cliente/email 1
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-2222',1)
GO
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-2211',1)
GO
insert into EmailCliente(Email,IdCliente) values ('cleopires@globo.com', 1)
GO

-- cliente numero 2
insert into Cliente (Nome, CPF, Logradouro, Numero,Bairro,Cidade,UF,Pais,CEP, DataNascimento,Foto,Ativo)
values ('Marcos Pasquim','111.111.111-22','Rua Pedreira', '1234','Presidente Lula', 'Araguaína','TO','Brasil', '77800-000','01/01/1990',null,1);
GO
-- telefone do cliente/email 2
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-3333',2)
GO
insert into TelefoneCliente (Telefone, IdCliente) values ('6399222-3311',2)
GO
insert into EmailCliente(Email,IdCliente) values ('marcospasquim@hotmail.com', 2)
GO

-- cadastro das raças
insert into Raca(Nome, Especie,PaisOrigem,Ativo) values ('Siberiano','Gato', 'Rússia',1);
insert into Raca(Nome, Especie,PaisOrigem,Ativo) values ('Ragdoll','Gato', 'Estados Unidos',1);
insert into Raca(Nome, Especie,PaisOrigem,Ativo) values ('Bombay','Gato', 'Asiático',1);
insert into Raca(Nome, Especie,PaisOrigem,Ativo) values ('Buldogue-campeiro','Cachorro', 'BrasilDogue brasileiro',1);
insert into Raca(Nome, Especie,PaisOrigem,Ativo) values ('Dogue brasileiro','Cachorro', 'Brasil',1);
insert into Raca(Nome, Especie,PaisOrigem,Ativo) values ('Dobermann','Cachorro', 'Alemanha',1);
insert into Raca(Nome, Especie,PaisOrigem,Ativo) values ('Poodle','Cachorro', 'França',1);
insert into Raca(Nome, Especie,PaisOrigem,Ativo) values ('Vira-Lata','Cachorro', 'Brasil',1);
GO

insert into Animal(IdCLiente, IdRaca, Nome, Sexo, Agressivo, Cor, Idade, Alergia, Foto, DataNascimento, Ativo)
values(1,1,'Mini', 'F', 'N','Branca',2,'Não tem', null,'01/01/2021',1);
GO

insert into Animal(IdCLiente, IdRaca, Nome, Sexo, Agressivo, Cor, Idade, Alergia, Foto, DataNascimento, Ativo)
values(2,4,'Lesse', 'F', 'N','Marrom',3,'Não tem', null,'01/01/2020',1);
GO

insert into Animal(IdCLiente, IdRaca, Nome, Sexo, Agressivo, Cor, Idade, Alergia, Foto, DataNascimento, Ativo)
values(2,3,'Michele', 'F', 'N','Preta',1,'Não tem', null,'01/01/2022',1);
GO

insert into Permissao (Nome) values ('Buscar Usuário');--1
insert into Permissao (Nome) values ('Buscar Cliente');--2
insert into Permissao (Nome) values ('Buscar Animal');--3
insert into Permissao (Nome) values ('Buscar Agendamento');--4
insert into Permissao (Nome) values ('Buscar Raça');--5
insert into Permissao (Nome) values ('Buscar Serviços');--6
insert into Permissao (Nome) values ('Buscar Profissional');--7
insert into Permissao (Nome) values ('Buscar Permissão');--8
insert into Permissao (Nome) values ('Buscar Função');--9
GO
insert into Permissao (Nome) values ('Cadastrar Usuário');--10
insert into Permissao (Nome) values ('Cadastrar Cliente');--11
insert into Permissao (Nome) values ('Cadastrar Animal');--12
insert into Permissao (Nome) values ('Cadastrar Agendamento');--13
insert into Permissao (Nome) values ('Cadastrar Raça');--14
insert into Permissao (Nome) values ('Cadastrar Serviços');--15
insert into Permissao (Nome) values ('Cadastrar Profissional');--16
insert into Permissao (Nome) values ('Cadastrar Permissão');--17
insert into Permissao (Nome) values ('Cadastrar Função');--18
GO
insert into Permissao (Nome) values ('Alterar Usuário');--19
insert into Permissao (Nome) values ('Alterar Cliente');--20
insert into Permissao (Nome) values ('Alterar Animal');--21
insert into Permissao (Nome) values ('Alterar Agendamento');--22
insert into Permissao (Nome) values ('Alterar Raça');--23
insert into Permissao (Nome) values ('Alterar Serviços');--24
insert into Permissao (Nome) values ('Alterar Profissional');--25
insert into Permissao (Nome) values ('Alterar Permissão');--26
insert into Permissao (Nome) values ('Alterar Função');--27
GO
insert into Permissao (Nome) values ('Excluir Usuário');--28
insert into Permissao (Nome) values ('Excluir Cliente');--29
insert into Permissao (Nome) values ('Excluir Animal');--30
insert into Permissao (Nome) values ('Excluir Agendamento');--31
insert into Permissao (Nome) values ('Excluir Raça');--32
insert into Permissao (Nome) values ('Excluir Serviços');--33
insert into Permissao (Nome) values ('Excluir Profissional');--34
insert into Permissao (Nome) values ('Excluir Permissão');--35
insert into Permissao (Nome) values ('Excluir Função');--36
insert into Permissao (Nome) values ('Alterar Ativo');--37
GO

--cadastro das funções
insert into Funcao (Nome) values ('Gerente');
insert into Funcao (Nome) values ('Atendente');
insert into Funcao (Nome) values ('Veterinário');
insert into Funcao (Nome) values ('Pet Stylist');
GO

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
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,33);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,34);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,35);
insert into FuncaoPermissao (IdFuncao,IdPermissao) values (1,36);
/* inserir permissão na função Atendente */
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
GO

--cadastro dos profissionais
insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (1,'Administrador','000.000.000-00','Rua Administrador','01','Administrador','Araguaína','TO','Brasil','77800-000', '01/01/2000',null, 1);
GO
insert into TelefoneProfissional(IdProfissional,Telefone) values (1,'6399200-0000')
insert into TelefoneProfissional(IdProfissional,Telefone) values (1,'6399200-0001')
insert into EmailProfissional(IdProfissional,Email) values (1,'administrador@gmail.com')
GO

insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (2,'Ana Paula Santos','000.000.000-01','Rua Carvalhães','308','Bairro Céu azul','Araguaína','TO','Brasil','77800-000', '02/01/2000',null, 1);
GO
insert into TelefoneProfissional(IdProfissional,Telefone) values (2,'6399200-1111')
insert into EmailProfissional(IdProfissional,Email) values (2,'anapaula@gmail.com')
GO
insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (3,'Lucas Sampaio','000.000.000-02','Rua Zâmbia','s/n','Bairro Lago Azul IV','Araguaína','TO','Brasil','77800-000', '03/01/2000',null, 1);
GO
insert into TelefoneProfissional(IdProfissional,Telefone) values (3,'6399200-2222')
insert into EmailProfissional(IdProfissional,Email) values (3,'sampoio@gmail.com')
GO
insert into Profissional (IdFuncao,Nome,CPF,Logradouro, Numero, Bairro, Cidade,UF,Pais, CEP,DataNascimento,Foto,Ativo)
values (4,'Carmem Aguiar','000.000.000-03','Rua Colinas','s/n','Bairro Patrocionio','Araguaína','TO','Brasil','77800-000', '04/01/2000',null, 1);
GO
insert into TelefoneProfissional(IdProfissional,Telefone) values (4,'6399200-3333')
insert into EmailProfissional(IdProfissional,Email) values (4,'aguiar@gmail.com')
GO

-- UTILIZANDO UMA PROCEDURE
CREATE PROCEDURE SP_CAD_USUARIO
	@IdProfissional INT,
	@UsuarioLogin VARCHAR(15),
	@Senha VARCHAR(100)
AS
BEGIN
	INSERT INTO USUARIO(IdProfissional,UsuarioLogin,Senha)
	VALUES(@IdProfissional,@UsuarioLogin,@Senha)
END
GO

EXEC SP_CAD_USUARIO 1,'administrador','HjAsWaTFbgNjwwyBrFLS0FiZTF7RQmTvkG13HT3yCZM='
EXEC SP_CAD_USUARIO 2,'AnaPaula','QJhhkqDEKtUFhMtxDloEMBIykHVngoWCjhHh0hFWiRQ='
EXEC SP_CAD_USUARIO 3,'Erisvaldo','2TbqERhDgvUD7AVPSqQyIZUmHYb9DUyJHiRaOSfUrtA='
EXEC SP_CAD_USUARIO 4,'teste','4l0T6ECg5gGUAd70iFwB+OrZlqIhNCQHx5aftxeJm2g=' 
GO
-- Ana Paula ana1234   e Erisvaldo 1234   e  teste tst1234

insert into Situacao(Descricao) values ('Agendado');
insert into Situacao(Descricao) values ('Em Andamento');
insert into Situacao(Descricao) values ('Finalizado');
GO

insert into Servico(Descricao,Preco,Tempo,Ativo) values ('Banho porte Pequeno',30.00,30,1);
insert into Servico(Descricao,Preco,Tempo,Ativo) values ('Banho porte Grande',50.00,45,1);
insert into Servico(Descricao,Preco,Tempo,Ativo) values ('Tosa Padrão',15.00,30,1);
insert into Servico(Descricao,Preco,Tempo,Ativo) values ('Tosa Completa',50.00,45,1);
insert into Servico(Descricao,Preco,Tempo,Ativo) values ('Buscar DriverTur',10.00,15,1);
insert into Servico(Descricao,Preco,Tempo,Ativo) values ('Levar DriverTur',10.00,15,1);
GO

insert into Agendamento(IdAnimal,IdSituacao,DataAg,Horario,Total,Ativo) values (1,1,'04/08/2023','09:30:00',0.00,1);
insert into Agendamento(IdAnimal,IdSituacao,DataAg,Horario,Total,Ativo) values (1,2,'04/09/2023','09:35:00',0.00,1);
insert into Agendamento(IdAnimal,IdSituacao,DataAg,Horario,Total,Ativo) values (1,3,'04/10/2023','09:40:00',0.00,1);
GO

insert into AgendamentoServicos(IdAgendamento,IdServico,Quantidade,ValorUnitario,IdProfissional) values (1,2,1,30.00,2);
insert into AgendamentoServicos(IdAgendamento,IdServico,Quantidade,ValorUnitario,IdProfissional) values (2,1,1,50.00,2);
insert into AgendamentoServicos(IdAgendamento,IdServico,Quantidade,ValorUnitario,IdProfissional) values (3,3,1,10.00,2);
GO

USE [master]
GO
ALTER DATABASE [petshop] SET  READ_WRITE 
GO
