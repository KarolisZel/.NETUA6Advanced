namespace LectureFive.Task_Two;

public class CheckingAccount : BankAccount
{
    private double OverdraftLimit { get; set; }

    public CheckingAccount(double balance, double overdraftLimit)
        : base(balance)
    {
        OverdraftLimit = overdraftLimit;
    }

    public void Withdraw(double amount)
    {
        if (Balance - amount > -OverdraftLimit)
        {
            UpdateBalance(-amount);
            Console.WriteLine($"Withdraw => {amount}, Balance left => {Balance}");
            return;
        }

        Console.WriteLine($"Not enough funds to withdraw ${amount}");
    }
}