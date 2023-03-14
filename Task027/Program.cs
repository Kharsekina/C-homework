// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Ведите число");
int number=Convert.ToInt32(Console.ReadLine());

int sumNumbers=Sum(number);
Console.WriteLine($"{sumNumbers}");

int Sum(int num)
{
    if(num<0) num= -num;
    int sum=0;
    int digit=0;

    do
    {
        digit=num%10;
        sum=sum+digit;
        num=num/10;
    }
    while(num!=0);
    return sum;
}
