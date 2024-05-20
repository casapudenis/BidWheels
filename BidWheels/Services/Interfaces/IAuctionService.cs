using BidWheels.Models;

namespace BidWheels.Services.Interfaces
{
	public interface IAuctionService
	{
		List<Auction> FindAll();
		Auction? FindById(int id);
		void Create(Auction auction);
		void Update(Auction auction);
		void Delete(Auction auction);
		void PlaceBid(Bid bid);
	}
}
