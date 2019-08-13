using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaShare.Models;
using MediaShare.ViewModels;

namespace MediaShare.Controllers
{
    public class PhotoController : Controller
    {
        // GET: Photo
        public ActionResult Gallery()
        {
            var photos = new List<Photo>
            {
                new Photo{Likes = 1},
                new Photo{Likes = 2},
                new Photo{Likes = 3},
                new Photo{Likes = 4},
                new Photo{Likes = 5},
                new Photo{Likes = 6},
                new Photo{Likes = 7},
                new Photo{Likes = 8},
                new Photo{Likes = 9},
                new Photo{Likes = 10},
                new Photo{Likes = 11},
                new Photo{Likes = 12}
            };
            var viewModel = new PhotoLIst
            {
                photoList = photos
            };
            return View(viewModel);
        }
        public ActionResult Upload()
        {
            return View();
        }
    }
}