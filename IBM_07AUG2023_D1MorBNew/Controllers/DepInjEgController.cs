using Microsoft.AspNetCore.Mvc;

namespace IBM_07AUG2023_D1MorBNew.Controllers
{
    public class DepInjEgController : Controller
    {

        Models.IProductLocalContext _db;
        public DepInjEgController( Models.IProductLocalContext db )
        {
            _db = db;

        }


        public IActionResult Index([FromServices] Models.IProductLocalContext Localdb)
        {

            


            Models.IProductLocalContext localDb = Localdb;

            ViewBag.ClassLevelObj = _db.GetHashCode();

            ViewBag.MethodLevelObj = localDb.GetHashCode();



            return View();
        }
    }
}
