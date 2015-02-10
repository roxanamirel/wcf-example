using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using Clinic.Repository;

namespace Clinic.BLL
{
    public class UserBLL
    {
        List<string> exceptions = new List<string>();

        public List<string> Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }
        public void AddUser(User user)
        {
            exceptions.Clear();
            UserRepo ur = new UserRepo();
            if (user == null)
            {
                exceptions.Add("cannot add null in the db");
            }
            else
            {
                ur.AddUser(user);
            }
        }

        public void UpdateUser(User user)
        {
            exceptions.Clear();
            UserRepo ur = new UserRepo();
            if (user == null)
            {
                exceptions.Add("cannot add null in the db");
            }
            else
            {
                ur.UpdateUser(user);
            }
        }

        public void DeleteUser(Guid userId)
        {
            exceptions.Clear();
            UserRepo ur = new UserRepo();
            ur.DeleteUser(userId);
        }

        public User GetUserById(Guid userId)
        {
            exceptions.Clear();
            UserRepo ur = new UserRepo();
            User user = ur.GetUserById(userId);
            if (user == null)
            {
                exceptions.Add("Could not find user");
            }
            return user;
        }

        public User GetUserByName(String userName)
        {
            exceptions.Clear();
            UserRepo ur = new UserRepo();
            User user = ur.GetUserByName(userName);
            if (user == null)
            {
                exceptions.Add("Could not find user");
            }
            return user;
        }

        public List<User> GetAllUsers()
        {
            exceptions.Clear();
            UserRepo ur = new UserRepo();
            var x = ur.GetAllUsers();
            if (x == null)
            {
                exceptions.Add("could not find users ");
            }
            return x.ToList();
        }

        public string checkLogedInUser(String username, String password)
        {
            exceptions.Clear();

            UserRepo ur = new UserRepo();
            User user = ur.GetUserByName(username);

            if (user == null)
            {
                exceptions.Add("The username does not exist");
                return null;

            }
            if (!user.Password.Equals(password))
            {
                exceptions.Add("Incorrect password");
                return null;

            }
            string role = user.Role;
            if (role == null || role.Equals(""))
            {
                exceptions.Add("This user doesn't have a role attached");
            }
            return role;
        }
    }
}
