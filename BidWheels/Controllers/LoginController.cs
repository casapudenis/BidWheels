﻿using BidWheels.Models;
using BidWheels.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BidWheels.Controllers
{
	public class LoginController : Controller
	{
		private readonly ILoginService _loginService;

		public LoginController(ILoginService loginService)
		{
			_loginService = loginService;
		}

		[HttpGet]
		public IActionResult Index(string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(LoginModel model, string returnUrl = null)
		{
			if (ModelState.IsValid)
			{
				var result = await _loginService.SignInAsync(model.Email, model.Password, model.RememberMe);
				if (result.Succeeded)
				{
					TempData["SuccessMessage"] = "Succesfuly logged in!";
					return RedirectToAction("Index", "Home");
				}
				ModelState.AddModelError(string.Empty, "Invalid login attempt.");
			}

			return View(model);
		}
	}

}
