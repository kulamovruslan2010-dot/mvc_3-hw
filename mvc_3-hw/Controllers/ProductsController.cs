using Microsoft.AspNetCore.Mvc;
using mvc_3_hw.Data;

namespace mvc_3_hw.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IRepository _repository;

        public ProductsController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var products = _repository.GetAll();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _repository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public IActionResult About() => View();

        public IActionResult Contacts() => View();
    }
}
