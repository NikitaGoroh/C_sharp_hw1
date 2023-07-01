//Задача 3: Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

int Prompt(string message)
{
    Console.WriteLine($"{message} > ");
    string inputedStr = Console.ReadLine();
    if (int.TryParse(inputedStr, out int value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}
int[] GenerateArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

int Length = Prompt("Введите длинну массива");
int min = Prompt("Введите min массива");
int max = Prompt("Введите max массива");
int[] array = GenerateArray(Length, min, max);
PrintArray(array);
