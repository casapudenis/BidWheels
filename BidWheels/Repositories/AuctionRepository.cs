using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BidWheels.Repositories
{
    public class AuctionRepository : RepositoryBase<Auction>, IAuctionRepository
    {
        public AuctionRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }
        public IQueryable<Auction> FindAll()
        {
            return ApplicationDbContext.Auctions.AsNoTracking()
                .Include(b => b.Car);
        }

        public IQueryable<Auction> FindByCondition(Expression<Func<Auction, bool>> expression)
        {
            return ApplicationDbContext.Auctions.Where(expression).AsNoTracking()
                .Include(b => b.Car);
        }

    }
}