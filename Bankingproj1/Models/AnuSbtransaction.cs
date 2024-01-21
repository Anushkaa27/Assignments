using System;
using System.Collections.Generic;

namespace Bankingproj1.Models;

public partial class AnuSbtransaction
{
    public int TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? AccountNumber { get; set; }

    public decimal? Amount { get; set; }

    public string? TransactionType { get; set; }
}
