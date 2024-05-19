using Microsoft.Identity.Client;

namespace BidWheels.Repositories.Interfaces
{
	public interface IRepositoryWrapper
	{
		IBrandRepository BrandRepository { get; }
		IColorRepository ColorRepository { get; }
        IEngineRepository EngineRepository { get; }
        ITransmissionRepository TransmissionRepository { get; }
        void Save();
	}
}