using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Чётные числа от 1 до " + num + ":");

        for (int i = 2; i <= num; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.ReadKey();
    }
}
