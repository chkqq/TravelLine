using Core.Models;
using DatabaseProvider.Repositories.Abstractions;
using System;

namespace DatabaseProvider.Repositories.Implementations
{
    public class CarMechanicRepository : Repository<CarMechanic>, ICarMechanicRepository
    {
        public CarMechanicRepository(ApplicationContext context) : base(context) { }
        
        public List<CarMechanic> GetAll()
        {
            return Entities.ToList();
        }
        
        public CarMechanic GetById(int id)
        {
            return Entities.FirstOrDefault(r => r.CarMechanicId == id);
        }
        
        public List<CarMechanic> GetByClientId(int id)
        {
            return Entities.Where(r => r.ClientId == id).ToList();
        }
        
        public List<CarMechanic> GetByCarId(int id)
        {
            return Entities.Where(r => r.CarId == id).ToList();
        }
    }
}
