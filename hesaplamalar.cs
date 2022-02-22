using System;

namespace hesaplamalar
{
    class Program
    {

        static void Main(string[] args)
        {   Console.WriteLine("---DAİRE---");
            const double PI = 3.14;
            double yaricapi, alan, cevre;
            Console.Write("Dairenin yarı çapını giriniz:");
            yaricapi = Convert.ToDouble(Console.ReadLine());
            alan = PI * yaricapi * yaricapi;
            cevre = 2 * PI * yaricapi;
            Console.WriteLine("Alan: " + alan);
            Console.WriteLine("Çevre: " + cevre);
        }
        public static void dikdortgen()
        {
            Console.WriteLine("---DİKDÖRTGEN---");
            int ukenar = 0, kkenar = 0, alan = 0, cevre = 0;
            Console.Write("Dikdörtgenin uzun kenarını giriniz:");
            ukenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin kısa kenarını giriniz:");
            kkenar = Convert.ToInt32(Console.ReadLine());
            alan = ukenar * kkenar;
            cevre = (ukenar + kkenar) * 2;
            Console.WriteLine("Çevre= {0} \nAlan= {1}", cevre,alan);
            Console.ReadKey();
        }
        public static void Kare()
        {
            Console.WriteLine("---KARE---");
            int kenar, karealan, kareçevre; 
            Console.Write("Karenin bir kenarını giriniz= ");
            kenar = Convert.ToInt32(Console.ReadLine());
            karealan = kenar * kenar;
            kareçevre = kenar * 4; 
            Console.WriteLine("Kare Alan= " + karealan);  
            Console.WriteLine("Kare Çevre= " + kareçevre); 
            Console.ReadLine();

        }
    }
}
