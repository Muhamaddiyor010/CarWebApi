using CarWebApi.Entity;

namespace CarWebApi.Services
{
    public interface ICar
    {
        
        Task<List<Car>> Gets();
        Task<Car> Get(Guid id);
        Task<Car> Create(Car newlearning);
        Task<Car> Update(Car learning);
        Task<Car> Delet(Guid id);
    }
}

