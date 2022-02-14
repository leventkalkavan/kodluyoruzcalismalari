using System;

 namespace overloading  {
     class Program{
         static void Main(string[] args)
         {
            string sayi ="123"; 
            
            int outSayi;
            bool sonuc =int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("BAşarısız");
            }

            Metotlar instance = new Metotlar();
            instance.topla(2,3,out int toplamsonucu);
            Console.WriteLine(toplamsonucu);

            int ifade = 123;
            instance.ekranayazdır(Convert.ToString(ifade));
            instance.ekranayazdır(ifade);
            instance.ekranayazdır("deneme","deneme2");

         }
        
     }

     class Metotlar
     {
         public void topla(int a,int b,out int toplam)
         {
             toplam = a+b;
         }
         
         public void ekranayazdır(string veri)
         {
             Console.WriteLine(veri);
         }
          public void ekranayazdır(int veri)
         {
             Console.WriteLine(veri);
         }
          public void ekranayazdır(string veri1,string veri2)
         {
             Console.WriteLine(veri1+veri2);
         }
     }
 }