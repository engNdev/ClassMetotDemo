using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi. \nMüşteri Adı: " + musteri.musteriAd + "\nMüşteri Soyad: " + musteri.musteriSoyad);
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Müşteri Id: " + musteri.musteriId +
                    "\nMüşteri Ad: " + musteri.musteriAd +
                    "\nMüşteri Soyad: " + musteri.musteriSoyad);
                Console.WriteLine("-----------------------");
            }
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("\n" + musteri.musteriId +" ID numaralı " 
                + musteri.musteriAd +" " + musteri.musteriSoyad 
                + " Ad soyadlı müşterimiz silinmiştir.\n");
        }
    }
    
}
