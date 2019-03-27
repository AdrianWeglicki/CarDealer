﻿using System.Collections.Generic;
using System.Linq;

namespace CarDealer.Models
{
    public class MockCarRepository : ICarRepository
    {
        private List<Car> cars;

        public MockCarRepository()
        {
            if(cars == null)
            {
                loadCars();
            }
        }

        private void loadCars()
        {
            cars = new List<Car>()
            {
                new Car{ Id=1, Brand="Ford", Model="Mustang", YearOfProduction = 2016, Kilometers="34 000 km",
                    EngineSize = "4 900 cm3",FuelType="Diesel", EnginePower="421 KM", Description="Used car to sell",
                    Price = 120000, PhotoUrl="", ThumbnailUrl = "/images/mustang.jpg", IsCarOfTheWeek=true },
                new Car{ Id=2, Brand="Audi", Model="A4", YearOfProduction = 2016, Kilometers="34 000 km",
                    EngineSize = "4 900 cm3",FuelType="Diesel", EnginePower="421 KM", Description="Used car to sell",
                    Price = 160000, PhotoUrl="", ThumbnailUrl = "/images/audia5.jpg", IsCarOfTheWeek=true },
                new Car{ Id=3, Brand="Volvo", Model="s60", YearOfProduction = 2005, Kilometers="340 000 km",
                    EngineSize = "4 900 cm3",FuelType="Diesel", EnginePower="421 KM", Description="Used car to sell",
                    Price = 30000, PhotoUrl="", ThumbnailUrl ="/images/volvo.jpg", IsCarOfTheWeek=true },
                new Car{ Id=3, Brand="Audi", Model="a5", YearOfProduction = 2005, Kilometers="340 000 km",
                    EngineSize = "4 900 cm3",FuelType="Diesel", EnginePower="421 KM", Description="Used car to sell",
                    Price = 30000, PhotoUrl="", ThumbnailUrl = "/images/audia5.jpg", IsCarOfTheWeek=true },
                new Car{ Id=3, Brand="Volvo", Model="s60", YearOfProduction = 2005, Kilometers="340 000 km",
                    EngineSize = "4 900 cm3",FuelType="Diesel", EnginePower="421 KM", Description="Used car to sell",
                    Price = 30000, PhotoUrl="", ThumbnailUrl = "/images/volvo.jpg", IsCarOfTheWeek=true }


            };
        }

        public IEnumerable<Car> getAllCars()
        {
            return cars;
        }

        public Car getCarById(int id)
        {
            return cars.FirstOrDefault(s => s.Id == id);
        }
    }
}
