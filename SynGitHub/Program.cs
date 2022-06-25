using System;

namespace SynGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialClassCustomer customer = new PartialClassCustomer();
            customer.FirstName = "Ibrahim";
            customer.LastName = "Arafeh";
            customer.address = "Dubai-UAE";
            customer.DOB = new DateTime(1994, 01, 01);
            string fullname = customer.FullName();
            Console.WriteLine("the full name is : " + fullname);
            

        }
    }
}
