using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using Clinic.Repository;

namespace Clinic.BLL
{
  public  class DoctorBLL
    {
        private List<string> exceptions = new List<string>();
        public List<string> Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }

        public void AddDoctor(Doctor doctor)
        {
            exceptions.Clear();
            if (doctor == null)
            {
                exceptions.Add("Cannot add a null doctor");
                return;
            }
            DoctorRepo dr = new DoctorRepo();
            dr.AddDoctor(doctor);
        }

        public void UpdateDoctor(Doctor doctor)
        {
            exceptions.Clear();
            if (doctor == null)
            {
                exceptions.Add("Cannot update a null doctor");
                return;
            }
            DoctorRepo dr = new DoctorRepo();
            dr.UpdateDoctor(doctor);
        }
        public void DeleteDoctor(Guid doctor)
        {
            exceptions.Clear();
            if (doctor == null)
            {
                exceptions.Add("Cannot delete a null doctor");
                return;
            }
            DoctorRepo dr = new DoctorRepo();
            dr.DeleteDoctor(doctor);
        }

        public Doctor GetDoctorById(Guid id)
        {
            exceptions.Clear();
            DoctorRepo dr = new DoctorRepo();
            Doctor p = dr.GetDoctorById(id);
            if (p == null)
            {
                exceptions.Add("could not find doctor");
            }
            return p;
        }

        public Doctor GetDoctorByUserId(Guid id)
        {
            exceptions.Clear();
            DoctorRepo dr = new DoctorRepo();
            Doctor p = dr.GetDoctorByUserId(id);
            if (p == null)
            {
                exceptions.Add("could not find doctor");
            }
            return p;
        }


        public List<Doctor> GetAllDoctors()
        {
            exceptions.Clear();
            DoctorRepo dr = new DoctorRepo();
            var x = dr.GetAllDoctors();
            if (x.Count == 0)
            {
                exceptions.Add("No doctors were found");
            }
            return x.ToList();
        }
    }
}
