using System.Collections.Generic;
using System.Linq;

namespace CheeseMVC.Models.User
{
    public class UserData
    {
        public static List<User> users = new List<User>();
        public static int nextId = 1;


        public static List<User> GetAll()
        {
            List<User> userList  = new List<User>();
            userList.AddRange(users);

            return userList;
        }

        public static User GetUser(int userId)
        {
            return users.SingleOrDefault(usr => usr.UserId == userId);
        }

        public static void AddUser(User user)
        {
            user.UserId = nextId++;
            users.Add(user);
        }

        public static void RemoveUser(int userId)
        {
            users.RemoveAll(usr => usr.UserId == userId);
        }

        public static void RemoveUser(User user)
        {
            RemoveUser(user.UserId);
        }
    }
}
