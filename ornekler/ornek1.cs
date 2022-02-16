using System;
using System.Collections;

 namespace ornek
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList asallar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            Console.WriteLine("20 adet sayı girin :");
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("{0}.sayıyı girin :",i);
                int n = int.Parse(Console.ReadLine());
                if (negatif(n))
                {
                    int sayac = 0;
                    for (int k = 2; k < n; k++)
                    {
                        if (n % k == 0)
                        {
                            sayac++;
                        }

                    }

                    if (sayac == 0)
                    {
                        if (sayac == 1)
                        {
                            asalOlmayanlar.Add(n);
                        }
                        else
                            asallar.Add(n);
                    }

                    else
                    {
                        asalOlmayanlar.Add(n);
                    }
                }

                else
                {
                    System.Console.WriteLine("Pozitif ve Numeric Bir sayı Girin");
                }


            }
            asallar.Sort();
            asallar.Reverse();
            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();

            System.Console.WriteLine("*****Asal Sayılar*****");

            foreach (int item in asallar)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("*****Asal Olmayan Sayılar*****");
            
            foreach (var item in asalOlmayanlar)
            {
                System.Console.WriteLine(item);
            }


            int toplam1=0;
            int toplam2=0;
            foreach (int item in asallar)
            {
                toplam1=toplam1+item;
                    
            }
            Console.WriteLine("Asalların ortalaması= " + toplam1/asallar.Count+" ve" + " dizideki eleman sayısı= "+asallar.Count );
            foreach (int item in asalOlmayanlar)
            {
                toplam2=toplam2+item;
                    
            }
            Console.WriteLine("Asal olmayan sayıların ortalaması= " + toplam2/asalOlmayanlar.Count+" ve" + " dizideki eleman sayısı= "+asalOlmayanlar.Count );
        }

        private static bool negatif(int s)
        {
            bool sonuc = true;
            if (s < 0)
            {
                sonuc = false;
            }

            return sonuc;

        }

    }

}
