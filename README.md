# Hastane Randevu Sistemi

## 📋 Proje Açıklaması

**Hastane Randevu Sistemi**, C# Windows Forms ile geliştirilmiş masaüstü tabanlı bir hastane yönetim ve randevu takip uygulamasıdır. Bu sistem, hastane personelinin hasta kayıtlarını, doktor bilgilerini ve randevuları verimli bir şekilde yönetmesini sağlar.

## 🎯 Temel Özellikler

### 1. **Kullanıcı Yönetimi**
- Güvenli giriş sistemi (Form1.cs)
- Kullanıcı kimlik doğrulama
- Oturum yönetimi (Session.cs, session2.cs)

### 2. **Doktor Yönetimi** (doktorislem.cs)
- Doktor kayıt, güncelleme ve silme işlemleri
- Doktor bilgilerini listeleme
- Branş/uzmanlık alanlarına göre filtreleme
- Doktor arama ve sorgulama

### 3. **Hasta Yönetimi** (hastaislem.cs)
- Hasta kayıt sistemi
- Hasta bilgilerini güncelleme
- Hasta geçmişi ve kayıtları görüntüleme
- Hasta bilgilerini arama ve filtreleme

### 4. **Randevu Sistemi** (newform1.cs)
- Yeni randevu oluşturma
- Mevcut randevuları görüntüleme
- Randevu güncelleme ve iptal etme
- Doktor ve hasta bazlı randevu takibi
- Tarih ve saat yönetimi

## 🛠️ Teknik Altyapı

### Teknolojiler
- **Dil:** C# (100%)
- **Framework:** .NET Framework
- **UI:** Windows Forms
- **Veritabanı:** SQL Server (LocalDB)
- **Veri Erişimi:** ADO.NET, Typed DataSet

### Veritabanı Yapısı
Proje, SQL Server veritabanı kullanmaktadır (SQLQuery1.sql):
- Hasta tablosu
- Doktor tablosu
- Randevu tablosu
- İlişkisel veritabanı yapısı

### Mimari
- **DataSet:** HastaneRandevuSistemiDataSet (Typed DataSet ile tip güvenli veri erişimi)
- **Form-Based Architecture:** Her modül için ayrı form yapısı
- **Session Management:** Kullanıcı oturumlarını yönetmek için özel session sınıfları

## 📁 Proje Yapısı

```
├── Form1.cs                    # Ana giriş formu
├── doktorislem.cs              # Doktor işlemleri modülü
├── hastaislem.cs               # Hasta işlemleri modülü
├── newform1.cs                 # Randevu yönetim formu
├── Sesssion.cs & session2.cs   # Oturum yönetimi
├── SQLQuery1.sql               # Veritabanı şeması
├── HastaneRandevuSistemiDataSet # Typed DataSet
└── Program.cs                  # Uygulama giriş noktası
```

## 💡 Kullanım Senaryoları

1. **Resepsiyonist:** Hasta kaydı oluşturur ve randevu alır
2. **Yönetici:** Doktor ekler/çıkarır, sistem ayarlarını yönetir
3. **Sağlık Personeli:** Randevuları kontrol eder ve hasta bilgilerine erişir

## 🔐 Güvenlik
- Kullanıcı kimlik doğrulama sistemi
- Oturum bazlı erişim kontrolü
- Veritabanı bağlantı güvenliği

## 📊 Veri Yönetimi
- SQL Server LocalDB ile veri kalıcılığı
- Typed DataSet kullanarak tip güvenli veri işleme
- Veritabanı şeması yönetimi

## 🚀 Kurulum ve Çalıştırma

1. Projeyi Visual Studio'da açın
2. SQL Server LocalDB'yi kurun
3. SQLQuery1.sql dosyasını çalıştırarak veritabanını oluşturun
4. App.config dosyasında connection string'i kontrol edin
5. Projeyi derleyin ve çalıştırın



## 🎓 Eğitim Değeri

Bu proje, aşağıdaki konularda pratik deneyim kazandırır:
- Windows Forms uygulaması geliştirme
- SQL Server veritabanı entegrasyonu
- CRUD (Create, Read, Update, Delete) işlemleri
- Kullanıcı arayüzü tasarımı
- Oturum yönetimi
- Veritabanı ilişkilendirme

**İdeal Kullanım:** Öğrenci projeleri, küçük/orta ölçekli klinik ve sağlık merkezleri için temel randevu yönetim sistemi.
