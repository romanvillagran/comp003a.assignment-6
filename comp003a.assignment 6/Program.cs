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

                            Lion lion = new Lion { Name = lionName, Species = lionSpecies };

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
                        Console.WriteLine("Displaying all animals:");
                        if (animal.Count == 0)
                        {
                            Console.WriteLine("No animals in the zoo yet!");
                        }
                        else
                        {

                            for (int i = 0; i < animal.Count; i++)
                            {
                                if (animal[i] != null)
                                {
                                    animal[i].MakeSound();
                                    Console.WriteLine($"Name: {animal[i].Name}, Species: {animal[i].Species}");
                                }
                            }
                        }
                        break;

                    case "4":
                        Console.WriteLine("Choose an option to describe an animal:");
                        Console.WriteLine("1. By Name");
                        Console.WriteLine("2. By Name and Species");
                        Console.WriteLine("3. By Name, Species, and Age");

                        string describeChoice = Console.ReadLine();
                        switch (describeChoice)
                        {
                            case "1": 
                                Console.Write("Enter the name: ");
                                string name = Console.ReadLine();
                                ZooUtility.DescribeAnimal(name);
                                break;

                            case "2": 
                                Console.Write("Enter the name: ");
                                string name2 = Console.ReadLine();
                                Console.Write("Enter the species: ");
                                string species2 = Console.ReadLine();
                                ZooUtility.DescribeAnimal(name2, species2); 
                                break;

                            case "3": 
                                Console.Write("Enter the name: ");
                                string name3 = Console.ReadLine();
                                Console.Write("Enter the species: ");
                                string species3 = Console.ReadLine();
                                Console.Write("Enter the age: ");
                                int age = int.Parse(Console.ReadLine());
                                ZooUtility.DescribeAnimal(name3, species3, age); 
                                break;

                            default:
                                Console.WriteLine("Invalid choice.");
                                break;





                        }
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;


                }
            }
        }
    }
}
