using System;

namespace silme
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesaj = "Cumle Denemesi";
            string yeni_mesaj = mesaj.Remove( 3);
            Console.WriteLine(yeni_mesaj);
        }
    }
}
