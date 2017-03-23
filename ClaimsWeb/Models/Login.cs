using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaimsWeb.Models
{
    public class Login
    {
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string userid { get; set; }
    }
}