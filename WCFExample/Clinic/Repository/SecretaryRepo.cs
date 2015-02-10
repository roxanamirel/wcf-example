using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using System.Data;

namespace Clinic.Repository
{
   public class SecretaryRepo
    {
        List<string> exceptions = new List<string>();

        public List<string> Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }

        public void AddSecretary(Secretary secretary)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    context.Secretaries.Add(secretary);
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not add secretary");
                throw;
            }
        }


        public void UpdateSecretary(Secretary doctor)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    context.Entry(doctor).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not update secretary");
                throw;
            }
        }

        public void DeleteSecretary(Guid secId)
        {
            try
            {

                using (var context = new ClinicContext())
                {
                    Secretary doc = context.Secretaries.Include("User")
                                                   .SingleOrDefault(item => item.Id == secId);

                    if (doc == null)
                    {
                        exceptions.Add("Could not delete doclyee");
                        throw (new Exception("The secretary does not exist."));
                    }

                    context.Secretaries.Remove(doc);

                    context.SaveChanges();
                }
            }

            catch (Exception exc)
            {
                exceptions.Add("Could not delete secretary");
                throw;

            }

        }


        public Secretary GetSecretaryById(Guid secretaryId)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    var c = context.Secretaries
                                      .SingleOrDefault(item => item.Id == secretaryId);

                    return c;
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not find secretary");
                throw;
            }
        }


        public Secretary GetSecretaryByUserId(Guid userId)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    var c = context.Secretaries
                                      .SingleOrDefault(item => item.UserId == userId);

                    return c;
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not find secretary");
                throw;
            }
        }



        public List<Secretary> GetAllSecretarys()
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    return context.Secretaries.ToList();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not retrieve secretaries");
                throw;
            }
        }



    }
}
