/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


internal class Program
{
    private static void Main(string[] args)
    {
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


        int sumOfDigit(int Number)
        {
            int result = 0;
            while (Number > 0)
            {
                result = result + Number % 10;
                Number = Number / 10;
            }
            return result;
        }


        int Number = Prompt("Введите число");
        int finalResult = sumOfDigit(Number);
        Console.WriteLine($"{Number} --> {finalResult}");
    }
}