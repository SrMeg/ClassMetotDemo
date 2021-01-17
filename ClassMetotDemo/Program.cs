using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Selçuk";
            musteri1.Soyad = "Oğur";
            musteri1.Yas = 21;
            musteri1.ID = 160314082;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Burak";
            musteri2.Soyad = "Demirel";
            musteri2.Yas = 20;
            musteri2.ID = 202056124;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Onur";
            musteri3.Soyad = "Pınarcı";
            musteri3.Yas = 31;
            musteri3.ID = 190485672;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            Console.WriteLine(" ");

            musteriManager.MusteriCikar(musteri1);
            musteriManager.MusteriCikar(musteri2);
            musteriManager.MusteriCikar(musteri3);

            Console.WriteLine(" ");

            musteriManager.MusteriListele(musteriler);








        }
    }
}
