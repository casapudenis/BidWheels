namespace BidWheels.Models
{
	public class Transmission
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public int Gears { get; set; }
		public ICollection<Car>? Cars { get; set; }
	}
}
