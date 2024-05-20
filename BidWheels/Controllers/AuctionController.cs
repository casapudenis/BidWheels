using BidWheels.Models;
using BidWheels.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BidWheels.Controllers
{
	[Authorize]
	public class AuctionController : Controller
	{
		private readonly IAuctionService _auctionService;
		private readonly ICarService _carService;

		public AuctionController(IAuctionService auctionService, ICarService carService)
		{
			_auctionService = auctionService;
			_carService = carService;
		}

		public IActionResult Index()
		{
			return View(_auctionService.FindAll());
		}

		public IActionResult Create()
		{
			ViewData["CarId"] = new SelectList(_carService.FindAll(), "Id", "Model");
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("Id,CarId,StartTime,EndTime,StartingPrice")] Auction auction)
		{
			ViewData["CarId"] = new SelectList(_carService.FindAll(), "Id", "Model");

			if (ModelState.IsValid)
			{
				_auctionService.Create(auction);
				return RedirectToAction(nameof(Index));
			}
			return View(auction);
		}

		public IActionResult Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var auction = _auctionService.FindById(id.Value);
			if (auction == null)
			{
				return NotFound();
			}

			return View(auction);
		}

		public IActionResult Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var auction = _auctionService.FindById(id.Value);
			if (auction == null)
			{
				return NotFound();
			}

			ViewData["CarId"] = new SelectList(_carService.FindAll(), "Id", "Model");
			return View(auction);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, [Bind("Id,CarId,StartTime,EndTime,StartingPrice,CurrentBid,CurrentBidderId")] Auction auction)
		{
			if (id != auction.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				_auctionService.Update(auction);
				return RedirectToAction(nameof(Index));
			}

			ViewData["CarId"] = new SelectList(_carService.FindAll(), "Id", "Model");
			return View(auction);
		}

		public IActionResult Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var auction = _auctionService.FindById(id.Value);
			if (auction == null)
			{
				return NotFound();
			}

			return View(auction);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			var auction = _auctionService.FindById(id);
			if (auction != null)
			{
				_auctionService.Delete(auction);
			}
			return RedirectToAction(nameof(Index));
		}
	}
}
