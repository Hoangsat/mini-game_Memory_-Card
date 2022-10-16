int a, b;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);
 int c, o;
c = a / b;
o= a % b;
Console.WriteLine("{o} / { 1} = {2)", a, b, c);
Console.WriteLine("{o} / { 1} = {2)", a, b, o);
