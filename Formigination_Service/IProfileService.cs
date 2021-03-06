﻿using Formigination_DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Formigination_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProfileService" in both code and config file together.
    [ServiceContract]
    public interface IProfileService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string SaveOrUpdateProfile(Profile profile);
    }
}
