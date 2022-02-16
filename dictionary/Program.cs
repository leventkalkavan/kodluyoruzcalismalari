using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
          Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

          kullanicilar.Add(1,"İsim1");
          kullanicilar.Add(2,"İsim2");
          kullanicilar.Add(3,"İsim3");
          kullanicilar.Add(4,"İsim4");
          Console.WriteLine(kullanicilar[3]);
          foreach (var item in kullanicilar)
          Console.WriteLine(item);          

          Console.WriteLine(kullanicilar.Count);
          Console.WriteLine(kullanicilar.ContainsKey(4));
          Console.WriteLine(kullanicilar.ContainsValue("İsim5"));
          
          kullanicilar.Remove(4);
          foreach (var item in kullanicilar)
              Console.WriteLine(item);

          foreach (var item in kullanicilar.Keys)
           Console.WriteLine(item);

           foreach(var item in kullanicilar.Values)
           Console.WriteLine(item);

        }
    }
}
