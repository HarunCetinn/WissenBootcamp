using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKavramı
{
    public class AnahtarDegerIkilisi<TKey, TValue>
    {
        public TKey ID {  get; set; }
        public TValue Name { get; set; }

        public DateOnly BirthDate { get; set; }
    }
}
