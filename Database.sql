DROP DATABASE IF EXISTS `calendarClasses`;

CREATE DATABASE `calendarClasses` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `calendarClasses`;

CREATE TABLE `Teachers` (
  `idTeacher` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phoneNbr` varchar(30) NOT NULL,
  PRIMARY KEY (`idTeacher`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `Classes` (
  `idClass` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `description` text NOT NULL,
  `idTeacher` int(11) NOT NULL,
  PRIMARY KEY (`idClass`),
  KEY `Teachers_Classes_idx` (`idTeacher`),
  CONSTRAINT `Teachers_Classes` FOREIGN KEY (`idTeacher`) REFERENCES `Teachers` (`idTeacher`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `Rooms` (
  `idRoom` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `capacity` int(11) NOT NULL,
  PRIMARY KEY (`idRoom`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `Schedules` (
  `idSchedule` int(11) NOT NULL AUTO_INCREMENT,
  `weekDay` enum('Lundi','Mardi','Mercredi','Jeudi','Vendredi') NOT NULL,
  `startHour` time NOT NULL,
  `endHour` time NOT NULL,
  `idRoom` int(11) NOT NULL,
  `idClass` int(11) NOT NULL,
  PRIMARY KEY (`idSchedule`),
  KEY `Rooms_Schedules_idx` (`idRoom`),
  KEY `Classes_Schedules_idx` (`idClass`),
  CONSTRAINT `Classes_Schedules` FOREIGN KEY (`idClass`) REFERENCES `Classes` (`idClass`),
  CONSTRAINT `Rooms_Schedules` FOREIGN KEY (`idRoom`) REFERENCES `Rooms` (`idRoom`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;