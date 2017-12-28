using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VeryImportantDoorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDoorService" in both code and config file together.
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract]
    public interface IDoorService
    {
        /// <summary>
        /// Gets the front door value.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetFrontDoorValue();
        /// <summary>
        /// Gets the middle door value.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetMiddleDoorValue();

    }
}
