-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 10-Nov-2021 às 23:24
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 7.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `localcars`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `contato`
--

CREATE TABLE `contato` (
  `Id` int(4) NOT NULL,
  `nome` varchar(200) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `mensagem` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `contato`
--

INSERT INTO `contato` (`Id`, `nome`, `email`, `mensagem`) VALUES
(1, 'Pedro', 'pedro@uol.com', 'Tem um Volkswagen Bettle?'),
(2, 'João', 'joao.sp@terra.com', 'Que horas a loja abre?'),
(3, 'Maria', 'msd.sc@terra.com', 'Qual o preço do Golf?'),
(4, 'Pedro', 'pedro@uol.com', 'Que horas a loja abre?'),
(5, 'Pedro', 'pedro@uol.com', 'Tem um Volkswagen Bettle?'),
(6, 'Pedro', 'pedro@uol.com', 'Que horas a loja abre?'),
(7, 'Pedro', 'pedro@uol.com', 'Qual o preço do Golf?'),
(8, 'Marcio', 'marcio@dpl7.com.br', 'Que horas a loja abre?'),
(9, 'Pedro', 'pedro@uol.com', 'Qual o preço do Golf?'),
(10, 'Maria', 'msd.sc@terra.com', 'asdf'),
(11, 'Pedro', 'pedro@uol.com', 'Tem um Volkswagen Bettle?');

-- --------------------------------------------------------

--
-- Estrutura da tabela `testdrive`
--

CREATE TABLE `testdrive` (
  `Id` int(4) NOT NULL,
  `nome` varchar(200) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `tel` int(30) DEFAULT NULL,
  `horas` int(30) DEFAULT NULL,
  `data` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `testdrive`
--

INSERT INTO `testdrive` (`Id`, `nome`, `email`, `tel`, `horas`, `data`) VALUES
(1, 'Pedro', 'pedro@uol.com', 991111111, 0, '2021-11-02'),
(2, 'Marcio', 'marcio@dpl7.com.br', 0, 0, '0001-01-01'),
(3, 'Pedro', 'pedro@uol.com', 991111111, 0, '2021-11-13');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `contato`
--
ALTER TABLE `contato`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `testdrive`
--
ALTER TABLE `testdrive`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `contato`
--
ALTER TABLE `contato`
  MODIFY `Id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `testdrive`
--
ALTER TABLE `testdrive`
  MODIFY `Id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
