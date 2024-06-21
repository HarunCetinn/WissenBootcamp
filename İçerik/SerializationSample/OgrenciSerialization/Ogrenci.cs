using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSerialization
{
    public class Ogrenci
    {
        public int OgrenciID {  get; set; }
        public string AdiSoyadi {  get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Email {  get; set; }
        public string Telefon {  get; set; }
        public string Bolumu {  get; set; } 
        public double NotOrtalamasi { get; set; }
        public string OgrenciHakkinda {  get; set; }

        
    }
}
