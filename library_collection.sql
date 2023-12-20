-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 20, 2023 at 06:04 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `library_collection`
--

CREATE TABLE `library_collection` (
  `id_library_collection` int(11) NOT NULL,
  `edition` int(11) NOT NULL,
  `placement` int(11) NOT NULL,
  `copy_count` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `library_collection`
--

INSERT INTO `library_collection` (`id_library_collection`, `edition`, `placement`, `copy_count`) VALUES
(1, 1, 1, 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `library_collection`
--
ALTER TABLE `library_collection`
  ADD PRIMARY KEY (`id_library_collection`),
  ADD KEY `placement_idx` (`placement`),
  ADD KEY `fk_edition_idx` (`edition`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `library_collection`
--
ALTER TABLE `library_collection`
  MODIFY `id_library_collection` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `library_collection`
--
ALTER TABLE `library_collection`
  ADD CONSTRAINT `fk_edition` FOREIGN KEY (`edition`) REFERENCES `edition` (`id_edition`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_placement` FOREIGN KEY (`placement`) REFERENCES `placement` (`id_placement`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
