using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FiltrelemeProjectMvc.Controllers
{
    public class HaberBasliksController : Controller
    {
        Context db=new Context();

        public IActionResult Index(string searching)
        {
            var haberBasliklari =from s in db.HaberBasliklari select s;
            if(!string.IsNullOrEmpty(searching))
            {
                haberBasliklari = haberBasliklari.Where(e => e.Description.Contains(searching));
            }

            return View(haberBasliklari.ToList());
        }
    }
}
