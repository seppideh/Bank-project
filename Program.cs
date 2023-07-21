using System;

namespace BankAccounts
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var bank = new Bank();

      // Create accounts
      Console.Write("How many accounts do you want to create?");
      int numberOfAccounts = Convert.ToInt16(Console.ReadLine());
      for (int i = 0; i < numberOfAccounts; i++)
      {
        Console.WriteLine($"The information of customer {i + 1}");
        CreatAccounts(bank);
      }

      // Display accounts's information
      foreach (Account account in bank._customersAccount)
      {
        Console.WriteLine($"Account Number:{account._accountNumber} , Accont holder:{account._holderName} , Account balance:{account._balance}");
      }
      Console.ReadKey();
      Console.Clear();

      // Bank operations by customertomer
      Console.Write("Please enter your ask: (C (Creat Account) , D (Deposit) , W (Withdraw) , B (Get balance) ):");
      var answer = Console.ReadLine().ToUpper();

      bankProcess(answer, bank);

    }

    public static void CreatAccounts(Bank bank)
    {
      var customer = new Account();
      Console.Write($"Please Enter account number:");
      customer._accountNumber = Convert.ToInt32(Console.ReadLine());
      Console.Write($"Please Enter account holder:");
      customer._holderName = Console.ReadLine();
      Console.Write($"Please Enter initial balance:");
      customer._balance = Convert.ToDouble(Console.ReadLine());
      bank.creatAccount(customer);
    }

    public static void bankProcess(string answer, Bank bank)
    {
      Account customer;
      if (answer == "C")
      {
        CreatAccounts(bank);
      }
      else if (answer == "D" || answer == "W" || answer == "B")
      {
        Console.Write("Please enter your accountNumber:");
        var accountNumber = Convert.ToInt32(Console.ReadLine());
        try
        {
          customer = bank.getAccount(accountNumber, bank._customersAccount);
        }
        catch (System.Exception ex)
        {
          Console.WriteLine(ex.Message);
          throw new Exception();
        }
        switch (answer)
        {
          case "D":
            Console.Write("How much do you want to deposit?");
            double amount = Convert.ToDouble(Console.ReadLine());
            var newBalance = bank.deposit(customer, amount);
            Console.WriteLine($"Your new balance is equal to {newBalance}.");
            break;
          case "W":
            Console.Write("How much do you want to Withdraw?");
            amount = Convert.ToDouble(Console.ReadLine());
            newBalance = bank.Withdraw(customer, amount);
            Console.WriteLine($"Your new balance is equal to {newBalance}.");
            break;
          case "B":
            var balance = customer._balance;
            Console.WriteLine($"Your  balance is equal to {balance}.");
            break;
          default:
            break;
        }
      }
    }
  }
}
