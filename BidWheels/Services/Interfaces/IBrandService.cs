using BidWheels.Models;

namespace BidWheels.Services.Interfaces
{
	public interface IBrandService
	{
		List<Brand> FindAll();
		Brand? FindById(int id);
		void Create(Brand entity);
		void Update(Brand entity);
		void Delete(Brand entity);
	}
}