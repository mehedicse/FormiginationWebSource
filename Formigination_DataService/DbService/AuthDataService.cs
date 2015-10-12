using Formigination_DataService.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formigination_DataService
{
   
    public class AuthDataService
    {
        IMongoDatabase db = MongoConnect.MongoDB();

        public string Registration(UserInfo oUserInfo)
        {
            var collection = db.GetCollection<UserInfo>("UserInfo");
            
            collection.InsertOneAsync(oUserInfo);
            return "Success";

        }

    }
}
