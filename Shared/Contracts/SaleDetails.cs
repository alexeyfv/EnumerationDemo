using System.Runtime.Serialization;

namespace Shared.Models
{
    [DataContract]
    public class SaleDetails
    {
        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public CurrenciesClass Currency { get; set; }
    }
}