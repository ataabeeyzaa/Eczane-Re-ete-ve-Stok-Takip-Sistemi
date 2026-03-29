USE EczaneTakipDB;
GO

CREATE TABLE Hasta (
    hasta_id INT IDENTITY(1,1) PRIMARY KEY,
    tc_no CHAR(11) NOT NULL UNIQUE,
    ad VARCHAR(50) NOT NULL,
    soyad VARCHAR(50) NOT NULL,
    telefon VARCHAR(15),
    dogum_tarihi DATE
);

CREATE TABLE Doktor (
    doktor_id INT IDENTITY(1,1) PRIMARY KEY,
    ad VARCHAR(50) NOT NULL,
    soyad VARCHAR(50) NOT NULL,
    uzmanlik VARCHAR(100),
    telefon VARCHAR(15)
);

CREATE TABLE Tedarikci (
    tedarikci_id INT IDENTITY(1,1) PRIMARY KEY,
    firma_adi VARCHAR(100) NOT NULL,
    telefon VARCHAR(15),
    adres VARCHAR(255)
);

CREATE TABLE Ilac (
    ilac_id INT IDENTITY(1,1) PRIMARY KEY,
    barkod VARCHAR(30) NOT NULL UNIQUE,
    ilac_adi VARCHAR(100) NOT NULL,
    kategori VARCHAR(50),
    birim_fiyat DECIMAL(10,2) NOT NULL CHECK (birim_fiyat >= 0),
    stok_miktari INT NOT NULL CHECK (stok_miktari >= 0),
    kritik_stok INT NOT NULL CHECK (kritik_stok >= 0),
    son_kullanma_tarihi DATE NOT NULL,
    tedarikci_id INT,
    FOREIGN KEY (tedarikci_id) REFERENCES Tedarikci(tedarikci_id)
);

CREATE TABLE Recete (
    recete_id INT IDENTITY(1,1) PRIMARY KEY,
    recete_no VARCHAR(30) NOT NULL UNIQUE,
    recete_tarihi DATE NOT NULL,
    hasta_id INT NOT NULL,
    doktor_id INT NOT NULL,
    FOREIGN KEY (hasta_id) REFERENCES Hasta(hasta_id),
    FOREIGN KEY (doktor_id) REFERENCES Doktor(doktor_id)
);

CREATE TABLE ReceteDetay (
    recete_detay_id INT IDENTITY(1,1) PRIMARY KEY,
    recete_id INT NOT NULL,
    ilac_id INT NOT NULL,
    adet INT NOT NULL CHECK (adet > 0),
    kullanim_talimati VARCHAR(255),
    FOREIGN KEY (recete_id) REFERENCES Recete(recete_id),
    FOREIGN KEY (ilac_id) REFERENCES Ilac(ilac_id)
);
GO

--------
CREATE TABLE dbo.Kullanici (
    kullanici_id INT IDENTITY(1,1) PRIMARY KEY,
    kullanici_adi VARCHAR(50) NOT NULL UNIQUE,
    sifre VARCHAR(50) NOT NULL,
    rol VARCHAR(30) NOT NULL
);
GO