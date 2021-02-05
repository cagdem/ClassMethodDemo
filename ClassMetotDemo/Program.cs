using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Çağlar";
            musteri1.Soyad = "Demir";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Bulut";
            musteri2.Soyad = "Demir";
            musteri2.Id = 2;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri2);
            Console.WriteLine();
            musteriManager.Listele(musteriler);
            Console.WriteLine();
        }
    }
}
