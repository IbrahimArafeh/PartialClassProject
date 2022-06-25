using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynGitHub
{
    public partial class PartialClassCustomer
    {
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
