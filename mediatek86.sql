-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 18 avr. 2025 à 09:47
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

--
-- Script complet de la base de données "mediatek86" exploitée par l'application "MediaTek86"
--
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

-- ----------------------------
-- Création de l'utilisateur
-- ----------------------------
CREATE USER IF NOT EXISTS 'mediatek86user'@'%' IDENTIFIED BY 'theuserofmediatek86';
GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, DROP, RELOAD, SHUTDOWN, PROCESS, FILE, REFERENCES, INDEX, ALTER, SHOW DATABASES, SUPER, CREATE TEMPORARY TABLES, LOCK TABLES, EXECUTE, REPLICATION SLAVE, REPLICATION CLIENT, CREATE VIEW, SHOW VIEW, CREATE ROUTINE, ALTER ROUTINE, CREATE USER, EVENT, TRIGGER, CREATE TABLESPACE, CREATE ROLE, DROP ROLE ON *.* TO `mediatek86user`@`%` WITH GRANT OPTION;
GRANT ALLOW_NONEXISTENT_DEFINER,APPLICATION_PASSWORD_ADMIN,AUDIT_ABORT_EXEMPT,AUDIT_ADMIN,AUTHENTICATION_POLICY_ADMIN,BACKUP_ADMIN,BINLOG_ADMIN,BINLOG_ENCRYPTION_ADMIN,CLONE_ADMIN,CONNECTION_ADMIN,ENCRYPTION_KEY_ADMIN,FIREWALL_EXEMPT,FLUSH_OPTIMIZER_COSTS,FLUSH_STATUS,FLUSH_TABLES,FLUSH_USER_RESOURCES,GROUP_REPLICATION_ADMIN,GROUP_REPLICATION_STREAM,INNODB_REDO_LOG_ARCHIVE,INNODB_REDO_LOG_ENABLE,PASSWORDLESS_USER_ADMIN,PERSIST_RO_VARIABLES_ADMIN,REPLICATION_APPLIER,REPLICATION_SLAVE_ADMIN,RESOURCE_GROUP_ADMIN,RESOURCE_GROUP_USER,ROLE_ADMIN,SENSITIVE_VARIABLES_OBSERVER,SERVICE_CONNECTION_ADMIN,SESSION_VARIABLES_ADMIN,SET_ANY_DEFINER,SHOW_ROUTINE,SYSTEM_USER,SYSTEM_VARIABLES_ADMIN,TABLE_ENCRYPTION_ADMIN,TELEMETRY_LOG_ADMIN,TRANSACTION_GTID_TAG,XA_RECOVER_ADMIN ON *.* TO `mediatek86user`@`%` WITH GRANT OPTION;
GRANT ALL PRIVILEGES ON `mediatek86`.* TO `mediatek86user`@`%`;

--
-- Base de données : `mediatek86`
--
CREATE DATABASE IF NOT EXISTS `mediatek86` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `mediatek86`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(3, '2024-01-10 00:00:00', '2024-01-15 00:00:00', 1),
(7, '2024-03-02 00:00:00', '2024-03-04 00:00:00', 2),
(1, '2024-04-05 00:00:00', '2024-04-07 00:00:00', 3),
(6, '2024-05-12 00:00:00', '2024-05-18 00:00:00', 1),
(8, '2024-06-01 00:00:00', '2024-06-10 00:00:00', 4),
(2, '2024-07-15 00:00:00', '2024-07-20 00:00:00', 2),
(4, '2025-04-03 00:00:00', '2025-04-17 00:00:00', 3),
(5, '2024-09-25 00:00:00', '2024-09-30 00:00:00', 3),
(10, '2024-10-10 00:00:00', '2024-10-17 00:00:00', 1),
(9, '2024-11-01 00:00:00', '2024-11-05 00:00:00', 2),
(1, '2024-12-20 00:00:00', '2024-12-27 00:00:00', 1),
(3, '2024-02-14 00:00:00', '2024-02-16 00:00:00', 3),
(6, '2024-03-10 00:00:00', '2024-03-13 00:00:00', 2),
(2, '2024-04-01 00:00:00', '2024-04-03 00:00:00', 4),
(5, '2024-05-07 00:00:00', '2024-05-09 00:00:00', 1),
(8, '2024-06-20 00:00:00', '2024-06-25 00:00:00', 3),
(10, '2024-07-12 00:00:00', '2024-07-19 00:00:00', 2),
(4, '2025-10-01 00:00:00', '2025-10-15 00:00:00', 1),
(7, '2024-09-05 00:00:00', '2024-09-08 00:00:00', 4),
(1, '2024-10-21 00:00:00', '2024-10-25 00:00:00', 3),
(2, '2024-11-11 00:00:00', '2024-11-15 00:00:00', 1),
(9, '2024-12-01 00:00:00', '2024-12-05 00:00:00', 2),
(3, '2025-01-03 00:00:00', '2025-01-06 00:00:00', 1),
(6, '2025-02-10 00:00:00', '2025-02-13 00:00:00', 4),
(8, '2025-03-19 00:00:00', '2025-03-26 00:00:00', 2),
(10, '2025-04-01 00:00:00', '2025-04-04 00:00:00', 3),
(5, '2025-05-05 00:00:00', '2025-05-10 00:00:00', 1),
(7, '2025-06-11 00:00:00', '2025-06-14 00:00:00', 4),
(4, '2025-07-08 00:00:00', '2025-07-15 00:00:00', 2),
(9, '2025-08-03 00:00:00', '2025-08-10 00:00:00', 3),
(1, '2025-09-12 00:00:00', '2025-09-15 00:00:00', 1),
(2, '2025-10-01 00:00:00', '2025-10-05 00:00:00', 2),
(3, '2025-11-10 00:00:00', '2025-11-13 00:00:00', 4),
(6, '2025-12-15 00:00:00', '2025-12-18 00:00:00', 1),
(5, '2024-01-20 00:00:00', '2024-01-24 00:00:00', 3),
(8, '2024-02-05 00:00:00', '2024-02-10 00:00:00', 2),
(7, '2024-03-18 00:00:00', '2024-03-22 00:00:00', 1),
(10, '2024-04-27 00:00:00', '2024-05-03 00:00:00', 4),
(9, '2024-06-15 00:00:00', '2024-06-20 00:00:00', 2),
(2, '2024-07-01 00:00:00', '2024-07-04 00:00:00', 1),
(4, '2025-07-27 00:00:00', '2025-08-02 00:00:00', 1),
(6, '2024-09-30 00:00:00', '2024-10-04 00:00:00', 2),
(3, '2024-11-12 00:00:00', '2024-11-15 00:00:00', 1),
(5, '2024-12-18 00:00:00', '2024-12-22 00:00:00', 3),
(1, '2025-01-14 00:00:00', '2025-01-18 00:00:00', 2),
(8, '2025-02-28 00:00:00', '2025-03-05 00:00:00', 1),
(9, '2025-04-10 00:00:00', '2025-04-15 00:00:00', 4),
(7, '2025-05-20 00:00:00', '2025-05-24 00:00:00', 2),
(10, '2025-06-05 00:00:00', '2025-06-10 00:00:00', 3),
(4, '2025-06-05 00:00:00', '2025-06-14 00:00:00', 4);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Durand', 'Alice', '0612345678', 'alice.durand@example.com', 1),
(2, 'Martin', 'Lucas', '0623456789', 'lucas.martin@example.com', 2),
(3, 'Lemoine', 'Chloé', '0634567890', 'chloe.lemoine@example.com', 3),
(4, 'Petit', 'Nathan', '0645678901', 'nathan.petit@example.com', 1),
(5, 'Moreau', 'Emma', '0656789012', 'emma.moreau@example.com', 2),
(6, 'Garcia', 'Leo', '0667890123', 'leo.garcia@example.com', 3),
(7, 'Faure', 'Jade', '0678901234', 'jade.faure@example.com', 1),
(8, 'Roux', 'Tom', '0689012345', 'tom.roux@example.com', 2),
(9, 'Blanc', 'Inès', '0690123456', 'ines.blanc@example.com', 3),
(10, 'Bernard', 'Axel', '0601234567', 'axel.bernard@example.com', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('userresponsable', 'b0c22bbc0b826a639f86e1e48043fa10f9a1b7b732d29c3344a63f1d7d349da9');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
