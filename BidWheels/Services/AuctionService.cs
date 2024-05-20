using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using BidWheels.Services.Interfaces;

namespace BidWheels.Services
{
	public class AuctionService : IAuctionService
	{
		private IRepositoryWrapper _repositoryWrapper;

		public AuctionService(IRepositoryWrapper repositoryWrapper)
		{
			_repositoryWrapper = repositoryWrapper;
		}

		public List<Auction> FindAll()
		{
			return _repositoryWrapper.AuctionRepository.FindAll().ToList();
		}

		public Auction? FindById(int id)
		{
			return _repositoryWrapper.AuctionRepository.FindByCondition(e => e.Id == id).FirstOrDefault();
		}

		public void Create(Auction entity)
		{
			_repositoryWrapper.AuctionRepository.Create(entity);
			_repositoryWrapper.Save();
		}

		public void Update(Auction entity)
		{
			_repositoryWrapper.AuctionRepository.Update(entity);
			_repositoryWrapper.Save();
		}

		public void Delete(Auction entity)
		{
			_repositoryWrapper.AuctionRepository.Delete(entity);
			_repositoryWrapper.Save();
		}
	}
}