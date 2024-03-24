using DeltaWare1.Service;
using Microsoft.AspNetCore.Mvc;

namespace DeltaWare1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public ActionResult Index()
        {
            var productList = _productService.GetProducts();
            return View(productList);
        }
    }
}
