/* Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int value(string message)
{
    Console.WriteLine(message);
    string input_string = Console.ReadLine();
    int result = Convert.ToInt32(input_string);
    return result;
}

int number = value("Введите пятизначное число");
int firstDigit = number / 10000;
int secondDigit = number / 1000 % 10;
int fourthDigit = number / 10 % 10;
int lastDigit = number % 10;

bool firstCheck()
{
    if (firstDigit == lastDigit)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool secondCheck()
{
    if (secondDigit == fourthDigit)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool firstCouple = firstCheck();
bool secondCouple = secondCheck();

if (number <= 9999 || number > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else if (firstCouple && secondCouple)
{
    Console.WriteLine($"{number} -- > да");
}
else
{
    Console.WriteLine($"{number} -- > нет");
}