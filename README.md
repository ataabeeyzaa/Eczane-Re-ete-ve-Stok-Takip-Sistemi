# 💊 Eczane Reçete ve Stok Takip Sistemi

Eczanelerde **hasta, doktor, reçete, ilaç ve stok** bilgilerinin düzenli ve güvenli bir şekilde yönetilmesi amacıyla geliştirilmiş bir **Masaüstü (Windows Forms) ve Veritabanı (MSSQL)** projesidir. Sistem; reçete işlemlerini kolaylaştırmayı, ilaç stoklarını izlemeyi ve kritik seviyedeki ürünleri hızlıca tespit etmeyi amaçlar.

## 🎯 Proje Amacı

Eczanelerde bilgilerin manuel ya da dağınık tutulması; kayıt karışıklığına, zaman kaybına ve işlem hatalarına yol açabilmektedir. Bu proje ile tüm bu veriler tek bir sistem altında toplanarak daha **planlı, güvenli ve erişilebilir** bir yapı oluşturulmuştur.

## ✨ Temel Özellikler

  - 🔐 **Kullanıcı Yetkilendirmesi:** Sınırlı yetkiye sahip kullanıcı girişi (Login ekranı).
  - 👤 **Hasta Yönetimi:** Sistemdeki hastaları ve geçmişlerini listeleme.
  - 📄 **Reçete İşlemleri:** Hastaya ait reçeteleri görüntüleme ve reçete detaylarına ulaşma.
  - ⚠️ **Kritik Stok Takibi:** Azalan ilaçları tespit edip "Kritik Stok" ekranında listeleme.
  - 📦 **Stok Güncelleme:** İlaç stoklarını manuel ve otomatik (Trigger ile) güncelleme.
  - 🗄️ **Güvenli Veri İşlemleri:** Tüm CRUD işlemleri tablo sorguları yerine `Stored Procedure` mimarisi ile sağlanır.

## 🛠️ Kullanılan Teknolojiler

**Arayüz (Frontend):** C\# Windows Forms  
**Veritabanı (Backend):** Microsoft SQL Server & T-SQL

-----

## 🧱 Veritabanı Mimarisi

Proje, veri tekrarını azaltmak ve bütünlüğü sağlamak amacıyla **3NF (Third Normal Form)** seviyesine uygun olarak tasarlanmıştır. Veritabanı şemasında `Primary Key`, `Foreign Key`, `UNIQUE`, `NOT NULL` ve `CHECK` kısıtlamaları (constraints) aktif olarak kullanılmıştır.

### ⚙️ SQL Bileşenleri

| Bileşen Tipi | İsimlendirme | Görevi |
| :--- | :--- | :--- |
| **View** | `vw_ReceteDetaylari`<br>`vw_KritikStokIlaclar` | Karmaşık sorguları basitleştirme ve raporlama. |
| **Stored Procedure** | `sp_KritikStoktakiIlaclar`<br>`sp_HastaReceteleri`<br>`sp_HastalariListele`<br>`sp_ReceteDetayGetir`<br>`sp_IlacStokGuncelle`<br>`sp_KullaniciGiris` | İş mantığını veritabanı katmanında yürütme, performansı artırma. |
| **Trigger** | `trg_ReceteDetay_StokKontrol` | Reçeteye ilaç eklendiğinde stoğu otomatik düşme / kontrol etme. |
| **Function** | `fn_StokDurumu`<br>`fn_ReceteToplamIlac` | Özelleştirilmiş hesaplama ve durum kontrolleri sağlama. |

### 📊 Örnek Veri Dağılımı

Proje testleri için toplam **5260** satırlık örnek veri (Mock Data) kullanılmıştır:

> **Hasta:** 700 | **Doktor:** 40 | **Tedarikçi:** 20 | **İlaç:** 300 | **Reçete:** 1400 | **Reçete Detay:** 2800

-----

## 🔒 Güvenlik Yaklaşımı

Projede temel güvenlik önlemleri veritabanı seviyesinde alınmıştır:

  - Sistem bağlantısı `sa` (System Admin) kullanıcısı yerine, **sadece bu veritabanında yetkili** kısıtlı bir kullanıcı (Login/User) ile sağlanmıştır.
  - Tüm veritabanı işlemleri **Stored Procedure** ve **Parametreli Sorgular** üzerinden geçirilerek *SQL Injection* riskleri minimize edilmiştir.

-----

## 🚀 Kurulum

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **SQL Server** üzerinde yeni bir veritabanı oluşturun.
2.  Proje dizinindeki SQL scriptlerini sırasıyla çalıştırın:
      - Önce `tables.sql` (Tabloları oluşturur)
      - Ardından `view_sp_trigger_function.sql` (Mantıksal bileşenleri ekler)
      - Son olarak `data.sql` ve `dml.sql` (Örnek verileri ekler)
3.  **Visual Studio** üzerinden `EczaneTakipApp` (C\# Windows Forms) projesini açın.
4.  `App.config` veya bağlantı sınıfı (Connection String) içerisindeki sunucu (Server) adını kendi SQL Server bilginize göre düzenleyin.
5.  Projeyi derleyip (**Start**) çalıştırın.

-----

## 📂 Proje Dizin Yapısı

```text
📦 Eczane_Otomasyonu
 ┣ 📂 EczaneTakipApp/          # C# Windows Forms kaynak kodları
 ┣ 📜 tables.sql               # Tablo (DDL) oluşturma scriptleri
 ┣ 📜 view_sp_trigger_function.sql # Gelişmiş veritabanı nesneleri
 ┣ 📜 data.sql                 # Örnek veri setleri
 ┣ 📜 dml.sql                  # INSERT, UPDATE, DELETE örnek sorguları
 ┗ 📜 README.md                # Proje dokümantasyonu
```

-----

## 📎 Proje Kısıtları (Limitations)

  - Sistem, yerel ağda (Masaüstü ortamında) çalışacak şekilde tasarlanmıştır.
  - Rol bazlı gelişmiş (Admin/Personel/Muhasebe) yetkilendirme sistemi projeye dahil edilmemiştir.
  - Gerçek eczane / SGK entegrasyonu (Medula vb.) içermez, test ve akademik/öğrenme amaçlıdır.

-----

## 👩‍💻 Geliştirici

**Beyza ATA** 🎓 Kastamonu Üniversitesi  
🏢 Mühendislik ve Mimarlık Fakültesi - Bilgisayar Mühendisliği
