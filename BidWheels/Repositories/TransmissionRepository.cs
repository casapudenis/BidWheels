using BidWheels.Models;
using BidWheels.Repositories.Interfaces;

namespace BidWheels.Repositories
{
	public class TransmissionRepository : RepositoryBase<Transmission>, ITransmissionRepository
	{
		public TransmissionRepository(ApplicationDbContext applicationDbContext)
			: base(applicationDbContext)
		{
		}
	}
}