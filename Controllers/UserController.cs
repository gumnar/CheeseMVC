using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models.User;
using CheeseMVC.ViewModels;

namespace CheeseMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Display sign in page
        [HttpGet]
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        // Create user account
        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                if (addUserViewModel.Password == addUserViewModel.Verify)
                {
                    User newUser = new User
                    {
                        Username = addUserViewModel.Username,
                        Password = addUserViewModel.Password,
                        Email = addUserViewModel.Email
                    };

                    UserData.AddUser(newUser);
                    return Redirect("Index");

                }
                else
                    return View(addUserViewModel);
            }
            else
                return View(addUserViewModel);
        }
    }
}