using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using BidWheels.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BidWheels.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly IBrandService _brandService;
        private readonly IEngineService _engineService;
        private readonly ITransmissionService _transmissionService;
        private readonly IColorService _colorService;
        private readonly IWebHostEnvironment _environment;

        public CarController(ICarService carService, IBrandService brandService, IEngineService engineService, ITransmissionService transmissionService, IColorService colorService, IWebHostEnvironment environment)
        {
            _carService = carService;
            _brandService = brandService;
            _engineService = engineService;
            _transmissionService = transmissionService;
            _colorService = colorService;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View(_carService.FindAll());
        }

        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_brandService.FindAll(), "Id", "Name");
            ViewData["EngineId"] = new SelectList(_engineService.FindAll(), "Id", "Name");
            ViewData["TransmissionId"] = new SelectList(_transmissionService.FindAll(), "Id", "Type");
            ViewData["ColorId"] = new SelectList(_colorService.FindAll(), "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Model,Year,BrandId,EngineId,TransmissionId,ColorId,ImageFile")] Car car)
        {
            ViewData["BrandId"] = new SelectList(_brandService.FindAll(), "Id", "Name");
            ViewData["EngineId"] = new SelectList(_engineService.FindAll(), "Id", "Name");
            ViewData["TransmissionId"] = new SelectList(_transmissionService.FindAll(), "Id", "Type");
            ViewData["ColorId"] = new SelectList(_colorService.FindAll(), "Id", "Name");

            if(car.ImageFile==null)
            {
                ModelState.AddModelError("ImageFile", "You need to add an image!");
            }
            if (ModelState.IsValid)
            {
                string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                newFileName += Path.GetExtension(car.ImageFile!.FileName);

                string imageFullPath = _environment.WebRootPath + "/cars/" + newFileName;
                using (var stream = System.IO.File.Create(imageFullPath))
                {
                    car.ImageFile.CopyTo(stream);
                }

                car.ImageFileName = newFileName;

                _carService.Create(car);
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = _carService.FindById(id.Value);
            if (car == null)
            {
                return NotFound();
            }

            ViewData["BrandId"] = new SelectList(_brandService.FindAll(), "Id", "Name");
            ViewData["EngineId"] = new SelectList(_engineService.FindAll(), "Id", "Name");
            ViewData["TransmissionId"] = new SelectList(_transmissionService.FindAll(), "Id", "Type");
            ViewData["ColorId"] = new SelectList(_colorService.FindAll(), "Id", "Name");

            return View(car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Model,Year,BrandId,EngineId,TransmissionId,ColorId,ImageFile")] Car car)
        {
            ViewData["BrandId"] = new SelectList(_brandService.FindAll(), "Id", "Name");
            ViewData["EngineId"] = new SelectList(_engineService.FindAll(), "Id", "Name");
            ViewData["TransmissionId"] = new SelectList(_transmissionService.FindAll(), "Id", "Type");
            ViewData["ColorId"] = new SelectList(_colorService.FindAll(), "Id", "Name");

            if (id != car.Id)
            {
                return NotFound();
            }

            if(car.ImageFile==null)
            {
                ModelState.AddModelError("ImageFile", "You need to add an image!");
            }
            if (ModelState.IsValid)
            {
                string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                newFileName += Path.GetExtension(car.ImageFile!.FileName);

                string imageFullPath = _environment.WebRootPath + "/cars/" + newFileName;
                using (var stream = System.IO.File.Create(imageFullPath))
                {
                    car.ImageFile.CopyTo(stream);
                }

                car.ImageFileName = newFileName;

                _carService.Update(car);
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = _carService.FindById(id.Value);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var car = _carService.FindById(id);
            if (car != null)
            {
                _carService.Delete(car);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}