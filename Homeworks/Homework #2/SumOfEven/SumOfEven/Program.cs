namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] numArray = new int[6];

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("Enter the numbers");
                numArray[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] % 2 == 0)
                {
                    sum += numArray[i];
                }
            }
            Console.WriteLine("The sum of even numbers is " + sum);
        }
    }
}
