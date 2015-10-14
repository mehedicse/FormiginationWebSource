using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formigination_DataService.Entities
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }

        public int Gender { get; set; }
        public int MeritalStatus { get; set; }
        public string BloodGroup { get; set; }
        public string Religious { get; set; }
        public string Nationality { get; set; }
        public string NationalId { get; set; }
        public string BirthCertificate {get;set; }
        public string PassportNo { get; set; }
        public string SocialId { get; set; }
        public string About { get; set; }


    }
}
