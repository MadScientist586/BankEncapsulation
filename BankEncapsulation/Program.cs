using BankEncapsulation;
BankAccount NewAccount = new BankAccount();
NewAccount.Deposit(10000);
Console.WriteLine($"You have deposited $10000. Your balance is now ${NewAccount.GetBalance()}");
NewAccount.Deposit(500);
Console.WriteLine($"You have deposited $500. Your balance is now ${NewAccount.GetBalance()}");
NewAccount.Withdraw(900);
Console.WriteLine($"You have withdrawn $900. Your balance is now ${NewAccount.GetBalance()}");



