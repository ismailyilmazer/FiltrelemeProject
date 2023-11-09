using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }
    }
}
