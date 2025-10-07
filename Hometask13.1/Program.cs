using Hometask13._1;

Account privatBankAccount = new Account("PrivatBank account", 100.00m);
Account monoBankAccount = new Account("MonoBank account", 2000.00m);

privatBankAccount.Withdrawal(50);
Console.WriteLine("The balance of PrivatBank account is now: " + privatBankAccount.Balance);

privatBankAccount.Deposit(100);
Console.WriteLine("The balance of PrivatBank account is now: " + privatBankAccount.Balance);

privatBankAccount.Withdrawal(160);
Console.WriteLine("The balance of PrivatBank account is now: " + privatBankAccount.Balance);

Console.WriteLine();

monoBankAccount.Deposit(500);
Console.WriteLine("The balance of MonoBank account is now: " + monoBankAccount.Balance);

monoBankAccount.Withdrawal(1500);
Console.WriteLine("The balance of MonoBank account is now: " + monoBankAccount.Balance);

monoBankAccount.Withdrawal(1100);
Console.WriteLine("The balance of MonoBank account is now: " + monoBankAccount.Balance);
