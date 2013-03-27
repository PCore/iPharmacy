using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iPharmacy.Model;
using iPharmacy.Domain;

namespace iPharmacy.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;


        public ProductController()
        {
            this.productRepository = new ProductRepository();
        }

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        //
        // GET: /Student/

        public ViewResult Index()
        {
            return View(productRepository.GetProducts());
        }


        //
        // GET: /Student/Details/5

        public ViewResult Details(int id)
        {
            Product student = productRepository.GetProductByID(id);
            return View(student);
        }

        //
        // GET: /Student/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Student/Create

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productRepository.InsertProduct(product);
                    productRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(product);
        }

        //
        // GET: /Student/Edit/5

        public ActionResult Edit(int id)
        {
            Product product = productRepository.GetProductByID(id);
            return View(product);
        }

        //
        // POST: /Student/Edit/5

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productRepository.UpdateProduct(product);
                    productRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(product);
        }

        //
        // GET: /Student/Delete/5

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }
            Product product = productRepository.GetProductByID(id);
            return View(product);
        }


        //
        // POST: /Student/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Product product = productRepository.GetProductByID(id);
                productRepository.DeleteProduct(id);
                productRepository.Save();
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                return RedirectToAction("Delete",
                    new System.Web.Routing.RouteValueDictionary { 
                { "id", id }, 
                { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            productRepository.Dispose();
            base.Dispose(disposing);
        }

    }
}