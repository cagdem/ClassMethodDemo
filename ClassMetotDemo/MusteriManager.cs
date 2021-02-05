using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi: " + musteri.Ad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi: " + musteri.Ad);
        }
        public void Listele(Array musteriler)
        { 
            Console.WriteLine("Musteri listesi: ");
            Console.WriteLine("-------------------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
            }
        }
    }
}
