
using Task3;
System.Console.WriteLine();
System.Console.WriteLine("******************");
var bank1 = new BankCount();
bank1.AccountNumber =  Convert.ToInt32(Console.ReadLine().ToString());
bank1.Owner = "Mansur";
bank1.TopUp(Convert.ToDecimal(Console.ReadLine()));

bank1.PrintStatement();

System.Console.WriteLine();
System.Console.WriteLine("*******************");