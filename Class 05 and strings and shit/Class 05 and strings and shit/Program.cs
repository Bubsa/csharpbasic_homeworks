namespace Class_05_and_strings_and_shit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Bube" + " Simonovikj";
            string name = "Bob";
            string lastName = "Bobsky";
            string fullName = name + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine(a);

            // Ako treba da pisheme "Hello name, how are you today", poso treba da dodademe ime, ke se vodime po dolniot princip
            string str = "Hello" + name +  "how are you today";
            string str2 = string.Format("Hello {0}, how are you today", name);
            Console.WriteLine(str);
            Console.WriteLine(str2);
            string str3 = string.Format("Hello {0} {1}, how are you today", name, lastName); // Kade sho gi stavash brojkite vo curly brackets, togash samiot format metod 
            // gi dodava parametrite name i last name na pozicijata kako sho si se pishani. Na nulta pozicija e name, na 1va pozicija ke bide lastName. 
            Console.WriteLine(str3);
            string str4 = string.Format("{0} {1} {2} {3} {4} {5}", "a", "b", "c", "d", "e", "f"); // Zapirkata posle site brojki e taa sho samata metoda ja prepoznava za site promenlivi
            // Posle petkata, znae deka od tamu pa nataka se site promenlivi
            Console.WriteLine(str4);

            // STRING SO INTERPOLACIJA AKA DOLLAR ZNAKCE
            string str5 = $"Hello {name} {lastName}. How are you today (INTERPOLACIJA)";
            Console.WriteLine(str5);

            // ESCAPE KARAKTERI

            string str6 = "https:\\google.com"; //  Ova se escape karakteri.Toa sho pravi e mu dava escape ili mu dava exception da se pojavi posle nego. Za da bide ok ke treba da bide so ushe dve takvi \\
            Console.WriteLine(str6);

            string str7 = @"http:\\google.com"; // So dodavanje na @, se kazuva deka site "specijalni karakteri" ke bidat escaped aka ke se isprintaat obichno.

            // MULTILINE STRING SO @
            string str8 = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
                " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            // Koga stiskash enter samiot program po sebe si konkatinira stvari

            string strOsumIpol = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry.
            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a 
            galley of type and scrambled it to make a type specimen book. It has survived not only five centuries,
            but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 
            1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop
            publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            // Koga stavash @ togas samiot program ke si go tretira kako eden golem string i koga stiskas enter ne ti stava plusevi

            string str9 = @"C# is ""popular"" language"; // Ova e eden nachin kako da go napravish ova
            string str10 = "C# is \"popular\" language"; // Ova e drug nachin kako da go napravis
            Console.WriteLine(str10);

            // Exercise #2

            string str11 = @"Check your c:\ drive";
            Console.WriteLine(str11);
            string str12 = @"We will have ""fair"" elections";
            Console.WriteLine(str12);
            string str13 = "The \\n sign means: new line";
            Console.WriteLine(str13);



            // FORMATIRANJE STRINGOVI

            string myStringCurrency = string.Format("{0:C}", 125.45); // Tuka ke ti iskochi dollar znak
            Console.WriteLine(myStringCurrency);

            string myStringNumber = string.Format("{0:N}", 190); // Tuka ke ti iskochi decimalka od dve nuli
            Console.WriteLine(myStringNumber);

            string myStringPercent = string.Format("{0:P}", .5); // Tuka iskacha 50%
            Console.WriteLine(myStringPercent);

            string myCustomStr = string.Format("{0:0##-###-###}", 071230617); // Tuka iskacha brojkata po nachinot na koj sho e napishana.
            Console.WriteLine(myCustomStr);

            string headers = string.Format("| {0,10} | {1,10}", "Id", "Order");
            string row = string.Format("| {0,10} | {1,10}", 25, "a box");
            Console.WriteLine(headers);
            Console.WriteLine(row);

            // STRING METODI

            string ourString = "   We are learning C# and it is FUN and EASY. Okay, maybe just fun     ";

            string[] splited = ourString.Split('.'); // Split bara separator aka tochkata u ovoj sluchaj. Sekogas gi dava vo array

            foreach (string b in splited)
            {
                Console.WriteLine(b);
            }


            string[] splited1 = ourString.Split('.', StringSplitOptions.RemoveEmptyEntries);

            foreach (string b in splited1)
            {
                Console.WriteLine(b);
            }


            int indexOf = ourString.IndexOf("FUN"); // Tuka ti ja dava brojkata na koe mesto e karakterot kaj sho ja baras
            Console.WriteLine(indexOf);
            int indexOfNone = ourString.IndexOf("None"); // Tuka ke ti izvadi -1 posho ne postoi takov zbor
            Console.WriteLine(indexOfNone);

            string subString = ourString.Substring(5, 16); // Substring znachi mu davas pochetna pozicija (prvata brojka) i kolku pozicii posle toa (vtorata brojka) sakas da otides ponataka
            Console.WriteLine(subString);

            char[] chars = ourString.ToCharArray();
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }

            string joinedString = string.Join(",", chars);
            Console.WriteLine(joinedString);


            string ourString2 = string.Join("*", splited);
            Console.WriteLine(ourString2);

            Console.WriteLine(new string(chars));


            // PRVOTO PROVERUVA DALI E NULL ILI PRAZNO, VTOROTO PROVERUVA DALI E NULL ILI PRAZNO MESTO
            string abc = " ";
            bool isValidString = string.IsNullOrEmpty(abc);
            Console.WriteLine(isValidString);
            bool isValidString2 = string.IsNullOrWhiteSpace(abc);
            Console.WriteLine(isValidString2);



            // IGRANJE SO DATUMI

            DateTime aDate = new DateTime(); // Ti dava pochetok na vreme, koga Isus voskresnal
            Console.WriteLine(aDate);


            // Vaka se pravi custom datum. Parametrite sho se zimaat se godina, mesec, den.
            DateTime customDate = new DateTime(1992, 10, 15);
            Console.WriteLine(customDate);



            // Varijacii na datumi
            //string stringDate = "15.12.2012";
            //string stringDate = "15/12/2012";
            //string stringDate = "15/12/12";
            //string stringDate = "dec.15.12";
            string stringDate = "15-12-2012";
            DateTime convertDate = DateTime.Parse(stringDate);
            Console.WriteLine(convertDate);
            DateTime currentDat = DateTime.Today;
            Console.WriteLine(currentDat);

            // Kako se zema i data i vreme
            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);

            Console.WriteLine(convertDate.Year);
            Console.WriteLine(convertDate.Month);
            Console.WriteLine(convertDate.DayOfWeek);


            DateTime bDate = DateTime.Now;
            DateTime addDays = bDate.AddDays(2); // Tuka mozes da dodavas denovi
            Console.WriteLine(addDays);
            DateTime addMinusDays = bDate.AddDays(-7); // Vaka mozes da odzemas denovi
            Console.WriteLine(addMinusDays);
            bDate.AddYears(2);
            bDate.AddMonths(-5);


            string dateFormat1 = currentDateAndTime.ToString("MM/dd/yyyy");
            string dateFormat2 = currentDateAndTime.ToString("ddd, dd MMMM yyyy");
            string dateFormat3 = string.Format("Today is {0:MM/dd/yy},{0}", currentDateAndTime);
            string dateFormat4 = string.Format("Today is {0: dd-MMMM-yyyy}, {0:t}", currentDateAndTime);
            Console.WriteLine(dateFormat1);
            Console.WriteLine(dateFormat2);
            Console.WriteLine(dateFormat3);
            Console.WriteLine(dateFormat4);
        }

    }
}
