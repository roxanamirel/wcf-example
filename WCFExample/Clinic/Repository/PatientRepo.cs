using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using System.Data;

namespace Clinic.Repository
{
   public class PatientRepo
    {
        List<string> exceptions = new List<string>();
        public List<string> Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }

        public void AddPatient(Patient patient)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    context.Patients.Add(patient);
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not add patient");
                throw;
            }
        }


        public void UpdatePatient(Patient patient)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    context.Entry(patient).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not update patient");
                throw;
            }
        }

        public void DeletePatient(Guid patientId)
        {
          

                using (var context = new ClinicContext())
                {
                    Patient pat = context.Patients.SingleOrDefault(item => item.Id == patientId);

                    if (pat == null)
                    {
                        exceptions.Add("Could not delete patient");
                        throw (new Exception("The Patient does not exist."));
                    }
                    
                    context.Patients.Remove(pat);
                    context.SaveChanges();
                }
            

           

        }


        public Patient GetPatientById(Guid patientId)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    var c = context.Patients
                        // .Include("Users")
                        //.Include("UserRoles")
                                      .SingleOrDefault(item => item.Id == patientId);

                    return c;
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not find Patient");
                throw;
            }
        }

        public List<Patient> GetAllPatients()
        {
           
                using (var context = new ClinicContext())
                {
                    return context.Patients.ToList();
                }
            
           
        }
    }
}
