using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Example
{
    class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {

        }

        public Person(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }
    }
}
