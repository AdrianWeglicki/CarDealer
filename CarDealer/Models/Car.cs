using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public string Kilometers { get; set; }
        public string EngineSize { get; set; }
        public string FuelType { get; set; }
        public string EnginePower { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string PhotoUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public bool IsCarOfTheWeek { get; set; }

        public Car()
        {

        }

      /*  public Car(int id, string brand, string model, int yearOfProduction, string kilometers, string engineSize, string fuelType, string enginePower, string description, string price, string photoUrl, string thumbnailUrl, bool isCarOfTheWeek)
        {
            Id = id;
            Brand = brand;
            Model = model;
            YearOfProduction = yearOfProduction;
            Kilometers = kilometers;
            EngineSize = engineSize;
            FuelType = fuelType;
            EnginePower = enginePower;
            Description = description;
            Price = price;
            PhotoUrl = photoUrl;
            ThumbnailUrl = thumbnailUrl;
            IsCarOfTheWeek = isCarOfTheWeek;
            //13
        }*/
    }
}
