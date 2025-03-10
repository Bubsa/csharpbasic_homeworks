namespace String_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Substrings();
        }
        static void Substrings()
        {
            string str = "Hello from SEDC Codecademy 2024";
            string input = Console.ReadLine();
            int length = int.Parse(input);

            string newString = str.Substring(0, length);
            Console.WriteLine(string.Format("New string is \"{0}\" and the length of the new string is \"{1}\"", newString, newString.Length));
        }
    }
}
