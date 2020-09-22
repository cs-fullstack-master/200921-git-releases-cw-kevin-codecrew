using Microsoft.AspNetCore.Mvc;
using ProductCatalog.DAO;
using ProductCatalog.Models;

namespace ProductCatolog.Controllers
{
    public class Product : Controller
    {
        // ref to db
        private readonly ProductDbContext _context;
        public Product(ProductDbContext context)
        {
            _context = context;
        }
        // list all
        public IActionResult Index()
        {
            return View(_context);
        }
        // display form to add
        public IActionResult CreateForm()
        {
            return View();
        }
        // add to db
        [HttpPost]
        public IActionResult Add(ProductModel newProduct)
        {
            // check the form data is valid
            if(ModelState.IsValid)
            {
                // add to db and save changes
                _context.products.Add(newProduct);
                _context.SaveChanges();
                // redirect on submit
                return RedirectToAction("Index");
            } else 
            // if form data isn't valid
            {
                // display form with invalid data
                return View("CreateForm", newProduct);
            }
        }
    }
}