using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    public interface IResponse
    {
        [OperationContract(IsOneWay = true)]
        void SendResponse(string response);
    }
}
