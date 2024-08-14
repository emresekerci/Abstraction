// Yazılım Geliştirici örneği
using Abstraction;

Sirket yazilimci = new YazilimGelistirici
{
    Ad = "Emre",
    Soyad = "Şekerci",
    Departman = "Yazılım Geliştirme"
};
yazilimci.Gorev();

// Proje Yöneticisi örneği
Sirket yonetici = new ProjeYoneticisi
{
    Ad = "Hasan",
    Soyad = "Çıldırmış",
    Departman = "Proje Yönetimi"
};
yonetici.Gorev();

// Satış Temsilcisi örneği
Sirket satici = new SatisTemsilcisi
{
    Ad = "Ayşe",
    Soyad = "Duran",
    Departman = "Satış"
};
satici.Gorev();