using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_10_3_16
{
    class Customer
    {
        //Auto implemented properties, these serve to set up private fields automatically in the background.  Can do this when
        //no other logic is required in the properties

        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }

        //Auto-implement and initialize at the same time:
        public string City { get; set; } = "Mentor";

       

        //Constructor - These required fields upon creating a Customer set all the properties and backing FIELDS

        public Customer(double purchases, string name, int id)
        {
            TotalPurchases = purchases;
            Name = name;
            CustomerID = id;
        }

        

        //Methods

        public string GetContactInfo()
        {
            return "Contact Info";   //Must return a string
        }

        public string GetTransactionHistory()
        {
            return "Transaction History";   //Must return a string
        }

        


    }
}
