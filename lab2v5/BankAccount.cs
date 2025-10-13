using System;
using System.Collections.Generic;

namespace lab2v5
{
    public class BankAccount
    {
        private decimal balance;
        private List<string> transactions = new List<string>();

        public decimal Balance
        {
            get => balance;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Баланс не може бути від’ємним!");
                balance = value;
            }
        }

        public BankAccount(decimal initialBalance = 0)
        {
            Balance = initialBalance;
            transactions.Add($"Відкрито рахунок з балансом: {Balance:C}");
        }

        public static BankAccount operator +(BankAccount account, decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Сума поповнення не може бути від’ємною!");
            account.Balance += amount;
            account.transactions.Add($"Поповнення: +{amount:C}");
            return account;
        }

        public static BankAccount operator -(BankAccount account, decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Сума зняття не може бути від’ємною!");
            if (account.Balance - amount < 0)
                throw new InvalidOperationException("Недостатньо коштів!");
            account.Balance -= amount;
            account.transactions.Add($"Зняття: -{amount:C}");
            return account;
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= transactions.Count)
                    return "Немає такої транзакції.";
                return transactions[index];
            }
        }

        public void ShowTransactions()
        {
            Console.WriteLine("Історія транзакцій:");
            foreach (var t in transactions)
                Console.WriteLine(" - " + t);
        }
    }
}
