//Петросян Араик 22-Исп-2/1 средний уровень 1.1
Console.WriteLine("Введите t:");
double t = double.Parse(Console.ReadLine());
Console.WriteLine("Введите r:");
double r = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
double part1 = 4 * (t * t * t) + Math.Log(r);
double part2 = Math.Pow(Math.Exp(1), y + r) + 7.2 * Math.Sin(r);
double W = part1 / part2;
Console.WriteLine($"W={W}");