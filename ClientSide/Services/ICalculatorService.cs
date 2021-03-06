using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ClientSide.Services
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Sum(int a, int b);

        [OperationContract]
        int Sub(int a, int b);

        [OperationContract]
        int Div(int a, int b);

        [OperationContract]
        int Mul(int a, int b);
    }
}
