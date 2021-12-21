-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jan 28, 2020 at 06:35 PM
-- Server version: 5.7.26
-- PHP Version: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hungryme`
--

-- --------------------------------------------------------

--
-- Table structure for table `customeraccounts`
--

DROP TABLE IF EXISTS `customeraccounts`;
CREATE TABLE IF NOT EXISTS `customeraccounts` (
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `ReEnterPassword` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `MobileNo` int(10) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `mycart`
--

DROP TABLE IF EXISTS `mycart`;
CREATE TABLE IF NOT EXISTS `mycart` (
  `ID` varchar(20) NOT NULL,
  `Meal` varchar(20) NOT NULL,
  `Price` varchar(20) NOT NULL,
  `Quantity` varchar(20) NOT NULL,
  `Total` varchar(20) NOT NULL,
  `Status` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
