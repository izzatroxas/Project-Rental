-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 03, 2019 at 05:14 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project_rental`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_kembali`
--

CREATE TABLE `tbl_kembali` (
  `Kode_Kembali` text NOT NULL,
  `Tanggal_Kembali` datetime NOT NULL,
  `Kode_Pinjam` text NOT NULL,
  `Berita_Hilang` text NOT NULL,
  `Denda_Hilang` int(11) NOT NULL,
  `Berita_Rusak` text NOT NULL,
  `Denda_Rusak` int(11) NOT NULL,
  `Berita_Terlambat` text NOT NULL,
  `Denda_Terlambat` int(11) NOT NULL,
  `Total_Harga` int(11) NOT NULL,
  `Pelunasan` int(11) NOT NULL,
  `Kembali` int(11) NOT NULL,
  `Kode_User` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_labarugi`
--

CREATE TABLE `tbl_labarugi` (
  `Nomor` text NOT NULL,
  `Tanggal` datetime NOT NULL,
  `Keterangan` text NOT NULL,
  `Pemasukan` int(11) NOT NULL,
  `Pengeluaran` int(11) NOT NULL,
  `Kode_User` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_mobil`
--

CREATE TABLE `tbl_mobil` (
  `Kode_Mobil` text NOT NULL,
  `Nama_Mobil` text NOT NULL,
  `Tarif_Per_Jam` int(11) NOT NULL,
  `Tarif_Per_Hari` int(11) NOT NULL,
  `Tarif_Supir_Per_Jam` int(11) NOT NULL,
  `Tarif_Super_Per_Hari` int(11) NOT NULL,
  `Status_Mobil` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pinjam`
--

CREATE TABLE `tbl_pinjam` (
  `Kode_Pinjam` text NOT NULL,
  `Tanggal_Pinjam` date NOT NULL,
  `KTP` text NOT NULL,
  `Nama_Customer` text NOT NULL,
  `Alamat` text NOT NULL,
  `Telp_HP` text NOT NULL,
  `Kartu_Keluarga` text NOT NULL,
  `Kode_Mobil` text NOT NULL,
  `Kode_Supir` text NOT NULL,
  `Rencara_Lama_Pinjam` int(11) NOT NULL,
  `Durasi` text NOT NULL,
  `Total_Biaya` int(11) NOT NULL,
  `Uang_Muka` int(11) NOT NULL,
  `Sisa` int(11) NOT NULL,
  `Tanggal_Berangkat` date NOT NULL,
  `Jam_Berangkat` time NOT NULL,
  `Status_Pinjam` text NOT NULL,
  `Kode_User` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supir`
--

CREATE TABLE `tbl_supir` (
  `Kode_Supir` text NOT NULL,
  `Nama_Supir` text NOT NULL,
  `Alamat_Supir` text NOT NULL,
  `Telp_Supir` text NOT NULL,
  `Status_Supir` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `Kode_User` int(11) NOT NULL,
  `Nama_User` text NOT NULL,
  `Pwd_User` text NOT NULL,
  `Status_User` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`Kode_User`, `Nama_User`, `Pwd_User`, `Status_User`) VALUES
(123, 'asd', 'zx', 'ADMINISTRATOR'),
(12345, 'a', 'b', 'ADMINISTRATOR'),
(1101171015, 'izzat', 'ayam', 'ADMINISTRATOR');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_detail`
--

CREATE TABLE `tbl_user_detail` (
  `Kode_User` text NOT NULL,
  `Nama_User` varchar(25) NOT NULL,
  `Status_User` enum('ADMINISTRATOR','USER') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user_detail`
--

INSERT INTO `tbl_user_detail` (`Kode_User`, `Nama_User`, `Status_User`) VALUES
('1101171015', 'Admin', 'ADMINISTRATOR'),
('08980696872', 'user', 'USER');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_kembali`
--
ALTER TABLE `tbl_kembali`
  ADD PRIMARY KEY (`Kode_Kembali`(20)),
  ADD KEY `Kode_User` (`Kode_User`(20));

--
-- Indexes for table `tbl_labarugi`
--
ALTER TABLE `tbl_labarugi`
  ADD PRIMARY KEY (`Nomor`(20)),
  ADD KEY `Kode_User` (`Kode_User`(20));

--
-- Indexes for table `tbl_mobil`
--
ALTER TABLE `tbl_mobil`
  ADD PRIMARY KEY (`Kode_Mobil`(20));

--
-- Indexes for table `tbl_pinjam`
--
ALTER TABLE `tbl_pinjam`
  ADD PRIMARY KEY (`Kode_Pinjam`(20)),
  ADD KEY `Kode_Mobil` (`Kode_Mobil`(20)),
  ADD KEY `Kode_Supir` (`Kode_Supir`(20)),
  ADD KEY `Kode_User` (`Kode_User`(20)) USING BTREE;

--
-- Indexes for table `tbl_supir`
--
ALTER TABLE `tbl_supir`
  ADD PRIMARY KEY (`Kode_Supir`(20));

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`Kode_User`);

--
-- Indexes for table `tbl_user_detail`
--
ALTER TABLE `tbl_user_detail`
  ADD KEY `Status_User` (`Status_User`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `Kode_User` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1101171016;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
