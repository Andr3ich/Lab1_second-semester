using System;

class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int, double> average = delegate (int a, int b, int c) {
            return (double)(a + b + c) / 3;
        };

        double result = average(12, 44, 88);
        Console.WriteLine("Середнє арифметичне значення: " + result);
    }
}