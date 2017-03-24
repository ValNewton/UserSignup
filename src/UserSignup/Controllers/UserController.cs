using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            //TODO 3: update this to get all users from your UserData class
            // and return it to the view.  Update the view to display some user data.
            UserData data = new UserData();
            List<User> users = new List<User>(data.FetchAll());
            return View(users);
        }

        // TODO 4: add a details controller and view that takes a single userid,
        // gets that user object from UserData, returns it to the details view
        // where it is displayed
        public IActionResult Details(int userId)
        {
            UserData data = new UserData();
            return View(data.FetchOne(userId));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            if (user.Password == verify && !String.IsNullOrEmpty(user.Username))
            {
                UserData data = new UserData();
                data.Add(user);
                return RedirectToAction("Details", new {userId = user.UserId});
            }
            else
            {
                ViewBag.PasswordError = user.Password != verify ? "Your passwords must match" : "";
                ViewBag.UsernameError = String.IsNullOrEmpty(user.Username) ? "You must enter a username" : "";
                return View(user);
            }
        }
    }
}
