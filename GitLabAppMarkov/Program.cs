using System;

namespace GitLabAppMarkov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение параметра X: ");
            string s = Console.ReadLine();
            double x = double.Parse(s);
            double F = Math.Sin(x) + Math.Cos(x);
            Console.WriteLine($"Значение F = {F}.");
            Console.ReadKey();
            return;
        }
    }
}
