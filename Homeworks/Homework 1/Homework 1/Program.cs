namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please input first number");
                string inputOne = Console.ReadLine();
                int parsedOne = int.Parse(inputOne);
                Console.WriteLine("Please input second number");
                string inputTwo = Console.ReadLine();
                int parsedTwo = int.Parse(inputTwo);
                Console.WriteLine("Please input the operation: +. -, *. /");
                string operation = Console.ReadLine();

                switch(operation) // Da bidam iskren, ne znam dali mu napraviv over engineering ama switch case-ov mi pomogna. Najdov na net implementacija so switch case i da bidam iskren posledniot 
                    // del dosta mi pomogna, inache aplikacijata ke si terashe. 
                {
                    case "+":
                        Console.WriteLine("The result is: " + (parsedOne + parsedTwo));
                        break;

                    case "-":
                        Console.WriteLine("The result is: " + (parsedOne - parsedTwo));
                        break;

                    case "*":
                        Console.WriteLine("The result is:" + (parsedOne * parsedTwo));

                        break;

                    case "/":
                        if (parsedTwo == 0) 
                        {
                            Console.WriteLine("Result is 0");
                        } else
                        {
                            Console.WriteLine("The result is: " + (parsedOne / parsedTwo));
                            
                        }
                        break;
                }
                Console.WriteLine("Do you want to exit the app? Type Y or N");
                char kill = Convert.ToChar(Console.ReadLine());
                if (kill == 'Y' || kill == 'y')
                {
                    break;
                }


            }





            }
        }
    }

