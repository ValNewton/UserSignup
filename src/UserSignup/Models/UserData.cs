using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        //TODO 2: instantiate a few new users in code here and add them to your users list
        //then write methods to add users to your list, return all users and return a user by UserId

        private static int nextUserId = 1;
        private static readonly List<User> users = new List<User>();

        public void Add(User user)
        {
            user.UserId = nextUserId++;
            users.Add(user);
        }

        public User[] FetchAll()
        {
            return users.ToArray();
        }

        public User FetchOne(int userId)
        {
            return users.Find(u => u.UserId == userId);
        }

        static UserData()
        {
            users.Add(new User()
            {
                UserId = nextUserId++,
                Email = "mal@serinity.com",
                FullName = "Malcolm Reynolds",
                Password = "misbehave",
                PhoneNumber = "555-1212"
            });

            users.Add(new User()
            {
                UserId = nextUserId++,
                Email = "zoe@serinity.com",
                FullName = "Zoe",
                Password = "wash",
                PhoneNumber = "555-2323"
            });

            users.Add(new User()
            {
                UserId = nextUserId++,
                Email = "jayne@serinity.com",
                FullName = "Jayne",
                Password = "vera",
                PhoneNumber = "555-3434"
            });

            users.Add(new User()
            {
                UserId = nextUserId++,
                Email = "jayne@serinity.com",
                FullName = "Jayne Cobb",
                Password = "vera",
                PhoneNumber = "555-3434"
            });

            users.Add(new User()
            {
                UserId = nextUserId++,
                Email = "kaylee@serinity.com",
                FullName = "Kaylee Frye",
                Password = "shiny",
                PhoneNumber = "555-4545"
            });
        }

    }
}
