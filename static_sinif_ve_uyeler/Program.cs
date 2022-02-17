using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
           
           calisan calisan = new calisan("isim","soyisim","D");
           Console.WriteLine("çalışan eleman: {0}",calisan.CalisanSayisi );
           calisan calisan1 = new calisan("isim2","soyisim2","D2");
           calisan calisan2 = new calisan("isim3","soyisim3","D3");
           Console.WriteLine("çalışan eleman: {0}",calisan.CalisanSayisi );
           Console.WriteLine("Toplanın sonucu: {0}",Islemler.topla(100,200));
           Console.WriteLine("Cikarmanın sonucu: {0}",Islemler.cikar(400,50));
    }
    class calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi {get => calisanSayisi;}
        private string Isim;
        private string Soyisim;
        private string Departman;

        static calisan()
        {
            calisanSayisi = 0;
        }
        public calisan (string isim,string soyisim,string departman)
        {
            this.Isim = isim;
            this.Soyisim =soyisim;
            this.Departman = departman;     
            calisanSayisi ++;
        }
    }
    static class Islemler{
        public static long topla (int sayi1,int sayi2)
        {
            return sayi1+sayi2;  
        }
        public static long cikar (int sayi1,int sayi2)
        {
            return sayi1-sayi2;  
        }
    }
    }
}