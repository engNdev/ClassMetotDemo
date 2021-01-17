using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();
            MusteriManager musteriManager = new MusteriManager();

            musteri1.musteriAd = "Engin";
            musteri1.musteriSoyad = "Taşkın";
            musteri1.musteriId = 1;

            musteri2.musteriAd = "Ahmet";
            musteri2.musteriSoyad = "Öz";
            musteri2.musteriId = 2;

            musteri3.musteriAd = "Mehmet";
            musteri3.musteriSoyad = "Taş";
            musteri3.musteriId = 3;

            Musteri[] musteriler = { musteri1, musteri2, musteri3 };

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSilme(musteri1);

            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSilme(musteri2);

            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriSilme(musteri3);

            musteriManager.MusteriListele(musteriler);

        }
    }
    
  
}
