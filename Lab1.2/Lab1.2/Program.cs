using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        Func<int>[] delegates = new Func<int>[] {
            () => rand.Next(0, 10),
            () => rand.Next(10, 20),
            () => rand.Next(20, 30)
        };

        Func<Func<int>[], double> averageDelegateValues = delegate (Func<int>[] dels) {
            int sum = 0;
            foreach (Func<int> del in dels)
            {
                sum += del();
            }
            return (double)sum / dels.Length;
        };

        double result = averageDelegateValues(delegates);
        Console.WriteLine("Середнє арифметичне значення: " + result);
    }
}