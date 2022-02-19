using System;

namespace oop
{
    public class Bitkiler:Canlilar
    {
        protected void fotosentez()
        {
            Console.WriteLine("bitkiler fotosentez yapar"); 
        }
    }
    public class Tohumlubitkiler:Bitkiler
    {
        public Tohumlubitkiler(){
            base.fotosentez();
            base.beslenme();
            base.bosaltim();
            base.solunum();
        }
        public void tohumlacogalma()
        {
            Console.WriteLine("tohumlu bitkiler tohumla çoğalır"); 
        }
    }
    public class Tohumsuzbitkiler:Bitkiler
    {
        public Tohumsuzbitkiler(){
            base.fotosentez();
            base.beslenme();
            base.bosaltim();
            base.solunum();
        }
        public void sporlacogalma()
        {
            Console.WriteLine("sporla çoğalır"); 
        }
    }
}