// Func that calculates fee
Func<decimal, decimal> creditCardFee = amount => amount * 0.025m;
Func<decimal, decimal> upiFee        = amount => 0m;

// Same method — different behavior injected
void ProcessPayment(decimal amount, Func<decimal, decimal> getFee)
{
    decimal fee   = getFee(amount);
    decimal total = amount + fee;
    Console.WriteLine($"Amount: ₹{amount:N2} | Fee: ₹{fee:N2} | Total: ₹{total:N2}");
}

ProcessPayment(10000m, creditCardFee); // Fee: ₹250
ProcessPayment(10000m, upiFee);        // Fee: ₹0






Action<string, decimal> logCredit = (account, amount)
    => Console.WriteLine($"CREDIT | {account} | ₹{amount:N2}");

Action<string, decimal> logDebit = (account, amount)
    => Console.WriteLine($"DEBIT  | {account} | ₹{amount:N2}");

void RecordTransaction(string account, decimal amount,
                       Action<string, decimal> logger)
{
    // do the transaction...
    logger(account, amount); // log with whatever logger was passed
}

RecordTransaction("ACC001", 5000m, logCredit);
RecordTransaction("ACC001", 2000m, logDebit);



Predicate<decimal> isHighValue  = amount => amount > 100000m;
Predicate<decimal> isNegative   = amount => amount < 0;

Console.WriteLine(isHighValue(150000m)); // true
Console.WriteLine(isHighValue(5000m));   // false