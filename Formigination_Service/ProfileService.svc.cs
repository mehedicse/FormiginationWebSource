using Formigination_DataService;
using Formigination_DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Formigination_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProfileService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProfileService.svc or ProfileService.svc.cs at the Solution Explorer and start debugging.
    public class ProfileService : IProfileService
    {
        public void DoWork()
        {
        }

        public string SaveOrUpdateProfile(Profile profile)
        {
            ProfileDataService service = new ProfileDataService();
            return service.SaveProfile(profile);
        }
    }
}
