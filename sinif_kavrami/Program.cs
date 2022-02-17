using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            calisan calisan1 = new calisan();
            calisan1.Ad ="İsim";
            calisan1.Soyad="Soyisim";
            calisan1.No=12548967;
            calisan1.Departman="Birinci Departman";
            calisan1.CalisanBilgileri();
            Console.WriteLine("--------------");
            calisan calisan2 = new calisan();
            calisan2.Ad="İsim2";
            calisan2.Soyad="Soyisim2";
            calisan2.No=41538959;
            calisan2.Departman="İkinci Departman";
            calisan2.CalisanBilgileri();
        }

        class calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;
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
