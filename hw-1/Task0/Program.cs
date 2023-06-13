/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3*/


Console.WriteLine("Введите первое число");
string input_string1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string input_string2 = Console.ReadLine();

int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);


if (number2 > number1)
{
    Console.WriteLine($"Max = {number2}");
}
else if (number2 == number1)
{
    Console.WriteLine($"числа равны");
}
else
{
    Console.WriteLine($"Max = {number1}");
}
