﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _222_Kobzev_Busin_PR6_Bank
{
    public class BankAccount
    {
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string AmountLessThanZeroMessage = "Amount is less than zero";

        private readonly string m_customerName;
        private double m_balance;


        private BankAccount() { }


        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }


        public string CustomerName
        {
            get { return m_customerName; }
        }


        public double Balance
        {
            get { return m_balance; }
        }


        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, AmountLessThanZeroMessage);
            }



            m_balance -= amount;
        }


        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, AmountLessThanZeroMessage);
            }


            m_balance += amount;
        }


        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Roman Abramovich", 11.99);


            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }

}
