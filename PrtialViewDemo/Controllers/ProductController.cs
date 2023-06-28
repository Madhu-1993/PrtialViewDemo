using Microsoft.AspNetCore.Mvc;
using PrtialViewDemo.Models;

namespace PrtialViewDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;
        private ProductCRUD db;

        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
            db = new ProductCRUD(this.context);
        }
        public IActionResult Index()
        {
            return View(db.GetProducts());
        }
    }
}
