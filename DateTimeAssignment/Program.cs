using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine("Current date and time: " + currentDateTime);

                // user input
                Console.Write("Enter your time: ");
                string userInput = Console.ReadLine();

                // convert
                if (int.TryParse(userInput, out int hours))
                {
                    // calculate future time
                    DateTime futureDateTime = currentDateTime.AddHours(hours);
                    Console.WriteLine("In " + hours + " hours, it will be: " + futureDateTime);
                }
                else
                {
                    //handling
                    Console.WriteLine("Whoops. Please try again.");
                }

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }

    }

