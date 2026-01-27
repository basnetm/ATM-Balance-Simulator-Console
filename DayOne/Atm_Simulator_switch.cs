using System;

namespace DayOne
{
    public class Atm_Simulator_switch
    {
        static float initial_balance = 0;

        public void RunATM()
        {
            int ch;

            do
            {
                Console.WriteLine("\n--- ATM MENU ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Show Balance");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        deposit();
                        break;

                    case 2:
                        Show_Balance();
                        break;

                    case 3:
                        WithDraw_Balance();
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using ATM");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (ch != 4);
        }

        public static void deposit()
        {
            Console.WriteLine("Enter amount to deposit:");
            float deposit = float.Parse(Console.ReadLine());

            initial_balance = initial_balance + deposit;

            Console.WriteLine("Updated Balance: " + initial_balance);
        }

        public static void Show_Balance()
        {
            Console.WriteLine("Your balance is: " + initial_balance);
        }

        public static void WithDraw_Balance()
        {
            if (initial_balance <= 0)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                Console.WriteLine("Enter amount to withdraw:");
                float withdraw = float.Parse(Console.ReadLine());

                if (withdraw > initial_balance)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    initial_balance = initial_balance - withdraw;

                    Console.WriteLine("Please collect your cash");
                    Console.WriteLine("Remaining balance: " + initial_balance);
                }
            }
        }
    }
}
