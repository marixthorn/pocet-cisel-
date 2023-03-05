Console.Write("Zadej čísla oddělená čárkou: ");
string input = Console.ReadLine() ?? "";
string[] numbers = input.Split(',');
numbers = numbers.Where(x => !string.IsNullOrEmpty(x)).ToArray();
Console.WriteLine($"\nPočet čísel: {numbers.Length}");