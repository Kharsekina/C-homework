// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x+b1=k2*x+b2;
// x=(b2-b1)/(k1-k2) =>
// y = k1 * (b2-b1)/(k1-k2) + b1

Console.WriteLine("Введите число b1");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
int digit1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2");
int num2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
int digit2= Convert.ToInt32(Console.ReadLine());

if (digit1==digit2) Console.WriteLine("Прямые являются параллельными");
else Console.WriteLine($"Координаты пересечения:({FindX(num1, digit1, num2, digit2)};{FindY(num1, digit1, num2, digit2)})");

double FindX(int b1, int k1, int b2, int k2)
{
    double X=(b2-b1)/(k1-k2);
    return X;
}

double FindY(int b1, int k1, int b2, int k2)
{
    double Y=k1 * (b2-b1)/(k1-k2) + b1;
    return Y;
}