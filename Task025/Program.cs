// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int numberA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB=Convert.ToInt32(Console.ReadLine());

if (Natural(numberB))
{
    Console.WriteLine($"{numberA}, {numberB} ->{Pow(numberA, numberB)}");
}

bool Natural(int num)
{
    if (num<0) 
    {
        Console.WriteLine("Введите натуральное число");
        return false;
    }  
    return true;    
}   

int Pow(int num1, int num2)
{
    if (num2 == 0) num1 = 1;

    int product=1;
    for(int i=0; i< num2; i++)
    {
         product= product*num1;
    }
    return product;
}
