namespace Statistic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = {1, 5, 4.25};

            try
            {
                double sum = CalculateSum(numbers);
                double min = CalculateMin(numbers);
                double max = CalculateMax(numbers);
                double average = CalculateAverage(numbers);
                PrintStatistics(sum, min, max, average);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
                throw;
            }
        }

        public static double CalculateSum(double[] numbers)
        {
            double sum = 0;
            foreach (double value in numbers)
            {
                sum += value;
            }
            return sum;
        }

        public static double CalculateMin(double[] numbers)
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

        public static double CalculateMax(double[] numbers)
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

        public static double CalculateAverage(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            double sum = CalculateSum(numbers);
            return sum / numbers.Length;
        }

        public static void PrintStatistics(double sum, double min, double max, double average)
        {
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Average: {Math.Round(average, 2)}");
        }
    }
}