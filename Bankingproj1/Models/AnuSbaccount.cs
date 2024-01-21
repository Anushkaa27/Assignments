using System;
using System.Collections.Generic;

namespace Bankingproj1.Models;

public partial class AnuSbaccount
{
    public int AccountNumber { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerAddress { get; set; }

    public decimal? CurrentBalance { get; set; }
}
