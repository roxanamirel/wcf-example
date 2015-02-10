using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using Clinic.Repository;

namespace Clinic.BLL
{
    public class ConsultationBLL
    {
        private List<string> exceptions = new List<string>();
        public List<string> Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }
        private ConsultationRepo cr = new ConsultationRepo();

        public void AddConsultation(Consultation consultation)
        {
            exceptions.Clear();
            if (consultation == null)
            {
                exceptions.Add("Cannot add a null consultation");
                return;
            }
            
            cr.AddConsultation(consultation);
        }

        public void UpdateConsultation(Consultation consultation)
        {
            exceptions.Clear();
            if (consultation == null)
            {
                exceptions.Add("Cannot update a null consultation");
                return;
            }
            
            cr.UpdateConsultation(consultation);
        }
        public void DeleteConsultation(Guid consultation)
        {
            exceptions.Clear();
            if (consultation == null)
            {
                exceptions.Add("Cannot delete a null consultation");
                return;
            }
           
            cr.DeleteConsultation(consultation);
        }

        public Consultation GetConsultationById(Guid id)
        {
            exceptions.Clear();
            
            Consultation p = cr.GetConsultationById(id);
            if (p == null)
            {
                exceptions.Add("could not find consultation");
            }
            return p;
        }

        public List<Consultation> GetAllConsultations()
        {
            exceptions.Clear();
           
            var x = cr.GetAllConsultations();
            if (x.Count == 0)
            {
                exceptions.Add("No consultations were found");
            }
            return x.ToList();
        }
        public List<Consultation> GetConsultationsByPatientId(Guid patientId)
        {
            exceptions.Clear();  
            return cr.GetConsultationsByPatient(patientId);
        }
        public List<Consultation> GetConsultationsByDoctorId(Guid doctorId)
        {
            exceptions.Clear();
            return cr.GetConsultationsByBoctor(doctorId);
        }
    }
}

