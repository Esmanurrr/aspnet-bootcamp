// See https://aka.ms/new-console-template for more information
using AttributeOrnek;


Ogrenci ogrenci = new Ogrenci();
ogrenci.Ad = "Esmanur";
ogrenci.Soyad = "Mazlum";
ogrenci.Bolum = "Bilgisayar mühendisliği";

if (!ZorunlulukKontrolu.Dogrula(ogrenci))
{
    Console.WriteLine("Öğrenci bilgileri doğrulamadan geçemedi");
}
else
{
    Console.WriteLine("Form başarılı");
}