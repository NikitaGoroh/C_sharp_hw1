/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16


int value(string message)
{
    Console.WriteLine($"{message} > ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

int firstNumber = value("Введите число A");
int secondNumber = value("Введите число B");

int resultOfcalc(int a, int b)
{
    int result = 1;
    if (a == 0)
    {
        result = 0;
    }
    else if (b == 0)
    {
        result = 1;
    }
    else
    {
        for (int i = 0; i <= b; i++)
        {
            result = result * a;
        }

    }
    return result;
}


int finalResult = resultOfcalc(firstNumber, secondNumber);
Console.WriteLine($"{firstNumber},{secondNumber} --> {finalResult}");*/





int value(string message)
{
    Console.WriteLine($"{message} > ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

int firstNumber = value("Введите число A");
int secondNumber = value("Введите число B");

int resultOfcalc(int firstNumber, int secondNumber)
{
    int result = 1;

    for (int i = 0; i < secondNumber; i++)
    {
        result = result * firstNumber;
    }

    return result;
}


int finalResult = resultOfcalc(firstNumber, secondNumber);
Console.WriteLine($"{firstNumber},{secondNumber} --> {finalResult}");