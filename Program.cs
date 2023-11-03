namespace Statistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = {1, 5, 4.25};

            double min = numbers[0];
            double max = numbers[1];
            double sum = 0;

            int count = numbers.Length;

            for (int i = 0; i < count; i++)
            {
                double value = numbers[i];
                sum += value;

                if (min > value)
                {
                    min = value;
                }
                if (max < value)
                {
                    min = value;
                }
            }

            double average = sum / count;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Average: " + Math.Round(average, 2));
        }
    }
}