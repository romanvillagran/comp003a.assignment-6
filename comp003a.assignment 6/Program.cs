// Author: roman villagran
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
namespace comp003a.assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animal = new List<Animal>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the zoo Management system");

                Console.WriteLine("Please choose and option: ");
                Console.WriteLine("1. add a Lion");
                Console.WriteLine("2. add a Parrot");
                Console.WriteLine("3. display all animals");
                Console.WriteLine("4. describe an animal");
                Console.WriteLine("5. exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Enter the name of the lion");
                            string lionName = Console.ReadLine();
                            Console.WriteLine("Enter the species of the lion");

                            string lionSpecies = Console.ReadLine();

                            Lion lion = new Lion { Name = lionName, Species = lionSpecies};

                            animal.Add(lion);
                            Console.WriteLine("Lion has been added"); 
                        }
                        catch (ArgumentException ex) // Handle errors
                        {
                            Console.WriteLine($"Error: {ex.Message}"); // Display error message
                        }
                        break;



                    case "2":
                        try
                        {

                        }


                    case "3":
                        try
                        {

                        }


                    case "4":
                        try
                        {

                        }


                    case "5":
                        try
                        {

                        }

                }
            }
        }
    }
}
