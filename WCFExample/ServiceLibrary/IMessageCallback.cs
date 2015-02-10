using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ServiceLibrary
{
    public interface IMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnMessageAdded(Guid doctorId);
    }
}
