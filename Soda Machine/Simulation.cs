using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public void RunSimulation()
        {
            int choice = customer.SelectSoda();
            sodaMachine.CheckInventory(choice);
            Coin coin;
            do
            {
                double value = sodaMachine.GetTemporaryRegister();
                coin = customer.InputCoins(value);
                sodaMachine.AddToTemporaryRegister(coin);

            }while(coin != null);
            
            Can can = sodaMachine.CompleteTransaction(choice);
            if (can != null)
            {
                customer.AddToBackpack(can);
            }
            //add can to backpack
            //add change to wallet

        }
        
    }
}
