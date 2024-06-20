using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari
{
    public class OracleOperatiıns : IDbOperations
    {
        public void Delete()
        {
            Console.WriteLine("Oracle Server ==> Delete OPeratiın");
        }

        public void Insert()
        {
            Console.WriteLine("Oracle Server ==> Insert OPeratiın");
        }

        public void Read()
        {
            Console.WriteLine("Oracle Server ==> Read OPeratiın");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server ==> Update OPeratiın");
        }
    }
}
