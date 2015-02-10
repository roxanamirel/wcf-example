using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization;

namespace Clinic.Models
{
    [DataContract]
    public class Doctor:Observer
    {
        public Doctor()
        {
        }
        public Doctor(Guid Id, string Name, Guid UserId)
        {
            this.Consultations = new List<Consultation>();
            this.Id = Id;
            this.Name = Name;
            this.UserId = UserId;
        }
        [DataMember]
        public System.Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public System.Guid UserId { get; set; }
        [DataMember]
        public virtual ICollection<Consultation> Consultations { get; set; }
        [DataMember]
        public virtual User User { get; set; }

        public void UpdateConsult(object Traveller)
        {
            if (Traveller is ConcreteSubject)
            {
                AddConsultForDoctor(
                            (ConcreteSubject)Traveller);


            }
        }

        private void AddConsultForDoctor(ConcreteSubject traveller)
        {
            Console.WriteLine("patient has arrived");

        }
    }
}
