using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iPharmacy.Model;
using iPharmacy.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iPharmacy.Web.Controllers
{
    [Authorize]
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
        // GET: /Product/
        public ViewResult Index()
        {
            return View(productRepository.GetProducts());
        }


        //
        // GET: /Product/Details/5

        public ViewResult Details(int id)
        {
            Product student = productRepository.GetProductByID(id);
            return View(student);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Product/Create

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
        // GET: /Product/Edit/5

        public ActionResult Edit(int id)
        {
            Product product = productRepository.GetProductByID(id);
            return View(product);
        }

        //
        // POST: /Product/Edit/5

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
        // GET: /Product/Delete/5

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
        // POST: /Product/Delete/5

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