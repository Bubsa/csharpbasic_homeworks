using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercises
    {
       public void ExerciseOne()
        {
            Dictionary<string, int> exerciseDictionary = new Dictionary<string, int>();
            {

                exerciseDictionary.Add("Bube", 123);
                exerciseDictionary.Add("Paul", 456);
                exerciseDictionary.Add("Ringo", 789);
                exerciseDictionary.Add("John", 258);
                exerciseDictionary.Add("George", 8910);

                string input = Console.ReadLine();

                if (exerciseDictionary.ContainsKey(input))
                {
                    Console.WriteLine(input);
                }
                
            }
        }
    }
}
