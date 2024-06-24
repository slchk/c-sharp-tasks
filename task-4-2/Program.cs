using System;
using System.Runtime.InteropServices.JavaScript;

class CreditCard
{
    public string AccountNumber;
    public double CurrentAmount;

    public CreditCard(string accountNumber, double currentAmount)
    {
        AccountNumber = accountNumber;
        CurrentAmount = currentAmount;
    }
    
    public void DepositMoney(double newAmount)
    {
        this.CurrentAmount += newAmount;
        Console.WriteLine($"New balance after deposit: {this.CurrentAmount}");
    }
    
    public void WithdrawMoney(double newAmount)
    {
        this.CurrentAmount -= newAmount;
        Console.WriteLine($"New balance after withdrawal: {this.CurrentAmount}");
    }
    
    public void CardInfo()
    {
        Console.WriteLine($"Card Info: account number: {this.AccountNumber}, Balance:{this.CurrentAmount} ");
    }
    
    class Program
    {
        static void Main()
        {
            CreditCard firstCard = new CreditCard("3456-546-3444-345", 1200);
            CreditCard secondCard = new CreditCard("5678-756-7846-757", 500);
            CreditCard thirdCard = new CreditCard("1234-567-8901-345", 5000);

            firstCard.DepositMoney(500);
            secondCard.DepositMoney(250);
            thirdCard.WithdrawMoney(300);
            
            firstCard.CardInfo();
            secondCard.CardInfo();
            thirdCard.CardInfo();
        }
    }
}