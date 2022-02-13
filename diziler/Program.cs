using System;

 namespace diziler  {
     class Program{
         static void Main(string[] args)
         {
            string [] renkler = new string[5];

            string[] hayvanlar = {"hayvan1","hayvan2","hayvan3","hayvan4"};

            int[] dizi;
            dizi = new int [5];

            renkler[0]="mavi";
            
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("dizinin eleman sayısını gir");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int [diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("{0}. sayıyı giriniz", i+1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }
            
            int toplam = 0;
            foreach (var sayi in sayidizisi)
            {
                toplam += sayi;
                Console.WriteLine("Ortalama: "+ toplam/diziuzunlugu);
            }

         }
     }
 }