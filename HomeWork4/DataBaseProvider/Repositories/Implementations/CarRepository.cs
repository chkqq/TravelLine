using Core.Models;
using DatabaseProvider.Repositories.Abstractions;
using System.Numerics;

namespace DatabaseProvider.Repositories.Implementations
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(ApplicationContext context) : base(context) { }
        
        public List<Car> GetAll()
        {
            return Entities.ToList();
        }
        
        public Car? GetById(int id)
        {
            return Entities.FirstOrDefault(d => d.CarId == id);
        }
    }
}
