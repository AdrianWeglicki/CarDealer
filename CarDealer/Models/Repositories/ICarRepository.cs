using System.Collections.Generic;

namespace CarDealer.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
    }
}
