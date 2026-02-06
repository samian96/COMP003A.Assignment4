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

            // Display the menu at the start of the console
            Console.WriteLine("\n 1. Start/ Continue Routine");

            Console.WriteLine("2. View Progress");

            Console.WriteLine("3. Exit");

            // start of a while loop
            while (active)
            {

                Console.Write("Please Enter Choice:");

                string input = Console.ReadLine();
                // start of if statement to check if the current condition is true or false to the input

                if (input == "1")
                {
                    if (step >= safety)
                    {
                        Console.WriteLine("\n Safety Limit Reached.");
                        continue; // break ends the program, preventing an endless loop of message displaying
                    }

                    step++;
                    /* checks to see if int value is equal to 3
                     * if true, will display writeline
                     * if false, will skip this step
                     * */
                    if (step == 3)
                    {
                        Console.WriteLine("\n Restricted step");
                    }
                    else
                    {
                        Console.WriteLine($"\n Current progress: {step} completed");
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine($"\n Current progress: {step} completed");
                }
                // checks to see if user input value 3 , displays writeline, then changes bool status to false to end the program
                else if (input == "3")
                {
                    Console.WriteLine("\n End of Program");
                    active = false;
                }
                else
                // displays error code if the input does not match a valid input 
                {
                    Console.WriteLine("\n invalid");
                }
            }
        }
    }
}
