using Client.ServiceReference;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new RequestClient(new InstanceContext(new Callback()));
            server.Open();
            try
            {
                server.SendRequest(new SaleDetails()
                {
                    Price = 100,
                    Currency = CurrenciesClass.EUR
                });
                server.SendRequest(new SaleDetails()
                {
                    Price = 200,
                    Currency = CurrenciesClass.USD
                });
                server.SendRequest(new SaleDetails()
                {
                    Price = 300,
                    Currency = CustomCurrenciesClass.GBR
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                server.Close();
            }

            Console.ReadLine();
        }
    }

    [DataContract]
    class CustomSaleDetails : SaleDetails
    {
        [DataMember]
        public new CustomCurrenciesEnum Currency { get; set; }
    }

    [DataContract(Name = "CurrenciesEnum")]
    enum CustomCurrenciesEnum
    {
        [EnumMember]
        EUR = CurrenciesEnum.EUR,
        [EnumMember]
        USD = CurrenciesEnum.USD,
        [EnumMember]
        GBP = 2
    }

    [DataContract]
    class CustomCurrenciesClass : CurrenciesClass
    {
        [DataMember]
        public static readonly CurrenciesClass GBR = new CurrenciesClass()
        {
            Value = 2,
            DisplayName = "GBR"
        };
    }
}
