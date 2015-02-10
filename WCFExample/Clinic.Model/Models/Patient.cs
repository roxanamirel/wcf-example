using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;

namespace Clinic.Models
{
    [DataContract]
    public class Patient
    {
        public Patient(System.Guid Id, string Name, string CNP, string  IdentityCardNo,string Address)
        {
            this.Consultations = new List<Consultation>();
            this.Id = Id;
            this.Name = Name;
            this.CNP = CNP;
            this.IdentityCardNo = IdentityCardNo;
            this.Address = Address;
        }
        public Patient()
        {

        }
        [DataMember]
        public System.Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string IdentityCardNo { get; set; }
        [DataMember]
        public string CNP { get; set; }
        [DataMember]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public virtual ICollection<Consultation> Consultations { get; set; }

      
    }
}
