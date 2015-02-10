using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;

namespace Clinic.Models
{
   [DataContract]
    public class Consultation
    {

        
        public Consultation(Guid Id, Guid PatientId, Guid DoctorId, DateTime Date, TimeSpan Hour, string Result)
        {
            this.Id = Id;
            this.PatientId = PatientId;
            this.DoctorId = DoctorId;
            this.Date = Date;
            this.Hour = Hour;
            this.Result = Result;
        }
        public Consultation() { }
        [DataMember]
        public System.Guid Id { get; set; }
        [DataMember]
        public System.Guid PatientId { get; set; }
        [DataMember]
        public System.Guid DoctorId { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Date { get; set; }
        [DataMember]
        public string Result { get; set; }
        [DataMember]
        public Nullable<System.TimeSpan> Hour { get; set; }
        [DataMember]
        public virtual Doctor Doctor { get; set; }
        [DataMember]
        public virtual Patient Patient { get; set; }

    }
   
}
