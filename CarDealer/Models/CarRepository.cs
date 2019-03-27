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

        public IEnumerable<Car> getAllCars()
        {
            return appDBContext.Cars;
        }

        public Car getCarById(int id)
        {
            return appDBContext.Cars.FirstOrDefault(c => c.Id == id);
        }
    }
}
