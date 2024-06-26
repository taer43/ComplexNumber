﻿using System;

namespace ComplexNumber;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите комплексное число в формате a+bi:");
            Console.Write("действительная часть a = ");
            double realPart = double.Parse(Console.ReadLine());

            Console.Write("мнимая часть b = ");
            double imaginaryPart = double.Parse(Console.ReadLine());

            // Создание комплексного числа
            ComplexNumber complex1 = new ComplexNumber(realPart, imaginaryPart);

            Console.WriteLine("Введите второе комплексное число в формате a+bi:");
            Console.Write("действительная часть a = ");
            realPart = double.Parse(Console.ReadLine());

            Console.Write("мнимая часть b = ");
            imaginaryPart = double.Parse(Console.ReadLine());

            // Создание второго комплексного числа
            ComplexNumber complex2 = new ComplexNumber(realPart, imaginaryPart);

            // Сложение комплексных чисел
            ComplexNumber sum = complex1 + complex2;
            Console.WriteLine($"Сумма: {sum}");

            // Вычитание комплексных чисел
            ComplexNumber difference = complex1 - complex2;
            Console.WriteLine($"Разность: {difference}");

            // Умножение комплексных чисел
            ComplexNumber product = complex1 * complex2;
            Console.WriteLine($"Произведение: {product}");

            // Деление комплексных чисел
            ComplexNumber quotient = complex1 / complex2;
            Console.WriteLine($"Частное: {quotient}");
        }

        // Обработка исключений
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка ввода: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");

        }
    }
}   

