using Core.Models;
using System;

namespace DatabaseProvider.Repositories.Abstractions
{
    public interface ICarMechanicRepository : IRepository<CarMechanic>
    {
        public List<CarMechanic> GetAll();
        public CarMechanic GetById(int id);
        public List<CarMechanic> GetByClientId(int id);
        public List<CarMechanic> GetByCarId(int id);
    }
}
