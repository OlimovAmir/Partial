using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    partial class Person
    {
        public string LastName { get; set; }
        public string FirsName { get; set; }

        public Person(string lastName, string firstName)
        {
            this.LastName = lastName;
            this.FirsName = firstName;
        }

       
    }
}
