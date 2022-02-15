using System;
using System.Collections.Generic;

 namespace generic_list  {
     class Program{
         static void Main(string[] args)
         {
             List <int> sayiListesi = new List<int>();
             sayiListesi.Add(19);
             sayiListesi.Add(14);
             sayiListesi.Add(5);
             sayiListesi.Add(78);
             sayiListesi.Add(91);

             List<string> renklerListesi = new List<string>();
             renklerListesi.Add("Renk1");
             renklerListesi.Add("Renk2");
             renklerListesi.Add("Renk3");
             renklerListesi.Add("Renk4");
             renklerListesi.Add("Renk5");

             Console.WriteLine(renklerListesi.Count);
             Console.WriteLine(sayiListesi.Count);

             foreach (var sayi in sayiListesi)
               Console.WriteLine(sayi);  
             foreach (var renk in renklerListesi)
              Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renklerListesi.ForEach(renk=>Console.WriteLine(renk));

            sayiListesi.Remove(4);
            renklerListesi.Remove("Renk5");
            sayiListesi.RemoveAt(0);
            renklerListesi.RemoveAt(0);
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renklerListesi.ForEach(renk=>Console.WriteLine(renk));

            if(sayiListesi.Contains(14))
            {
                Console.WriteLine("sayı(14) bulundu");
            }

            Console.WriteLine(renklerListesi.BinarySearch("Renk3"));
            
            string[] hayvanlar = {"hayvan1","hayvan2","hayvan3"};

            List <string> hayvanListesi = new List<string>(hayvanlar) ;

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "İsim1";
            kullanıcı1.SoyIsim = "Soyisim1";
            kullanıcı1.Yas=12;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "İsim2";
            kullanıcı2.SoyIsim = "Soyisim2";
            kullanıcı1.Yas2=121;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2); 

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            
            yeniListe.Add(new Kullanıcılar(){
                Isim ="İsim3",
                SoyIsim="Soyisim3",
                Yas=12,
            });  

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("kullanıcı adı:" + kullanıcı.Isim);
                Console.WriteLine("kullanıcı soyadı:" + kullanıcı.SoyIsim);
                Console.WriteLine("kullanıcı yas:" + kullanıcı.Yas);
            }

            

         }
     }
     public class Kullanıcılar {
         string isim; 
         string soyisim;
         
         int yas;

         public string Isim {get => isim; set=>isim=value;}

         public string SoyIsim {get => soyisim; set=>soyisim=value;}

         public int Yas {get => yas; set=>yas=value;}
     }
 }