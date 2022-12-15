using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS_WEB.Models
{
    public class Login
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class ResetPassword : Login
    {
        public string Type { get; set; }
    }
}