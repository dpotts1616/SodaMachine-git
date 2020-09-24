using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    class Simulation
    {
        //member variables
        public SodaMachine sodaMachine;
        public Customer customer;
        public static Random random = new Random();

        //constructor
        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
        }

        //methods
    }
}
