﻿using System;

 namespace switch_case  {
     class Program{
         static void Main(string[] args)
         {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak ayındasın");
                break;
                case 2:
                Console.WriteLine("Şubat ayındasın");
                break;
                case 6:
                Console.WriteLine("Haziran ayındasın");
                break;

                
                default:
                Console.WriteLine("Yanlış veri girişi");
                break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("Kış mevsimindesin");
                break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("İlkbahar mevsimindesin");
                break;
                case 6:
                case 7:
                case 8:
                Console.WriteLine("Yaz mevsimindesin");
                break;
                case 9:
                case 10:
                case 11:
                Console.WriteLine("Sonbahar mevsimindesin");
                break;

                default:
                break;
            }

         }
     }
 }