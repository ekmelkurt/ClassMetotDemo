using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) //Müşteri Ekleme
        {
            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd + " --> " + "Müşteri Listesine Eklendi..!");
            Console.WriteLine();
        }


        public void MusteriListele(Musteri[] musteriler) //Müşterileri Listeleme
        {
            // Musteri[] musteriler = new Musteri[] { };
            Console.WriteLine();
            Console.WriteLine("Müşteri Bilgileri Aşağıda Yer Almaktadır:");
            Console.WriteLine();
            foreach (Musteri musteri in musteriler)
            {
                Console.Write("Müşteri Adı Soyadı: " + musteri.Ad + " ");
                Console.WriteLine(musteri.SoyAd);
                Console.WriteLine("Müşteri Numarası: " + musteri.Numara);
                Console.WriteLine("Müşteri Cinsiyet: " + musteri.Cinsiyet);
                Console.WriteLine();
            }

        }
        public void MusteriGüncelle(Musteri musteri) //Müşteri Güncelleme (Manuel)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd + " <<-->> Kişisel Bilgiler Güncellendi!..");
            musteri.Ad = "Güncel Ad";
            musteri.SoyAd = "Güncel Soyad";
            musteri.Numara = 111111;
            musteri.Cinsiyet = "Değişti";
            Console.WriteLine("Güncel Veriler Aşağıdadır:");
            Console.WriteLine();
            Console.Write("Müşteri Adı Soyadı: " + musteri.Ad + " ");
            Console.WriteLine(musteri.SoyAd);
            Console.WriteLine("Müşteri Numarası: " + musteri.Numara);
            Console.WriteLine("Müşteri Cinsiyet: " + musteri.Cinsiyet);
            Console.WriteLine();
        }

        public void MusteriSil(Musteri musteri) //Müşteri Silme
        {

            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd + ": Müşteri Silindi..");
        }
    }
}