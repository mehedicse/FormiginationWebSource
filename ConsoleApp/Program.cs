using Formigination_DataService;
using Formigination_DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static   void Main(string[] args)
        {
          
            TestMongo test = new TestMongo();
             test.SaveTestDocument();
            test.FindData();

            //ProfileDataService service = new ProfileDataService();
            //service.SaveProfile(new Profile() { FirstName = "Sobuj", LastName = "Islam" });


        }
    }
}
