using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elamsı";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] 
            {
            urun1, urun2
            };


            int i = 1;
            foreach (Product urun in urunler)
            {
                Console.WriteLine(i + ". Ürün");
                Console.WriteLine("Ürün Adı: " + urun.Adi);
                Console.WriteLine("Ürün Fiyatı: " + urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması: " + urun.Aciklama);
                Console.WriteLine("-----------------------------");
                i++;
            }

            Console.WriteLine("-------------Metotlar-----------");

         
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 20);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 32);

        }
    }
}



// Dont repeat yourself - DRY - Clean Code - Best Practice

