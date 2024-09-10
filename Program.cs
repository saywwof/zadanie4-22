using System;

class Program
{
    static void Main()
    {
        // Запрос числа у пользователя
        Console.Write("Введите число для вычисления его факториала: ");
        string input = Console.ReadLine();

        // Проверка, что введенное значение является числом
        if (int.TryParse(input, out int number))
        {
            if (number < 0)
            {
                Console.WriteLine("Факториал для отрицательных чисел не определен.");
            }
            else
            {
                // Вычисление факториала
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Факториал числа {number} равен {factorial}");
            }
        }
        else
        {
            Console.WriteLine("Введите корректное целое число.");
        }
    }

    // Метод для вычисления факториала
    static long CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
