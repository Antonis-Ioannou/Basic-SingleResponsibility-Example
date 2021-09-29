using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            StandardMessages.WelcomeMessage();

            //Ask for user information
            Person user = PersonDataCapture.Capture();

            //checks to be sure the first and last names are valid
            bool isUserValid = PersonValidator.Validate(user);
            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            //create username for the person
            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}
