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
                            Console.Write("Enter the name of the lion: ");
                            string lionName = Console.ReadLine();
                            Console.Write("Enter the species of the lion");

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
                            Console.Write("Enter the name of the Parrot: ");
                            string parrotName = Console.ReadLine();
                            Console.Write("Enter the species of the parrot: ");

                            string parrotSpecies = Console.ReadLine();

                            Parrot parrot = new Parrot { Name = parrotName, Species = parrotSpecies };
                        }
                        catch (ArgumentException ex) // Handle errors
                        {
                            Console.WriteLine($"Error: {ex.Message}"); // Display error message
                        }
                        break;

                    case "3":
                        try
                        {
                            Console.WriteLine("Displaying all animals:");
                    foreach (var animal in animals) 
                            {

                                animal.MakeSound();
                                Console.WriteLine($"({animal.Name}, {animal.Species})");
                            }
                        }
                        break;

                    case "4":
                        try
                        {

                        }
                      
                        break;

                    case "5":
                        try
                        {

                        }

                }
            }
        }
    }
}
