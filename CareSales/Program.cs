namespace CareSales
{
    class Program
    {
        public static List<Cars> Inventory = new List<Cars>();

        public static void ListCars()
        {
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine($"Car #{i + 1}: {Inventory[i]}");
            }
        }
        public static void Remove(int index)
        {
            if (index >= 0 && index < Inventory.Count)
            {
                Inventory.RemoveAt(index);
            }
        }
        static void Main(string[] args)
        {
            //Car list, new and used
            Inventory.Add(new Cars("Dodge", "Viper", 2023, 80000));
            Inventory.Add(new Cars("Toyota", "Supra", 2023, 60000));
            Inventory.Add(new Cars("Nissan", "370z", 2023, 50000));
            Inventory.Add(new UsedCars("Ford", "F150", 2020, 40000, 30000));
            Inventory.Add(new UsedCars("Toyota", "Camry", 2018, 30000, 60000));
            Inventory.Add(new UsedCars("Ford", "Focus", 2015, 20000, 80000));

            while (true)
            {
                Console.WriteLine("Current Car Inventory:");
                Program.ListCars();

                Console.Write("Enter the car # of the car you want to buy (or 0 to exit): ");
                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 0)
                    {
                        break;
                    }

                    if (choice >= 1 && choice <= Program.Inventory.Count)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Excellent choice! You have selected: ");
                        
                        Console.WriteLine(Program.Inventory[choice - 1]);

                        // Remove the chosen car from the list
                        Program.Remove(choice - 1);
                        Console.WriteLine("We only accept cash....");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Pleas enter a valid number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large or small");
                }



            }
        }
    }
}