using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using BidWheels.Services.Interfaces;

namespace BidWheels.Services
{
	public class EngineService : IEngineService
	{
		private IRepositoryWrapper _repositoryWrapper;

		public EngineService(IRepositoryWrapper repositoryWrapper)
		{
			_repositoryWrapper = repositoryWrapper;
		}

		public List<Engine> FindAll()
		{
			return _repositoryWrapper.EngineRepository.FindAll().ToList();
		}

		public Engine? FindById(int id)
		{
			return _repositoryWrapper.EngineRepository.FindByCondition(e => e.Id == id).FirstOrDefault();
		}

		public void Create(Engine entity)
		{
			_repositoryWrapper.EngineRepository.Create(entity);
			_repositoryWrapper.Save();
		}

		public void Update(Engine entity)
		{
			_repositoryWrapper.EngineRepository.Update(entity);
			_repositoryWrapper.Save();
		}

		public void Delete(Engine entity)
		{
			_repositoryWrapper.EngineRepository.Delete(entity);
			_repositoryWrapper.Save();
		}
	}
}