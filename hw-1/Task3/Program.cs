/*Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/


Console.WriteLine("Введите число");
string input_string1 = Console.ReadLine();
int number = Convert.ToInt32(input_string1);
int step = 2;

while (step <= number)
{
    Console.WriteLine(step);
    step += 2;
}
