using System;

namespace oop
{
    public class Hayvanlar:Canlilar
    {
        protected void adaptasyon()
        {
            Console.WriteLine("hayvanlar adaptasyon sağlar"); 
        }
    }
    class Surungenler:Hayvanlar
    {
        public Surungenler(){
            base.adaptasyon();
            base.beslenme();
            base.bosaltim();
            base.solunum();
        }
        public void surunerekhareketedenler()
        {
            Console.WriteLine("sürngenler sürünerek hareket ederler"); 
        }
    }
    class Kuslar:Hayvanlar
    {
        public Kuslar(){
            base.adaptasyon();
            base.beslenme();
            base.bosaltim();
            base.solunum();
        }
        public void ucmak()
        {
            Console.WriteLine("kuslar ucar"); 
        }
    }
}