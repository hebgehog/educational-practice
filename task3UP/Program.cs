using System;

namespace task3UP
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; bool D;
            double u = 0;
            Console.WriteLine("Введите координатy X");
            x = wwww();
            Console.WriteLine("Введите координату Y");
            y = wwww();
            D = ((x * x + y * y >= 1)&&(x * x + y * y <= 4)) && (x <= 0) && (y >= 0) || ((x * x + y * y >= 1)&& (x * x + y * y <= 4)) && (x >= 0) && (y >= 0);
            Console.WriteLine("Число находиться в указанной зоне:" + D);
            if (D) { u = 0; }
            else { u = x; }
            Console.WriteLine("Значение u = "+u);
            Console.ReadKey();
        }
        static double wwww()
        {
            while (true){
                double x;
                if (double.TryParse(Console.ReadLine(), out x))
                    return x;
                else
                    Console.WriteLine("Ошибка ввода, попробуйте еще раз");
            }
        }
    }
}