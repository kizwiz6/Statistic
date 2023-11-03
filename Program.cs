namespace Statistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = {1, 5, 4.25};

            double sum = CalculateSum(numbers);
            double min = CalculateMin(numbers);
            double max = CalculateMax(numbers);
            double average = CalculateAverage(numbers);

            PrintStatistics(sum, min, max, average);
        }

        static double CalculateSum(double[] numbers)
        {
            double sum = 0;
            foreach (double value in numbers)
            {
                sum += value;
            }
            return sum;
        }

        static double CalculateMin(double[] numbers)
        {
            double min = numbers[0];
            foreach (double value in numbers)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            return min;
        }

        static double CalculateMax(double[] numbers)
        {
            double max = numbers[0];
            foreach (double value in numbers)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }

        static double CalculateAverage(double[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            double sum = CalculateSum(numbers);
            return sum / numbers.Length;
        }

        static void PrintStatistics(double sum, double min, double max, double average)
        {
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Average: {Math.Round(average, 2)}");
        }
    }
}