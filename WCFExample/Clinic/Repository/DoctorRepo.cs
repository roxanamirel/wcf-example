using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using System.Data;

namespace Clinic.Repository
{
    public class DoctorRepo
    {
        List<string> exceptions = new List<string>();

        public List<string> Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }

        public void AddDoctor(Doctor doctor)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    context.Doctors.Add(doctor);
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not add doctor");
                throw;
            }
        }


        public void UpdateDoctor(Doctor doctor)
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
                exceptions.Add("Could not update doctor");
                throw;
            }
        }

        public void DeleteDoctor(Guid doctorId)
        {
            try
            {

                using (var context = new ClinicContext())
                {
                    Doctor doc = context.Doctors.Include("User")
                                                   .SingleOrDefault(item => item.Id == doctorId);

                    if (doc == null)
                    {
                        exceptions.Add("Could not delete doctor");
                        throw (new Exception("The doctor does not exist."));
                    }

                    context.Doctors.Remove(doc);
                    context.SaveChanges();
                }
            }

            catch (Exception exc)
            {
                exceptions.Add("Could not delete doctor");
                throw;

            }

        }


        public Doctor GetDoctorById(Guid doctorId)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    var c = context.Doctors
                        // .Include("Users")
                        //.Include("UserRoles")
                                      .SingleOrDefault(item => item.Id == doctorId);

                    return c;
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not find doctor");
                throw;
            }
        }


        public Doctor GetDoctorByUserId(Guid userId)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    var c = context.Doctors
                                      .SingleOrDefault(item => item.UserId == userId);

                    return c;
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not find doctor");
                throw;
            }
        }



        public List<Doctor> GetAllDoctors()
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    return context.Doctors.ToList();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not retrieve doctors");
                throw;
            }
        }









    }
}
