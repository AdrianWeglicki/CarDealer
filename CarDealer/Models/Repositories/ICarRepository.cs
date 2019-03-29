using System.Collections.Generic;

namespace CarDealer.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> getAllCars();
        Car getCarById(int id);
    }
}
