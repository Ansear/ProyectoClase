CREATE DATABASE proyectoclase;

USE proyectoclase;

CREATE TABLE `person_type` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `country` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `state` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `IdcountryFk` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_state_IdcountryFk` (`IdcountryFk`),
  CONSTRAINT `FK_state_country_IdcountryFk` FOREIGN KEY (`IdcountryFk`) REFERENCES `country` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `city` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `IdstateFk` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_city_IdstateFk` (`IdstateFk`),
  CONSTRAINT `FK_city_state_IdstateFk` FOREIGN KEY (`IdstateFk`) REFERENCES `state` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `customer` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `Idcustomer` varchar(255) NOT NULL,
  `IdTipoPersonaFk` int NOT NULL,
  `date_register` date NOT NULL,
  `IdcityFk` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_customer_IdcityFk` (`IdcityFk`),
  KEY `IX_customer_IdTipoPersonaFk` (`IdTipoPersonaFk`),
  CONSTRAINT UC_Customer UNIQUE (Idcustomer),
  CONSTRAINT `FK_customer_city_IdcityFk` FOREIGN KEY (`IdcityFk`) REFERENCES `city` (`Id`),
  CONSTRAINT `FK_customer_person_type_IdTipoPersonaFk` FOREIGN KEY (`IdTipoPersonaFk`) REFERENCES `person_type` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;