/* SimpleDate d1 = new SimpleDate(17, 9, 2025);
Console.WriteLine(d1);
Console.WriteLine(d1.IsLeapYear());

Currency s1 = new Currency(100m, "EUR");
Currency s2 = s1;
s2.Amount = 200m;
Console.WriteLine(s1); // ?

CurrencyClass c1 = new CurrencyClass(100m, "EUR");
CurrencyClass c2 = c1;
c2.Amount = 200m;
Console.WriteLine(c1); // ? */
/* 
SimpleDate d1 = new SimpleDate(1, 1, 2024);
SimpleDate.CreateNewDate(ref d1, 17, 9, 2025);
Console.WriteLine(d1); // ? */

Mathematics.DivideByTwo(17, out int quotient, out int remainder);
Console.WriteLine($"17 / 2 = {quotient}, remainder {remainder}");
