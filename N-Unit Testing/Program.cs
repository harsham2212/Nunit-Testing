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
                Console.WriteLine("Enter your Choice Number to Execute the NUnit Program \n 1. Vending Machine \n 2. Exit \n ");
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
                        flag = false;
                        break;
                }
            }
        }

    }
}
