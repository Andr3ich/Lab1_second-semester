using System;

namespace Lab1_1
{
    public delegate int Delegate(int a, int b);

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Оберiть дiю : +, -, *, /");
            string a = Console.ReadLine();
            Console.WriteLine("Перше число : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Друге число :");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case "+":
                    Delegate Delegate1 = (c, b) => c + b;
                    int del1 = Delegate1(x, y);
                    Console.WriteLine("Вiдповiдь : {0}", del1);
                    break;
                case "-":
                    Delegate Delegate2 = (c, b) => c - b;
                    int del2 = Delegate2(x, y);
                    Console.WriteLine("Вiдповiдь : {0}", del2);
                    break;
                case "*":
                    Delegate Delegate3 = (c, b) => c * b;
                    int del3 = Delegate3(x, y);
                    Console.WriteLine("Вiдповiдь : {0}", del3);
                    break;
                case "/":
                    Delegate Delegate4 = (c, b) => b == 0 ? 0 : c / b;
                    int del4 = Delegate4(x, y);
                    Console.WriteLine("Вiдповiдь : {0}", del4);
                    break;
            }

            Console.ReadKey();

        }
    }
}