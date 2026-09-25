using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Domain.Entities;

public class SavingAccount : Account
{
    public SavingAccount(string accountNumber, Guid userId) : base(accountNumber, userId)
    {
    }
}
