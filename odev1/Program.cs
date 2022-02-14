using System;

 namespace operatorler 
  {
     class Program{
         static void Main(string[] args)
         {
            Console.WriteLine("pozitif bir sayi girin: ");
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            int [] sayi = new int [n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("sayi girin: ");
                m= int .Parse(Console.ReadLine());
                sayi[i] = m;
            }
            Console.WriteLine("cift sayilar: ");
            foreach (var item in sayi)
            {
                if (item %2==0)
                Console.WriteLine(item);
            }

         }
         public void a (string[] args)
         {
             Console.WriteLine("ilk pozitif sayiyi girin: ");
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine("ikinci pozitif sayiyi girin: ");
             int m = int.Parse(Console.ReadLine());
             int k=0;
             int [] sayi = new int [n];
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine("sayi girin");
                 k=int.Parse(Console.ReadLine());
                 sayi[i]=k; 
             }
             Console.WriteLine("ikinci sayıya eşit ve tam bölünüyor");
             foreach (var item in sayi)
             {
                 if(item %m==0||item==m)
                 Console.WriteLine(item);
             }
         Console.WriteLine("pozitif sayi gir");
         int a = int.Parse(Console.ReadLine());
         string b;
         string[] kelimeler = new string[n];
         for (int i = 0; i < n; i++)
         {
             Console.WriteLine("kelime giriniz ");
                 b = Console.ReadLine();
                 kelimeler[i] = b;
         }
         Console.WriteLine("girilen kelimeler sondan başa göre ");
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
         }
          public void v (string [] args)
          {
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