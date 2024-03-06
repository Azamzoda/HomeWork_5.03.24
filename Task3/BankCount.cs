namespace Task3;

public class BankCount
{
    public int AccountNumber { get; set; }
    decimal _balance;
    public string  Owner { get; set; }
    public void TopUp(decimal amount)
    {
        _balance = amount;
    }
    public void WithDraw()
    {
            System.Console.WriteLine(_balance);
    }
    public void PrintStatement()
    {
        System.Console.WriteLine(AccountNumber);
        System.Console.WriteLine(_balance);
        System.Console.WriteLine(Owner);
    }
}
