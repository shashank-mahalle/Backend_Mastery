
// Same result — clean, readable, maintainable
var transactions = new List<Transaction>();
var result = transactions
    .Where(t => t.Type == "DEBIT" && t.Amount > 10000m)
    .ToList();

internal class Transaction
{
    public string Type { get; set; } = string.Empty;
    public decimal Amount { get; set; }
}