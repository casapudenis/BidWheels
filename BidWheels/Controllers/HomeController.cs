using BidWheels.Models;
using BidWheels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace BidWheels.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _context;

		public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}

        public IActionResult Index()
        {
            return View(new AuctionSearchResultsViewModel());
        }

        [HttpPost]
		public IActionResult Search(AuctionSearchViewModel searchViewModel)
		{
			var auctions = _context.Auctions.Include(a => a.Car)
											.ThenInclude(c => c.Brand)
											.Include(a => a.Car.Engine)
											.Include(a => a.Car.Transmission)
											.AsQueryable();

			if (!string.IsNullOrEmpty(searchViewModel.Brand))
			{
				auctions = auctions.Where(a => a.Car.Brand.Name.Contains(searchViewModel.Brand));
			}

			if (!string.IsNullOrEmpty(searchViewModel.Model))
			{
				auctions = auctions.Where(a => a.Car.Model.Contains(searchViewModel.Model));
			}

			if (!string.IsNullOrEmpty(searchViewModel.Fuel))
			{
				auctions = auctions.Where(a => a.Car.Engine.Type.Contains(searchViewModel.Fuel));
			}

			if (!string.IsNullOrEmpty(searchViewModel.Transmission))
			{
				auctions = auctions.Where(a => a.Car.Transmission.Type.Contains(searchViewModel.Transmission));
			}

			if (searchViewModel.Mileage.HasValue)
			{
				auctions = auctions.Where(a => a.Car.Mileage <= searchViewModel.Mileage.Value);
			}

			if (searchViewModel.Price.HasValue)
			{
				auctions = auctions.Where(a => a.StartingPrice <= searchViewModel.Price.Value);
			}

			return View("Index", new AuctionSearchResultsViewModel
			{
				SearchViewModel = searchViewModel,
				Results = auctions.ToList()
			});
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
