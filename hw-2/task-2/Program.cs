/* Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */


int value(string message)
{
    Console.WriteLine(message);
    string input_string = Console.ReadLine();
    int result = Convert.ToInt32(input_string);
    return result;
}

int number = value("Введите цифру");

if (number == 6 || number == 7)
{
    Console.WriteLine($"{number} --> Да");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine($"{number} --> Нет");
}
else
{
    Console.WriteLine("Неверное значение");
}