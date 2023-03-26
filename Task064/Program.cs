// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N");
int numberN=Convert.ToInt32(Console.ReadLine());
if (numberN<1) Console.WriteLine("Введите число больше 1");
else 
{
    Console.Write($"N={numberN}->");
    NaturalNumbers(numberN);
}

void NaturalNumbers(int num)
{
    if(num==0) return;
    if (num==1) 
    {
        Console.Write("1");
        return;
    }
    Console.Write($"{num}, ");
    NaturalNumbers(num-1);
}


