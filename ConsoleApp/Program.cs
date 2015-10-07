using Formigination_DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MongoConnect mong = new MongoConnect();
            //mong.MongoDB();
            TestMongo test = new TestMongo();
            test.SaveTestDocument();
            test.FindData();
        }
    }
}
