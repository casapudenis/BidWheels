using BidWheels.Models;
using BidWheels.Repositories.Interfaces;

namespace BidWheels.Repositories
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private ApplicationDbContext _applicationDbContext;
		private IBrandRepository? _brandRepository;
		private IColorRepository? _colorRepository;
		private ITransmissionRepository? _transmissionRepository;
		private IEngineRepository? _engineRepository;

		public IBrandRepository BrandRepository
		{
			get
			{
				if (_brandRepository == null)
				{
					_brandRepository = new BrandRepository(_applicationDbContext);
				}

				return _brandRepository;
			}
		}

        public IColorRepository ColorRepository
        {
            get
            {
                if (_colorRepository == null)
                {
                    _colorRepository = new ColorRepository(_applicationDbContext);
                }

                return _colorRepository;
            }
        }

        public ITransmissionRepository TransmissionRepository
        {
            get
            {
                if (_transmissionRepository == null)
                {
                    _transmissionRepository = new TransmissionRepository(_applicationDbContext);
                }

                return _transmissionRepository;
            }
        }
        public IEngineRepository EngineRepository
        {
            get
            {
                if (_engineRepository == null)
                {
                    _engineRepository = new EngineRepository(_applicationDbContext);
                }

                return _engineRepository;
            }
        }

        public RepositoryWrapper(ApplicationDbContext applicationDbContext)
		{
			_applicationDbContext = applicationDbContext;
		}

		public void Save()
		{
			_applicationDbContext.SaveChanges();
		}
	}
}