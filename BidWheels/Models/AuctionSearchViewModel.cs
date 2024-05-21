using BidWheels.Models;

namespace BidWheels.ViewModels
{
	public class AuctionSearchViewModel
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Fuel { get; set; }
		public string Transmission { get; set; }
		public int? Mileage { get; set; }
		public int? Price { get; set; }
	}

	public class AuctionSearchResultsViewModel
	{
		public AuctionSearchViewModel SearchViewModel { get; set; }
		public List<Auction> Results { get; set; }
	}
}
