using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    //Derived Class(Türemiş Sınıf)
    public class Araba : Tasit // ":" ile hangi sınıftan miras alacağı belirlenir
    {
        public Araba() : base(150)
        {
            Console.WriteLine("Araba Constructor");
            ID = 1;
            Kapasite = 200;
            TekerSayisi = 4;
            MaximumHiz = 400;
            KapiSayisi = 2;

        }

        public Araba(int id, int kapi) : base()
        {
            Console.WriteLine("Araba Constructor - Parametre alan COnstructor");
            ID = id;
            KapiSayisi = kapi;

        }
        public int KapiSayisi {  get; set; }
    }
}
