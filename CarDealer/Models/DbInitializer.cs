using System.Linq;

namespace CarDealer.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDBContext appDBContext)
        {
           if (!appDBContext.Cars.Any())
            {
                appDBContext.AddRange(
                     new Car
                     {
                         Brand = "Ford",
                         Model = "Mustang",
                         YearOfProduction = 2016,
                         Kilometers = "34 000 km",
                         EngineSize = "4 900 cm3",
                         FuelType = "Diesel",
                         EnginePower = "421 KM",
                         Description = "Used car to sell",
                         Price = 120000,
                         PhotoUrl = "",
                         ThumbnailUrl = "/images/mustang.jpg",
                         IsCarOfTheWeek = true
                     },
                new Car
                {
                    Brand = "Audi",
                    Model = "A4",
                    YearOfProduction = 2016,
                    Kilometers = "34 000 km",
                    EngineSize = "4 900 cm3",
                    FuelType = "Diesel",
                    EnginePower = "421 KM",
                    Description = "Used car to sell",
                    Price = 160000,
                    PhotoUrl = "",
                    ThumbnailUrl = "/images/audia5.jpg",
                    IsCarOfTheWeek = true
                },
                new Car
                {
                    Brand = "Volvo",
                    Model = "s60",
                    YearOfProduction = 2005,
                    Kilometers = "340 000 km",
                    EngineSize = "4 900 cm3",
                    FuelType = "Diesel",
                    EnginePower = "421 KM",
                    Description = "Used car to sell",
                    Price = 30000,
                    PhotoUrl = "",
                    ThumbnailUrl = "/images/volvo.jpg",
                    IsCarOfTheWeek = true
                },
                new Car
                {
                    Brand = "Audi",
                    Model = "a5",
                    YearOfProduction = 2005,
                    Kilometers = "340 000 km",
                    EngineSize = "4 900 cm3",
                    FuelType = "Diesel",
                    EnginePower = "421 KM",
                    Description = "Used car to sell",
                    Price = 30000,
                    PhotoUrl = "",
                    ThumbnailUrl = "/images/audia5.jpg",
                    IsCarOfTheWeek = true
                },
                new Car
                {
                    Brand = "Volvo",
                    Model = "s60",
                    YearOfProduction = 2005,
                    Kilometers = "340 000 km",
                    EngineSize = "4 900 cm3",
                    FuelType = "Diesel",
                    EnginePower = "421 KM",
                    Description = "Used car to sell",
                    Price = 30000,
                    PhotoUrl = "",
                    ThumbnailUrl = "/images/volvo.jpg",
                    IsCarOfTheWeek = true
                });
            
            }
            appDBContext.SaveChanges();
        }
    }
}
