using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    class Wallet
    {
        //member variables
        public List<Coin> coins;

        //constructor
        public Wallet()
        {
            coins = new List<Coin>();
            GenerateCoins();
        }

        //methods
        public void GenerateCoins()
        {
            for (int i = 0; i < Simulation.random.Next(13,20); i++) { coins.Add(new Quarter()); }
            for (int i = 0; i < Simulation.random.Next(13, 20); i++) { coins.Add(new Dime()); }
            for (int i = 0; i < Simulation.random.Next(13, 20); i++) { coins.Add(new Nickel()); }
            for (int i = 0; i < Simulation.random.Next(13, 20); i++) { coins.Add(new Penny()); }
        }
    }
}
