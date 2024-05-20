using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BidWheels.Repositories
{
	public class CarRepository : RepositoryBase<Car>, ICarRepository
	{
		public CarRepository(ApplicationDbContext applicationDbContext)
			: base(applicationDbContext)
		{
		}
		public IQueryable<Car> FindAll()
		{
			return ApplicationDbContext.Cars.AsNoTracking()
				.Include(b => b.Brand)
				.Include(b => b.Engine)
				.Include(b => b.Transmission)
				.Include(b => b.Color);
		}

		public IQueryable<Car> FindByCondition(Expression<Func<Car, bool>> expression)
		{
			return ApplicationDbContext.Cars.Where(expression).AsNoTracking()
				.Include(b => b.Brand)
				.Include(b => b.Engine)
				.Include(b => b.Transmission)
				.Include(b => b.Color);
		}

	}
}