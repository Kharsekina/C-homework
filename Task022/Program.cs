// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число");
int number=Convert.ToInt32(Console.ReadLine());
if (number<=0) Console.WriteLine("Некорректное число");
else TabCube(number);

void TabCube (int number)
{
    int index=1;
    int result=0;
    while (index<= number)
    {
        result=index*index*index;
        Console.WriteLine($"{index,5}{result,5}");
        index++;
    }
}