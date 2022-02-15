using System;

 namespace hazir_metotlar  {
     class Program{
         static void Main(string[] args)
         {
            string degisken = "Deneme denemebir";
            string degisken2 ="denemeiki";
            Console.WriteLine(degisken.Length);

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            Console.WriteLine(String.Concat(degisken," Denemeler"));

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Denemeüç"));
            Console.WriteLine(degisken.StartsWith("Denemedört"));

            Console.WriteLine(degisken.IndexOf("denemebeş"));
            Console.WriteLine(degisken.IndexOf("denemealtı"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            Console.WriteLine(degisken.Insert(0,"denemeyedi"));

            Console.WriteLine(degisken + degisken2.PadLeft(30));  
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);  
            Console.WriteLine(degisken.PadLeft(50,'-')+ degisken2);
            

            Console.WriteLine(degisken.Remove(5));
            Console.WriteLine(degisken.Remove(5,1));
            Console.WriteLine(degisken.Remove(0,1));

            Console.WriteLine(degisken.Replace("denemebir","denemesekiz"));
            Console.WriteLine(degisken.Replace(" ","*"));

            Console.WriteLine(degisken.Split(' ')[1]);

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

         }
     }
 }