using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site1.Data.Interfaces;
using Site1.Data.Models;
using Site1.ViewModels;

namespace Site1.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategoryes;

        public CarsController(IAllCars iallCars, ICarsCategory iCarCat)
        {
            _allCars = iallCars;
            _allCategoryes = iCarCat; 
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            //ViewBag.Category = "some name";//после View. можно хоть какое имя
            //var cars = _allCars.Cars;
            IEnumerable<Car> cars=null;
            string carrCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i=>i.id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i => i.id);
                    carrCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Бензиновые автомобили")).OrderBy(i => i.id);
                    carrCategory = "Бензиновые автомобили";
                }
                
            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = carrCategory
            };

            ViewBag.Title = "AutoDrive";
            return View(carObj);
        }
    }
}
