// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3-> 1, 8, 27
//5-> 1, 8, 27, 64, 125

int value(string message)
{
    Console.WriteLine($"{message} > ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

int number = value("введите число");

for (int i = 1; i <= number; i++)
{
    int result = i * i * i;
    Console.WriteLine($"{result}");
}

