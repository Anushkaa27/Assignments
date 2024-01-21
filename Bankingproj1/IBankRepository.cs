using System;
using System.Collections.Generic;

namespace Microsoft.EntityFrameworkCore.Design{
public interface IBankRepository
{
    void NewAccount(AnuSBAccount acc);
    List<AnuSBAccount> GetAllAccounts();
    AnuSBAccount GetAccountDetails(int accno);
    void DepositAmount(int accno, decimal amt);
    void WithdrawAmount(int accno, decimal amt);
    List<AnuSBTransaction> GetTransactions(int accno);
}
}
