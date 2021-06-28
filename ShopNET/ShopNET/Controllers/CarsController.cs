using Microsoft.AspNetCore.Mvc;
using ShopNET.Data.Interfaces;
using ShopNET.Data.Models;
using ShopNET.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNET.Controllers
{
    public class CarsController : Controller {

        private readonly IAllCars _allCars;
        private readonly ICarCategory _allCategories;

        public CarsController(IAllCars allCars, ICarCategory carCategory) {
            _allCars = allCars;
            _allCategories = carCategory;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category) {

            string _category = category;
            IEnumerable<Car> cars;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars;
            }
            else {
                if (string.Equals("Electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.getElectro;
                    currCategory = "Elektro samochody";
                }
                else 
                {
                    cars = _allCars.getClassic;
                    currCategory = "Klasyczne samochody";
                }

               
            }

            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                currCategory = currCategory
            };

            ViewBag.Title = "Strona z samochodami";
            
            
            return View(carObj);
        }

    }
}
