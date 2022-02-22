using System;

namespace terstenyazma
{
    class Program
    {
        static void Main(string[] args)
        {
            String cumle;
            Console.Write("cumle giriniz:  ");
            cumle= Console.ReadLine();
           for (int i = 0; i<= cumle.Length - 1; i++)
             {
              Console.Write(cumle[cumle.Length - i - 1]);
             }
             Console.ReadLine();
        }
    }
}
