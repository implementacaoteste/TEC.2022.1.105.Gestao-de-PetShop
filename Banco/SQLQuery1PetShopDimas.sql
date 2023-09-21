USE [master]
GO
/****** Object:  Database [DimasTestepetshop]    Script Date: 16/09/2023 16:42:22 ******/
CREATE DATABASE [DimasTestepetshop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DimasTestepetshop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DimasTestepetshop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DimasTestepetshop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DimasTestepetshop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DimasTestepetshop] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DimasTestepetshop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DimasTestepetshop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET ARITHABORT OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DimasTestepetshop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DimasTestepetshop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DimasTestepetshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DimasTestepetshop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DimasTestepetshop] SET  MULTI_USER 
GO
ALTER DATABASE [DimasTestepetshop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DimasTestepetshop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DimasTestepetshop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DimasTestepetshop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DimasTestepetshop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DimasTestepetshop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DimasTestepetshop] SET QUERY_STORE = OFF
GO
USE [DimasTestepetshop]
GO
/****** Object:  Table [dbo].[AgendamentoServicos]    Script Date: 16/09/2023 16:42:23 ******/
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
	[ValorUnitario] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servico]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  View [dbo].[View_ServicosAgendamento]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  Table [dbo].[Agendamento]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  Table [dbo].[Animal]    Script Date: 16/09/2023 16:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdRaca] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Agressivo] [char](1) NOT NULL,
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  Table [dbo].[EmailCliente]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  Table [dbo].[EmailProfissional]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  Table [dbo].[Funcao]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  Table [dbo].[FuncaoPermissao]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  Table [dbo].[Permissao]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  Table [dbo].[Profissional]    Script Date: 16/09/2023 16:42:23 ******/
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
/****** Object:  Table [dbo].[Raca]    Script Date: 16/09/2023 16:42:24 ******/
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
/****** Object:  Table [dbo].[Situacao]    Script Date: 16/09/2023 16:42:24 ******/
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
/****** Object:  Table [dbo].[TelefoneCliente]    Script Date: 16/09/2023 16:42:24 ******/
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
/****** Object:  Table [dbo].[TelefoneProfissional]    Script Date: 16/09/2023 16:42:24 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 16/09/2023 16:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProfissional] [int] NOT NULL,
	[UsuarioLogin] [varchar](15) NOT NULL,
	[Senha] [varchar](15) NOT NULL,
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
ALTER TABLE [dbo].[AgendamentoServicos]  WITH CHECK ADD FOREIGN KEY([IdProfissional])
REFERENCES [dbo].[Profissional] ([Id])
GO
ALTER TABLE [dbo].[Agendamento]  WITH CHECK ADD FOREIGN KEY([IdSituacao])
REFERENCES [dbo].[Situacao] ([Id])
GO
ALTER TABLE [dbo].[AgendamentoServicos]  WITH CHECK ADD FOREIGN KEY([IdAgendamento])
REFERENCES [dbo].[Agendamento] ([Id])
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

USE [master]
GO
ALTER DATABASE [DimasTestepetshop] SET  READ_WRITE 
GO
