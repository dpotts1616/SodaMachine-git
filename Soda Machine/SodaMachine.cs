﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Soda_Machine
{
    class SodaMachine
    {
        //member variables
        public List<Coin> register;
        public List<Can> inventory;
        List<Coin> temporaryRegister;


        //constructor
        public SodaMachine()
        {
            register = new List<Coin>();
            PopulateCoins();
            inventory = new List<Can>();
            PopulateCans();
            temporaryRegister = new List<Coin>();

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

        public void AddToTemporaryRegister(Coin coin)
        {
            temporaryRegister.Add(coin);
        }

        public double GetTemporaryRegister()
        {
            double value = temporaryRegister.Sum(s => s.Value);
            return value;
            //return temporaryRegister;
        }

        public void DisplayInventory()
        {
            int rootBeer = GetSodaQuantity("Root Beer");
            int orangeSoda = GetSodaQuantity("Orange Soda");
            int cola = GetSodaQuantity("Cola");
            UserInterface.DisplayInventory(rootBeer, orangeSoda, cola);
        }

        public int GetSodaQuantity(string name)
        {
            int count = 0;
            foreach (Can can in inventory)
            {
                if (can.name == name)
                {
                    count++;
                }
            }
            return count;
        }

        public bool CheckInventory(int choice)
        {
            switch (choice)
            {
                case 1:
                    foreach(Can can in inventory)
                    {
                        if (can.name == "Root Beer")
                        {
                            return true;
                        }
                    }
                    return false;
                case 2:
                    foreach (Can can in inventory)
                    {
                        if (can.name == "Orange Soda")
                        {
                            return true;
                        }
                    }
                    return false;
                case 3:
                    foreach (Can can in inventory)
                    {
                        if (can.name == "Cola")
                        {
                            return true;
                        }
                    }
                    return false;
            }
            return false;
        }

        public Can GetSoda(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new RootBeer();
                case 2:
                    return new OrangeSoda();
                case 3:
                    return new Cola();
            }
            return null;
        }

        public Can CompleteTransaction(int choice)
        {
            double value = GetTemporaryRegister();
            Can can = GetSoda(choice);
            if (value < can.Cost)
            {
                return null;
            }
            else if (value == can.Cost)
            {
                MoveTempToRegister(temporaryRegister);
                inventory.Remove(inventory.Where(c => c.name == can.name).FirstOrDefault());
                return can;
            }
            else if (value > can.Cost)
            {
                double difference = (value - can.Cost);
                if (CheckForChange(difference) == true)
                {
                    MoveTempToRegister(temporaryRegister);
                    MoveChangeToTemp(difference);
                    inventory.Remove(inventory.Where(c => c.name == can.name).FirstOrDefault());
                    return can;
                }
                else
                {
                    UserInterface.DisplayMissingChange();
                    return null;
                }
            }
            return null;
        }

        public void MoveTempToRegister(List<Coin> temporaryRegister)
        {
            foreach (Coin coin in temporaryRegister)
            {
                register.Add(coin);
            }
            ClearTemporaryRegister();
        }

        public bool CheckForChange(double change)
        {
            double tempChange = 0;

            foreach(Coin coin in register)
            {
                if (coin.Value <= (change - tempChange))
                {
                    tempChange += coin.Value;
                }
            }
            if (tempChange == change)
            {
                return true;
            }
            return false;
        }
        
        public void MoveChangeToTemp(double change)
        {
            foreach (Coin coin in register)
            {
                if (coin.Value <= (change))
                {
                    change -= coin.Value;
                    temporaryRegister.Add(coin);
                }
            }
            foreach (Coin coin in temporaryRegister)
            {
                register.Remove(register.Where(c => c.name == coin.name).FirstOrDefault());
            }
        }

        public List<Coin> ReturnMoney()
        {
            return temporaryRegister;
        }

        public void ClearTemporaryRegister()
        {
            temporaryRegister.Clear();
        }
    }
}
