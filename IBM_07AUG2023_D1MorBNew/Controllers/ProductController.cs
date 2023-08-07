using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IBM_07AUG2023_D1MorBNew.Controllers
{
    public class ProductController : Controller
    {

        Models.ProductLocalContext ctx = new Models.ProductLocalContext();



        // GET: ProductController
        public ActionResult Index()
        {
            return View(ctx.GetAllProducts());
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        public ActionResult Create(Models.Product product )
        {
            try
            {

                ctx.AddNewProduct(product);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            ctx.GetProductByID(id);
            return View(ctx.GetProductByID(id));
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            ctx.GetProductByID(id);
            return View(ctx.GetProductByID(id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Models.Product product)
        {
            try
            {
                ctx.UpdateProduct(id, product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {

            return View(ctx.GetProductByID(id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
