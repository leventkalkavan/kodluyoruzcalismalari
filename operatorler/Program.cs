using System;

 namespace operatorler{
     class Program{
         static void Main(string[] args)
         {
            int x=4;
            int y=5;
            y=y+2;
            y+=2;
            Console.WriteLine(y);
            Console.WriteLine(x);

            bool isSucces=true;
            bool isCompleted=false;

            if(isSucces && isCompleted)
            Console.WriteLine("Harika");

            if(isSucces || isCompleted)
            Console.WriteLine("Müthiş");

            if(isSucces && !isCompleted)
            Console.WriteLine("İyi");

            int a=5;
            int b= 6;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            int sayi1=10;
            int sayi2=8;
            int sonuc1 =sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            int sonuc2= 20%4;
            Console.WriteLine(sonuc2);

         }
     }
 }

