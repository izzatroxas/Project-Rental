-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 17, 2019 at 08:41 PM
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
  `Kode_Kembali` varchar(20) NOT NULL,
  `Tanggal_Kembali` datetime NOT NULL,
  `Kode_Pinjam` varchar(20) NOT NULL,
  `Berita_Hilang` text NOT NULL,
  `Denda_Hilang` int(11) NOT NULL,
  `Berita_Rusak` text NOT NULL,
  `Denda_Rusak` int(11) NOT NULL,
  `Berita_Terlambat` text NOT NULL,
  `Denda_Terlambat` int(11) NOT NULL,
  `Total_Harga` int(11) NOT NULL,
  `Pelunasan` int(11) NOT NULL,
  `Kembali` int(11) NOT NULL,
  `Kode_User` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_labarugi`
--

CREATE TABLE `tbl_labarugi` (
  `Nomor` int(20) NOT NULL,
  `Tanggal` datetime NOT NULL,
  `Keterangan` text NOT NULL,
  `Pemasukan` int(11) NOT NULL,
  `Pengeluaran` int(11) NOT NULL,
  `Kode_User` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_mobil`
--

CREATE TABLE `tbl_mobil` (
  `Kode_Mobil` varchar(20) NOT NULL,
  `Nama_Mobil` text NOT NULL,
  `Tarif_Per_Jam` int(11) NOT NULL,
  `Tarif_Per_Hari` int(11) NOT NULL,
  `Tarif_Supir_Per_Jam` int(11) NOT NULL,
  `Tarif_SupIr_Per_Hari` int(11) NOT NULL,
  `Status_Mobil` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_mobil`
--

INSERT INTO `tbl_mobil` (`Kode_Mobil`, `Nama_Mobil`, `Tarif_Per_Jam`, `Tarif_Per_Hari`, `Tarif_Supir_Per_Jam`, `Tarif_SupIr_Per_Hari`, `Status_Mobil`) VALUES
('B 1234 ABC', 'Avanza', 24500, 280000, 14500, 295000, 'Ada'),
('B 2345 DEF', 'Xenia', 23500, 270000, 13500, 280000, 'Ada'),
('B 2547 BAA', 'Innova', 24000, 275000, 14000, 290000, 'Ada'),
('B 5897 GAP', 'Mercendez', 25000, 300000, 15000, 250000, 'Ada');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pinjam`
--

CREATE TABLE `tbl_pinjam` (
  `Kode_Pinjam` varchar(20) NOT NULL,
  `Tanggal_Pinjam` date NOT NULL,
  `KTP` text NOT NULL,
  `Nama_Customer` text NOT NULL,
  `Alamat` text NOT NULL,
  `Telp_HP` text NOT NULL,
  `Kartu_Keluarga` text NOT NULL,
  `Jenis_Pinjam` text NOT NULL,
  `Kode_Mobil` varchar(20) NOT NULL,
  `Kode_Supir` varchar(20) NOT NULL,
  `Rencara_Lama_Pinjam` int(11) NOT NULL,
  `Durasi` text NOT NULL,
  `Total_Biaya` int(11) NOT NULL,
  `Uang_Muka` int(11) NOT NULL,
  `Sisa` int(11) NOT NULL,
  `Tanggal_Berangkat` date NOT NULL,
  `Jam_Berangkat` time NOT NULL,
  `Status_Pinjam` text NOT NULL,
  `Kode_User` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pinjam`
--

INSERT INTO `tbl_pinjam` (`Kode_Pinjam`, `Tanggal_Pinjam`, `KTP`, `Nama_Customer`, `Alamat`, `Telp_HP`, `Kartu_Keluarga`, `Jenis_Pinjam`, `Kode_Mobil`, `Kode_Supir`, `Rencara_Lama_Pinjam`, `Durasi`, `Total_Biaya`, `Uang_Muka`, `Sisa`, `Tanggal_Berangkat`, `Jam_Berangkat`, `Status_Pinjam`, `Kode_User`) VALUES
('P0001', '2019-07-07', '1234567846', 'Udin Sedunia', 'Tambak', '0101010101', '3216498432', 'Sama Supir', 'B 5897 GAP', 'P0002', 4, 'Jam', 500000, 250000, 250000, '2019-07-07', '11:00:00', 'Booking', 111),
('P0002', '2019-07-16', '218045486450', 'KOCHENG', 'EAEAEA', '123456789', '2345678', 'Tanpa Supir', 'B 2547 BAA', 'P0001', 5, 'Hari', 100000, 25000, -75000, '2019-07-17', '18:00:00', 'Jalan', 1101171015);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supir`
--

CREATE TABLE `tbl_supir` (
  `Kode_Supir` varchar(20) NOT NULL,
  `Nama_Supir` text NOT NULL,
  `Alamat_Supir` text NOT NULL,
  `Telp_Supir` text NOT NULL,
  `Status_Supir` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_supir`
--

INSERT INTO `tbl_supir` (`Kode_Supir`, `Nama_Supir`, `Alamat_Supir`, `Telp_Supir`, `Status_Supir`) VALUES
('P0001', 'Izzat', 'Jakarta', '1101171015', 'Ada'),
('P0002', 'Udin', 'Tambak', '080808080', 'Ada');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `Kode_User` int(20) NOT NULL,
  `Nama_User` text NOT NULL,
  `Pwd_User` text NOT NULL,
  `Status_User` enum('Administrator','User','','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`Kode_User`, `Nama_User`, `Pwd_User`, `Status_User`) VALUES
(1, 'aaaa', 'bb', 'Administrator'),
(111, 'a', 'b', 'Administrator'),
(122447, 'roxas', 'zat', 'User'),
(123456, 'izzat', 'ayam', 'User'),
(1101171015, 'izzatroxas', 'zatzat', 'Administrator');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_detail`
--

CREATE TABLE `tbl_user_detail` (
  `Kode_User` int(20) NOT NULL,
  `Nama_User` text NOT NULL,
  `Status_User` enum('Administrator','User','','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user_detail`
--

INSERT INTO `tbl_user_detail` (`Kode_User`, `Nama_User`, `Status_User`) VALUES
(1101171015, 'izzatroxas', 'Administrator'),
(123456, 'izzat', 'User');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_kembali`
--
ALTER TABLE `tbl_kembali`
  ADD PRIMARY KEY (`Kode_Kembali`),
  ADD KEY `Kode_User` (`Kode_User`);

--
-- Indexes for table `tbl_labarugi`
--
ALTER TABLE `tbl_labarugi`
  ADD PRIMARY KEY (`Nomor`),
  ADD UNIQUE KEY `Kode_User` (`Kode_User`);

--
-- Indexes for table `tbl_mobil`
--
ALTER TABLE `tbl_mobil`
  ADD PRIMARY KEY (`Kode_Mobil`);

--
-- Indexes for table `tbl_pinjam`
--
ALTER TABLE `tbl_pinjam`
  ADD PRIMARY KEY (`Kode_Pinjam`),
  ADD KEY `Kode_Mobil` (`Kode_Mobil`),
  ADD KEY `Kode_Supir` (`Kode_Supir`),
  ADD KEY `Kode_User` (`Kode_User`);

--
-- Indexes for table `tbl_supir`
--
ALTER TABLE `tbl_supir`
  ADD PRIMARY KEY (`Kode_Supir`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`Kode_User`);

--
-- Indexes for table `tbl_user_detail`
--
ALTER TABLE `tbl_user_detail`
  ADD KEY `Kode_User` (`Kode_User`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `Kode_User` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1101171016;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_kembali`
--
ALTER TABLE `tbl_kembali`
  ADD CONSTRAINT `tbl_kembali_ibfk_1` FOREIGN KEY (`Kode_User`) REFERENCES `tbl_user` (`Kode_User`) ON UPDATE CASCADE;

--
-- Constraints for table `tbl_labarugi`
--
ALTER TABLE `tbl_labarugi`
  ADD CONSTRAINT `tbl_labarugi_ibfk_1` FOREIGN KEY (`Kode_User`) REFERENCES `tbl_user` (`Kode_User`) ON UPDATE CASCADE;

--
-- Constraints for table `tbl_pinjam`
--
ALTER TABLE `tbl_pinjam`
  ADD CONSTRAINT `tbl_pinjam_ibfk_1` FOREIGN KEY (`Kode_User`) REFERENCES `tbl_user` (`Kode_User`) ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_pinjam_ibfk_2` FOREIGN KEY (`Kode_Supir`) REFERENCES `tbl_supir` (`Kode_Supir`) ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_pinjam_ibfk_3` FOREIGN KEY (`Kode_Mobil`) REFERENCES `tbl_mobil` (`Kode_Mobil`) ON UPDATE CASCADE;

--
-- Constraints for table `tbl_user_detail`
--
ALTER TABLE `tbl_user_detail`
  ADD CONSTRAINT `tbl_user_detail_ibfk_1` FOREIGN KEY (`Kode_User`) REFERENCES `tbl_user` (`Kode_User`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
