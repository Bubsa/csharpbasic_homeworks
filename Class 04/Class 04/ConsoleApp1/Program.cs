using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SayHello("Bube");
            string fullName = GetFullName("Bube", "Simonovikj");
            Console.WriteLine(fullName);
            string fName = "Marija";
            string lName = "Petrovska";
            string result = FullName(fName, lName);
            Console.WriteLine(result);
            // NIZI || ARRAYS

            // Eden nachin na definiranje na niza sho ke sodrzi 5 elementi. Sekoj pat koga ke dodelime vrednost na nekoja niza, ne smee da ima povekje od takvi elementi
            //int[] numbersArray = new int[5];
            //numbersArray[0] = 1; // nachin na dodeluvanje na vrednost preku index
            //numbersArray[3] = 5;
            ////numbersArray[7] = 6; || Ova dzitka greshka poso nie imame 5 elementi. Ne 7.

            //string[] names = new string[] { "bob", "jill", "kenny" };
            //Console.WriteLine(names[2]);
            //bool[] fullBoolArray = new bool[] { true, false, true, false }; // samo pokazuvanje deka moze da se napravi niza od booleans

            //int[] shorterWay = {1, 2, 3, 4, 5, 6, 7}; // pokratok nachin na pravenje na niza kako toa pogore
            //string[] shortWay = new string[10];

            // Razni metodi za iskoristuvanje na nizi

            // LENGTH ili dolzina na edna niza
            //Console.WriteLine(names.Length);

            // IndexOf ili baranje specificno indexi t.e elementi
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int index = Array.IndexOf(numbers, 7); // Tuka preku varijabla i ja davame vrednosta na koja index pozicija se naogja odreden element.
            //Console.WriteLine(numbers[index]);
            //Array.Reverse(numbers);
            //Console.WriteLine("Index in reverse array " + numbers[index]); // Istoto se deshava kako pogore samo poso e naopacki nizata, ti go dava rezultatot 4

            // RESIZE - Menjanje na goleminata na odredena niza. Poteshka operacija sho moze tuka da se koristi no na rabota ne bash poso mnogu memorija e potrebno za taa operacija.

            //Array.Resize(ref numbers, 20);
            //Console.WriteLine(numbers.Length);


            // FOR EACH - gi dodava elementite vo lokalni varijabli. Site stvari kako break/continue mozat da se apliciraat tuka

            //string[] cars = { "Ford", "Opel", "Tesla", "Nisan", "Kia", "Mazda", "Porsche"};

            //for (int i = 0; i < cars.Length; i++) // Tuka ako barash preku index sekogas preku for loop, a za foreach sekad e za kolekcija da izvadish
            //{
            //    string car = cars[i];
            //    Console.WriteLine(car);
            //}

            //foreach(string car in cars)
            //{
            //    if (car == "Tesla")
            //    {
            //        continue;
            //    }
            //    if (car == "Mazda")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(car);


            //    string[] laptops = { "Dell", "Acer", "Alienware", "Apple", "Nesho" };
            //    double[] integers = { 4.4, 5.6, 7.8, 9.1, 5.3 };
            //    char[] symbols = { '!', '$', '@', '#', '&' };
            //    bool[] values = { true, false, true, true, false };
            //    int[][] matrix = new int[][] { new int[] { 1, 2 } };

            ////foreach (string laptop in laptops)
            ////{
            ////    Console.WriteLine(laptop);
            ////}

            //int[] sumArray = new int[5];

            //for (int i = 0; i < sumArray.Length; i++)
            //{
            //    string input = Console.ReadLine();
            //    int number = int.Parse(input);
            //    sumArray[i] = number;
            //}

            //int sum = 0; // moze isto da se stavi default

            //foreach (int i in sumArray)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("The sum is " + sum);


            Console.WriteLine("================= METODI AMA BEZ KIRIL =====================");

            // Methods and other shit


            }

        public static void SayHello(string name) // Ova se vika signature na samata metoda. Name e samo promenliva, moze da bide bilo sho imenuvano. Naming convention
        {
            Console.WriteLine("Hello" + name);
        }
        //void znaci deka ne vrakja nisho, nema return type
        
        public static string GetFullName(string fName, string lName) // Tuka ke ti se buni ako ne stavish return posho mu pishuvas deka e od tip string (mesto void od prethodnoto)
        {
            string fullName = fName + " " + lName;
            return fullName;
        } // Ovaa e 

        public static string GetFirstName(string fName)
        {
            return fName + "FIRST NAME";
        }

        public static string GetLastName(string lName)
        {
            return lName + "LAST NAME";
        }

        public static string FullName(string fName, string lName)
        {
            string result = GetFirstName(fName);
            string result1 = GetLastName(lName);
            return result + " " + result1;
        }

    }
}

