using BidWheels.Models;

namespace BidWheels.Services.Interfaces
{
	public interface ITransmissionService
	{
		List<Transmission> FindAll();
		Transmission? FindById(int id);
		void Create(Transmission entity);
		void Update(Transmission entity);
		void Delete(Transmission entity);
	}
}