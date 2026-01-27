using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    /// <summary>
    /// Simulates a simple ATM system that allows a user to deposit money,
    /// withdraw funds, and view their account balance.
    /// </summary>
    public class ATM_Balance_Simulator
    {
        float initial_balance;

        public void RunATM()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- ATM MENU ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Show Balance");
                Console.WriteLine("3. withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Deposit_Balance();
                }
                else if (choice == 2)
                {
                    Show_Balance();
                }
                else if (choice == 3)
                {
                    With_Draw();
                }
                else if (choice == 4)
                {
                    running = false;
                    Console.WriteLine("Thank you for using the ATM.");
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
        public void Show_Balance()
        {
            if (initial_balance == 0)
            {
                Console.WriteLine("Your balance is 0");
            }
            else
            {
                Console.WriteLine("Your balance is: " + initial_balance);
            }
        }

    
        public void Deposit_Balance()
        {
            Console.WriteLine("Enter the amount you want to deposit:");
            float balance = float.Parse(Console.ReadLine());
            initial_balance = initial_balance + balance;
        }
        public void With_Draw()
        {
            Console.WriteLine("How much money do you want to withdraw?");
            float withdraw = float.Parse(Console.ReadLine());

            if (withdraw <= initial_balance)
            {
                initial_balance = initial_balance - withdraw;
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine("Remaining balance: " + initial_balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }









    }
}
