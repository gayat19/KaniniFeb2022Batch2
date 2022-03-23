using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagementApplication.Models
{
    public class UserVM
    {
        [Required(ErrorMessage ="Username cannot be empty")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password cannot be empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password mismatch")]
        public string ReTypePassword { get; set; }
        public string Role { get; set; }
    }
}
