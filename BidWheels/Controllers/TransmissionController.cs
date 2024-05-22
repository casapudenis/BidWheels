using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using BidWheels.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BidWheels.Controllers
{
    [Authorize(Roles = "admin")]
    public class TransmissionController : Controller
	{
		private readonly ITransmissionService _entityService;

		public TransmissionController(ITransmissionService entityService)
		{
			_entityService = entityService;
		}

		public IActionResult Index()
		{
			return View(_entityService.FindAll());
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("Id,Type,Gears")] Transmission entity)
		{
			if (ModelState.IsValid)
			{
				_entityService.Create(entity);
				return RedirectToAction(nameof(Index));
			}
			return View(entity);
		}

		public IActionResult Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var entity = _entityService.FindById(id.Value);
			if (entity == null)
			{
				return NotFound();
			}
			return View(entity);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, [Bind("Id,Type,Gears")] Transmission entity)
		{
			if (id != entity.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				_entityService.Update(entity);
				return RedirectToAction(nameof(Index));
			}
			return View(entity);
		}

		public IActionResult Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var entity = _entityService.FindById(id.Value);
			if (entity == null)
			{
				return NotFound();
			}

			return View(entity);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			var entity = _entityService.FindById(id);
			if (entity != null)
			{
				_entityService.Delete(entity);
			}
			return RedirectToAction(nameof(Index));
		}
	}
}