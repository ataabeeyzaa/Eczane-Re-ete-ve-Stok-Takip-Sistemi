USE EczaneTakipDB;
GO

IF OBJECT_ID('dbo.Adlar', 'U') IS NOT NULL DROP TABLE dbo.Adlar;
IF OBJECT_ID('dbo.Soyadlar', 'U') IS NOT NULL DROP TABLE dbo.Soyadlar;
IF OBJECT_ID('dbo.Uzmanliklar', 'U') IS NOT NULL DROP TABLE dbo.Uzmanliklar;
IF OBJECT_ID('dbo.Firmalar', 'U') IS NOT NULL DROP TABLE dbo.Firmalar;
IF OBJECT_ID('dbo.Kategoriler', 'U') IS NOT NULL DROP TABLE dbo.Kategoriler;
GO

CREATE TABLE dbo.Adlar (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ad VARCHAR(50) NOT NULL
);

CREATE TABLE dbo.Soyadlar (
    id INT IDENTITY(1,1) PRIMARY KEY,
    soyad VARCHAR(50) NOT NULL
);

CREATE TABLE dbo.Uzmanliklar (
    id INT IDENTITY(1,1) PRIMARY KEY,
    uzmanlik VARCHAR(100) NOT NULL
);

CREATE TABLE dbo.Firmalar (
    id INT IDENTITY(1,1) PRIMARY KEY,
    firma_adi VARCHAR(100) NOT NULL
);

CREATE TABLE dbo.Kategoriler (
    id INT IDENTITY(1,1) PRIMARY KEY,
    kategori VARCHAR(50) NOT NULL
);
GO

INSERT INTO dbo.Adlar (ad) VALUES
('Ahmet'), ('Mehmet'), ('Ayse'), ('Fatma'), ('Ali'), ('Zeynep'), ('Mustafa'), ('Emine'),
('Hasan'), ('Hatice'), ('Huseyin'), ('Elif'), ('Ibrahim'), ('Merve'), ('Osman'), ('Esra'),
('Yusuf'), ('Buse'), ('Murat'), ('Selin'), ('Burak'), ('Ceren'), ('Can'), ('Ece'),
('Onur'), ('Gamze'), ('Kerem'), ('Derya'), ('Omer'), ('Seda'), ('Serkan'), ('Nazli'),
('Tolga'), ('Pelin'), ('Ugur'), ('Asli'), ('Kaan'), ('Gizem'), ('Tugba'), ('Baris');
GO

INSERT INTO dbo.Soyadlar (soyad) VALUES
('Yilmaz'), ('Kaya'), ('Demir'), ('Sahin'), ('Celik'), ('Yildiz'), ('Aydin'), ('Arslan'),
('Dogan'), ('Kilic'), ('Aslan'), ('Cetin'), ('Kara'), ('Koc'), ('Kurt'), ('Ozdemir'),
('Simsek'), ('Polat'), ('Erdem'), ('Aksoy'), ('Tas'), ('Bulut'), ('Avci'), ('Kaplan'),
('Tekin'), ('Ergin'), ('Gunes'), ('Bozkurt'), ('Sezer'), ('Altintas'), ('Acar'), ('Guler'),
('Karaca'), ('Turan'), ('Akin'), ('Eren'), ('Unal'), ('Sari'), ('Coskun'), ('Karaman');
GO

INSERT INTO dbo.Uzmanliklar (uzmanlik) VALUES
('Dahiliye'), ('Cocuk Hastaliklari'), ('Kardiyoloji'), ('Noroloji'), ('Kulak Burun Bogaz'),
('Goz Hastaliklari'), ('Dermatoloji'), ('Ortopedi'), ('Aile Hekimligi'), ('Genel Cerrahi');
GO

INSERT INTO dbo.Firmalar (firma_adi) VALUES
('ABC Ilac'), ('Anadolu Pharma'), ('Marmara Medikal'), ('Saglik Deposu'),
('Ege Ilac Dagitim'), ('Nova Farma'), ('Vita Ilac'), ('Sifa Medikal'),
('Bereket Pharma'), ('Guven Ilac'), ('Atlas Medikal'), ('Huzur Pharma'),
('Derman Ilac'), ('Lokman Dagitim'), ('Merkez Medikal'), ('Pusula Pharma'),
('Yasam Ilac'), ('Cinar Medikal'), ('Akdeniz Pharma'), ('Yildiz Ilac');
GO

INSERT INTO dbo.Kategoriler (kategori) VALUES
('Agri Kesici'), ('Antibiyotik'), ('Vitamin'), ('Soguk Alginligi'),
('Mide Ilaci'), ('Alerji'), ('Kas Gevsetici'), ('Cilt Bakimi'),
('Tansiyon'), ('Diyabet');
GO