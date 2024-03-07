using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        // Field
        //public string FirstName;

        // Encapsulation
        //private string _firstName;
        //public string FirstName 
        //{
        //    get { return "Mr." + _firstName; }
        //    set { _firstName = value; } 
        //}

        // Property
        public string FirstName { get; set; }
        public int Id { get; set; } //Müşteri bilgileri tutmak
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
