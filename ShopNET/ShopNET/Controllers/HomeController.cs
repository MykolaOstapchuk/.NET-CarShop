using Microsoft.AspNetCore.Mvc;
using ShopNET.Data.Interfaces;
using ShopNET.ViewModels;

namespace ShopNET.Controllers{
    public class HomeController : Controller{

        private IAllCars _carRep;

        public HomeController(IAllCars carrep) {
            _carRep = carrep;
        }

        public ViewResult Index() {
            var homeCars = new HomeViewModel{
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }

    }
}
