//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 2, 3, 7 -> 7
Console.WriteLine("Введите первое число");
int A= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int C=Convert.ToInt32(Console.ReadLine());
int MAX=A;
if (MAX<A) MAX=A;
if (MAX<B) MAX=B;
if (MAX<C) MAX=C;
Console.WriteLine($"Максимальное число {MAX}");

