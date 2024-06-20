using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstanceSample
{
    public class Utu
    {
        //Boş bir Constructor
        public Utu() 
        {
            Console.WriteLine("Hello Ütü!!");
        }

        //Parametreli COnstructor
        public Utu(string marka,string renk,int sicaklik,bool kazanliMi) 
        {
            this.Marka = marka;
            this.Renk = renk;
            this.Sicaklik = sicaklik;
            this.KazanliMi = kazanliMi;

            string utuBilgileri =
                $"Ütü nesnesi aşağıdaki bilgiler ile oluşturuldu\n" +
                $"Marka : {this.Marka}\n" +
                $"Renk : {this.Renk}\n" +
                $"Sıcaklık : {this.Sicaklik}\n" +
                $"Kazanlı mı? : {(this.KazanliMi ? "Var" : "Yok")}";
            Console.WriteLine(utuBilgileri);
        }

        public Utu(string marka)
        {
            Marka = marka;
            string utuBilgileri =
                $"Ütü nesnesi aşağıdaki bilgiler ile oluşturuldu\n" +
                $"Marka : {this.Marka}\n";
            Console.WriteLine(utuBilgileri);
        }
        
        public void Isın(int derece)
        {
            Sicaklik += derece;
            Console.WriteLine($"Ütünün sıcaklığı arttı. Şu anki sıcaklı : {Sicaklik}");
        }

        public string Marka {  get; set; }
        public string Renk {  get; set; }
        public int Sicaklik { get; set; }
        public bool KazanliMi { get; set; }
        //public int ID1 { get => ID; set => ID = value; }
        //public string FirstName { get => firstName; set => firstName = value; }
        //public string LastName { get => lastName; set => lastName = value; }
        //public DateTime DogumTarihi { get => dogumTarihi; set => dogumTarihi = value; }

        //private int ID;
        //private string firstName;
        //private string lastName;
        //private DateTime dogumTarihi;

    }
}
