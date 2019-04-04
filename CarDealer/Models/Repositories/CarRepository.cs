using System.Collections.Generic;
using System.Linq;

namespace CarDealer.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDBContext appDBContext;

        public CarRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public IEnumerable<Car> GetAllCars()
        {
            return appDBContext.Cars;
        }

        public Car GetCarById(int id)
        {
            return appDBContext.Cars.FirstOrDefault(c => c.Id == id);
        }
        public void AddCar(Car car)
        {
            appDBContext.Cars.Add(car);
            appDBContext.SaveChanges();
        }

        public void DeleteCar(Car car)
        {
            appDBContext.Cars.Remove(car);
            appDBContext.SaveChanges();
        }

        public void EditCar(Car car)
        {
            appDBContext.Cars.Update(car);
            appDBContext.SaveChanges();
        }
    }
}
