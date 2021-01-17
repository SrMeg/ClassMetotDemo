using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri :" + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas);
        }

        public void MusteriCikar(Musteri musteri)
        {
            Console.WriteLine("Çıkartılan Müşteri :" + " " + musteri.Ad + " " + musteri.Soyad);
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Listesi : " + " " + musteri.ID + " - " + musteri.Ad);
            }
        }
    }
}
