namespace Bank
{
    class BankAccount
    {
        private int number;
        private string fio;
        private double balance;

        public void Account(int number, string fio, double balance)
        {
            this.number = number;
            this.fio = fio;
            this.balance = balance;
        }

        public void Info()
        {
            Console.WriteLine("Номер счета: " + number);
            Console.WriteLine("ФИО владельца: " + fio);
            Console.WriteLine("Сумма на счету: " + balance);
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Положено на счет: " + amount);
            }
            else
            {
                Console.WriteLine("Сумма должна быть положительной.");
            }
        }

        public void Get_Balance(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Снято со счета: " + amount);
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете или сумма должна быть положительной.");
            }
        }

        public void Delete_Balance()
        {
            balance = 0;
            Console.WriteLine("Баланс обнулен.");
        }

        public void Move_Balance(BankAccount recipientAccount, double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                recipientAccount.Deposit(amount);
                Console.WriteLine("Перенесено на счет " + recipientAccount.number + ": " + amount);
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете или сумма должна быть положительной.");
            }
        }
    }
}
