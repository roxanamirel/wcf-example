using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using Clinic.Repository;

namespace Clinic.BLL
{
    public class SecretaryBLL
    {
        private List<string> exceptions = new List<string>();
        public List<string> Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }
        public void AddSecretary(Secretary secretary)
        {
            exceptions.Clear();
            if (secretary == null)
            {
                exceptions.Add("Cannot add a null secretary");
                return;
            }
            SecretaryRepo sr = new SecretaryRepo();
            sr.AddSecretary(secretary);
        }

        public void UpdateSecretary(Secretary secretary)
        {
            exceptions.Clear();
            if (secretary == null)
            {
                exceptions.Add("Cannot update a null secretary");
                return;
            }
            SecretaryRepo sr = new SecretaryRepo();
            sr.UpdateSecretary(secretary);
        }
        public void DeleteSecretary(Guid secretary)
        {
            exceptions.Clear();
            if (secretary == null)
            {
                exceptions.Add("Cannot delete a null secretary");
                return;
            }
            SecretaryRepo sr = new SecretaryRepo();
            sr.DeleteSecretary(secretary);
        }

        public Secretary GetSecretaryById(Guid id)
        {
            exceptions.Clear();
            SecretaryRepo sr = new SecretaryRepo();
            Secretary p = sr.GetSecretaryById(id);
            if (p == null)
            {
                exceptions.Add("could not find secretary");
            }
            return p;
        }

        public List<Secretary> GetAllSecretarys()
        {
            exceptions.Clear();
            SecretaryRepo sr = new SecretaryRepo();
            var x = sr.GetAllSecretarys();
            if (x.Count == 0)
            {
                exceptions.Add("No secretarys were found");
            }
            return x.ToList();
        }

        public Secretary GetSecretaryByUserId(Guid userId)
        {
            exceptions.Clear();
            SecretaryRepo sr = new SecretaryRepo();
            Secretary s = sr.GetSecretaryByUserId(userId);
            if (s == null)
            {
                exceptions.Add("could not find secretary");
            }
            return s;
        }
    }
}
