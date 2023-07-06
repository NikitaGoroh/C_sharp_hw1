// Задача 3: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] GenerateArray(int len, int min, int max)
{
    double[] answer = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1) + rnd.NextDouble;

    }
    return answer;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write(item + "\t");
    }
    System.Console.WriteLine();
    return;
}
double FindMax(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] newArray = GenerateArray(7, 10, 30);
double Diff = FindMax(newArray) - FindMin(newArray);
System.Console.WriteLine();
PrintArray(newArray);
Console.Write($"Разница между max и min ->  {Diff}");


