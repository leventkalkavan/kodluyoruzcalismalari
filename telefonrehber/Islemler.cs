using System;
namespace Islemler
{
    public static class Islemler
    {
        public static void Basla(){
         Console.WriteLine("yapmak istediğin işlemi seç");
         Console.WriteLine("---------------------------");
         Console.WriteLine("(1) Yeni Numara Kaydetmek");
         Console.WriteLine("(2) Kayıtlı Numarayı Silmek");
         Console.WriteLine("(3) Kayıtlı Numarayı Güncelleme");
         Console.WriteLine("(4) Rehberi Listelemek");
         Console.WriteLine("(5) Rehberde Arama Yapmak");
        }

        public static void KayıtB(){
            for (int i = 0; i <Rehber.Rehber.tRehber.Count; i++)
            {
                Console.WriteLine("Rehber");
                Console.WriteLine("Isim {0}",Rehber.Rehber.tRehber[i].Isim);
                Console.WriteLine("Soyisim {0}",Rehber.Rehber.tRehber[i].Soyisim);
                Console.WriteLine("Numara {0}",Rehber.Rehber.tRehber[i].Numara);
            }   
        }
        public static void KayıtN()
        {
            Console.WriteLine("isim giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyisim giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("Tel. numarasi giriniz");
            string numara = Console.ReadLine();
        }
        public static void KayıtS()
        {
            Console.WriteLine("silmek istediğniz kişinin adını soyadını girin ");
            int check = 0;
            string name = Console.ReadLine();
            foreach (var item in Rehber.Rehber.tRehber)
            {
                if (item.Isim.ToLower() == name.ToLower() || item.Soyisim.ToLower() == name.ToLower())
                {
                    Console.WriteLine("{0} silinecek, onaylıyor musun?(y/n)",name);
                    char kontrol = char.Parse(Console.ReadLine());
                    if (kontrol == 'y' )
                    {
                        int deleteI = Rehber.Rehber.tRehber.IndexOf(item);
                        Rehber.Rehber.tRehber.RemoveAt(deleteI);
                        check++;
                        Console.WriteLine("silme onayı başarılı");
                        break;
                    }
                }
            }
        }
        public static void NumaraA()
        {
            Console.WriteLine("isime göre arama için: (1)");
            Console.WriteLine("numaraya göre arama için: (2)");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("arama yapmak için isim giriniz");
                string name = Console.ReadLine();
                foreach (var item in Rehber.Rehber.tRehber)
                {
                    if (item.Isim.ToLower() == name.ToLower() || item.Soyisim.ToLower() == name.ToLower())
                    {
                        Console.WriteLine("isim {0}",item.Isim);
                        Console.WriteLine("soyisim {0}",item.Soyisim);
                        Console.WriteLine("telefon numarası {0}", item.Numara);
                    }
                    
                }
            }
            else if (select == 2)
            {
                Console.WriteLine("arama yapmak için numara giriniz");
                string numara = Console.ReadLine();
                foreach (var item in Rehber.Rehber.tRehber)
                {
                    if (item.Numara == numara)
                    {
                        Console.WriteLine("isim {0}",item.Isim);
                        Console.WriteLine("soyisim {0}",item.Soyisim);
                        Console.WriteLine("telefon numarası {0}", item.Numara);
                    }
                }
            } 
        }
        public static void KayıtG()
        {
            Console.WriteLine("numarası güncellemek istediğin kişinin adı ya da soyadını gir");
            string name = Console.ReadLine();
            int Count = Rehber.Rehber.tRehber.Count;
            int guncelleme = 0;
            for (var i = 0; i < Count; i++)
            {
                if (Rehber.Rehber.tRehber[i].Isim.ToLower() == name.ToLower() || Rehber.Rehber.tRehber[i].Soyisim.ToLower() == name.ToLower() )
                {
                    Console.WriteLine("kişi bulundu {0}");
                    Console.WriteLine("güncellemek istediğiniz numarayı giriniz");
                    string ynumara = Console.ReadLine();
                    Rehber.Rehber.tRehber[i].Numara = ynumara;
                    Console.WriteLine("numara güncellendi");
                    guncelleme++;
                    break;
                }
            }
        }
    }
} 
