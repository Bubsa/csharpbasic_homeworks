namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
            string[] studentsG2 = new string[] { "John", "Paul", "Ringo", "George", "and the fifth one"};

            Console.WriteLine("Please input either 1 or 2");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("The students in G1 are: ");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    string students = studentsG1[i];
                    Console.WriteLine("\n" + students);
                }
            }
           if (input == 2)
            {
                Console.WriteLine("The students in G2 are: ");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    string students = studentsG2[i];
                    Console.WriteLine("\n" + students);
                }
            }
        }
    }
}
