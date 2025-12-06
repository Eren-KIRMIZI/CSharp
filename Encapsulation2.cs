using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class BankAccount
    {
        // ---- Private Fields (dışarıdan erişilemez) ----

        private string ownerName;
        private decimal balance;

        // ---- Public property for OwnerName ----

        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("İsim boş olamaz!");
                ownerName = value;
            }
        }

        // ---- Public property for Balance (sadece get) ----
        public decimal Balance
        {
            get { return balance; }
            private set // sadece bu sınıf içinde değiştirilebilir.
            {
                if (value < 0)
                    throw new ArgumentException("Bakiye negatif olamaz");
                balance = value;
            }
        }

        // ---- Constructor ----
        public BankAccount(string ownerName, decimal startingBalance)
        {
            OwnerName = ownerName;  // property üzerinden set ediliyor (kontrollü)
            Balance = startingBalance; // private set
        }

        // ---- Para yatırma metodu ----
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Yatırılan para pozitif olmalıdır!");
            Balance += amount;
        }

        // ---- Para çekme metodu ----
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Çekilen para pozitif olmalıdır!");

            if (amount > Balance)
                throw new InvalidOperationException("Yetersiz bakiye!");
            Balance -= amount;
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount acc = new BankAccount("Eren", 1000);

            acc.Deposit(500);
            Console.WriteLine($"Yeni bakiye: {acc.Balance}");

            acc.Withdraw(300);
            Console.WriteLine($"Kalan bakiye: {acc.Balance}");

            Console.WriteLine($"Hesap Sahibi: {acc.OwnerName}");
        }
    }
}
