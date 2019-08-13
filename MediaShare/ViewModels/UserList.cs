using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediaShare.Models;

namespace MediaShare.ViewModels
{
    public class UserList
    {
        public int Id { get; set; }
        public List<User> Users { get; set; }
    }
}