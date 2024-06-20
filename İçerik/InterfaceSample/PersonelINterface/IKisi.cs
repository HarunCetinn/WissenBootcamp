using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelINterface
{
    interface IKisi
    {
        int ID { get; set; }
        string Ad {  get; set; }
        string Soyad {  get; set; }
        string Departman {  get; set; }
        double Maas {  get; set; }

        string getInfo();
    }
}
