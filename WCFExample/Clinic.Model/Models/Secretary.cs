using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace Clinic.Models
{
    [DataContract]
    public class Secretary
    {
        public Secretary()
        {
        }
        public Secretary(Guid Id, string Name, Guid UserId)
        {
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
        public virtual User User { get; set; }
       
    }
}
