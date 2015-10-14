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
        public async  Task SaveTestDocument()
        {

            var collection = db.GetCollection<BsonDocument>("StudentProfile");

            var document = new BsonDocument()
            {
                { "StudentName" , "Sobuj" },
                { "StudentId" , 2 },
                { "Address", "Pabna" }
            };

            var st = new StudentProfile()
            {

                StudentName = "Sobuj",
                StudentId = 2,
                Address = "Pabna"
            };
            await  collection.InsertOneAsync(document);
            var id = st._id;


        }

        public void FindData()
        {


            var collection = db.GetCollection<BsonDocument>("StudentProfile");
            var filter = new BsonDocument();

            var result = collection.Find(filter).ToListAsync();


        }

    }



}
