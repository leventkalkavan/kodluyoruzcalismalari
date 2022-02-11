using System;
namespace deneme {
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("İsminizi Girin");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Girin");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " +surname);
         


            string dt = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dt);

            string c = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(c);

        }
    }
}
