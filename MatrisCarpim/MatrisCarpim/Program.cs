using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisCarpim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan matris boyutunu al
            Console.Write("Matrislerin boyutunu girin (NxN): ");
            int n = int.Parse(Console.ReadLine());

            // Matrisleri tanımla
            int[,] matris1 = new int[n, n];
            int[,] matris2 = new int[n, n];
            int[,] sonucMatris = new int[n, n];

            // İlk matris için kullanıcıdan değerleri al
            Console.WriteLine("1. matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matris1[{i + 1},{j + 1}]: ");
                    matris1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // İkinci matris için kullanıcıdan değerleri al
            Console.WriteLine("2. matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matris2[{i + 1},{j + 1}]: ");
                    matris2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Matris çarpımını gerçekleştir
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sonucMatris[i, j] = 0;  // Başlangıç değeri
                    for (int k = 0; k < n; k++)
                    {
                        sonucMatris[i, j] += matris1[i, k] * matris2[k, j];
                    }
                }
            }

            // Sonuç matrisini ekrana yazdır
            Console.WriteLine("Matrislerin çarpımı sonucu:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sonucMatris[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            Console.ReadLine(); // Programı sonlandırmadan önce ekranda tutmak için



        }
    }
}
