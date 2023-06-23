/* Задача 2: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


Console.WriteLine("Введите число");
string input_string1 = Console.ReadLine();
int number = Convert.ToInt32(input_string1);
int thirdDigit = 0;

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра --> {thirdDigit}");
}


