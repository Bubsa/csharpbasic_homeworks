namespace Exercises_in_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double doubleOne = 10.64;
            double doubleTwo = 20.32;
            double result = doubleOne / doubleTwo;
            int intOne = 8;
            int intTwo = 2;
            int resultInt = intOne / intTwo;

            Console.WriteLine(resultInt);
            Console.WriteLine(result);

            string stringOne = "Bube";
            string stringTwo = "Dube";
            string concat = stringOne + stringTwo;
            string numb1 = "9";
            string numb2 = "3";
            string numb3 = numb1 + numb2;
            Console.WriteLine(numb3);
            Console.WriteLine(concat);

            int numb4 = 6;
            string numb6 = "5";
            string numb7 = numb4 + numb6;
            Console.WriteLine(numb7);

            int credits = 102;
            int messages = 5;
            int resultOne = credits / messages;
            Console.WriteLine(resultOne);

            Console.ReadLine();
        }
    }
}
