using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using BidWheels.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

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
			return _repositoryWrapper.AuctionRepository.FindAll().Include(a => a.Car)
															.ThenInclude(c => c.Brand)
															.Include(a => a.Car)
															.ThenInclude(c => c.Engine)
															.Include(a => a.Car)
															.ThenInclude(c => c.Transmission)
															.Include(a => a.Car)
															.ThenInclude(c => c.Color)
															.ToList();
		}
		public Auction? FindById(int id)
		{
			return _repositoryWrapper.AuctionRepository.FindByCondition(e => e.Id == id)
														.Include(a => a.Car)
														.ThenInclude(c => c.Brand)
														.Include(a => a.Car)
														.ThenInclude(c => c.Engine)
														.Include(a => a.Car)
														.ThenInclude(c => c.Transmission)
														.Include(a => a.Car)
														.ThenInclude(c => c.Color)
														.FirstOrDefault();
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

		public void PlaceBid(Bid bid)
		{
			var auction = _repositoryWrapper.AuctionRepository.FindByCondition(a => a.Id == bid.AuctionId).FirstOrDefault();

			if(auction != null && auction.EndTime > DateTime.Now && (auction.CurrentBid == null || bid.Amount > auction.CurrentBid))
			{
				auction.CurrentBid = bid.Amount;
				auction.CurrentBidderId = bid.UserId;
				auction.Bids.Add(bid);

				_repositoryWrapper.AuctionRepository.Update(auction);
				_repositoryWrapper.BidRepository.Create(bid);
				_repositoryWrapper.Save();
			}
		}
        public List<Auction> FindByUserId(string userId)
        {
            return _repositoryWrapper.AuctionRepository
                .FindByCondition(a => a.CurrentBidderId == userId)
                .ToList();
        }
    }
}