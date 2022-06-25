using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynGitHub
{
    internal class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string address { get; set; }
        public DateTime DOB { get; set; }


        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
