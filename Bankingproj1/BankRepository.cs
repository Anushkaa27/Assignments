using System;
using System.Collections.Generic;
using System.Linq;
using Bankingproj1.Models;

public class BankRepository : IBankRepository
{
    private readonly Ace52024Context _dbContext;

    public BankRepository(Ace52024Context dbContext)
    {
        _dbContext = dbContext;
    }

    public BankRepository()
    {
    }

    public void NewAccount(AnuSBAccount acc)
    {
        _dbContext.AnuSBAccount.Add(acc);
        _dbContext.SaveChanges();
    }

    public List<AnuSBAccount> GetAllAccounts()
    {
        return _dbContext.AnuSBAccount.ToList();
    }

    public AnuSBAccount GetAccountDetails(int accno)
    {
        return _dbContext.AnuSBAccount.FirstOrDefault(a => a.AccountNumber == accno);
    }

    public void DepositAmount(int accno, decimal amt)
    {
        var account = _dbContext.AnuSBAccount.FirstOrDefault(a => a.AccountNumber == accno);
        if (account != null)
        {
            account.CurrentBalance += amt;
            _dbContext.SaveChanges();
        }
    }

    public void WithdrawAmount(int accno, decimal amt)
    {
        var account = _dbContext.AnuSBAccount.FirstOrDefault(a => a.AccountNumber == accno);
        if (account != null)
        {
            if (account.CurrentBalance >= amt)
            {
                account.CurrentBalance -= amt;
                _dbContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }
    }

    public List<AnuSBTransaction> GetTransactions(int accno)
    {
        return _dbContext.AnuSBTransaction
            .Where(t => t.AccountNumber == accno)
            .OrderByDescending(t => t.TransactionDate)
            .ToList();
    }
}
