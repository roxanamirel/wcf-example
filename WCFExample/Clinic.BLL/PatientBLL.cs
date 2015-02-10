using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using Clinic.Repository;

namespace Clinic.BLL
{
   public class PatientBLL
    {
       private List<string> exceptions = new List<string>();
       public List<string> Exceptions
       {
           get { return exceptions; }
           set { exceptions = value; }
       }
       public void AddPatient(Patient patient)
       {
           exceptions.Clear();
           if (patient == null)
           {
               exceptions.Add("Cannot add a null patient");
               return;
           }
           PatientRepo pr = new PatientRepo();
           pr.AddPatient(patient);
       }

       public void UpdatePatient(Patient patient)
       {
           exceptions.Clear();
           if (patient == null)
           {
               exceptions.Add("Cannot update a null patient");
               return;
           }
           PatientRepo pr = new PatientRepo();
           pr.UpdatePatient(patient);
       }
       public void DeletePatient(Guid patient)
       {
           exceptions.Clear();
           if (patient == null)
           {
               exceptions.Add("Cannot delete a null patient");
               return;
           }
           PatientRepo pr = new PatientRepo();
           pr.DeletePatient(patient);
       }

       public Patient GetPatientById(Guid id)
       {
           exceptions.Clear();
           PatientRepo pr = new PatientRepo();
           Patient p = pr.GetPatientById(id);
           if (p == null)
           {
               exceptions.Add("could not find patient");
           }
           return p;
       }

       public List<Patient> GetAllPatients()
       {
           exceptions.Clear();
           PatientRepo pr = new PatientRepo();
           var x = pr.GetAllPatients();
           if (x.Count == 0)
           {
               exceptions.Add("No patients were found");
           }
           return x.ToList();
       }

    }
}
