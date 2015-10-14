using Formigination_DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formigination_DataService
{
    public class ProfileDataService
    {
        
        public string SaveProfile(Profile objProfile)
        {
            var db = MongoConnect.MongoDB();
            var collection = db.GetCollection<Profile>("Profile");
           
            collection.InsertOneAsync(objProfile);
            var id = objProfile._id;
            return "";
        }
    }
}
