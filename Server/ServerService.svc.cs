using Shared.Models;
using System.ServiceModel;

namespace Server
{
    public class Request : IRequest
    {
        public void SendRequest(SaleDetails saleDetails)
        {
            var response = OperationContext.Current.GetCallbackChannel<IResponse>();

            var responseString =
                 $"<SaleDetails>\n" +
                 $"\t<Price>{saleDetails.Price:N2}</Price>\n" +
                 $"\t<Currency>{saleDetails.Currency}</Currency>\n" +
                 $"</SaleDetails>";

            response.SendResponse(responseString);
        }
    }
}
