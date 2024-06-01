using FinalAECApp.Data;
using FinalAECApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalAECApp.Controllers
{
    public class FarmerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FarmerController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var farmers = _context.Farmers.ToList();
            List<FarmerViewModel> farmerList = new List<FarmerViewModel>();

            if (farmers != null)
            {
                foreach (var farmer in farmers)
                {
                    var FarmerViewModel = new FarmerViewModel()
                    {
                        FarmerId = farmer.FarmerId,
                        Name = farmer.Name,
                        Surname = farmer.Surname,
                        Email = farmer.Email,
                        Password = farmer.Password,
                    };
                    farmerList.Add(FarmerViewModel);
                }
                return View(farmerList);
            }
            return View(farmerList);
        }
    }
}
