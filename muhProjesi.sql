-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 18 Oca 2021, 21:08:44
-- Sunucu sürümü: 8.0.17
-- PHP Sürümü: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `mühprojesi`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `asidepobilgileri`
--

CREATE TABLE `asidepobilgileri` (
  `StokID` varchar(50) NOT NULL,
  `YetkiliTC` varchar(11) NOT NULL,
  `StokAdedi` varchar(50) NOT NULL,
  `EklemeTarihi` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `asidepobilgileri`
--

INSERT INTO `asidepobilgileri` (`StokID`, `YetkiliTC`, `StokAdedi`, `EklemeTarihi`) VALUES
('1000', '66611111111', '3', '2022-01-23'),
('1000000', '66611111111', '100', '2011-11-18'),
('1111', '66611111111', '100', '2010-10-01'),
('33', '77711111111', '10', '2020-12-20'),
('55', '66611111111', '2', '2021-03-02'),
('77', '77711111111', '10', '2010-10-20'),
('9', '77711111111', '20', '2012-12-12');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `asidepoyetkilibilgileri`
--

CREATE TABLE `asidepoyetkilibilgileri` (
  `TC` varchar(11) NOT NULL,
  `Şifre` varchar(50) NOT NULL,
  `AdSoyad` varchar(80) NOT NULL,
  `BulunduğuİşMevki` varchar(50) NOT NULL,
  `Hatirlatici Isaret` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `asidepoyetkilibilgileri`
--

INSERT INTO `asidepoyetkilibilgileri` (`TC`, `Şifre`, `AdSoyad`, `BulunduğuİşMevki`, `Hatirlatici Isaret`) VALUES
('66611111111', 'deneme0', 'Pınar İpek', 'Depo Sorumlu Müdür', 'ipucu1'),
('77711111111', 'boşluk0', 'Cengiz Kılıç', 'Depo Sorumlu Müdür Yardımcısı', 'spacetuşu');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `doktorbilgileri`
--

CREATE TABLE `doktorbilgileri` (
  `TC` varchar(11) NOT NULL,
  `Şifre` varchar(50) NOT NULL,
  `AdSoyad` varchar(50) NOT NULL,
  `Hatirlatici Isaret` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `doktorbilgileri`
--

INSERT INTO `doktorbilgileri` (`TC`, `Şifre`, `AdSoyad`, `Hatirlatici Isaret`) VALUES
('33111111111', 'şifre1', 'Başak Altın', 'denedur'),
('44111111155', 'deneme12345', 'Sena Kalemoğlu', 'kedimtekir'),
('99111111111', 'yeni1', 'Barış Cengiz', 'beypazarı');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hastabilgileri`
--

CREATE TABLE `hastabilgileri` (
  `TC` varchar(11) NOT NULL,
  `AdSoyad` varchar(50) NOT NULL,
  `Adres` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Yas` varchar(3) NOT NULL,
  `Meslek` varchar(50) NOT NULL,
  `AsilanmaTarihi` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `hastabilgileri`
--

INSERT INTO `hastabilgileri` (`TC`, `AdSoyad`, `Adres`, `Yas`, `Meslek`, `AsilanmaTarihi`) VALUES
('12345345633', 'fff', 'fff', '44', 'fff', '2021-01-21'),
('15345234235', 'ee', 'e', '1', 'e', '12.12.1212'),
('21211111111', 'Sıla Genç', 'Ankara Mahallesi Ankara Sokak No:0 Ankara', '22', 'Öğrenci', '2021-01-27'),
('32111111111', 'Seçil Kadıköy', 'Kadıköy Mahallesi Kadıköy Sokak Kadıköy/Ankara', '38', 'Genel Müdür', '2021-01-26'),
('61111111111', 'Betül Kırlangıç', 'Maltepe Mahallesi Maltepe Sokak No:0 Çankaya/Ankara', '22', 'E ticaret Uzmanı', '2021-01-20');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `asidepobilgileri`
--
ALTER TABLE `asidepobilgileri`
  ADD PRIMARY KEY (`StokID`);

--
-- Tablo için indeksler `asidepoyetkilibilgileri`
--
ALTER TABLE `asidepoyetkilibilgileri`
  ADD PRIMARY KEY (`TC`);

--
-- Tablo için indeksler `doktorbilgileri`
--
ALTER TABLE `doktorbilgileri`
  ADD PRIMARY KEY (`TC`);

--
-- Tablo için indeksler `hastabilgileri`
--
ALTER TABLE `hastabilgileri`
  ADD PRIMARY KEY (`TC`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
