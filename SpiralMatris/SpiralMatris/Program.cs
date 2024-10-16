using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matris boyutunu girin (NxN): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matris = new int[n, n];

            // Spiral matrisi doldur
            int deger = 1;
            int baslangicSatir = 0, bitisSatir = n - 1;
            int baslangicSutun = 0, bitisSutun = n - 1;

            while (baslangicSatir <= bitisSatir && baslangicSutun <= bitisSutun)
            {
                // Sol üstten sağa doğru ilerle
                for (int i = baslangicSutun; i <= bitisSutun; i++)
                {
                    matris[baslangicSatir, i] = deger++;
                }
                baslangicSatir++; // Üst satırı daralt

                // Sağdan aşağı doğru ilerle
                for (int i = baslangicSatir; i <= bitisSatir; i++)
                {
                    matris[i, bitisSutun] = deger++;
                }
                bitisSutun--; // Sağ sütunu daralt

                // Sağ alttan sola doğru ilerle
                if (baslangicSatir <= bitisSatir)
                {
                    for (int i = bitisSutun; i >= baslangicSutun; i--)
                    {
                        matris[bitisSatir, i] = deger++;
                    }
                    bitisSatir--; // Alt satırı daralt
                }

                // Soldan yukarı doğru ilerle
                if (baslangicSutun <= bitisSutun)
                {
                    for (int i = bitisSatir; i >= baslangicSatir; i--)
                    {
                        matris[i, baslangicSutun] = deger++;
                    }
                    baslangicSutun++; // Sol sütunu daralt
                }
            }

            // Spiral matrisi yazdır
            Console.WriteLine("Spiral Matris:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matris[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();

                Console.ReadLine();








            }
        }
    }
}
