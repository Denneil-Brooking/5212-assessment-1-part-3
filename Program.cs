using System;

namespace part_3
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //ClearConsole
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This Program takes user input on the asked fields and returns it");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            //Part-3.b adding the loop
            char inputYnN;
            do
            {
                //users input
                Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
                Person p1 = new Person("", "");
                Console.Write("First Name: ");
                p1.FirstName = Console.ReadLine();
                Console.Write("Last Name: ");
                p1.LastName = Console.ReadLine();
                Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
                Console.WriteLine();
                Console.WriteLine("Creating new person record ......");
                Console.WriteLine();
                Console.Write("Enter Year of birth: ");
                p1.YearOfBirth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                //return data
                Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
                Console.WriteLine("Person: " + p1.GetFullName() + " is " + p1.GetAge() + " Years old");
                Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
                //Part-3.b more loop things
                Console.WriteLine("Would you like to add a new Person Y/N");
                inputYnN = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            while (char.ToLower(inputYnN) == 'y');
            //Loop end
            //program end
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("**************PROGRAM END***************");
            Console.WriteLine("Please Press <any key> to quit the program");
            Console.ReadKey();
        }
    }
}
