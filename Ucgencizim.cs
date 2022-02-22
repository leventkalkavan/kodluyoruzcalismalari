using System;

namespace ucgencizim
{
    class Program
    {
        static void Main(string[] args)
        {
              for (int row = 1; row <= 4; ++row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }
 
            Console.WriteLine();
        }
        }
    }
}
