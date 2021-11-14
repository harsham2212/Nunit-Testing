using System;

namespace N_Unit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the NUnit Program \n 1. Vending Machine \n 2. DayOFWeek \n 3. Temperature Conversion \n  4. Exit \n ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Amount to Change");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        VendingMachine vm = new VendingMachine();
                        vm.Calculate(amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Day: ");
                        int day = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Month: ");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter the Temp. to change");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        Temperature tc = new Temperature();
                        tc.Calculate(temp);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }

    }
}
