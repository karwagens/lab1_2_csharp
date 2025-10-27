using System;

class Program
{
    static void Main()
    {
        // Задача 1: Конвертер температур
        Console.WriteLine("Задача 1: Конвертация Цельсий → Фаренгейт");
        double celsius = GetNumber("Температура в градусах Цельсия");
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine($"Результат: {fahrenheit:F2}°F\n");

        // Задача 2: Площадь полусферы
        Console.WriteLine("Задача 2: Расчет площади полусферы");
        double radius = GetPositiveNumber("Радиус полусферы: ");
        double area = 0.5 * 4 * Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Площадь полусферы: {area:F2}\n");

        // Задача 3: Площадь поверхности куба
        Console.WriteLine("Задача 3: Расчет площади поверхности куба");
        double edge = GetPositiveNumber("Длина ребра куба: ");
        double cubeArea = 6 * Math.Pow(edge, 2);
        Console.WriteLine($"Площадь поверхности куба: {cubeArea:F2}");
    }

    // "Проверки на дурака"
    static double GetNumber(string message)
    {
        while (true)
        {
            Console.Write($"Введите {message}: ");
            if (double.TryParse(Console.ReadLine(), out double result))
                return result;
            Console.WriteLine("Ошибка! Введите число.");
        }
    }

    static double GetPositiveNumber(string message)
    {
        while (true)
        {
            double num = GetNumber(message);
            if (num > 0) return num;
            Console.WriteLine("Ошибка! Число должно быть положительным.");
        }
    }
}
