namespace Class_02_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Ovaka se deklarira varijabla. Ako ja ostavis sama po sebe ima vrednost od NULA
            //int number;

            //// Vaka ja incijalizirash. Sekogash mora da ima vrednost
            //number = 10;
            //// Ova podole
            //int num = 10;
            //short smallInt = 10;
            //byte verySmallInt = 10;
            //long biggerInt = 1000000;

            //float floatNumber = 10.10f;
            //double doubleNumber = 10.00d;
            //decimal decimalNumber = 10.12m;

            //char character = 'A';
            //string str = "Bube";

            //bool isValid = false;
            //bool hasValue = true;

            //object obj = 1;
            //object objOne = "something";
            //object objTwo = true;
            //// Site benefiti sho gi nosat site prethodni tipovi, shtom se stavat vo objekt, togas nema da gi prepoznae. Ke gi tretira kako obichen object.

            //int defaultInt = default; // tuka dobivame NULA
            //Console.WriteLine(defaultInt);
            //bool isDefault = default; // tuka ke bide FALSE
            //Console.WriteLine(isDefault);
            //string str2 = default; // DEFAULT VALUE E NULL
            //Console.WriteLine(str2);
            //string str3 = "";
            //string str4 = string.Empty; // tuka ke bides kompletno siguren deka ke dobieme empty value

            //// C# NEMA TRUTHY ILI FALSY VREDNOSTI. SAMO TRUE ILI FALSE

            //// OPERATORI I LOGIKA

            //// SOBIRANJE
            //int num1 = 10;
            //int num2 = num1 + 10;
            //int num3 = num2 + num1;

            //// ODZIMANJE
            //int num4 = 10 - 5;
            //int num5 = num3 - num4;
            //int b = 3;

            //// DELENJE
            //int num6 = 10 / 5;
            //double num7 = 10 / 3; // Ispagja deka dava integer na kraj. 
            //Console.WriteLine(num7);
            //Console.ReadLine();

            //// MNOZENJE
            //int num8 = 10 * 3;
            //int num9 = num8 * num1;

            //// MODULUS
            //int num10 = num9 % b;
            //Console.WriteLine(num10);


            //// LOGICKI OPERATORI

            //int num11 = 10;
            //num11 = num11 + 1;
            //num11 ++; // ovaka sekogas se zgolemuva za EDEN
            //num11 += 1;
            //num11 = num11 - 1;
            //num11 -= 1;
            //num11 --; // ovaka sekogas ODZEMA EDEN

            //bool isValid10 = true;
            //isValid10 &= true;
            //isValid10 = isValid10 && true;


            //bool isValid11 = true;
            //isValid11 |= true;
            //isValid10 = isValid10 || true;

            //bool isValid12 = !isValid11;
            //isValid12 = !isValid12;
            //Console.WriteLine(isValid12);

            //// READLINE KOMANDATA
            //// VREDNOSTA SHO ISKACHA NA READLINE E SEKOGAS STRING. OVIE STVARI KE GI KORISTIME ZA AKO SAKAME DA SMENIME VO NEKAKOV DRUG TIP DA NI ISKOCI

            ////string input = Console.ReadLine();
            ////Console.WriteLine(input);

            ////int parsedNumber = int.Parse(input);
            ////Console.WriteLine(parsedNumber);

            ////string input1 = Console.ReadLine();
            ////bool parsedBool = bool.Parse(input1);
            ////Console.WriteLine(parsedBool);


            ////string input2 = Console.ReadLine();
            ////double parsedDouble = double.Parse(input2);
            ////Console.WriteLine(parsedDouble);


            ////string input3 = Console.ReadLine();
            ////long parsedLong = long.Parse(input3);
            ////Console.WriteLine(parsedLong);

            ////string input4 = Console.ReadLine();
            ////char parsedChar = char.Parse(input4);
            ////Console.WriteLine(parsedChar);


            ////string input10 = Console.ReadLine();
            ////string input11 = Console.ReadLine();   
            ////int number10 = int.Parse(input10);
            ////int number11 = int.Parse(input11);

            ////int result10 = number10 + number11;
            ////Console.WriteLine(result10);


            ////string input20 = Console.ReadLine();
            ////int parsedNumber10 = Convert.ToInt32(input20);
            ////Console.WriteLine(parsedNumber10);

            ////string input21 = Console.ReadLine();   
            ////long parsedLong10 = Convert.ToInt64(input21);
            ////Console.WriteLine(parsedLong10);

            ////string input22 = Console.ReadLine();
            ////bool isValid200 = Convert.ToBoolean(input22);
            ////Console.WriteLine(isValid200);

            ////short parsed = Convert.ToInt16();

            string input30 = Console.ReadLine();

            int tryParseInteger = default;

            bool isValidParsing = int.TryParse(input30,out tryParseInteger); // ova so out e nesho so ne go znaeme do sega i mora vaka da go pishuvame
            Console.WriteLine($"this is bool:{isValidParsing} ");
            Console.WriteLine(tryParseInteger);

            string input31 = Console.ReadLine();
            bool isValidParsingOfBoolean = bool.TryParse(input31, out bool value); // ova e shorthand na ova tryParseInteger pogore
            Console.WriteLine($"this is validParsingofBool: {isValidParsingOfBoolean}");
            Console.WriteLine(value);

            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }
    }
}
