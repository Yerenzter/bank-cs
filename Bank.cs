using System;

public class BankAccount {
    private string accountNumber;
    private decimal balance;
    private double interestRate;
    
    public string AccountNumber {
        get { return accountNumber; }
        set { accountNumber = value; }
    }
    
    public decimal Balance {
        get { return balance; }
        set { balance = value; }
    }
    
    public double InterestRate {
        get { return InterestRate; }
        set { interestRate = value; }
    }
    
    public BankAccount(string setAccountNumber, decimal setBalance, double setInterestRate) {
        this.AccountNumber = setAccountNumber;
        this.Balance = setBalance;
        this.InterestRate = setInterestRate;
    }
    
    public decimal Deposit(decimal deposit) {
        return Balance = balance + deposit;
    }
    
    public decimal Withdraw(decimal withdraw) {
        return Balance = balance - withdraw;
    }
    
    public void CalculateInterest() {
        decimal _interest = Balance * Convert.ToDecimal(interestRate);
        decimal _balance = Balance + _interest;
        
        Console.WriteLine(_balance);
    }
}

class Bank {
    static void Main(String[] args) {
        BankAccount bank = new BankAccount("2020-YR2020-RY2020-1024", 0, 2);
        
        Console.WriteLine("Deposit: " + bank.Deposit(2048));
        Console.WriteLine("Withdraw: " + bank.Withdraw(1024));
        bank.CalculateInterest();
    }
}
