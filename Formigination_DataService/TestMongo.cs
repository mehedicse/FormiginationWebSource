using Formigination_DataService.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formigination_DataService
{
    public class TestMongo
    {
        IMongoDatabase db = MongoConnect.MongoDB();
        public void SaveTestDocument()
        {

            var collection = db.GetCollection<StudentProfile>("StudentProfile");
            var st = new StudentProfile()
            {
                StudentId = 1,
                StudentName = "Sobuj"
            };
            collection.InsertOneAsync(st);



        }

        public void FindData()
        {
            

            var collection = db.GetCollection<BsonDocument>("StudentProfile");
            var filter = new BsonDocument();
            
            var result =   collection.Find(filter).ToListAsync();


        }

    }

    

}
