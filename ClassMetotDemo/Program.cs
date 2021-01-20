using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 17854256;
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Can";

            Musteri musteri2 = new Musteri();
            musteri1.ID = 17854586;
            musteri1.Ad = "Ayşe";
            musteri1.Soyad = "Demir";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Sil(musteri1);

            musteriManager.Listele();
        }
    }
}
