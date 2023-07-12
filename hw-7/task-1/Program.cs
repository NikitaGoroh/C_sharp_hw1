// Задача 2. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7->такого числа в массиве нет
// 0, 0 -> 1

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateArray2D(int rows, int columns, int min, int max)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(min, max + 1);
        }
    }
    return numbers;
}

int FindElementByIndex(int[,] numbers, int IndexR, int IndexC)
{
    int result = numbers[0, 0];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {

        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] == numbers[IndexR, IndexC])
            {
                result = numbers[i, j];

            }

        }
        return result;
    }
    return result;
}

bool Validate(int[,] numbers, int indexRows, int indexColumns)
{
    if (indexRows > numbers.GetLength(0) || indexColumns > numbers.GetLength(1))
    {
        return false;
    }
    return true;
}


void PrintNum(int indexRows, int indexColumns, int[,] array)
{
    if (Validate(array, indexRows, indexColumns))
    {
        System.Console.Write($"Элемент равен {array[indexRows, indexColumns]}");
    }
    else
    {
        System.Console.Write($"нет такого элемента");
    }

}

int rows = ReadInt("Введите количество строк > ");
int columns = ReadInt("Введите количество столбцов > ");
System.Console.WriteLine();
int indexRows = ReadInt("Введите индекс строки > ");
int indexColumns = ReadInt("Введите индекс столбца > ");
int[,] array = GenerateArray2D(rows, columns, 0, 10);
PrintArray2D(array);
PrintNum(indexRows, indexColumns, array);


// if (Validate(array, rows, columns))
// {
//     System.Console.Write($"Элемент равен {IndexOfElement}");
// }
// else
// {
//     System.Console.Write($"нет такого элемента");
// }

