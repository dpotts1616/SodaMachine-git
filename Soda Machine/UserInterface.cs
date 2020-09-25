using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public static class UserInterface
    {
        //member variables

        //constructor

        //methods
        public static void DisplayInventory(int rootReer, int orangeSoda, int cola)
        {
            Console.WriteLine("Which Soda would you like?");
            Console.WriteLine($"1) Root Beer $0.65 Quantity Left: {rootReer}");
            Console.WriteLine($"2) Orange Soda $0.06 Quantity Left: {orangeSoda}");
            Console.WriteLine($"3) Cola $0.35 Quantity Left: {cola}");
        }

        public static int AskForSodaChoice()
        {
            bool valid = false;
            int i = 0;
            do
            {
                try { i = Convert.ToInt32(Console.ReadLine()); } catch { }
                switch(i)
                {
                    case 1:
                        return i;
                    case 2:
                        return i;
                    case 3:
                        return i;
                    default:
                        Console.WriteLine("Sorry, that is invalid. Please enter 1, 2, or 3");
                        break;
                }

            } while (valid == false);

            return i;
        }

        public static int InputCoins(double temporaryRegister)
        {
            bool valid = false;
            int i = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Please insert coins");
                Console.WriteLine("1) Quarter");
                Console.WriteLine("2) Dime");
                Console.WriteLine("3) Nickel");
                Console.WriteLine("4) Penny");
                Console.WriteLine("5) Done");
                Console.WriteLine($"Total inserted: ${temporaryRegister}");
                Console.Write("Enter:");
                try { i = Convert.ToInt32(Console.ReadLine()); } catch { }

                switch (i)
                {
                    case 1:
                        return i;
                    case 2:
                        return i;
                    case 3:
                        return i;
                    case 4:
                        return i;
                    case 5:
                        return i;
                    default:
                        Console.WriteLine("Sorry, that is invalid. Please enter 1, 2, 3, 4 or 5");
                        break;
                }

            } while (valid == false);

            return i;
        }

        public static void DisplayLackOfCoin(string coinName)
        {
            Console.WriteLine($"Sorry, you don't have any {coinName}'s");
            Thread.Sleep(1000);
        }

        public static void DisplayCustomerDetails(int cans, double money)
        {
            money = Math.Round(money, 2);
            Console.Clear();
            Console.WriteLine($"Sodas in backpack: {cans}");
            Console.WriteLine($"Money in wallet: {money}");
            Console.WriteLine();
        }

        public static void DisplayMissingChange()
        {
            Console.WriteLine("Sorry, unable to make change for your purchase");
            Thread.Sleep(1000);
        }

        public static void DisplayLackOfMoneyInput()
        {
            Console.WriteLine("Sorry, not enough money entered");
            Thread.Sleep(1000);
        }
    }
}
