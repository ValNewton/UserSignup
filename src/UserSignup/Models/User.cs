using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {
        // TODO 1: Add UserId, CreateDate and a few more properties of your choosing.  Update the Add and Index views
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        // add a constructor to set the CreateDate when a new user is instantiated
        public User()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
