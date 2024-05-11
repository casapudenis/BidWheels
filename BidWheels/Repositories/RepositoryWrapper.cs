using BidWheels.Models;
using BidWheels.Repositories.Interfaces;

namespace BidWheels.Repositories
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private ApplicationDbContext _applicationDbContext;
		private IBrandRepository? _brandRepository;

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