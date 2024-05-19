using BidWheels.Models;
using BidWheels.Repositories.Interfaces;

namespace BidWheels.Repositories
{
	public class ColorRepository : RepositoryBase<Color>, IColorRepository
	{
		public ColorRepository(ApplicationDbContext applicationDbContext)
			: base(applicationDbContext)
		{
		}
	}
}