using BidWheels.Models;
using BidWheels.Services;
using BidWheels.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BidWheels.Controllers
{
	public class RegisterController : Controller
	{
		private readonly IRegisterService _registerService;
		private readonly IWebHostEnvironment _environment;

		public RegisterController(IRegisterService registerService, IWebHostEnvironment environment)
		{
			_registerService = registerService;
			_environment = environment;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(RegisterModel model)
		{
			if (ModelState.IsValid)
			{
				var result = await _registerService.RegisterAsync(model);
				if (result.Succeeded)
				{
					TempData["SuccessMessage"] = "Succesfuly registered!";
					return RedirectToAction("Index", "Home");
				}
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
			}
			return View(model);
		}

	}
}
