Console.WriteLine("Statistics calculator");
Console.WriteLine("Enter numbers separated by spaces:");

string? input = Console.ReadLine();

if (input != null)
{
    string[] values = input.Split(' ');
    int count = StatisticsHelper.CountValues(values);
    Console.WriteLine($"You entered {count} values.");
}