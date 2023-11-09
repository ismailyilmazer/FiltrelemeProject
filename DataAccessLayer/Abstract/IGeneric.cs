using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGeneric<T> where T : class
    {
        List<T> GetList();
    }
}
