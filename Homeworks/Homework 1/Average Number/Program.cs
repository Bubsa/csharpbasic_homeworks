namespace Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first number");
            string inputOne = Console.ReadLine();
            int parsedOne = int.Parse(inputOne);
            Console.WriteLine("Please input second number");
            string inputTwo = Console.ReadLine();
            int parsedTwo = int.Parse(inputTwo);
            Console.WriteLine("Please input third number");
            string inputThree = Console.ReadLine();
            int parsedThree = int.Parse(inputThree);
            Console.WriteLine("Please input fourth number");
            string inputFour = Console.ReadLine();
            int parsedFour = int.Parse(inputFour);
            int averageResult = (parsedOne + parsedTwo + parsedThree + parsedFour) / 4;
            Console.WriteLine("The average number is " + averageResult);
        }
    }
}
