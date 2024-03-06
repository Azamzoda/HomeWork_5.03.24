
using Task1;

System.Console.WriteLine();
var rac1 = new Ractangle();
rac1.Length = 20;
rac1.Width = 40;
System.Console.WriteLine(rac1.CalculateArea());
rac1.Description = "Ractangle";
System.Console.WriteLine(rac1.PrintDescription());
System.Console.WriteLine("***********************");
System.Console.WriteLine();
var cir1 = new Circle();
cir1.Radius = 4;
System.Console.WriteLine(cir1.CalculateArea());
cir1.Description = "CIRCLE";
System.Console.WriteLine(cir1.PrintDescription());