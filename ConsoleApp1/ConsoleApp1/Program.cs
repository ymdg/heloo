using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string again = "yes";
            string reply = "";

            while (again.ToLower() == "yes" )
            //|| "no" || "y" || "n"
            {
                Console.WriteLine("Name the biggest club in London ");
                reply = Console.ReadLine();

            switch (reply)
            {
                    case ("Barnet"):
              Console.WriteLine("Your answer is spot on " + " \nBeeeeeZZzzz!!!!");
                break;
                    //if
                    case ("Arsenal"):
              Console.WriteLine("Your answer: " + reply + " is incorrect");
                break;
                default:
        Console.WriteLine("I don't think you and me are on the same Page!!");
                break;
                
                }
                Console.WriteLine("Would you like to ask again ? ");
                again = Console.ReadLine();

          
            }
    }
    }
}
