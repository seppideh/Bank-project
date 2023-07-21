using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccounts
{
  public class Bank : Account
  {
    public List<Account> _customersAccount = new List<Account>();
    public List<Account> CustomersAccount
    {
      get { return _customersAccount; }
      set { _customersAccount = value; }
    }

    // public void creatAccount(int accountNumber, string holderName, double initialBalance, Account obj)
    // {
    //   obj._accountNumber = accountNumber;
    //   obj._holderName = holderName;
    //   obj._balance = initialBalance;
    //   _customersAccount.Add(obj);
    // }
    public void creatAccount(Account obj)
    {
      _customersAccount.Add(obj);
    }

    public Account getAccount(int accountNumber, List<Account> customersAccount)
    {
      var customer = customersAccount.Find(custumer => custumer._accountNumber == accountNumber);
      if (customer != null)
      {
        // Console.WriteLine(customer._holderName);
        return customer;
      }
      else
      {
        throw new Exception("This customer there isn't in customerAccounts");
      }

    }
    public double deposit(Account obj, double amount)
    {
      obj._balance = obj._balance + amount;
      return obj._balance;
    }
    public double Withdraw(Account obj, double amount)
    {
      if (obj._balance > amount)
      {
        obj._balance = obj._balance - amount;
        return obj._balance;
      }
      else
      {
        throw new Exception("The account balance is insufficient");
      }
    }

  }
}