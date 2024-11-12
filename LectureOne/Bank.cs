namespace LectureOne;

class Bank
{
    public string Name { get; set; }
    public List<Account> Account { get; set; }

    public Bank(string name)
    {
        Name = name;
    }
}

class Account
{
    public string Name { get; set; }
    public double Balance { get; set; }

    public Account(string name, double balance)
    {
        Name = name;
        Balance = balance;
    }
}
