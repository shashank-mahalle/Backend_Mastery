
// Same result — clean, readable, maintainable
var result = transactions
    .Where(t => t.Type == "DEBIT" && t.Amount > 10000m)
    .ToList();

internal class transactions : IEnumerable<object>
{
}