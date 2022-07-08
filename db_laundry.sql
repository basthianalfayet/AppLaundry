-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 08 Jul 2022 pada 22.42
-- Versi server: 10.4.13-MariaDB
-- Versi PHP: 7.2.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_laundry`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_jenis`
--

CREATE TABLE `tbl_jenis` (
  `IdJenis` int(11) NOT NULL,
  `NamaJenis` varchar(20) NOT NULL,
  `Harga` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_jenis`
--

INSERT INTO `tbl_jenis` (`IdJenis`, `NamaJenis`, `Harga`) VALUES
(1, 'Jeans', '7000'),
(2, 'Kemeja', '5000'),
(3, 'Jaket Kulit', '15000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `IdPelanggan` varchar(6) NOT NULL,
  `NamaPelanggan` varchar(25) DEFAULT NULL,
  `AlamatPelanggan` varchar(30) DEFAULT NULL,
  `TelpPelanggan` varchar(25) DEFAULT NULL,
  `KetPelanggan` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`IdPelanggan`, `NamaPelanggan`, `AlamatPelanggan`, `TelpPelanggan`, `KetPelanggan`) VALUES
('PLG001', 'aldo', 'jln a yani gg kurnia', '0728728782782782', 'di samping rumah rt'),
('PLG002', 'azral', 'pusong', '2987298729782', 'lewat kuala langsa'),
('PLG003', 'willy', 'dsn pahlawan', '08287376272', 'dekat rumah ibu rw');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_transaksi`
--

CREATE TABLE `tbl_transaksi` (
  `IdTransaksi` varchar(6) NOT NULL,
  `IdPelanggan` varchar(6) NOT NULL,
  `TotalItem` int(11) NOT NULL,
  `TotalHarga` int(11) NOT NULL,
  `Tunai` int(11) NOT NULL,
  `Kembalian` int(11) NOT NULL,
  `TanggalTransaksi` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_transaksi`
--

INSERT INTO `tbl_transaksi` (`IdTransaksi`, `IdPelanggan`, `TotalItem`, `TotalHarga`, `Tunai`, `Kembalian`, `TanggalTransaksi`) VALUES
('TRS003', 'PLG002', 3, 20000, 0, 0, '2022-07-07 22:46:18'),
('TRS004', 'PLG002', 4, 24000, 50000, 26000, '2022-07-09 01:57:58'),
('TRS005', 'PLG002', 5, 59000, 60000, 1000, '2022-07-09 02:14:26'),
('TRS006', 'PLG002', 5, 55000, 60000, 5000, '2022-07-09 02:18:15'),
('TRS007', 'PLG002', 17, 45000, 80000, 35000, '2022-07-09 02:19:34'),
('TRS008', 'PLG002', 17, 45000, 80000, 35000, '2022-07-09 02:19:50'),
('TRS009', 'PLG002', 0, 0, 0, 0, '2022-07-09 02:20:35'),
('TRS010', '', 0, 0, 0, 0, '2022-07-09 02:22:53');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_transaksi_item`
--

CREATE TABLE `tbl_transaksi_item` (
  `IdTransaksiItem` int(11) NOT NULL,
  `IdTransaksi` varchar(6) NOT NULL,
  `NamaJenis` varchar(20) NOT NULL,
  `Harga` int(11) NOT NULL,
  `Jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_transaksi_item`
--

INSERT INTO `tbl_transaksi_item` (`IdTransaksiItem`, `IdTransaksi`, `NamaJenis`, `Harga`, `Jumlah`) VALUES
(1, 'TRS001', '1', 7000, 2),
(2, 'TRS001', '2', 15000, 1),
(3, 'TRS005', '', 7000, 2),
(4, 'TRS005', '', 15000, 3),
(5, 'TRS006', '', 5000, 2),
(6, 'TRS006', '', 15000, 3),
(7, 'TRS007', 'Kemeja', 5000, 1),
(8, 'TRS007', 'Kemeja', 5000, 8),
(9, 'TRS008', 'Kemeja', 5000, 1),
(10, 'TRS008', 'Jaket Kulit', 15000, 8);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `IdUser` varchar(6) NOT NULL,
  `NamaUser` varchar(25) DEFAULT NULL,
  `PasswordUser` varchar(25) DEFAULT NULL,
  `LevelUser` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`IdUser`, `NamaUser`, `PasswordUser`, `LevelUser`) VALUES
('Basthi', '082277127462', 'Jln. A Yani', 'triplex123'),
('USR001', 'ADMIN', 'ADMIN', 'ADMIN'),
('USR002', 'USER', 'USER', 'USER'),
('USR003', 'DIA', 'DIA', 'ADMIN');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_jenis`
--
ALTER TABLE `tbl_jenis`
  ADD PRIMARY KEY (`IdJenis`);

--
-- Indeks untuk tabel `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`IdPelanggan`);

--
-- Indeks untuk tabel `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD PRIMARY KEY (`IdTransaksi`);

--
-- Indeks untuk tabel `tbl_transaksi_item`
--
ALTER TABLE `tbl_transaksi_item`
  ADD PRIMARY KEY (`IdTransaksiItem`);

--
-- Indeks untuk tabel `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`IdUser`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbl_jenis`
--
ALTER TABLE `tbl_jenis`
  MODIFY `IdJenis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `tbl_transaksi_item`
--
ALTER TABLE `tbl_transaksi_item`
  MODIFY `IdTransaksiItem` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
