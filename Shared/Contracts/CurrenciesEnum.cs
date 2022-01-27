using System.Runtime.Serialization;

namespace Shared.Models
{
    [DataContract]
    public enum CurrenciesEnum
    {
        [EnumMember]
        EUR,
        [EnumMember]
        USD
    }
}