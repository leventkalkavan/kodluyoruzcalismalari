using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
           D diktorgen = new D();
           diktorgen.Kk = 3;
           diktorgen.Uk=4;
           Console.WriteLine("Class Alan Hesabı:{0}", diktorgen.Ah());
           
           dDstruct dDstruct = new dDstruct();
           dDstruct.Kk=3;
           dDstruct.Uk=4;

           Console.WriteLine("Class Alan Hesabı:{0}", dDstruct.Ah());
        }
        class D
        {
            public int Kk;
            public int Uk;
            public D(){
                Kk=3;
                Uk=4; 
            }
            public long Ah(){
                 return this.Kk *this.Uk;

            }
        }
    }
    struct dDstruct
    {

            public int Kk;
            public int Uk;
            public long Ah(){
                 return this.Kk*this.Uk;

            }
    }
}
