USE EczaneTakipDB;
GO

DELETE FROM dbo.ReceteDetay;
DELETE FROM dbo.Recete;
DELETE FROM dbo.Ilac;
DELETE FROM dbo.Tedarikci;
DELETE FROM dbo.Doktor;
DELETE FROM dbo.Hasta;
GO

DBCC CHECKIDENT ('dbo.ReceteDetay', RESEED, 0);
DBCC CHECKIDENT ('dbo.Recete', RESEED, 0);
DBCC CHECKIDENT ('dbo.Ilac', RESEED, 0);
DBCC CHECKIDENT ('dbo.Tedarikci', RESEED, 0);
DBCC CHECKIDENT ('dbo.Doktor', RESEED, 0);
DBCC CHECKIDENT ('dbo.Hasta', RESEED, 0);
GO

;WITH Sayilar AS (
    SELECT TOP (700)
        ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS n
    FROM sys.all_objects a
    CROSS JOIN sys.all_objects b
)
INSERT INTO dbo.Hasta (tc_no, ad, soyad, telefon, dogum_tarihi)
SELECT
    RIGHT('10000000000' + CAST(n AS VARCHAR(11)), 11) AS tc_no,
    a.ad,
    s.soyad,
    '05' + RIGHT('000000000' + CAST(500000000 + n AS VARCHAR(9)), 9) AS telefon,
    DATEADD(DAY, -(n * 7 % 12000), '2005-01-01') AS dogum_tarihi
FROM Sayilar sn
JOIN dbo.Adlar a
    ON a.id = ((sn.n - 1) % (SELECT COUNT(*) FROM dbo.Adlar)) + 1
JOIN dbo.Soyadlar s
    ON s.id = (((sn.n - 1) / (SELECT COUNT(*) FROM dbo.Adlar)) % (SELECT COUNT(*) FROM dbo.Soyadlar)) + 1;
GO

;WITH Sayilar AS (
    SELECT TOP (40)
        ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS n
    FROM sys.all_objects
)
INSERT INTO dbo.Doktor (ad, soyad, uzmanlik, telefon)
SELECT
    a.ad,
    s.soyad,
    u.uzmanlik,
    '053' + RIGHT('0000000' + CAST(1000000 + n AS VARCHAR(7)), 7) AS telefon
FROM Sayilar sn
JOIN dbo.Adlar a
    ON a.id = ((sn.n - 1) % (SELECT COUNT(*) FROM dbo.Adlar)) + 1
JOIN dbo.Soyadlar s
    ON s.id = (((sn.n + 5) - 1) % (SELECT COUNT(*) FROM dbo.Soyadlar)) + 1
JOIN dbo.Uzmanliklar u
    ON u.id = ((sn.n - 1) % (SELECT COUNT(*) FROM dbo.Uzmanliklar)) + 1;
GO

INSERT INTO dbo.Tedarikci (firma_adi, telefon, adres)
SELECT
    firma_adi,
    '0212' + RIGHT('0000000' + CAST(2000000 + id AS VARCHAR(7)), 7),
    CASE 
        WHEN id % 5 = 1 THEN 'Istanbul'
        WHEN id % 5 = 2 THEN 'Ankara'
        WHEN id % 5 = 3 THEN 'Izmir'
        WHEN id % 5 = 4 THEN 'Bursa'
        ELSE 'Antalya'
    END
FROM dbo.Firmalar;
GO

;WITH Sayilar AS (
    SELECT TOP (300)
        ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS n
    FROM sys.all_objects a
    CROSS JOIN sys.all_objects b
)
INSERT INTO dbo.Ilac (
    barkod,
    ilac_adi,
    kategori,
    birim_fiyat,
    stok_miktari,
    kritik_stok,
    son_kullanma_tarihi,
    tedarikci_id
)
SELECT
    '869' + RIGHT('000000000' + CAST(n AS VARCHAR(9)), 9) AS barkod,
    k.kategori + ' Ilac ' + CAST(n AS VARCHAR(10)) AS ilac_adi,
    k.kategori,
    CAST(20 + (n % 180) + ((n % 7) * 0.5) AS DECIMAL(10,2)) AS birim_fiyat,
    30 + (n % 220) AS stok_miktari,
    10 + (n % 25) AS kritik_stok,
    DATEADD(DAY, 365 + (n % 900), CAST('2026-01-01' AS DATE)) AS son_kullanma_tarihi,
    ((n - 1) % 20) + 1 AS tedarikci_id
FROM Sayilar sn
JOIN dbo.Kategoriler k
    ON k.id = ((sn.n - 1) % (SELECT COUNT(*) FROM dbo.Kategoriler)) + 1;
GO



;WITH ReceteDagilimi AS (
    SELECT h.hasta_id, 1 AS recete_adedi
    FROM dbo.Hasta h
    WHERE h.hasta_id BETWEEN 1 AND 250

    UNION ALL

    SELECT h.hasta_id, 2 AS recete_adedi
    FROM dbo.Hasta h
    WHERE h.hasta_id BETWEEN 251 AND 500

    UNION ALL

    SELECT h.hasta_id, 3 AS recete_adedi
    FROM dbo.Hasta h
    WHERE h.hasta_id BETWEEN 501 AND 650

    UNION ALL

    SELECT h.hasta_id, 4 AS recete_adedi
    FROM dbo.Hasta h
    WHERE h.hasta_id BETWEEN 651 AND 700
),
Genisletilmis AS (
    SELECT 
        d.hasta_id,
        v.n
    FROM ReceteDagilimi d
    JOIN (VALUES (1), (2), (3), (4)) v(n)
        ON v.n <= d.recete_adedi
),
Numarali AS (
    SELECT 
        ROW_NUMBER() OVER (ORDER BY hasta_id, n) AS rn,
        hasta_id
    FROM Genisletilmis
)
INSERT INTO dbo.Recete (recete_no, recete_tarihi, hasta_id, doktor_id)
SELECT
    'RCP' + RIGHT('000000' + CAST(rn AS VARCHAR(6)), 6) AS recete_no,
    DATEADD(DAY, -(rn % 365), CAST('2026-03-20' AS DATE)) AS recete_tarihi,
    hasta_id,
    ((rn - 1) % 40) + 1 AS doktor_id
FROM Numarali;
GO

;WITH Sayilar AS (
    SELECT TOP (2800)
        ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS n
    FROM sys.all_objects a
    CROSS JOIN sys.all_objects b
)
INSERT INTO dbo.ReceteDetay (recete_id, ilac_id, adet, kullanim_talimati)
SELECT
    ((n - 1) % 1400) + 1 AS recete_id,
    ((n - 1) % 300) + 1 AS ilac_id,
    (n % 3) + 1 AS adet,
    CASE 
        WHEN n % 4 = 0 THEN 'Gunde 1 kez'
        WHEN n % 4 = 1 THEN 'Gunde 2 kez'
        WHEN n % 4 = 2 THEN 'Sabah aksam'
        ELSE 'Tok karnina'
    END AS kullanim_talimati
FROM Sayilar;
GO

INSERT INTO dbo.Kullanici (kullanici_adi, sifre, rol)
VALUES ('admin', '1234', 'Yonetici');
GO

UPDATE dbo.Ilac
SET stok_miktari = 250
WHERE ilac_id = 1;
GO

DELETE FROM dbo.ReceteDetay
WHERE recete_detay_id = 1;
GO

SELECT 'Hasta' AS tablo, COUNT(*) AS kayit_sayisi FROM dbo.Hasta
UNION ALL
SELECT 'Doktor', COUNT(*) FROM dbo.Doktor
UNION ALL
SELECT 'Tedarikci', COUNT(*) FROM dbo.Tedarikci
UNION ALL
SELECT 'Ilac', COUNT(*) FROM dbo.Ilac
UNION ALL
SELECT 'Recete', COUNT(*) FROM dbo.Recete
UNION ALL
SELECT 'ReceteDetay', COUNT(*) FROM dbo.ReceteDetay;
GO