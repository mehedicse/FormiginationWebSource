using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formigination_DataService.Entities
{
    public class StudentProfile
    {
        public ObjectId _id { get; set; }
        [BsonElementAttribute("StudentName")]
        public String StudentName { get; set; }
        [BsonElementAttribute("StudentId")]
        public int StudentId { get; set; }
        [BsonElementAttribute("Address")]

        public String Address { get; set; }
    }
}
