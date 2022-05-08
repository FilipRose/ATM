using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    class ATM
    {
        static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose from one of the following options...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
            }
            void deposite(cardHolder currnetUser)
            {
                Console.WriteLine("How much $$ would you like to deposit: ");
                double depsoit = Double.Parse(Console.ReadLine());
                currnetUser.setBalance(depsoit);
                Console.WriteLine("Thank you for your $$. Your new balance is:  " + currnetUser.getBalance());
            }
            void withdraw(cardHolder currentUser)
            {
                Console.WriteLine("How much $$ would you like to withdraw: ");
                double withdraw = Double.Parse(Console.ReadLine());
                if (currentUser.getBalance() < withdraw)
                {
                    Console.WriteLine("Insufficent balance :( ");
                }
                else
                {

                    currentUser.setBalance(currentUser.getBalance() - withdraw);
                    Console.WriteLine("You are good to go! Thank you :) ");

                }
            }
            void balance(cardHolder currentUser)
            {
                Console.WriteLine("Current balance:  " + currentUser.getBalance());
            }
            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("3476591207453268", 3456, "Jack", "Smith", 2100.50));
            cardHolders.Add(new cardHolder("2156792453981245", 6789, "Anna", "Jones", 500.20));
            cardHolders.Add(new cardHolder("8794512743980454", 0977, "John", "Dickerson", 10000.90));
            cardHolders.Add(new cardHolder("6789342176459907", 2109, "Yuki", "Kasabari", 5000.00));
            cardHolders.Add(new cardHolder("4569897612459088", 4043, "Shoji", "Shigeru", 200.50));

            Console.WriteLine("Welcome to BaracudATM");
            Console.WriteLine("Please insert your debit card: ");
            String debitCardNum = "";
            cardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Card not recognized. Please try again"); }
                }
                catch { Console.WriteLine("Card not recognized. Please try again"); }
            }
            Console.WriteLine("Please enter your pin:  ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.getPin() == userPin) { break; }
                    else { Console.WriteLine("Incorrect pin. Please try again"); }
                }
                catch { Console.WriteLine("Incorrect pin. Please try again"); }
            }

            Console.WriteLine("Welcome " + currentUser.getName());
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { deposite(currentUser); }
                else if (option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
            }
            while (option != 4);
            Console.WriteLine("Thank you");
        }
    }
    public class cardHolder
    {
        public String cardNum;
        int pin;
        String firstName;
        String lastName;
        double balance;
        public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }
        public String getNum()
        {
            return cardNum;
        }
        public int getPin()
        {
            return pin;
        }
        public String getName()
        {
            return firstName;
        }
        public String getLastName()
        {
            return lastName;
        }
        public double getBalance()
        {
            return balance;
        }
        public void setNum(String newCardNum)
        {
            cardNum = newCardNum;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public void setFirstName(String newFirstName)
        {
            firstName = newFirstName;

        }
        public void setLastName(String newLastName)
        {
            lastName = newLastName;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
    }
}