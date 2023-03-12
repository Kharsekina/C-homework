// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Ведите цифру");
int number=Convert.ToInt32(Console.ReadLine());

if (number<1 || number>7) Console.WriteLine("Некорректное число, введите число от 1 до 7");
else WeekDays(number);


bool WeekDays(int num)
{
    if(num>5) 
    {
        Console.WriteLine("да");
        return true;
    }
    Console.WriteLine("нет");
    return false;
}