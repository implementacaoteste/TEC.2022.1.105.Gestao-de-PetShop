USE [master]
GO
/****** Object:  Database [petshop]    Script Date: 06/07/2023 20:35:05 ******/

IF EXISTS(SELECT 1 FROM SYSDATABASES WHERE NAME = 'PETSHOP')
	DROP DATABASE petshop
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
/****** Object:  Table [dbo].[Agendamento]    Script Date: 06/07/2023 20:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agendamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Data] [date] NOT NULL,
	[Horario] [time](7) NOT NULL,
	[Situacao] [varchar](15) NOT NULL,
	[IdAnimal] [int] NOT NULL,
	[Total] [numeric](5, 2) NOT NULL,
	[IdProfissional] [int] NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AgendamentoServicos]    Script Date: 06/07/2023 20:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgendamentoServicos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAgendamento] [int] NOT NULL,
	[IdServico] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 06/07/2023 20:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Agressivo] [char](1) NOT NULL,
	[Cor] [varchar](25) NOT NULL,
	[Idade] [int] NOT NULL,
	[Alergia] [varchar](50) NULL,
	[IdCliente] [int] NOT NULL,
	[IdRaca] [int] NOT NULL,
	[Foto] [image] NULL,
	[DataNascimento] [varchar](10) NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 06/07/2023 20:35:05 ******/
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
/****** Object:  Table [dbo].[EmailCliente]    Script Date: 06/07/2023 20:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailCliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[IdCliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailProfissional]    Script Date: 06/07/2023 20:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailProfissional](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[IdProfissional] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcao]    Script Date: 06/07/2023 20:35:05 ******/
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
/****** Object:  Table [dbo].[FuncaoPermissao]    Script Date: 06/07/2023 20:35:05 ******/
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
/****** Object:  Table [dbo].[Permissao]    Script Date: 06/07/2023 20:35:05 ******/
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
/****** Object:  Table [dbo].[Profissional]    Script Date: 06/07/2023 20:35:05 ******/
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
/****** Object:  Table [dbo].[Raca]    Script Date: 06/07/2023 20:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
    [Especie] [varchar](50) NOT NULL,
	[PaisOrigem] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servico]    Script Date: 06/07/2023 20:35:05 ******/
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
/****** Object:  Table [dbo].[TelefoneCliente]    Script Date: 06/07/2023 20:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefoneCliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Telefone] [varchar](15) NOT NULL,
	[IdCliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelefoneProfissional]    Script Date: 06/07/2023 20:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefoneProfissional](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Telefone] [varchar](15) NOT NULL,
	[IdProfissional] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/07/2023 20:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](15) NOT NULL,
	[Senha] [varchar](15) NOT NULL,
	[IdProfissional] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Agendamento] ADD  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[Agendamento]  WITH CHECK ADD FOREIGN KEY([IdAnimal])
REFERENCES [dbo].[Animal] ([Id])
GO
ALTER TABLE [dbo].[Agendamento]  WITH CHECK ADD FOREIGN KEY([IdProfissional])
REFERENCES [dbo].[Profissional] ([Id])
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
USE [master]
GO
ALTER DATABASE [petshop] SET  READ_WRITE 
GO
