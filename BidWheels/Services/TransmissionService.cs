using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using BidWheels.Services.Interfaces;

namespace BidWheels.Services
{
	public class TransmissionService : ITransmissionService
	{
		private IRepositoryWrapper _repositoryWrapper;

		public TransmissionService(IRepositoryWrapper repositoryWrapper)
		{
			_repositoryWrapper = repositoryWrapper;
		}

		public List<Transmission> FindAll()
		{
			return _repositoryWrapper.TransmissionRepository.FindAll().ToList();
		}

		public Transmission? FindById(int id)
		{
			return _repositoryWrapper.TransmissionRepository.FindByCondition(e => e.Id == id).FirstOrDefault();
		}

		public void Create(Transmission entity)
		{
			_repositoryWrapper.TransmissionRepository.Create(entity);
			_repositoryWrapper.Save();
		}

		public void Update(Transmission entity)
		{
			_repositoryWrapper.TransmissionRepository.Update(entity);
			_repositoryWrapper.Save();
		}

		public void Delete(Transmission entity)
		{
			_repositoryWrapper.TransmissionRepository.Delete(entity);
			_repositoryWrapper.Save();
		}
	}
}