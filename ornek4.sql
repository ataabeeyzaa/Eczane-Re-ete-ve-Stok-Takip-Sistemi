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



SELECT 
    t.firma_adi,
    SUM(i.stok_miktari) AS toplam_stok
FROM dbo.Tedarikci t
LEFT JOIN dbo.Ilac i ON t.tedarikci_id = i.tedarikci_id
GROUP BY t.firma_adi
ORDER BY toplam_stok DESC;