using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Formigination_Service
{
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string GetData(string value)
        {
            //it takes the symbol as parameter and returns price
            for (int i = 0; i < stocks.GetLength(0); i++)
            {
                if (String.Compare(value, stocks[i, 0], true) == 0)
                    return Convert.ToString(stocks[i, 1]);
            }

            return "";
            //return string.Format("You entered: {0}", value);
        }

        
        public string Login(string user, string pass)
        {

            for (int i = 0; i < stocks.GetLength(0); i++)
            {
                if (String.Compare(user, stocks[i, 0], true) == 0)
                    return Convert.ToString(stocks[i, 1]);
            }

            return "";
        }

        #region Register

        public string Register(string email, string pass)
        {

            
            return "";
        }
        #endregion


        public string PostSampleMethod(string post)
        {
            return string.Format("You posted: {0}", post);
        }

        string[,] stocks =
   {
      {"102925", "MD Mehedi Hasan", "5"},
      {"102926", "Mahmudul", "5"},
      {"102927", "Evan", "5"},
      {"102928", "Nehar", "6"},
      {"102929", "Molla", "5"}
   };

        

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
