using System;

namespace kurucumetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            calisan calisan1 = new calisan("İsim","Soyisim",12548967,"Birinci Departman");
            calisan1.CalisanBilgileri();
            Console.WriteLine("--------------");
            calisan calisan2 = new calisan();
            calisan2.Ad="İsim2";
            calisan2.Soyad="Soyisim2";
            calisan2.No=41538959;
            calisan2.Departman="İkinci Departman";
            calisan2.CalisanBilgileri();
            Console.WriteLine("--------------------");
            calisan calisan3 = new calisan("İsim3","Soyisim3");
            calisan3.CalisanBilgileri();
        }

        class calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;
            public calisan(string ad,string soyad,int no, string departman)
            {
                this.Ad=ad;
                this.Soyad=soyad;
                this.No=no;
                this.Departman=departman;
            }
            public calisan(string ad,string soyad)
            {
                this.Ad=ad;
                this.Soyad=soyad;
            }
            public calisan(){}
            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışanın Adı:{0}", Ad);
                Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
                Console.WriteLine("Çalışanın Numarası:{0}",No);
                Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
            }
        }
    }
}
