using System;

namespace _enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cumartesi); 

            int sıcaklık = 34;
            if (sıcaklık<=(int)havas.Normal)
                Console.WriteLine("hava sıcaklığı ortalamanın altında");
                else if(sıcaklık>=(int)havas.Sıcak)
                Console.WriteLine("hava çok sıcak");
                else if(sıcaklık>=(int)havas.Normal && sıcaklık<(int)havas.CokSıcak)
                Console.WriteLine("hava sıcaklığı normal");
        }
    }
    enum Gunler{
        pazartesi=1,
        sali,
        carsamba,
        persembe,
        cuma=23,
        cumartesi,
        pazar
    }
    enum havas{
        Soguk = 5,
        Normal = 20,
        Sıcak =25,
        CokSıcak =30
    }
}
