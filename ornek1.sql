USE master;
GO

CREATE LOGIN EczaneAppLogin
WITH PASSWORD = 'EczaneApp123!';
GO

USE EczaneTakipDB;
GO

CREATE USER EczaneAppUser FOR LOGIN EczaneAppLogin;
GO

GRANT EXECUTE ON OBJECT::dbo.sp_HastalariListele TO EczaneAppUser;
GRANT EXECUTE ON OBJECT::dbo.sp_HastaReceteleri TO EczaneAppUser;
GRANT EXECUTE ON OBJECT::dbo.sp_ReceteDetayGetir TO EczaneAppUser;
GRANT EXECUTE ON OBJECT::dbo.sp_KritikStoktakiIlaclar TO EczaneAppUser;
GRANT EXECUTE ON OBJECT::dbo.sp_IlacStokGuncelle TO EczaneAppUser;
GRANT EXECUTE ON OBJECT::dbo.sp_KullaniciGiris TO EczaneAppUser;
GO

DELETE FROM dbo.Kullanici;
DBCC CHECKIDENT ('dbo.Kullanici', RESEED, 0);

DELETE FROM dbo.Kullanici;
DBCC CHECKIDENT ('dbo.Kullanici', RESEED, 0);