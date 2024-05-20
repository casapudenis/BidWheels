using BidWheels.Models;

namespace BidWheels.Services.Interfaces
{
	public interface ICarService
	{
		List<Car> FindAll();
		Car? FindById(int id);
		void Create(Car entity);
		void Update(Car entity);
		void Delete(Car entity);
	}
}