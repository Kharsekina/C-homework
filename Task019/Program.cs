// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number >=10000  && number <=99999?$"Является ли число {number} палиндромом - {Polindrom(number)}":"Введено некорректноечисло");

string Polindrom(int num)
{
    int num1= num/10000;
    int num2= num/1000 %10;
    int num4= num/10 %10;
    int num5= num%10;
    if(num1 != num5) return "нет";
    if(num2 != num4) return "нет";
    return "да";
}