Console.WriteLine("Statistics calculator");
Console.WriteLine("Enter numbers separated by spaces:");

string? input = Console.ReadLine();

if (input != null)
{
    string[] values = input.Split(' ');
    Console.WriteLine($"You entered {values.Length} values.");
}