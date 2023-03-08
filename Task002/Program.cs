// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.a = 5; b = 7 -> max = 7
Console.WriteLine("Ведите первое число");
int A = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32 (Console.ReadLine());
if (A>B)
{
    Console.WriteLine($"Максимальное число {A}");
    }
else
{
    Console.WriteLine($"Максимальное число {B}");
}    

