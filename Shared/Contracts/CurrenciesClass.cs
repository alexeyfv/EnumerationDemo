using System.Runtime.Serialization;

namespace Shared.Models
{
    [DataContract]
    public class CurrenciesClass : Enumeration
    {
        [DataMember]
        public static readonly CurrenciesClass EUR = new CurrenciesClass
        {
            Value = 0,
            DisplayName = "EUR"
        };

        [DataMember]
        public static readonly CurrenciesClass USD = new CurrenciesClass
        {
            Value = 1,
            DisplayName = "USD"
        };
    }
}