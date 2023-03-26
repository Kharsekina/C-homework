// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumbers(numberM, numberN);
Console.WriteLine($"M={numberM}; N={numberN}->{sumNumber}");


int SumNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        if (numM == numN) return numM;
        return numM + SumNumbers(numM + 1, numN);
    }
    else if (numM > numN)
    {
        if (numN == numM) return numN;
        return numM + SumNumbers(numM - 1, numN);
    }
    else return numM;

}

