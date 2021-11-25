using ClientSide;
using ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            var client = new Client();

            server.Start();
            client.Init();

            var sum = client.Service.Sum(10, 5);
            Console.WriteLine($"sum = {sum}");

            var sub = client.Service.Sub(10, 5);
            Console.WriteLine($"sub = {sub}");

            var div = client.Service.Div(10, 5);
            Console.WriteLine($"div = {div}");

            var mult = client.Service.Mul(10, 10);
            Console.WriteLine($"mult = {mult}");

            Console.ReadKey();
        }
    }
}
