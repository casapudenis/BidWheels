using BidWheels.Models;
using BidWheels.Repositories.Interfaces;

namespace BidWheels.Repositories
{
	public class EngineRepository : RepositoryBase<Engine>, IEngineRepository
	{
		public EngineRepository(ApplicationDbContext applicationDbContext)
			: base(applicationDbContext)
		{
		}
	}
}