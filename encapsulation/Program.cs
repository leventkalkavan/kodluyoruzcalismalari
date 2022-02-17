using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci = new ogrenci();
            ogrenci.Isim="İsim";
            ogrenci.Soyisim="Soyisim"; 
            ogrenci.OgrenciNo=102;
            ogrenci.Sinif=4;    
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.sinify();
            ogrenci.OgrenciBilgileriniGetir(); 
            ogrenci ogrenci1 = new ogrenci("İsim2","Soyisim2",1907,4);
            ogrenci1.sinifd();
            ogrenci1.sinifd();
            ogrenci1.OgrenciBilgileriniGetir(); 

        }
    }
    class ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif; 
        public string Isim
        {
            get{return isim;}
            set{isim=value;}
        }
        public string Soyisim
        {
            get{return soyisim;}
            set{soyisim =value;}
        }
        public int OgrenciNo
        {
            get{return ogrenciNo;}
            set{ogrenciNo =value;}
        }
        public int Sinif
        {
            get{return sinif;}
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("sınıf 1'den az olamaz!");
                    sinif=1;
                }
                else
                sinif =value;
            }
        }

        public ogrenci(string isim,string soyisim,int ogrenciNo, int sinif){
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("Ogrenci Bİlgileri");
            Console.WriteLine("Ogrenci Adi    :{0}", this.Isim);
            Console.WriteLine("Ogrenci Soyadi    :{0}", this.Soyisim);
            Console.WriteLine("Ogrenci No    :{0}", this.OgrenciNo); 
            Console.WriteLine("Ogrenci Sinifi    :{0}", this.Sinif);
        }
        public void sinify (){
            this.Sinif = this.Sinif +1;
        }
        public void sinifd (){
            this.Sinif = this.Sinif -1;
        }

    }
}
