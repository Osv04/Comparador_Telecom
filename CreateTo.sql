USE [master]
GO

/****** Object:  Database [ProyectoArquictectura]    Script Date: 25-Oct-21 9:32:26 PM ******/
CREATE DATABASE [ProyectoArquictectura]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoArquictectura', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProyectoArquictectura.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoArquictectura_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProyectoArquictectura_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoArquictectura].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ProyectoArquictectura] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET ARITHABORT OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ProyectoArquictectura] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ProyectoArquictectura] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ProyectoArquictectura] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ProyectoArquictectura] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET RECOVERY FULL 
GO

ALTER DATABASE [ProyectoArquictectura] SET  MULTI_USER 
GO

ALTER DATABASE [ProyectoArquictectura] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ProyectoArquictectura] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ProyectoArquictectura] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ProyectoArquictectura] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ProyectoArquictectura] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ProyectoArquictectura] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ProyectoArquictectura] SET  READ_WRITE 
GO

