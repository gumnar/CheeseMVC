﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models.Cheese;
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
            return View();
        }

        [HttpPost]
        public IActionResult Add(Cheese cheese)
        {
            CheeseData.Add(cheese);
            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult CheckBoxDelete()
        {
            List<Cheese> model = CheeseData.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult CheckBoxDelete(int[] cheeseIdsToDelete)
        {
            cheeseIdsToDelete.ToList().ForEach(id => CheeseData.Remove(id));
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


        // !--HANDLES THE USER ACCOUNTS ---!
        /*
        [HttpGet]
        public IActionResult UserSignUp()
        {
            // Display user signup page
        }

        [HttpPost]
        public IActionResult UserSignUp(User user)
        {
            // Create user object and add it to the list

            // Add user object to the active session

            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult UserSignIn()
        {
            // Display user sign in page
        }

        [HttpPost]
        public IActionResult UserSignIn(User user)
        {
            // Add user from list to the active session

            return Redirect("Index");
        }

        [HttpPost]
        public IActionResult UserSignOut()
        {
            // Remove current user from the active session

            return Redirect("Index");
        }
        */

    }
}