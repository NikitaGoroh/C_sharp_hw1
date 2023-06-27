/* Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 3D пространстве.
A(3, 6, 8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53*/

int value(string message)
{
    Console.WriteLine($"{message} > ");
    int result = int.Parse(Console.ReadLine());
    return result;
}

double Length(int x, int y, int z)
{
    double temp = (x * x) + (y * y) + (z * z);
    return Math.Sqrt(temp);
}

int x1 = value("введите координату X первой точки");
int y1 = value("введите координату Y первой точки");
int z1 = value("введите координату Z первой точки");
int x2 = value("введите координату X второй точки");
int y2 = value("введите координату Y второй точки");
int z2 = value("введите координату Z второй точки");

double result = Length(x1 - x2, y1 - y2, z1 - z2);
double finalResult = Math.Round(result, 2);

Console.WriteLine
($"расстояние между двумя точками в 3D пространстве равно: {finalResult}");