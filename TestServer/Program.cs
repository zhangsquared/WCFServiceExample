using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Uri baseUri = new Uri("http://localhost:8080/TestService");
            using (ServiceHost host = new ServiceHost(typeof(TestService), baseUri))
            {
                WSHttpBinding binding = new WSHttpBinding();
                host.AddServiceEndpoint(typeof(ITestService), binding, "");

                ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                behavior.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                behavior.HttpGetEnabled = true;
                behavior.HttpsGetEnabled = true;

                host.Description.Behaviors.Add(behavior);

                host.Open();

                Console.WriteLine("The service is ready at {0}", baseUri.AbsoluteUri);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }

    }
}
