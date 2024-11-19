namespace LectureFive.Task_Two;

public class BankAccount
{
    protected double Balance { get; private set; }

    public BankAccount(double balance)
    {
        Balance = balance;
    }

    protected void PrintBalance()
    {
        Console.WriteLine($"Balance => {Balance}");
    }

    protected void UpdateBalance(double amount)
    {
        Balance += amount;
    }
}
