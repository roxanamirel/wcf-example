using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Models;
using System.Data;

namespace Clinic.Repository
{
    public class ConsultationRepo
    {
        List<string> exceptions = new List<string>();
        public List<string> Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }
        public void AddConsultation(Consultation consultation)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    context.Consultations.Add(consultation);
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not add consultation");
                throw;
            }
        }


        public void UpdateConsultation(Consultation consultation)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    context.Entry(consultation).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not update consultation");
                throw;
            }
        }

        public void DeleteConsultation(Guid consultationId)
        {


            using (var context = new ClinicContext())
            {
                Consultation cons = context.Consultations.SingleOrDefault(item => item.Id == consultationId);

                if (cons == null)
                {
                    exceptions.Add("Could not delete consultation");
                    throw (new Exception("The Consultation does not exist."));
                }

                context.Consultations.Remove(cons);
                context.SaveChanges();
            }
        }
        public Consultation GetConsultationById(Guid consultationId)
        {
            try
            {
                using (var context = new ClinicContext())
                {
                    var c = context.Consultations
                                      .SingleOrDefault(item => item.Id == consultationId);

                    return c;
                }
            }
            catch (Exception exc)
            {
                exceptions.Add("Could not find Consultation");
                throw;
            }
        }

        public List<Consultation> GetAllConsultations()
        {

            using (var context = new ClinicContext())
            {
                return context.Consultations.ToList();
            }


        }

        public List<Consultation> GetConsultationsByPatient(Guid patientId)
        {
            using (var context = new ClinicContext())
            {
                return context.Consultations.Where(x => x.PatientId == patientId).ToList();
            }
        }

        public List<Consultation> GetConsultationsByBoctor(Guid doctorId)
        {
            using (var context = new ClinicContext())
            {
                return context.Consultations.Where(x => x.DoctorId == doctorId).ToList();
            }
        }




    }
}
