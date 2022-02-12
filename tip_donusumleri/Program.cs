using System;

 namespace tip_donusumleri  {
     class Program{
         static void Main(string[] args)
         {
            byte a=4;
            sbyte b =9;
            short c= 12;
            int d=a+b+c;
            Console.WriteLine("d:"+ d);

            long h=d;
            Console.WriteLine("h:"+ h);

            float i = h;
            Console.WriteLine("i:"+ i);

            string e="deneme";
            char f ='k';
            object g = e+f+d;
            Console.WriteLine("g:"+ g);

            int x=4;
            byte y =(byte)x;
            Console.WriteLine("y:"+ y);

            int z= 190;
            byte t = (byte)z;
            Console.WriteLine("t:"+ t);
            
            float v =10.3f;
            byte r =(byte)v;
            Console.WriteLine("r:"+ r);

            int xx = 8;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+ yy);
            
            string zz = 12.5f.ToString();
            Console.WriteLine("zz:"+ zz);
            
            string s1 ="21", s2 ="20";
            int sayi1,sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam:" + Toplam);

         }
     }
 }

