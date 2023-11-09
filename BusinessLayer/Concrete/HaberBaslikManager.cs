using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HaberBaslikManager : IHaberBaslik
    {
        IHaberBaslik iHaberBaslik;

        public HaberBaslikManager(IHaberBaslik haberBaslik)
        {
            iHaberBaslik = haberBaslik;
        }
        public List<HaberBaslik> GetList()
        {
            return iHaberBaslik.GetList();
        }
    }
}
