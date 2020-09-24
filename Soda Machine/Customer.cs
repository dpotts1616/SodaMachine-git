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
    }
}
