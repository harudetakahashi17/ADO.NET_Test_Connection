using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediaShare.Models;

namespace MediaShare.ViewModels
{
    public class PhotoLIst
    {
        public int Id { get; set; }
        public List<Photo> photoList { get; set; }
    }
}