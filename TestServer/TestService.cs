using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        string Test(string name);
    }


    public class TestService : ITestService
    {
        public string Test(string name)
        {
            Console.WriteLine("Receive request name = " + name);
            string response = $"Hello, {name}";
            return response;
        }
    }


}
