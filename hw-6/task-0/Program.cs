// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int value(string message)
{
    Console.WriteLine($"{message} > ");
    int result = int.Parse(Console.ReadLine());
    return result;
}
int[] PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + "\t");
    }
    System.Console.WriteLine();
    return array;
}


int[] inputOfNumbers(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        int input = value("введите число -> ");
        array[i] = input;
    }
    return array;
}

int sumOfPositive(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0)
        {
            count += item;
        }
    }
    return count;
}

int countNumbers = value("сколько чисел вы хотите ввести");
int[] num = inputOfNumbers(countNumbers);
PrintArray(num);
int sum = sumOfPositive(num);
System.Console.WriteLine($"Сумма положительных равна {sum}");