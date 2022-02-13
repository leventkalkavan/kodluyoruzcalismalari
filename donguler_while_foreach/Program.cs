using System;

 namespace donguler_while_foreach {
     class Program{
         static void Main(string[] args)
         {
             Console.Write("Sayı Giriniz:");
             int sayi = int.Parse(Console.ReadLine());
             int sayac = 1;
             int toplam = 0;
            while (sayac <= sayi)
            {
               toplam += sayac;
               sayac ++;
            }
            Console.WriteLine(toplam/sayi); 
            
            char karakter = 'a';
            while (karakter <= 'z')
            {
                Console.Write(karakter);
                karakter ++;
            }

            string[] araba = {"model1","model2","model3"};

            foreach (var item in araba)
            {
                Console.WriteLine(item);                
            }         

         }
     }
 }