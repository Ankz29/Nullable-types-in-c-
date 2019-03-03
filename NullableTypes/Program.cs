using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? AreYouMajor = null;
            Console.WriteLine("enter your first name: ");
            Console.ReadLine();
            Console.WriteLine("enter your last name: ");
            Console.ReadLine();

            Console.WriteLine("enter your age: ");
            Console.ReadLine();
            if (AreYouMajor >= 18)
            {
                Console.WriteLine("you are eligible to vote..");
                Console.ReadLine();
            }
            else if (AreYouMajor <= 18)
            {
                Console.WriteLine("you are not eligible to vote...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("user did not enter the value..");
                Console.ReadLine();
            }
        }
    }
}
