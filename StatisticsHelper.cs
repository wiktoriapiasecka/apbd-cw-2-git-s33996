public static class StatisticsHelper
{
    public static int CountValues(string[] values)
    {
        return values.Length;
    }

    public static double CalculateAverage(int[] values)
    {
        int sum = 0;

        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }

        return (double)sum / values.Length;
    }
}