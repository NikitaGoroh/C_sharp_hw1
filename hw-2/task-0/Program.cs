/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456-> 5
782-> 8
918-> 1 */


Console.WriteLine("Введите число");
string input_string1 = Console.ReadLine();
int number = Convert.ToInt32(input_string1);
int secondDigit = 0;

if (number >= 100 && number < 1000)
{
    secondDigit = number / 10 % 10;
    Console.WriteLine($"Вторая цифра --> {secondDigit}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}