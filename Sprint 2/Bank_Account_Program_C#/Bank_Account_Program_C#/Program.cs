using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace bank_account
{
    class account
    {
        // Identifiers of the type account
        private int account_id;
        private string? account_name;
        private double account_balance;

        private static int new_id = 0;

        public account()
        {
            // Account constructor
            account_id = new_id++;
        }

        public int Id
        {
            // Account Id getter
            get { return account_id; }
        }
        public string? Name
        {
            // Account Name getter and setter
            get { return account_name; }
            set { account_name = value; }
        }
        public double Balance
        {
            // Account Balance getter and setter
            get { return account_balance; }
            set { account_balance = value; }
        }

        public void AddBalance(double value)
        {
            // Add a deposit to an account
            account_balance += value;
        }

        public void SubBalance(double value)
        {
            // Subtract from a balance
            account_balance -= value;
        }
    }
    class functions
    {
        public static void Display(List<account> accounts)
        {
            // Display all accounts in list
            foreach (account account in accounts)
            {
                Console.WriteLine("Id: " + account.Id);
                Console.WriteLine("Name: " + account.Name);
                Console.WriteLine("Balance: $" + account.Balance);
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        { 
            // List of objects
            List<account> accounts = new List<account>();

            var a = new account();
            var p = new program();

            bool user_choice = true;
            while (user_choice) // Program Menu
            {
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("0: End Program");
                Console.WriteLine("1: Add an Account");
                Console.WriteLine("2: Display Account Information");
                Console.WriteLine("3: Add a Deposit");
                Console.WriteLine("4: Make a Withdrawal");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        user_choice = false;
                        break;
                    case 1:
                        p.CreateAccount(accounts);
                        break;
                    case 2:
                        functions.Display(accounts);
                        break;
                    case 3:
                        int number1;
                        double deposit;

                        Console.WriteLine("Enter the account ID: ");
                        number1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the deposit amount: $");
                        deposit = Convert.ToDouble(Console.ReadLine());

                        accounts.Find(account => account.Id == number1);
                        //FindAccount(accounts);

                        break;
                    case 4:
                        int number2;
                        double withdrawal;

                        Console.WriteLine("Enter the account ID: ");
                        number2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the withdrawl amount: $");
                        withdrawal = Convert.ToDouble(Console.ReadLine());

                        //FindAccount(accounts);

                        break;
                }

            }
        }
        public void CreateAccount(List<account> accounts)
        {
            // Create new account type
            string name = "";
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine()!;

            double balance;
            Console.WriteLine("Enter the account balance: $");
            balance = Convert.ToDouble(Console.ReadLine());

            accounts.Add(new account() {Name = name, Balance = balance}); // Add new account to a list
        }
/*        public static IEnumerable<account> FindAccount(List<account> accounts)
        {
            // Iterate through the object list to find an account
            int id;

            Console.WriteLine("Enter the account Id: ");
            id = Convert.ToInt32(Console.ReadLine());

            for (int it = 0; it < accounts.Count; it++)
            {
                Console.WriteLine("Made it to for");
                if (it == id)
                {
                    Console.WriteLine("Made it to if");
                    yield return accounts[it];
                }
            }
        }*/
    }
}
