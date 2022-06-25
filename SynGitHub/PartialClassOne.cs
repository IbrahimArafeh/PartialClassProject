using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynGitHub
{
    public partial class PartialClassCustomer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string address { get; set; }
        public DateTime DOB { get; set; }
    }
}
