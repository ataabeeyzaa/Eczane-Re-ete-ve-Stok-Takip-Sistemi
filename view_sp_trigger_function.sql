USE EczaneTakipDB;
GO

CREATE OR ALTER VIEW vw_ReceteDetaylari AS
SELECT 
    r.recete_no,
    r.recete_tarihi,
    h.ad AS hasta_ad,
    h.soyad AS hasta_soyad,
    d.ad AS doktor_ad,
    d.soyad AS doktor_soyad,
    i.ilac_adi,
    rd.adet,
    rd.kullanim_talimati
FROM dbo.Recete r
JOIN dbo.Hasta h ON r.hasta_id = h.hasta_id
JOIN dbo.Doktor d ON r.doktor_id = d.doktor_id
JOIN dbo.ReceteDetay rd ON r.recete_id = rd.recete_id
JOIN dbo.Ilac i ON rd.ilac_id = i.ilac_id;
GO

CREATE OR ALTER VIEW vw_KritikStokIlaclar AS
SELECT 
    ilac_id,
    ilac_adi,
    kategori,
    stok_miktari,
    kritik_stok
FROM dbo.Ilac
WHERE stok_miktari <= kritik_stok;
GO

CREATE OR ALTER PROCEDURE sp_KritikStoktakiIlaclar
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ilac_id, ilac_adi, stok_miktari, kritik_stok
    FROM dbo.Ilac
    WHERE stok_miktari <= kritik_stok;
END;
GO

CREATE OR ALTER PROCEDURE sp_HastaReceteleri
    @hasta_id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        r.recete_id,
        r.recete_no,
        r.recete_tarihi
    FROM dbo.Recete r
    WHERE r.hasta_id = @hasta_id
    ORDER BY r.recete_tarihi DESC;
END;
GO

CREATE OR ALTER TRIGGER trg_ReceteDetay_StokKontrol
ON dbo.ReceteDetay
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM dbo.Ilac i
        INNER JOIN inserted ins ON i.ilac_id = ins.ilac_id
        WHERE i.stok_miktari < ins.adet
    )
    BEGIN
        RAISERROR ('Yetersiz stok nedeniyle islem gerceklestirilemedi.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    UPDATE i
    SET i.stok_miktari = i.stok_miktari - ins.adet
    FROM dbo.Ilac i
    INNER JOIN inserted ins ON i.ilac_id = ins.ilac_id;
END;
GO

CREATE OR ALTER FUNCTION fn_StokDurumu (@ilac_id INT)
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @sonuc VARCHAR(20);

    SELECT @sonuc =
        CASE
            WHEN stok_miktari <= kritik_stok THEN 'Kritik'
            ELSE 'Normal'
        END
    FROM dbo.Ilac
    WHERE ilac_id = @ilac_id;

    RETURN @sonuc;
END;
GO

CREATE OR ALTER FUNCTION fn_ReceteToplamIlac (@recete_id INT)
RETURNS INT
AS
BEGIN
    DECLARE @toplam INT;

    SELECT @toplam = SUM(adet)
    FROM dbo.ReceteDetay
    WHERE recete_id = @recete_id;

    RETURN ISNULL(@toplam, 0);
END;
GO
-----------
CREATE OR ALTER PROCEDURE sp_HastalariListele
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        hasta_id,
        tc_no,
        ad,
        soyad,
        telefon,
        dogum_tarihi
    FROM dbo.Hasta
    ORDER BY hasta_id;
END;
GO

CREATE OR ALTER PROCEDURE sp_ReceteDetayGetir
    @recete_id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        rd.recete_detay_id,
        i.ilac_adi,
        rd.adet,
        rd.kullanim_talimati
    FROM dbo.ReceteDetay rd
    JOIN dbo.Ilac i ON rd.ilac_id = i.ilac_id
    WHERE rd.recete_id = @recete_id;
END;
GO

CREATE OR ALTER PROCEDURE sp_IlacStokGuncelle
    @ilac_id INT,
    @yeni_stok INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @yeni_stok < 0
    BEGIN
        RAISERROR('Stok miktari negatif olamaz.', 16, 1);
        RETURN;
    END

    UPDATE dbo.Ilac
    SET stok_miktari = @yeni_stok
    WHERE ilac_id = @ilac_id;
END;
GO

CREATE OR ALTER PROCEDURE sp_KullaniciGiris
    @kullanici_adi VARCHAR(50),
    @sifre VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        kullanici_id,
        kullanici_adi,
        rol
    FROM dbo.Kullanici
    WHERE kullanici_adi = @kullanici_adi
      AND sifre = @sifre;
END;
GO

--------
USE EczaneTakipDB;
GO

CREATE OR ALTER PROCEDURE sp_KullaniciGiris
    @kullanici_adi VARCHAR(50),
    @sifre VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        kullanici_id,
        kullanici_adi,
        rol
    FROM dbo.Kullanici
    WHERE kullanici_adi = @kullanici_adi
      AND sifre = @sifre;
END;
GO
-----------
USE EczaneTakipDB;
GO

CREATE OR ALTER PROCEDURE sp_HastalariListele
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        hasta_id,
        tc_no,
        ad,
        soyad,
        telefon,
        dogum_tarihi
    FROM dbo.Hasta
    ORDER BY hasta_id;
END;
GO

----------