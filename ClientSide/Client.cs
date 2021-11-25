using ClientSide.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientSide
{
    public class Client
    {
        public ICalculatorService Service { get; set; }

        public void Init()
        {
            var serviceAddress = "127.0.0.1:12345";
            var serviceName = "MyService";

            Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
            EndpointAddress address = new EndpointAddress(tcpUri);
            NetTcpBinding clientBinding = new NetTcpBinding();
            ChannelFactory<ICalculatorService> factory = new ChannelFactory<ICalculatorService>(clientBinding, address);
            this.Service = factory.CreateChannel();
        }
    }
}
