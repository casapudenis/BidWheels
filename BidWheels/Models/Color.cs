namespace BidWheels.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
		public ICollection<Car>? Cars { get; set; }
	}
}
