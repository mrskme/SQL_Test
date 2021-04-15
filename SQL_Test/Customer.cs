#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Test
{
    public class Customer
    {
        public string FirstName;
        public string? MiddleName;
        public string LastName;

        public Customer( string firstName, string lastName, string? middleName = null)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

    }
}
