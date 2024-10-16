using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmacaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Türkiye'nin 10 ili
            List<string> sehirler = new List<string>
            {
                "istanbul", "ankara", "izmir", "antalya", "bursa",
                "adana", "konya", "gaziantep", "kayseri", "trabzon"
            };

            //Rastgele bir şehir seç
            Random rastgele = new Random();
            string secilenSehir = sehirler[rastgele.Next(0, sehirler.Count)];

            // Seçilen şehri "_" ile gizle
            List<char> gizliKelime = new List<char>();
            for (int i = 0; i < secilenSehir.Length; i++)
            {
                gizliKelime.Add('_');
            }

            //Tahmin edilen harfleri sakla
            List<char> tahminEdilenHarfler = new List<char>();

            //Gizli kelimeyi ekrana yazdır
            Console.WriteLine("Tahmin etmeye çalışacağınız şehir:");
            foreach (char c in gizliKelime)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            // Oyuncuya 6 hak ver
            int kalanHak = 6;

            while (kalanHak > 0 && gizliKelime.Contains('_'))
            {
                //Harf tahmini iste
                Console.Write("Bir harf tahmin edin: ");
                char tahmin = char.Parse(Console.ReadLine().ToLower());

                // Daha önce tahmin edilen harf mi kontrol et
                if (tahminEdilenHarfler.Contains(tahmin))
                {
                    Console.WriteLine("Başka bir harf girin.");
                    continue;
                }

                // Tahmin edilen harfi listeye ekle
                tahminEdilenHarfler.Add(tahmin);

                // Harf doğru mu kontrol et
                bool dogruTahmin = false;
                for (int i = 0; i < secilenSehir.Length; i++)
                {
                    if (secilenSehir[i] == tahmin)
                    {
                        gizliKelime[i] = tahmin; // Doğru harf yerine konur
                        dogruTahmin = true;
                    }
                }

                // Yanlış tahmin kontrolü
                if (!dogruTahmin)
                {
                    kalanHak--;
                    Console.WriteLine("Yanlış tahmin! Kalan hak: " + kalanHak);
                }

                // Kelimenin son durumunu göster
                foreach (char c in gizliKelime)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }

            // sonuç
            if (!gizliKelime.Contains('_'))
            {
                Console.WriteLine("Tebrikler! Şehri doğru tahmin ettiniz.");
            }
            else
            {
                Console.WriteLine("Maalesef, kaybettiniz! Şehir: " + secilenSehir);
            }

            Console.ReadLine(); 

        }
    }
}