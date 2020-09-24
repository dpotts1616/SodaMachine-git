using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    class SodaMachine
    {
        //member variables
        public List<Coin> register;
        public List<Can> inventory;

        //constructor
        public SodaMachine()
        {
            register = new List<Coin>();
            PopulateCoins();
            inventory = new List<Can>();
            PopulateCans();

        }

        //methods
        public void PopulateCoins()
        {
            for (int i = 0; i < 20; i++) { register.Add(new Quarter()); }
            for (int i = 0; i < 10; i++) { register.Add(new Dime()); }
            for (int i = 0; i < 20; i++) { register.Add(new Nickel()); }
            for (int i = 0; i < 50; i++) { register.Add(new Penny());  }
        }

        public void PopulateCans()
        {
            for (int i = 0; i < 10; i++) { inventory.Add(new RootBeer()); }
            for (int i = 0; i < 10; i++) { inventory.Add(new OrangeSoda()); }
            for (int i = 0; i < 10; i++) { inventory.Add(new Cola()); }
        }
    }
}
