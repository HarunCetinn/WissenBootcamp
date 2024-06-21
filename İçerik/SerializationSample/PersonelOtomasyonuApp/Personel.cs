using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace PersonelOtomasyonuApp
{
    public class Personel
    {
        public int ID { get; set; }
        public string Ad {  get; set; }
        public string Soyad {  get; set; }
        public string TCKN { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Email {  get; set; }
        public string Telefon { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public string Unvan { get; set; }
        public string PersonelResmi { get; set; }

        public object Tag { get; set; }
    }
}
