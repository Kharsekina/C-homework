// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M");
int numberM=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN=Convert.ToInt32(Console.ReadLine());
if(numberM<0 || numberN<0) Console.WriteLine("Введите числа больше 0");
else
{
   int akk=Akkerman(numberM,numberN);
   Console.WriteLine($"M={numberM}, N={numberN}->A(m,n)={akk}");
}

int Akkerman(int numM, int numN)
{
    if(numM==0) return numN+1;
    else if (numN==0) return Akkerman(numM-1,1);
    else return Akkerman(numM-1, Akkerman(numM,numN-1));
}