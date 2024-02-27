namespace PersonalRegister
{

    class Personalregister
    {
        public string Name { get; set; }
        public int Salary {  get; set; }
    }
    class Program
    {
        static List<Personalregister> people = new List<Personalregister>();
        static void Main(string[] args)
        {
            

            int salary, choice;
            string name, input;
            bool run = true;
            
            while(run) 
            {
                Console.WriteLine();
                Console.WriteLine("Hey and welcome to this Register");
                Console.WriteLine("Choice your option: ");
                Console.WriteLine("1. Add Name & Salary");
                Console.WriteLine("2. Show All");
                Console.WriteLine();
                Console.WriteLine("Every other input will result in EXIT!");
                Console.WriteLine();

                input = Console.ReadLine();
                if(int.TryParse(input, out choice))
                {
                    if (choice == 1)
                    {
                        // add user
                        Console.WriteLine("Name of user: ");
                        name = Console.ReadLine();
                        Console.WriteLine("How much should the user have in Salary: ");
                        if(int.TryParse(Console.ReadLine(), out salary)){
                            AddUserToList(name, salary);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input of salary");
                            Console.WriteLine();
                        }

                        

                    }
                    else if (choice == 2)
                    {
                        // view all users
                        ShowUsersData();
                    }
                    else
                    {
                        Console.WriteLine("Program Closed!");
                        run = false;
                    }
                }
                else
                {
                    Console.WriteLine("Program Closed!");
                    run = false;
                }
                

                
            }
            
        }

        static void AddUserToList(string name, int Salary)
        {
            Personalregister newUser = new Personalregister { Name = name, Salary = Salary };
            people.Add(newUser);
        }

        static void ShowUsersData()
        {
            Console.WriteLine();
            Console.WriteLine("All persons in the register: ");
            foreach (Personalregister person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Salary: {person.Salary} $");
            }
        }
    }
}
