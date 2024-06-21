using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKavramı
{
    public class GenericOLmayanSınıf
    {
        public void EkranaYaz<T>(T veri)
        {
            Console.WriteLine("T tipinde gelen veri : " + veri);
        }
    }
}
