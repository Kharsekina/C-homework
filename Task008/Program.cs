// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int N=Convert.ToInt32(Console.ReadLine());
if (N>0)
{
int count = 1;
while(count<=N)
{
    Console.Write(count + " ");
    count++;
}
}
else Console.WriteLine("Введите положительное число");
