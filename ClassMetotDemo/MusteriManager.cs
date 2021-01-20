using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager //Musteri ekleme, listeleme,silm
    {
        public void Ekle(Musteri x ) 
        {
          
            Console.WriteLine("müşteri eklendi." + x.ID );
        }

        public void Sil(Musteri y )
        {
            Console.WriteLine("müşteri silindi"+ y.ID);
        }

        public void Listele()
        {
            Musteri[] musteriler = new Musteri[] { };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.ID);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
            }
        }
    }
}
