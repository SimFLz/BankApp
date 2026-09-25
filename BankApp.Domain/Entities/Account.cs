namespace BankApp.Domain.Entities;

public class Account
{
    public Guid Id { get; private set; }
    public string AccountNumber { get; private set; }
    public decimal Balance { get; private set; }
    public Guid UserId { get; private set; }
    public Account(string accountNumber, Guid userId)
    {
        Id = Guid.NewGuid();
        AccountNumber = accountNumber;
        Balance = 0;
        UserId = userId;
    }
    
}
