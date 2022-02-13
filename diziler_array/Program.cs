using System;

 namespace diziler_array {
     class Program{
         static void Main(string[] args)
         {
            int[] sayidizisi = {12,411,11,74,92};

            foreach (var item in sayidizisi)
            {
                Console.WriteLine(item);

                Console.WriteLine("Sıralı");
            Array.Sort(sayidizisi);
             foreach (var r in sayidizisi)
              Console.WriteLine(r);

             Console.WriteLine("ArrayClear");

             Array.Clear(sayidizisi,2,2);
             
             foreach (var d in sayidizisi)
                 Console.WriteLine(d);

                 Console.WriteLine("ArrayReverse");

             Array.Reverse(sayidizisi);
             foreach (var d in sayidizisi)
                 Console.WriteLine(d);

             Console.WriteLine("IndexOf");                 
             Console.WriteLine(Array.IndexOf(sayidizisi,12));

             Console.WriteLine("ArrayResize");
             Array.Resize<int>(ref sayidizisi,5);
             sayidizisi[4] = 99;
             foreach (var d in sayidizisi)
                 Console.WriteLine(d);
            }
         }
     }
 }