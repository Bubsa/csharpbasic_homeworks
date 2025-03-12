namespace Class_06
{
    public class Program // Klasa e shablon aka bluepring, objekt e nesho sho se pravi od taa klasa. Klasa e skica na kukja kako da se napravi, objekt e kukjata
    {
        //public string FirstName { get; set; }

        //public string LastName { get; set; }

        // Metodi

        //public void PrintFullName()
        //{
        //    Console.WriteLine("Hello");
        //}

        //Plane plane = new Plane("Avion1", 100, "Airbus", "Blue", true);

        //Dog dog = new Dog("Mittens", "Doberman", "Black");
        
        static void Main() // KONSTRUKTORI, PROPERTINJA, METODI. PO TOJ REDOSLED GI PISHUVAME STVARITE
        {
            Console.WriteLine("A");
            Dog dog = new Dog("Mittens", "Doberman", "Black");
            Console.WriteLine(dog.EatMethod());
            Console.WriteLine(dog.PlayMethod());
            Console.WriteLine(dog.ChaseTail());

            Student[] students = new Student[5]
            {
             new Student("Bube","QA",3),
             new Student("Dejan", "QA", 3),
             new Student("Slave", "QA", 3),
             new Student("Trajan", "QA", 3),
             new Student("Stefan", "Business", 3),
            };


            bool isFound = false;
            foreach (Student student in students)
            {
                if (student.Name == "as")
                {
                    Console.WriteLine(student.Name);
                    isFound = true;
                    break;
                }
            }

            if(!isFound)
            {
                Console.WriteLine("Error");
            }
        }   



    }
    
}

