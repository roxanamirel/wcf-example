using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;


namespace Clinic.Models
{
    [DataContract]
    public class Admin
    {
        [DataMember]
        public System.Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public System.Guid UserId { get; set; }
        [DataMember]
        public virtual User User { get; set; }


    }
}
