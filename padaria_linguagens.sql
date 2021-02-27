-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.17-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Copiando estrutura para tabela padaria_linguagens.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `cpf` varchar(14) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `endereco` varchar(99) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela padaria_linguagens.clientes: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
REPLACE INTO `clientes` (`cpf`, `nome`, `endereco`, `telefone`) VALUES
	('127.008.970-64', 'Gabriel Barbosa', 'Rua Maracanã', '3822-9999'),
	('253.854.171-90', 'Maria Joaquina', 'Rua Bartolomeu', '9999-5234'),
	('531.936.866-62', 'Helena Santos', 'Rua Sorocaba', '7777-7777'),
	('601.355.198-70', 'Julesca Santos', 'Rua Batman', '1234-4567'),
	('628.012.933-00', 'Josualdo Silva', 'Rua Batman', '9555-4521'),
	('725.758.484-23', 'Cirilo Paiva', 'Rua Dois', '8888-8888');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Copiando estrutura para procedure padaria_linguagens.deletaCliente
DELIMITER //
CREATE PROCEDURE `deletaCliente`(cpfRem varchar(15))
BEGIN
DELETE FROM `padaria_linguagens`.`clientes`
    WHERE cpf = cpfRem;
COMMIT;

END//
DELIMITER ;

-- Copiando estrutura para procedure padaria_linguagens.insereCliente
DELIMITER //
CREATE PROCEDURE `insereCliente`(cpf varchar(15), nome varchar(45), endereco varchar(99), telefone varchar(15))
BEGIN
INSERT INTO `padaria_linguagens`.`clientes`
(`cpf`,
`nome`,
`endereco`,
`telefone`)
VALUES
(cpf,
nome,
endereco,
telefone);

END//
DELIMITER ;

-- Copiando estrutura para procedure padaria_linguagens.listaClientes
DELIMITER //
CREATE PROCEDURE `listaClientes`()
BEGIN
select * from clientes;
END//
DELIMITER ;

-- Copiando estrutura para procedure padaria_linguagens.updateCliente
DELIMITER //
CREATE PROCEDURE `updateCliente`(nome varchar(45), endereco varchar(99), telefone varchar(15), id varchar(15))
BEGIN
UPDATE `padaria_linguagens`.`clientes`
SET

`nome` = nome,
`endereco` = endereco,
`telefone` = telefone
WHERE `cpf` = id;

END//
DELIMITER ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
