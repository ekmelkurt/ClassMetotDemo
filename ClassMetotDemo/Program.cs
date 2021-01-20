using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Müşteri Takip Metodu------------");
            Console.WriteLine();

            //Musteri Classını kullanarak manuel olarak müşteri ekliyoruz
            Musteri musteri1 = new Musteri(); //Müşteri-1
            musteri1.Ad = "Ahmet";
            musteri1.SoyAd = "Kurt";
            musteri1.Numara = 123456;
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri(); //Müşteri-2
            musteri2.Ad = "Ayşe";
            musteri2.SoyAd = "Nur";
            musteri2.Numara = 487845;
            musteri2.Cinsiyet = "Kadın";

            Musteri musteri3 = new Musteri(); //Müşteri-3
            musteri3.Ad = "Ali";
            musteri3.SoyAd = "Demir";
            musteri3.Numara = 854556;
            musteri3.Cinsiyet = "Erkek";

            //Musteri classından dizi oluşturuyoruz
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager ekle = new MusteriManager();
            ekle.MusteriEkle(musteri1); //istediğimiz müşteriyi ekliyoruz
            ekle.MusteriEkle(musteri2);
            ekle.MusteriEkle(musteri3);

            MusteriManager listele = new MusteriManager();
            listele.MusteriListele(musteriler);

            MusteriManager güncelle = new MusteriManager();
            güncelle.MusteriGüncelle(musteri1);

            MusteriManager sil = new MusteriManager();
            sil.MusteriSil(musteri2);

            Console.ReadLine();
        }
    }
}


