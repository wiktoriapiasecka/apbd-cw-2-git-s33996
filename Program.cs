Console.WriteLine("Statistics calculator - FEATURE");
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

    int[] numbers = Array.ConvertAll(values, int.Parse);
    double average = StatisticsHelper.CalculateAverage(numbers);
    int max = StatisticsHelper.CalculateMax(numbers);
    int min = StatisticsHelper.CalculateMin(numbers);

    Console.WriteLine($"You entered {count} values.");
    Console.WriteLine($"Average: {average}");
    Console.WriteLine($"Max: {max}");
    Console.WriteLine($"Min: {min}");
}