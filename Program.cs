using System;

namespace odev
{

    class Program
    {

        static void Main(string[] args)
        {      
            Console.WriteLine("pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("sayı giriniz: ");
                m = int.Parse(Console.ReadLine());
                sayilar[i] = m;
            }
            Console.WriteLine("girilen çift sayılar :");
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                    Console.WriteLine(item);
            }
            Console.WriteLine("1. sayıyı giriniz :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz :");
            int b = int.Parse(Console.ReadLine());
            int k = 0;
            int[] sayi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("sayı giriniz: ");
                k = int.Parse(Console.ReadLine());
                sayi[i] = k;
            }

            Console.WriteLine("İkinci sayıya eşit veya tam bölünen sayılar :");
            foreach (var item in sayi)
            {
                if (item % b == 0 || item == b)
                    Console.WriteLine(item);
            }
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int c = int.Parse(Console.ReadLine());
            string d;
            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("kelime giriniz ");
                int z = int.Parse(Console.ReadLine());
                kelimeler[i] = y;
            }
            Console.WriteLine("Girilen kelimeler sondan başa göre ");
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Lüften bir cümle yazınız : ");
            string m = Console.ReadLine();
            string[] kelimeler = m.Split(" ");
            int sayi = 0;
            Console.WriteLine("Toplam kelime sayısı :" + kelimeler.Length);
            for (int i = 0; i < kelimeler.Length; i++)
            {
                char[] harfler = kelimeler[i].ToCharArray();
                sayi += harfler.Length;
            }
            Console.WriteLine("Toplam harf sayısı :" + sayi);
        }



    }




    
}
