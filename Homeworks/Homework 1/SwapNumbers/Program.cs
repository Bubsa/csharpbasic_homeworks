namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number");
            string inputOne = Console.ReadLine();
            int parsedOne = int.Parse(inputOne);
            Console.WriteLine("Input the second number");
            string inputTwo = Console.ReadLine();
            int parsedTwo = int.Parse(inputTwo);
            (parsedOne, parsedTwo) = (parsedTwo, parsedOne); // Probav so obichno ednakvo ama samo edna vrednost mi davashe, taka da na internet go najdov ova.
            Console.WriteLine("Switched value for first input is " + parsedOne);
            Console.WriteLine("Switched value for second input is " + parsedTwo);
        }
    }
}
