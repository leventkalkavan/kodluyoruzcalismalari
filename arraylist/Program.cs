using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList liste = new ArrayList();
           liste.Add("isim");
           liste.Add(2);
           liste.Add(true);
           liste.Add('i');

           Console.WriteLine(liste[1]);
           foreach (var item in liste)
           Console.WriteLine(item);
           
           string[]renkler = {"renk1","renk2","renk3"};
           List<int> sayilar = new List<int>(){1,2,3,4,5,6};
           Liste.AddRange(renkler);
           Liste.AddRange(sayilar);

           foreach (var item in liste)
           {
               Console.WriteLine(item);
           }
           
            liste.Sort();

           foreach (var item in liste)
           {
               Console.WriteLine(item);
           }

           Console.WriteLine(liste.BinarySearch(6));

           liste.Reverse();
           foreach (var item in liste)
           {
               Console.WriteLine(item);
           }
        }
    }
}
