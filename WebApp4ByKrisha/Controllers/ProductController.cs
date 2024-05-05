using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApp4ByKrisha.Models;
using WebApp4ByKrisha.Repositories;

namespace WebApp4ByKrisha.Controllers
{
    public class ProductController : Controller
    {
        IRepository<Product> _repo = null;
        public ProductController(IRepository<Product> repo)
        {
            _repo = repo;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View(_repo.GetAllRecords());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetSingleRecord(id));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product prod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.AddRecord(prod);
                    return Content("Record has been inserted!");
                }
                else
                {
                    return View(prod);
                }
            }
            catch (SqlException ex)
            {
                return Content("Something wrong " + ex.Message);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product prod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.UpdateRecord(prod);
                    return Content("Record has been edited!");
                }
                else
                {
                    return View(prod);
                }
            }
            catch (SqlException ex)
            {
                return Content("Something wrong " + ex.Message);
            }
        }
        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _repo.GetSingleRecord(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _repo.DeleteRecord(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Content("Something wrong " + ex.Message);
            }
        }

    }
}
