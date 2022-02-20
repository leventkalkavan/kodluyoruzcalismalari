using System;
namespace Kayit
{
    class Kayit
    {
      private string _baslik;
      private string _content;
      private int _mid;
      private int _beden;
      private int _d;
     
      public Kayit(string baslik, string content, int beden , int mid=1,int d=0)
      {
          this._baslik = baslik;
          this._content = content;
          this._mid = mid;
          this._beden = beden;
          this._d= d;          
      }
      public string GKayit (){ return this._baslik;}
      public string GContent(){return this._content;}
      public string GMid(){
          if (this._mid == 1) {return "Hayri Yeten";}
          else if (this._mid == 2){return "Selami Tok";}
          else if (this._mid == 3){return "İrfan Fincan";}
          else if (this._mid == 4){return "Hami Su";}
          else {
                return "Atanan yok.";
            } 
      }
      public string Gbeden(){
          string beden = Enum.GetName(typeof(beden),this._beden);
          return beden;
      }
      public int Gd(){ return this._d;}
      public void Sbaslik(string value){this._baslik=value;}
      public void SContent(string value){this._content=value;}
      public void Smid(int value){this._mid=value;}
      public void Sbeden(int value){this._beden=value;}
      public void Sd(int value){
          if (value==0||value==1||value==2)
          {
              this._d=value;
          }
          else{
              throw new Exception("Todo durumu 0(TODO),1(IN PROGRESS) ya da 2(DONE) olabilir");
          }
       }
       public void TodoD() {
            Console.WriteLine("Başlık      :" + GKayit());
            Console.WriteLine("İçerik      :" + GContent());
            Console.WriteLine("Atanan Kişi :" + GMid() );
            Console.WriteLine("Büyüklük    :" + Gbeden() );  
        }      
    }
}