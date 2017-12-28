using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VeryImportantDoorService
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VeryImportantDoorService.IDoorService" />
    public class DoorService : IDoorService
    {
        /// <summary>
        /// Gets the front door value.
        /// </summary>
        /// <returns></returns>
        public string GetFrontDoorValue()
        {
            Random rand = new Random();
            string answer;
            // Make a random value
            switch (rand.Next(0, 3))
            {
                case 0:
                    answer = "OPEN";
                    break;
                case 1:
                    answer = "CLOSED AND UNLOCKED";
                    break;
                default:
                    answer = "CLOSED AND LOCKED";
                    break;
            }
            // Show that data is being returned by the service.
            Console.WriteLine("Returning the state of the front door.");
            Console.WriteLine("The sensor reads: " + answer);
            return answer;
        }

        /// <summary>
        /// Gets the middle door value.
        /// </summary>
        /// <returns></returns>
        public string GetMiddleDoorValue()
        {
            Random rand = new Random();
            string answer;
            // Make a random value
            switch (rand.Next(0, 3))
            {
                case 0:
                    answer = "OPEN";
                    break;
                case 1:
                    answer = "CLOSED AND UNLOCKED";
                    break;
                default:
                    answer = "CLOSED AND LOCKED";
                    break;
            }
            // Show that data is being returned by the service.
            Console.WriteLine("Returning the state of the middle door.");
            Console.WriteLine("The sensor reads: " + answer);
            return answer;
        }

    }
}
