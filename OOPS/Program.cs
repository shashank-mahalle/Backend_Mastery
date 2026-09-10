public class Account
{
    private decimal _balance;
    public decimal Balance => _balance;   // read-only exposure

    public void Deposit(decimal amt)
    {
        if (amt <= 0) throw new ArgumentException("Invalid amount");
        _balance += amt;
    }
}

