using BankApp.Domain.Exceptions;

namespace BankApp.Domain.Entities;

public class Account
{
    public Guid Id { get; private set; }
    public string AccountNumber { get; private set; }
    public decimal Balance { get; private set; }
    public Guid UserId { get; private set; }
    public DateOnly CreatedAt { get; private set; } 
    public Account(string accountNumber, Guid userId)
    {
        if(string.IsNullOrWhiteSpace(accountNumber))
            throw new DomainException("Account number cannot be null or empty.");
 
        if (userId == Guid.Empty)
            throw new DomainException("User ID cannot be empty.");
        
        AccountNumber = accountNumber;
        Id = Guid.NewGuid();
        Balance = 0;
        UserId = userId;
        CreatedAt = DateOnly.FromDateTime(DateTime.UtcNow);
    }

    private Account()
    { 
    
    }

    public void Debit(decimal amount)
    {
        if (amount <= 0)
            throw new DomainException("Amount must be greater than zero.");
        if (Balance < amount)
            throw new DomainException("Insufficient funds.");
        Balance -= amount;
    }

    public void Credit(decimal amount)
    {
        if (amount <= 0)
            throw new DomainException("Amount must be greater than zero.");
        Balance += amount;
    }

}
