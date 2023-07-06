// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0


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
int FindSumUnevenPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] newArray = GenerateArray(10, 1, 10);
int UnevenSum = FindSumUnevenPosition(newArray);
System.Console.WriteLine();
PrintArray(newArray);
Console.Write($"Cумма элементов, стоящих на нечётных позициях ->  {UnevenSum}");
