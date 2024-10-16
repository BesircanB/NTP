using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalTop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Asal sayı toplama---");
            Console.WriteLine("Sayı giriniz:");

            int sayi = int.Parse(Console.ReadLine());

            bool asalMi = false;

            if (sayi < 2)
            {
                Console.WriteLine("Asal sayı bulunamadı!");
                Console.ReadLine();

            }



            else
            {
                int top = 2;

                for (int i = 3; i < sayi; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            asalMi = false;
                            break;
                        }
                        else if (i % j != 0)
                        {
                            asalMi = true;


                        }



                    }
                    if (asalMi)
                        top += i;


                }

                Console.WriteLine("Toplam:" + top);

                Console.ReadLine();









             }
          }
    }
}
