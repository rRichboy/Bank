namespace Bank
{
    class main
    {
        static void Main()
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            Console.WriteLine("Введите информацию о счете 1:");
            Console.Write("Номер счета: ");
            int accountNumber1 = int.Parse(Console.ReadLine());
            Console.Write("ФИО владельца: ");
            string ownerName1 = Console.ReadLine();
            Console.Write("Сумма на счету: ");
            double initialBalance1 = double.Parse(Console.ReadLine());

            account1.Account(accountNumber1, ownerName1, initialBalance1);

            Console.WriteLine("\nВведите информацию о счете 2:");
            Console.Write("Номер счета: ");
            int accountNumber2 = int.Parse(Console.ReadLine());
            Console.Write("ФИО владельца: ");
            string ownerName2 = Console.ReadLine();
            Console.Write("Сумма на счету: ");
            double initialBalance2 = double.Parse(Console.ReadLine());

            account2.Account(accountNumber2, ownerName2, initialBalance2);

            while (true)
            {
                Console.WriteLine("\nВыберите действие для счета (1/2):");
                Console.WriteLine("1. Показать информацию о счете");
                Console.WriteLine("2. Положить/снять/обнулить средства");
                Console.WriteLine("3. Перенести средства между счетами");
                Console.WriteLine("0. Выйти");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Выберите счет (1/2):");
                        int accountChoice1 = int.Parse(Console.ReadLine());

                        if (accountChoice1 == 1)
                        {
                            account1.Info();
                        }
                        else if (accountChoice1 == 2)
                        {
                            account2.Info();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Выберите счет (1/2):");
                        int accountChoice2 = int.Parse(Console.ReadLine());

                        if (accountChoice2 == 1)
                        {
                            Console.WriteLine("Выберите действие (1. Положить/2. Снять/3. Обнулить):");
                            int actionChoice = int.Parse(Console.ReadLine());

                            switch (actionChoice)
                            {
                                case 1:
                                    Console.Write("Введите сумму для пополнения: ");
                                    double depositAmount = double.Parse(Console.ReadLine());
                                    account1.Deposit(depositAmount);
                                    break;

                                case 2:
                                    Console.Write("Введите сумму для снятия: ");
                                    double withdrawAmount = double.Parse(Console.ReadLine());
                                    account1.Get_Balance(withdrawAmount);
                                    break;

                                case 3:
                                    account1.Delete_Balance();
                                    break;
                            }
                        }
                        else if (accountChoice2 == 2)
                        {
                            Console.WriteLine("Выберите действие (1. Положить/2. Снять/3. Обнулить):");
                            int actionChoice = int.Parse(Console.ReadLine());

                            switch (actionChoice)
                            {
                                case 1:
                                    Console.Write("Введите сумму для пополнения: ");
                                    double depositAmount = double.Parse(Console.ReadLine());
                                    account2.Deposit(depositAmount);
                                    break;

                                case 2:
                                    Console.Write("Введите сумму для снятия: ");
                                    double withdrawAmount = double.Parse(Console.ReadLine());
                                    account2.Get_Balance(withdrawAmount);
                                    break;

                                case 3:
                                    account2.Delete_Balance();
                                    break;
                            }
                        }
                        break;

                    case 3:
                        Console.Write("Введите как будут перенесены деньги\n1. 1 - 2\n2. 2 - 1\n");
                        int choice_move = int.Parse(Console.ReadLine());

                        if (choice_move == 1)
                        {
                            Console.Write("Введите сумму для переноса: ");
                            double transferAmount = double.Parse(Console.ReadLine());
                            account1.Move_Balance(account2, transferAmount);
                        }

                        else if (choice_move == 2)
                        {
                            Console.Write("Введите сумму для переноса: ");
                            double transferAmount = double.Parse(Console.ReadLine());
                            account2.Move_Balance(account1, transferAmount);
                        }
                        
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}


