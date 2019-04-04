using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Models;
using CarDealer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository carRepository;

        public HomeController(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public IActionResult Index()
        {
            var cars = carRepository.GetAllCars().OrderBy(s => s.Brand);

            var homeVM = new HomeVM()
            {
                Title = "Car review",
                Cars = cars.ToList()
            };
        
            return View(homeVM);
        }
        public IActionResult Details(int id)
        {
            var car = carRepository.GetCarById(id);
            if(car == null)
            {
                return NotFound();
            }
            return View(car);
        }
    }
}