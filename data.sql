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

-----------------------------
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
-----------
INSERT INTO dbo.Kullanici (kullanici_adi, sifre, rol)
VALUES ('admin', '1234', 'Yonetici');
GO





