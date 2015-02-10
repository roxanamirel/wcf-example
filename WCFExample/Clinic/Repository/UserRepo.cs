using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using System.Data;

namespace Clinic.Repository
{
   public class UserRepo
    {
        List<string> exceptions = new List<string>();

        public List<string> Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }
        public void AddUser(User user)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not insert into database");
                throw;
            }
        }


        public void UpdateUser(User user)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    context.Entry(user).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not update database");
                throw;
            }
        }

        public void DeleteUser(Guid userId)
        {
            try
            {

                using (var context = new ClinicContext())
                {
                    User user = context.Users
                                          .SingleOrDefault(item => item.Id == userId);

                    if (user == null)
                    {
                        throw (new Exception("The user does not exist."));
                    }

                    context.Users.Remove(user);

                    context.SaveChanges();
                }
            }

            catch (Exception exc)
            {
                exceptions.Add("Could not delete from database");
                throw;

            }

        }


        public User GetUserById(Guid userId)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    var c = context.Users
                                   .SingleOrDefault(item => item.Id == userId);

                    return c;
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not get user by id");
                throw;
            }
        }


        public User GetUserByName(String userName)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    var c = context.Users
                        
                                   .SingleOrDefault(item => item.Username == userName);

                    return c;
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could nor find user");
                throw;
            }
        }



        public List<User> GetAllUsers()
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    return context.Users.ToList();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("could not list users");
                throw;
            }
        }


    }
}
