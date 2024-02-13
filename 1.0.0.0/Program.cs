namespace Week4Q1Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsvalidEmployeeID("yes"));
        }
        static bool IsvalidEmployeeID(string input)
        {
            Console.Write("Enter Password : ");
            input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("must be at least 6 characters...");
                return false;
            }
            return true;

        }
    }
}
