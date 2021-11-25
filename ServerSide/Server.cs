using ServerSide.Contracts;
using ServerSide.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide
{
    public class Server
    {
        public void Start()
        {
            var serviceAddress = "127.0.0.1:12345";
            var serviceName = "MyService";

            var host = new ServiceHost(typeof(CalculatorService), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
            var serverBinding = new NetTcpBinding();
            host.AddServiceEndpoint(typeof(ICalculatorService), serverBinding, "");
            host.Open();
        }
    }
        
}
