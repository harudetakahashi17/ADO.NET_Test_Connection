using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaShare.Models;
using MediaShare.ViewModels;

namespace MediaShare.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult UserView()
        {
            var userList = new List<User>
            {
                new User { Username = "harude17", Name = "Harude", Password = "Himitsu" },
                new User { Username = "harude18", Name = "Harud1", Password = "Himits1" },
                new User { Username = "harude19", Name = "Harud2", Password = "Himits2" },
                new User { Username = "harude11", Name = "Harud3", Password = "Himits3" },

            };
            var viewModel = new UserList
            {
                Users = userList
            };
            return View(viewModel);
        }
    }
}