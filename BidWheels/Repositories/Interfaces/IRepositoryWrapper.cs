using Microsoft.Identity.Client;

namespace BidWheels.Repositories.Interfaces
{
	public interface IRepositoryWrapper
	{
		IBrandRepository BrandRepository { get; }

		void Save();
	}
}