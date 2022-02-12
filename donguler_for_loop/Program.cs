using System;

 namespace donguler_for_loop  {
     class Program{
         static void Main(string[] args)
         {
             Console.WriteLine("Sayı girin");
            int sayac = int.Parse(Console.ReadLine());
            for(int i = 0; i <= sayac; i++)
            {
                if(i%2==1)
                Console.WriteLine(i);
            }

            int tekToplam =0;
            int CiftToplam =0;
            for (int i = 1; i <= 1000; i++)
            {
               if(i%2==1) 
               tekToplam += i;
               else
                CiftToplam += i;
            }
            Console.WriteLine("Tek Toplam:" + tekToplam);
            Console.WriteLine("Tek Toplam:" + CiftToplam);

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
            }

         }
     }
 }