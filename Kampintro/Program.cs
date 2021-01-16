using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            // do not repeat yourself = kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 0.18;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
