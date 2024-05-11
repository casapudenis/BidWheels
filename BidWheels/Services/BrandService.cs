using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using BidWheels.Services.Interfaces;

namespace BidWheels.Services
{
	public class BrandService : IBrandService
	{
		private IRepositoryWrapper _repositoryWrapper;

		public BrandService(IRepositoryWrapper repositoryWrapper)
		{
			_repositoryWrapper = repositoryWrapper;
		}

		public List<Brand> FindAll()
		{
			return _repositoryWrapper.BrandRepository.FindAll().ToList();
		}

		public Brand? FindById(int id)
		{
			return _repositoryWrapper.BrandRepository.FindByCondition(e => e.Id == id).FirstOrDefault();
		}

		public void Create(Brand entity)
		{
			_repositoryWrapper.BrandRepository.Create(entity);
			_repositoryWrapper.Save();
		}

		public void Update(Brand entity)
		{
			_repositoryWrapper.BrandRepository.Update(entity);
			_repositoryWrapper.Save();
		}

		public void Delete(Brand entity)
		{
			_repositoryWrapper.BrandRepository.Delete(entity);
			_repositoryWrapper.Save();
		}
	}
}