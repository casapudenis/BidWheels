using BidWheels.Models;

namespace BidWheels.Services.Interfaces
{
	public interface IEngineService
	{
		List<Engine> FindAll();
		Engine? FindById(int id);
		void Create(Engine entity);
		void Update(Engine entity);
		void Delete(Engine entity);
	}
}