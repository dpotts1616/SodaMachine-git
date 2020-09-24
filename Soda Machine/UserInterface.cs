using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public static class UserInterface
    {
        //member variables

        //constructor

        //methods
        public static int AskForSodaChoice()
        {
            bool valid = false;
            int i = 0;
            do
            {
                Console.WriteLine("Which Soda would you like?");
                Console.WriteLine("1) Root Beer");
                Console.WriteLine("2) Orange Soda");
                Console.WriteLine("3) Cola");
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

        public static int InputCoins(double value)
        {
            bool valid = false;
            int i = 0;
            do
            {
                Console.WriteLine("Please insert coins");
                Console.WriteLine("1) Quarter");
                Console.WriteLine("2) Dime");
                Console.WriteLine("3) Nickel");
                Console.WriteLine("4) Penny");
                Console.WriteLine("5) Done");
                Console.WriteLine($"Total inserted: ${value}");
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
                }

            } while (valid == false);

            return i;
        }
    }
}
