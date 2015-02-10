using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace Clinic.Models
{
    [DataContract]
    public class User
    {

        public User()
        {
            this.Admins = new List<Admin>();
            this.Doctors = new List<Doctor>();
            this.Secretaries = new List<Secretary>();
        }
        [DataMember]
        public System.Guid Id { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Role { get; set; }
        [DataMember]
        public virtual ICollection<Admin> Admins { get; set; }
        [DataMember]
        public virtual ICollection<Doctor> Doctors { get; set; }
        [DataMember]
        public virtual ICollection<Secretary> Secretaries { get; set; }


    }
}
