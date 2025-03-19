using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Metoda za vrtenje na listi
            static void GoThroughCollection(IEnumerable collection, string name)
            {
                Console.WriteLine($"Collection {name} items: ");
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
                
            }

            // Kako se pravat obichni nizi
            string[] strings = new string[4];
            string [] strings2 = new string[] { "Hello", "Bye"};

            // Kako se kreira lista sho ke go ima istoto
            List<string> listOfStrings = new List<string>();

            // Lista od integeri kaj sho ke dodademe vrednost
            List<int> listOfNumbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6
            };

            // Count e istoto kako length vo nizi. Gi broi elementite sho se vnatre vo edna lista

            Console.WriteLine(listOfNumbers.Count);

            // Na listi isto taka moze da se zemaat indexi kako preku nizi

            Console.WriteLine(strings2[0]); // Tuka ke ti dade Hello
            Console.WriteLine(listOfNumbers[3]); // Tuka ke ti go dade broj 4

            // Dodavanje elementi vo niza
            Array.Resize(ref strings2, strings2.Length + 1);
            strings2[strings2.Length - 1] = "new element added";
            GoThroughCollection(strings2, "Niza od string");

            // Dodavanje na element vo lista
            listOfNumbers.Add(10);
            listOfNumbers.Remove(1);
            listOfStrings.Add("Trajan");
            listOfStrings.Add("Slave");
            listOfStrings.Add("Bob");
            listOfStrings.Remove("Trajan");
            GoThroughCollection(listOfNumbers, "Niza od string");


            List<int> numsForAdd = new List<int>() { 6, 1, 3, 5 };
            listOfNumbers.AddRange(numsForAdd);

            //GoThroughCollection(listOfNumbers, "list of numbers");
            //GoThroughCollection(listOfStrings, "list of strings");


            // Dictionary aka Rechnik. Sekogas e kluch/vrednost par. Kluchot i vrednosta moze da ima isti i razlichni tipovi. String so String, String so Int itn itn

            Dictionary<string,string> dictionaryOne = new Dictionary<string,string>();
            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string>();
            Dictionary<double, bool> dictionaryThree = new Dictionary<double, bool>();


            // Kako se dodavaat stvari vo Dictionary
            dictionaryOne.Add("song1", "Wind of Change");
            dictionaryOne.Add("song2", "Enter Sandman");
            //GoThroughCollection(dictionaryOne, "Dictionary");

            // Moze da se zeme vrednost po samiot kluch
            Console.WriteLine(dictionaryOne["song1"]);

            // Ova ni ja dava brojkata na elementi
            Console.WriteLine(dictionaryOne.Count);

            // Try Add ti dava boolean
            bool isValidBoolshit = dictionaryOne.TryAdd("song3", "song3");
            Console.WriteLine(isValidBoolshit);

            // Vaka odzemame elementi vo dictionary. SEKOGAS SE FOKUSIRAME NA KLUCHEVITE, NIKAD VREDNOSTITE
            //dictionaryOne.Remove("song1");

            // Moze da se izlistaat kluchevi i vrednosti vo stvari
            //GoThroughCollection(dictionaryOne.Keys, "Keys");
            //GoThroughCollection(dictionaryOne.Values, "Values");

            //  QUEUE (First In, First Out ili FIFO) ili REDICA
            // So enqueue se stava nesho na redicata

            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(25);
            someQueue.Enqueue(3);
            someQueue.Enqueue(111);
            GoThroughCollection(someQueue, "QUEUE");

            // Dequeue ili vadenje nesho od redica. Sekogas go vrakja prviot sho vlegol vo redicata. Zatoa First In First Out

            int element = someQueue.Dequeue();
            Console.WriteLine("Element removed: " + element);
            GoThroughCollection(someQueue, "QUEUE");
            Console.WriteLine(someQueue.Peek());
            Console.WriteLine(someQueue.Count);


            // STACK (LIFO ILI LAST IN FIRST OUT)

            Stack<string> someStack = new Stack<string>();
            someStack.Push("Hey");
            someStack.Push("Hello there");
            someStack.Push("General Kenobi");
            someStack.Push("Sup");

            string stackElement = someStack.Pop();
            Console.WriteLine(stackElement);
            Console.WriteLine(someStack.Peek());
            Console.WriteLine("Length " + someStack.Count);

            GoThroughCollection(someStack, "STACK");

            
            Exercises exercises = new Exercises();
            exercises.ExerciseOne();


        }
    }
}
