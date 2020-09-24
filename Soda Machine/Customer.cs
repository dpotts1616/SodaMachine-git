using System;
using System.Collections.Generic;
using System.Linq;
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
        public void SelectSoda()
        {
            int choice = UserInterface.AskForSodaChoice();
        }

        public void InputCoins()
        {
            List<Coin> totalCoinInput = new List<Coin>();
            double value = 0;
            int coinSelection;
            do
            {
                coinSelection = UserInterface.InputCoins(value);
                Coin coin = GetCoin(coinSelection);
                if (wallet.coins.Contains(coin))
                {
                    totalCoinInput.Add(coin);
                    wallet.coins.Remove(coin);
                    value = UpdateTotalInput(totalCoinInput);
                }
            } while (coinSelection != 5);
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

        public double UpdateTotalInput(List<Coin> coins)
        {
            double value = 0;
            foreach (Coin coin in coins)
            {
                value += coin.Value;
            }
            return value;
        }
        //input coins/take out of wallet
        //user interface select soda
        //compare to selection(in simulation)
    }
}
