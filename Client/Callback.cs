using Client.ServiceReference;
using System;

namespace Client
{
    class Callback : IRequestCallback
    {
        public void SendResponse(string response) => Console.WriteLine(response);
    }
}
