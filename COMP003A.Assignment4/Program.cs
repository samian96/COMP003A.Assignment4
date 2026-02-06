namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine");

            Console.WriteLine("2. View Progress");

            Console.WriteLine("3. Exit");

            bool active = true;

            // start of a while loop
            while (active)
            {
                Console.WriteLine("\n Start/ Continue Routine");

                Console.WriteLine("2. View Progress");

                Console.WriteLine("3. Exit");

                Console.Write("Please Enter Choice:");

                string input = Console.ReadLine();
            }
        }
    }
}
