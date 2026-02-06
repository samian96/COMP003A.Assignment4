using System.ComponentModel.Design;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine");

            Console.WriteLine("2. View Progress");

            Console.WriteLine("3. Exit");

            int step = 0;

            int safety = 6;

            bool active = true;

            // start of a while loop
            while (active)
            {
                // Display the menu at the start of the console
                Console.WriteLine("\n 1. Start/ Continue Routine");

                Console.WriteLine("2. View Progress");

                Console.WriteLine("3. Exit");

                Console.Write("Please Enter Choice:");

                string input = Console.ReadLine();
                // start of if statement to check if the current condition is true or false to the input

                if (input == "1")
                {
                    if (step >= safety)
                    {
                        Console.WriteLine("Safety Limit Reached");
                        continue;
                    }

                    step++;

                    if (step == 3)
                    {
                        Console.WriteLine("Restricted step");
                    }
                    else
                    {
                        Console.WriteLine($"Current progress: {step} completed");
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine($"Current progress: {step} completed");
                }
                // checks to see if user input value 3 , displays writeline, then changes bool status to false to end the program
                else if (input == "3")
                {
                    Console.WriteLine("End of Program");
                    active = false;
                }
            }
        }
    }
}
