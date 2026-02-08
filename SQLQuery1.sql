-- Veri Tabaný Oluþturma
--CREATE DATABASE HastaneRandevuSistemi;
--USE HastaneRandevuSistemi

---- Hastalar Tablosu
--CREATE TABLE Hastalar (
--    HastaID INT PRIMARY KEY AUTO_INCREMENT,
--    Ad VARCHAR(50) NOT NULL,
--    Soyad VARCHAR(50) NOT NULL,
--    TCKimlikNo CHAR(11) UNIQUE NOT NULL,
--    TelefonNo VARCHAR(15),
--    Adres TEXT,
--    DogumTarihi DATE,
--    Email VARCHAR(100)
--);

---- Doktorlar Tablosu
--CREATE TABLE Doktorlar (
--    DoktorID INT PRIMARY KEY AUTO_INCREMENT,
--    Ad VARCHAR(50) NOT NULL,
--    Soyad VARCHAR(50) NOT NULL,
--    UzmanlikAlani VARCHAR(100) NOT NULL,
--    TelefonNo VARCHAR(15),
--    Email VARCHAR(100)
--);

---- Randevular Tablosu
--CREATE TABLE Randevular (
--    RandevuID INT PRIMARY KEY AUTO_INCREMENT,
--    HastaID INT NOT NULL,
--    DoktorID INT NOT NULL,
--    RandevuTarihi DATETIME NOT NULL,
--    RandevuDurumu ENUM('Tamamlandý', 'Ýptal Edildi', 'Bekliyor') DEFAULT 'Bekliyor',
--    FOREIGN KEY (HastaID) REFERENCES Hastalar(HastaID) ON DELETE CASCADE,
--    FOREIGN KEY (DoktorID) REFERENCES Doktorlar(DoktorID) ON DELETE CASCADE
--);

---- Tetkikler Tablosu
--CREATE TABLE Tetkikler (
--    TetkikID INT PRIMARY KEY AUTO_INCREMENT,
--    TetkikAdi VARCHAR(100) NOT NULL,
--    TetkikAciklama TEXT,
--    TetkikTarihi DATETIME NOT NULL,
--    HastaID INT NOT NULL,
--    DoktorID INT,
--    FOREIGN KEY (HastaID) REFERENCES Hastalar(HastaID) ON DELETE CASCADE,
--    FOREIGN KEY (DoktorID) REFERENCES Doktorlar(DoktorID) ON DELETE SET NULL
--);

---- Tetkik Sonuçlarý Tablosu
--CREATE TABLE TetkikSonuclari (
--    SonucID INT PRIMARY KEY AUTO_INCREMENT,
--    TetkikID INT NOT NULL,
--    Sonuc TEXT NOT NULL,
--    SonucTarihi DATETIME NOT NULL,
--    FOREIGN KEY (TetkikID) REFERENCES Tetkikler(TetkikID) ON DELETE CASCADE
--);

---- Bölümler Tablosu
--CREATE TABLE Bolumler (
--    BolumID INT PRIMARY KEY AUTO_INCREMENT,
--    BolumAdi VARCHAR(100) NOT NULL,
--    BolumAciklama TEXT
--);

---- Doktor Bölümleri Tablosu
--CREATE TABLE DoktorBolumleri (
--    DoktorBolumID INT PRIMARY KEY AUTO_INCREMENT,
--    DoktorID INT NOT NULL,
--    BolumID INT NOT NULL,
--    FOREIGN KEY (DoktorID) REFERENCES Doktorlar(DoktorID) ON DELETE CASCADE,
--    FOREIGN KEY (BolumID) REFERENCES Bolumler(BolumID) ON DELETE CASCADE
--);

