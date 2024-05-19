using BidWheels.Models;

namespace BidWheels.Services.Interfaces
{
	public interface IColorService
	{
		List<Color> FindAll();
		Color? FindById(int id);
		void Create(Color entity);
		void Update(Color entity);
		void Delete(Color entity);
	}
}