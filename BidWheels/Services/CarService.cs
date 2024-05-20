using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using BidWheels.Services.Interfaces;

namespace BidWheels.Services
{
	public class CarService : ICarService
	{
		private IRepositoryWrapper _repositoryWrapper;

		public CarService(IRepositoryWrapper repositoryWrapper)
		{
			_repositoryWrapper = repositoryWrapper;
		}

		public List<Car> FindAll()
		{
			return _repositoryWrapper.CarRepository.FindAll().ToList();
		}

		public Car? FindById(int id)
		{
			return _repositoryWrapper.CarRepository.FindByCondition(e => e.Id == id).FirstOrDefault();
		}

		public void Create(Car entity)
		{
			_repositoryWrapper.CarRepository.Create(entity);
			_repositoryWrapper.Save();
		}

		public void Update(Car entity)
		{
			_repositoryWrapper.CarRepository.Update(entity);
			_repositoryWrapper.Save();
		}

		public void Delete(Car entity)
		{
			_repositoryWrapper.CarRepository.Delete(entity);
			_repositoryWrapper.Save();
		}
	}
}