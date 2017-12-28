using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using VeryImportantDoorService;

namespace DoorServiceHost
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Set the Uri to port 8080
            Uri baseAddress = new Uri("http://localhost:8080/DoorService");

            // Create the ServiceHost
            using (ServiceHost host = new ServiceHost(typeof(VeryImportantDoorService.DoorService), baseAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                // Add the metadata to the host description
                host.Description.Behaviors.Add(smb);

                // Start the service host on port 8080
                host.Open();

                // Indicate on the console where the service is hosted.
                Console.WriteLine("There service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                // Keep the service open until the user presses the enter key.
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
