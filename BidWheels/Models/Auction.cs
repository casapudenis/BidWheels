using System;
using System.ComponentModel.DataAnnotations;

namespace BidWheels.Models
{
	public class Auction
	{
		public int Id { get; set; }
		public int CarId { get; set; }
		public Car? Car { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int StartingPrice { get; set; }
		public int? CurrentBid { get; set; }
		public string? CurrentBidderId { get; set; }
		public List<Bid>? Bids { get; set; } = [];
	}
}
