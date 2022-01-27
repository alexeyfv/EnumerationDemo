using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Shared.Models;

namespace Server
{
    [ServiceContract(CallbackContract = typeof(IResponse))]
    public interface IRequest
    {
        [OperationContract]
        void SendRequest(SaleDetails saleDetails);
    }
}
