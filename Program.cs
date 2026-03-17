Console.WriteLine("Statistics calculator");
Console.WriteLine("Enter numbers separated by spaces:");

string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: no values were provided.");
}
else
{
    string[] values = input.Split(' ');
    int count = StatisticsHelper.CountValues(values);
    Console.WriteLine($"You entered {count} values.");
}
