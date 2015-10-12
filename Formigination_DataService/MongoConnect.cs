using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Formigination_DataService
{
   public class MongoConnect
    {
        public static IMongoDatabase MongoDB()
        {
            MongoClient client = new  MongoClient("mongodb://sobuj:azbd123@ds053312.mongolab.com:53312");
           var db= client.GetDatabase("student");
            return db;

        }
    }
}
