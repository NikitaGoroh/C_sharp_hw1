// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)


int value(string message)
{
    Console.WriteLine($"{message} > ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

int b1 = value("введите значение b1");
int k1 = value("введите значение k1");
int b2 = value("введите значение b2");
int k2 = value("введите значение k2");

