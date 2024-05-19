namespace BidWheels.Models
{
	public class Engine
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public int HorsePower { get; set; }
		public double Volume { get; set; }
		public ICollection<Car>? Cars { get; set; }
	}
}
