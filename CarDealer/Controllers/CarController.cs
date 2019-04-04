using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;

        public CarController(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View(carRepository.GetAllCars());
        }


    }
}