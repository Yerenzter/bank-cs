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
        return balance = balance + deposit;
    }
    
    public decimal Withdraw(decimal withdraw) {
        return widthdraw = balance - withdraw;
    }
    
    public void CalculateInterest() {
        public double _interest = balance * .ToDouble(interestRate);
        public double _balance = balance + _interest;
        
        Console.WriteLine(_balance);
    }
}

class Bank {
    static void Main(String[] args) {
        BankAccount bank = new BankAccount("2020-YR2020-RY2020-1024", 1024, 2);
        
        Console.WriteLine(bank.Deposit(2048);
        Console.WriteLine(bank.WithDraw(1024);
        bank.CalculateInterest();
    }
}