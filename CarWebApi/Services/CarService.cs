using CarWebApi.Data;
using CarWebApi.Entity;

namespace CarWebApi.Services
{
    public class CarService : ICar
    {
        private AppDbContext dbContext;

        public CarService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<Car> Create(Car newlearning)
        {
            throw new NotImplementedException();
        }

        public Task<Car> Delet(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Car> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Car>> Gets()
        {
            throw new NotImplementedException();
        }

        public Task<Car> Update(Car learning)
        {
            throw new NotImplementedException();
        }
    }
}
