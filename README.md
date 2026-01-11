# Ders Kaydet 📚  
_Katmanlı Mimari ile ASP.NET MVC Öğrenme Projesi_

ders_kaydet, **katmanlı mimari (Layered Architecture)** yapısını öğrenmek ve uygulamak amacıyla geliştirilmiş örnek bir **ASP.NET MVC** projesidir.

Proje; ders, öğrenci, öğretmen ve başvuru formu gibi temel varlıkların **SQL Server** veritabanı üzerinden yönetilmesini hedefler.  
Amaç, **UI – Business – Data Access – Entity** katmanlarının birbirinden ayrıldığı sürdürülebilir bir mimariyi kavramaktır.

---

## 🧩 Teknik Mimari

ders_kaydet projesinin mimarisi aşağıdaki bileşenlerden oluşur:

| Katman                     | Teknoloji / Dil      | Sorumluluklar                                                         |
|----------------------------|----------------------|------------------------------------------------------------------------|
| **UI Katmanı**             | ASP.NET MVC          | Kullanıcı arayüzü, Controller ve View yapısı                           |
| **Business Logic Layer**   | C#                   | İş kuralları, validasyonlar, uygulama mantığı                          |
| **Data Access Layer**      | C#, Entity Framework | SQL Server ile veri okuma/yazma işlemleri                              |
| **Entity Layer**           | C#                   | Veritabanı tablolarını temsil eden entity sınıfları                    |
| **Veritabanı**             | SQL Server           | Kalıcı veri saklama                                                    |

---

## ✨ Özellikler

### 🎯 Katmanlı Mimari Yapısı
- UI, BLL, DAL ve Entity katmanlarının ayrımı  
- Katmanlar arası bağımlılığın azaltılması  
- Temiz ve sürdürülebilir proje yapısı  

### 🧱 Entity Tabanlı Veri Modeli
- Ders (EntityDers)  
- Öğrenci (EntityOgrenci)  
- Öğretmen (EntityOgretmen)  
- Başvuru Formu (EntityBasvuruForm)  

### 🔄 Veri Yönetimi
- SQL Server entegrasyonu  
- Temel CRUD (Create, Read, Update, Delete) işlemleri  
- Data Access Layer üzerinden kontrollü veri erişimi  

---

## ⚙️ Kurulum

### 1. Depoyu Klonla

    git clone https://github.com/Melikeacar/ders_kaydet.git
    cd ders_kaydet

---

### 2. Projeyi Aç

    WebApplication5.sln

dosyasını **Visual Studio** ile aç.

---

### 3. Veritabanı Ayarları

- SQL Server üzerinde gerekli veritabanını oluştur  
- `Web.config` veya ilgili DAL ayarlarından bağlantı cümlesini güncelle  

---

### 4. Uygulamayı Çalıştır

    Ctrl + F5

---

## 🧠 Çalışma Süreci

1. **Kullanıcı**, ASP.NET MVC arayüzü üzerinden işlem yapar  
2. **Controller**, isteği Business Logic Layer’a iletir  
3. **Business Logic Layer**, iş kurallarını uygular  
4. **Data Access Layer**, SQL Server ile iletişim kurar  
5. **Entity Layer**, veriyi nesne yapısı olarak taşır  
6. Sonuç, kullanıcıya View üzerinden gösterilir  

---

## 📦 Kullanılan Teknolojiler

### Backend
- C#  
- ASP.NET MVC  
- .NET Framework  

### Veritabanı
- SQL Server  

### Mimari
- Layered Architecture (N-Tier)  

---

## 📌 Notlar

- Bu proje **öğrenme amaçlıdır**
- Katmanlı mimari kavramını pekiştirmek için geliştirilmiştir
- Repository Pattern veya Service Pattern ile geliştirilmeye uygundur

---

## 👩‍💻 Geliştirici

**Melike Acar**  
Software & AI Enthusiast
