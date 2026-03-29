USE EczaneTakipDB;
GO

-- Tüm hastalarý listeleme
SELECT * 
FROM dbo.Hasta;

-- Kritik stok seviyesindeki ilaçlarý listeleme
SELECT ilac_adi, stok_miktari, kritik_stok
FROM dbo.Ilac
WHERE stok_miktari <= kritik_stok;

-- Belirli kategoriye ait ilaçlarý görüntüleme
SELECT ilac_adi, kategori, birim_fiyat
FROM dbo.Ilac
WHERE kategori = 'Antibiyotik';

-- Reçeteleri tarihe göre sýralama
SELECT recete_no, recete_tarihi
FROM dbo.Recete
ORDER BY recete_tarihi DESC;

-- Reçete, hasta, doktor ve ilaç bilgilerini birlikte listeleme
SELECT 
    r.recete_no,
    r.recete_tarihi,
    h.ad AS hasta_ad,
    h.soyad AS hasta_soyad,
    d.ad AS doktor_ad,
    d.soyad AS doktor_soyad,
    i.ilac_adi,
    rd.adet
FROM dbo.Recete r
JOIN dbo.Hasta h ON r.hasta_id = h.hasta_id
JOIN dbo.Doktor d ON r.doktor_id = d.doktor_id
JOIN dbo.ReceteDetay rd ON r.recete_id = rd.recete_id
JOIN dbo.Ilac i ON rd.ilac_id = i.ilac_id;

-- Her doktora ait reçete sayýsýný bulma
SELECT 
    d.ad,
    d.soyad,
    COUNT(r.recete_id) AS recete_sayisi
FROM dbo.Doktor d
LEFT JOIN dbo.Recete r ON d.doktor_id = r.doktor_id
GROUP BY d.ad, d.soyad
ORDER BY recete_sayisi DESC;

-- Her hastaya ait toplam ilaç adedini bulma
SELECT 
    h.hasta_id,
    h.ad,
    h.soyad,
    SUM(rd.adet) AS toplam_ilac_adedi
FROM dbo.Hasta h
JOIN dbo.Recete r ON h.hasta_id = r.hasta_id
JOIN dbo.ReceteDetay rd ON r.recete_id = rd.recete_id
GROUP BY h.hasta_id, h.ad, h.soyad
ORDER BY toplam_ilac_adedi DESC;

-- Ortalama ilaç fiyatýnýn üstündeki ilaçlarý listeleme
SELECT ilac_adi, birim_fiyat
FROM dbo.Ilac
WHERE birim_fiyat > (
    SELECT AVG(birim_fiyat)
    FROM dbo.Ilac
);

-- Her tedarikçiye ait toplam stok miktarýný bulma
SELECT 
    t.firma_adi,
    SUM(i.stok_miktari) AS toplam_stok
FROM dbo.Tedarikci t
LEFT JOIN dbo.Ilac i ON t.tedarikci_id = i.tedarikci_id
GROUP BY t.firma_adi
ORDER BY toplam_stok DESC;

-- En çok kullanýlan ilaçlarý bulma
SELECT 
    i.ilac_adi,
    SUM(rd.adet) AS toplam_kullanim
FROM dbo.ReceteDetay rd
JOIN dbo.Ilac i ON rd.ilac_id = i.ilac_id
GROUP BY i.ilac_adi
ORDER BY toplam_kullanim DESC;

-- Son kullanma tarihi en yakýn olan ilaçlarý listeleme
SELECT ilac_adi, son_kullanma_tarihi
FROM dbo.Ilac
ORDER BY son_kullanma_tarihi ASC;