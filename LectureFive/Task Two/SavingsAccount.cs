namespace LectureFive.Task_Two;

public class SavingsAccount : BankAccount
{
    private double InterestRate { get; set; }

    public SavingsAccount(double balance, double interestRate)
        : base(balance)
    {
        InterestRate = interestRate;
    }

    public void CalculateInterest()
    {
        Console.WriteLine($"Interest => {Math.Round(Balance + (Balance * InterestRate), 2)}");
    }
}