// Задача 1: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GenerateArray(int len, int min, int max)
{
    int[] answer = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);

    }
    return answer;
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
int ShowEvenCountInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] newArray = GenerateArray(10, 100, 1000);
int EvenCount = ShowEvenCountInArray(newArray);
System.Console.WriteLine();
PrintArray(newArray);
Console.Write($"Четных чисел ->  {EvenCount}");
