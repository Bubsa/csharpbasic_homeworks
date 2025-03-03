using System.Globalization;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (expression)
            //{

            //}

            //if (expression)
            //{

            //}
            //else // Vo Else nikogash ne stavame proverka
            //{
            //}

            // Vaka bi izgledalo obichen template na if else.

            //if (expression)
            //{

            //}
            //else if (second expression)
            //{

            //}
            //else if (third expression)
            //{

            //}
            //else
            //{

            //}


            if (3 < 5)
            {
                Console.WriteLine("I'm in if statement");
            }

            int a = 10;
            int b = 15;

            if (a <= b)
            {
                Console.WriteLine("A is larger than B");
            }
            else
            {
                Console.WriteLine("B is larger than A");
            }


            // Imame budget i treba da vidime trosenje

            //int budget = 100;

            //if (budget >= 75)
            //{
            //    Console.WriteLine("You can go to a fancy restaurant");
            //}
            //else if (budget < 75 && budget >= 50)
            //{
            //    Console.WriteLine("You can go to the movies and get popcorn");
            //}
            //else if (budget < 50 && budget >= 20)
            //{
            //    Console.WriteLine("You can get a cup of coffee");
            //}
            //else
            //{
            //    Console.WriteLine("You can stay home");
            //}

            // Apples and Trees zadacha


            //Console.WriteLine("Enter the number of trees you want");
            //string numberOfTrees = Console.ReadLine();
            //int parsedTrees = int.Parse(numberOfTrees);
            //int branches = 12;
            //int totalBranches = parsedTrees * branches;

            //int apples = 8;

            //int buckets = 5;

            //int perTree = (totalBranches * apples) / buckets;
            //Console.WriteLine(perTree);

            //int inputOne = 5;
            //int inputTwo = 4;

            //if (inputOne < inputTwo)
            //{
            //    Console.WriteLine(inputTwo + " is larger than " + inputOne);
            //}
            ////else if () 
            ////{

            ////}
            //else
            //{

            //}


            //int numberOne = 10;
            //int numberTwo = 21;

            //int largerNumber = default;

            //if (numberOne > numberTwo)
            //{
            //    largerNumber = numberOne;
            //    Console.WriteLine("The number " + numberOne + " is larger than " + numberTwo);
            //}
            //else
            //{
            //    largerNumber = numberTwo;
            //    Console.WriteLine("The number " + numberTwo + " is larger than " + numberOne);
            //}

            //if (largerNumber % 2 == 0)
            //{
            //    Console.WriteLine("Is even");
            //}
            //else
            //{
            //    Console.WriteLine("Is odd");
            //}


            // Switch sekogas raboti so konstanti. Dodeka if-ot raboti so expressions

            // Switch Template

            //int vrednost = 10;
            //switch (vrednost) 
            //{
            //    case 1:
            //        // Vlaga vo eden case i iskacha so break
            //        break;
            //        case 2:
            //        break;
            //    default:
            //        break;
            //}

            //int dayOfWeek = 5;

            //switch (dayOfWeek)
            //{
            //    case 1: Console.WriteLine("Monday");
            //        break;
            //    case 2: Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default: Console.WriteLine("No such day");
            //        break ;
            //}

            //int day = 3;

            //// Poradi faktot deka imame duplikati, gi stavame edno do drugo. Poso case 1 nema kod, si vlaga vo case 3.
            //switch (day)
            //{
            //    case 1:
            //    case 3: 
            //        Console.WriteLine("Academy");
            //        break;
            //    case 2:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Free");
            //            break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("Weekend");
            //        break;
            //    default: Console.WriteLine("no such day");
            //        break ;
            //}


            //int value = 1;

            //if (value == 1)
            //{
            //    Console.WriteLine("You got a new car!");
            //}
            //else if (value == 2)
            //{
            //    Console.WriteLine("You got a new bike!");
            //}
            //else if (value == 3)
            //{
            //    Console.WriteLine("You got a new plane!");
            //}
            //else
            //{
            //    Console.WriteLine("You You have NOTHING");
            //}


            //int valueOne = default;

            //switch (valueOne)
            //{
            //    case 1:
            //        Console.WriteLine("You got a new car!");
            //        break;
            //    case 2:
            //        Console.WriteLine("You got a new plane!");
            //        break;
            //    case 3:
            //        Console.WriteLine("You got a new bike!");
            //        break;
            //    default:
            //        Console.WriteLine("You have NOTHING");
            //        break;





            // CIKLUSI I NIZI || LOOPS AND ARRAYS

            // Obichen template za for loop
            //for (counter,expression,increment/decrement) 

            //for (int i = 0; i <= 100; i += 1)
            //{
            //    Console.WriteLine(i);
            //}

            // Beskonechen ciklus

            //for (; ; )
            //{

            //}


            // while loop so counter, za da imame counter morame da go definirame pred ciklusot

            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter += 1;
            //}

            //int aOne = 100;

            //while (aOne != 99)
            //{
            //    if (aOne == 100)
            //    {
            //        aOne = 99;
            //    }
            //}


            // do while template 

            //do
            //{

            //} while (expression);

            //int counter = 0;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter += 1;
            //} while (counter < 10);


            //for (int i = 0; i < 100; i++)
            //{
            //    if (i == 70)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("===================================================");

            //int index = 0;
            //while (index < 100)
            //{
            //    if (index % 2 == 0)
            //    {
            //        index++;
            //        continue;
            //    }
            //    Console.WriteLine(index);
            //    index++;
            //}



        }
    }
}
