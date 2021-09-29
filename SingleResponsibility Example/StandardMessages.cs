using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Example
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press enter to close...");
            Console.Read();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give a valid {fieldName}!");
        }
    }
}
