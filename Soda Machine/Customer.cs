using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    class Customer
    {
        //member variables
        public Wallet wallet;
        public Backpack backpack;

        //constructor
        public Customer()
        {
            backpack = new Backpack();
            wallet = new Wallet();
        }

        //methods

        public int SelectSoda()
        {
            int choice = UserInterface.AskForSodaChoice();
            return choice;
        }

        public Coin InputCoins(double temporaryRegister)
        {
            int coinSelection = UserInterface.InputCoins(temporaryRegister);
            while (coinSelection < 5)
            {
                Coin coin = GetCoin(coinSelection);
                if (CheckWallet(coin) == true)
                {
                    wallet.coins.Remove(wallet.coins.Where(c => c.name == coin.name).FirstOrDefault());
                    return coin;
                }
            }
            return null;
        }


        public bool CheckWallet(Coin coin)
        {
            return wallet.coins.Any(c => c.name == coin.name);
        }


        public Coin GetCoin(int coinSelection)
        {
            if (coinSelection == 1)
            {
                return new Quarter();
            }
            if (coinSelection == 2)
            {
                return new Dime();
            }
            if (coinSelection == 3)
            {
                return new Nickel();
            }
            if (coinSelection == 4)
            {
                return new Penny();
            }
            return null;
        }

        public void AddToBackpack(Can can)
        {
            backpack.cans.Add(can);
        }

        //public double UpdateTotalInput(List<Coin> coins)
        //{
        //    double value = 0;
        //    foreach (Coin coin in coins)
        //    {
        //        value += coin.Value;
        //    }
        //    return value;
        //}
        //input coins/take out of wallet
        //user interface select soda
        //compare to selection(in simulation)
    }
}
