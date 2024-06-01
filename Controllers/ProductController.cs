using FinalAECApp.Data;
using FinalAECApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalAECApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            List<ProductViewModel> productList = new List<ProductViewModel>();

            if (products != null)
            {
                foreach (var product in products)
                {
                    var ProductViewModel = new ProductViewModel()
                    {
                        ProductId = product.ProductId,
                        FarmerId = product.FarmerId,
                        Name = product.Name,
                        Category = product.Category,
                        ProductionDate = product.ProductionDate,
                    };
                    productList.Add(ProductViewModel);
                }
                return View(productList);
            }
            return View(productList);
        }
    }
}
