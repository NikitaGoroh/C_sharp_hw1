/*Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/



Console.WriteLine("Введите первое число");
string input_string1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string input_string2 = Console.ReadLine();
Console.WriteLine("Введите третье число");
string input_string3 = Console.ReadLine();

int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);
int number3 = Convert.ToInt32(input_string3);

int[] numbers = { number1, number2, number3 };
int index = 0;
int max = number1;


while (index < numbers.Length)
{
    if (numbers[index] > max)
    {
        max = numbers[index];

    }
    index++;
};


Console.WriteLine($"Max = {max}");