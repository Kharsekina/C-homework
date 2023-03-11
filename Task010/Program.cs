// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число");
int number=Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
 {
  int socondDigit=SecondDigit(number);
  Console.WriteLine($"Вторая цифра {socondDigit}");
 }
else Console.WriteLine("Введите трехзначное число");

int SecondDigit(int num)
{
    return num/10%10;
}