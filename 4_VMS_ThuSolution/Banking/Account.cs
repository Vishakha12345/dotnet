﻿using System;
using Policy;


namespace Banking
{
    public class Account
    {
        //according to Policy Operation  
        //We are defining two event

        public event Operation UnderBalance;
        public event Operation OverBalance;


        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amount)
        {

            balance = balance + amount;
            Monitor();
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
            Monitor();
        }

        public void Monitor()
        {
            if (balance >= 500000)
            {
                //raise event
                //trigger event
                OverBalance(5000);
            }
            else if (balance <= 10000)
            {
                UnderBalance(5000);
            }
        }
    }
}
