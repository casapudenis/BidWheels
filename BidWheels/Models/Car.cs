namespace BidWheels.Models
{
	public class Car
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		//public decimal StartingPrice { get; set; }

		public int BrandId { get; set; }
		public Brand? Brand { get; set; }

		public int EngineId { get; set; }
		public Engine? Engine { get; set; }

		public int TransmissionId { get; set; }
		public Transmission? Transmission { get; set; }

		public int ColorId { get; set; }
		public Color? Color { get; set; }
	}
}
