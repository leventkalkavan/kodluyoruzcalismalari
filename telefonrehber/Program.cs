using System;

namespace telefonrehber
{
    class Program
    {
        static void Main(string[] args)
        {
            Rehber.Rehber.tRehber.Add(new Rehber.Kayıt("Volkan", "Şahin", "1"));
            Rehber.Rehber.tRehber.Add(new Rehber.Kayıt("Selçuk", "Demirel", "2"));
            Rehber.Rehber.tRehber.Add(new Rehber.Kayıt("Ozan", "Bulut", "3"));
            Rehber.Rehber.tRehber.Add(new Rehber.Kayıt("Erol", "Kocaman", "4"));
            Rehber.Rehber.tRehber.Add(new Rehber.Kayıt("Aykut","Tufan", "5"));
            
            Islemler.Islemler.Basla();
            int select = int.Parse(Console.ReadLine());
            {
                if (select == 1)
                {
                    Islemler.Islemler.KayıtN();
                }else if (select == 2)
                {
                    Islemler.Islemler.KayıtS();
                }else if (select == 3)
                {
                    Islemler.Islemler.KayıtG();
                }else if (select == 4)
                {
                    Islemler.Islemler.KayıtB();
                }
                else if (select == 5)
                {
                    Islemler.Islemler.NumaraA();
                }
                Islemler.Islemler.Basla();
                select = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("rehberin son hali ");
            Islemler.Islemler.KayıtB();
        }
    }
}
