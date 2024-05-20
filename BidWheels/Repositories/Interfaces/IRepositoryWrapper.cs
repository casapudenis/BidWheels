using Microsoft.Identity.Client;

namespace BidWheels.Repositories.Interfaces
{
	public interface IRepositoryWrapper
	{
        ICarRepository CarRepository { get; }
		IAuctionRepository AuctionRepository { get; }
		IBidRepository BidRepository { get; }
		IBrandRepository BrandRepository { get; }
		IColorRepository ColorRepository { get; }
        IEngineRepository EngineRepository { get; }
        ITransmissionRepository TransmissionRepository { get; }
        void Save();
	}
}