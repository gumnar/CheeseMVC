using System.Collections.Generic;
using CheeseMVC.Models.Cheese;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            List<Cheese> model = CheeseData.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddCheeseViewModel addCheeseViewModel = new AddCheeseViewModel();
            return View(addCheeseViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            if (ModelState.IsValid)
            {
                Cheese newCheese = new Cheese
                {
                    Name = addCheeseViewModel.Name,
                    Description = addCheeseViewModel.Description
                };

                CheeseData.Add(newCheese);
                return Redirect("Index");
            }

            return View(addCheeseViewModel);
        }

        [HttpGet]
        public IActionResult CheckBoxDelete()
        {
            DeleteCheesesViewModel model = new DeleteCheesesViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult CheckBoxDelete(DeleteCheesesViewModel model)
        {
            if(!ModelState.IsValid)
                return View();

            model.Delete();
            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult DropDownDelete()
        {
            List<Cheese> model = CheeseData.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult DropDownDelete(Cheese cheese)
        {
            CheeseData.Remove(cheese);
            return Redirect("Index");
        }
    }
}