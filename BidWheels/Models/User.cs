using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BidWheels.Models
{
	public class User : IdentityUser
	{
		public string Name { get; set; } = "";
		public string Address { get; set; } = "";
		public string PhoneNumber { get; set; } = "";
		
	}
}