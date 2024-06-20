using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari
{
    public class DbOPerationsManager : IDbOperations
    {
        private IDbOperations _dbOperations;

        public DbOPerationsManager(IDbOperations dbOperations)
        {
            _dbOperations = dbOperations;
        }

        public void Delete()
        {
            _dbOperations.Delete();
        }

        public void Insert()
        {
            _dbOperations.Insert();
        }

        public void Read()
        {
            _dbOperations.Read();
        }

        public void Update()
        {
            _dbOperations.Update();
        }
    }
}
