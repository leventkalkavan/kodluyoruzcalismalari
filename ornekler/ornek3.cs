using System;
using System.Collections;

namespace ornek
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümleyi girin: ");
            string cumle = Console.ReadLine().ToLower();     
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };       
            int toplam = 0;
            foreach(char karakter in cumle)
            foreach(char sesli in sesliler)
            if(karakter == sesli)
            toplam++;
            Console.WriteLine("Cümlede {0} adet sesli harf vardır", toplam);
            Console.WriteLine("sesli harfler ", sesliler);
            
        }      
        
    }
}    