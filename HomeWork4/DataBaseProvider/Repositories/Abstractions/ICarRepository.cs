using Core.Models;


namespace DatabaseProvider.Repositories.Abstractions
{
    public interface ICarRepository : IRepository<Car>
    {
        public List<Car> GetAll();
        public Car GetById(int id);
    }
}
