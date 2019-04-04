using System.Collections.Generic;

namespace CarDealer.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
        void AddCar(Car car);
        void EditCar(Car car);
        void DeleteCar(Car car);

    }
}
