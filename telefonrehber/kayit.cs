using System;

namespace Rehber
{
     
     public class Kayıt{ 
         public Kayıt(string isim, string soyisim, string numara)
        {
            this.Isim = isim;
            this.Soyisim = soyisim; 
            this.Numara = numara;
        }
        
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Numara { get; set; }
    }
} 
