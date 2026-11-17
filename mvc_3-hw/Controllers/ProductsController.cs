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
    }
}
