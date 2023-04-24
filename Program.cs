using System;
using System.Collections.Generic;

namespace encapsulation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Araba araba1=new Araba("BMW","X1",2014,150000,true,true,Renkler.Siyah);
            araba1.Ozellikler();
            araba1.FiyatUygula();
            araba1.Ozellikler();

            araba1.RenkGuncelle(Renkler.Kırmızı);
            araba1.SunroofGuncelle(false);
            //araba1.FiyatUygula();
            araba1.Ozellikler();
        }
    }
    public enum Renkler{
        Kırmızı,Beyaz,Siyah,Mavi,Gri
    }
    class Araba{

        private string Marka;
        private string Model;
        private int Yas;
        private float Fiyat;
        private bool AC;
        private bool Sunroof;
        private Renkler Renk;

        public string marka { get => Marka; set => Marka = value; }
        public string model { get => Model; set => Model = value; }
        public int yas { get => Yas; set => Yas = value; }
        public float fiyat { get => Fiyat; set => Fiyat = value; }
        public bool klima { get => AC; set => AC = value; }

        public bool sunroof { get => Sunroof; set => Sunroof = value; }
        public Renkler Renk1 { get => Renk; set => Renk = value; }

        public Araba(string name,string mod,int year,float price,bool ac,bool roof,Renkler colour){
            this.AC=ac;
            this.Fiyat=price;
            this.Marka=name;
            this.Model=mod;
            this.Yas=year;
            this.Fiyat=price;
            this.Sunroof=roof;
            this.Renk=colour;
        }

        public void Ozellikler(){
            Console.WriteLine("Marka:"+this.Marka);
            Console.WriteLine("Model:"+this.Model);
            Console.WriteLine("Yıl:"+this.Yas);
            Console.WriteLine("Fiyat:"+this.Fiyat);
        }

        public void KlimaGuncelle(bool clima){
            this.AC=clima;
            this.Fiyat=this.Fiyat*.95f;
        }
        public void SunroofGuncelle(bool roof){
            this.Sunroof=roof;
            this.Fiyat=this.Fiyat*.85f;
        }
        public void RenkGuncelle(Renkler renk){
            this.Renk=renk;
            this.Fiyat=this.Fiyat*.7f;
        }

        public void FiyatUygula(){
            float c=1,s=1,a=1;
            
            if(this.Renk==Renkler.Siyah){
                c=1.3f;
            }else{
                c=1f;
            }

            if(this.Sunroof){
                s=1.15f;

            }else{
                s=1f;
            }

            if(this.AC){
                a=1.05f;
            }else{
                a=1f;
            }

            this.Fiyat=this.Fiyat*a*s*c;
        }
    }
}