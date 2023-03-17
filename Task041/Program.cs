// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int size)
{
    int[] arr= new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число");
        arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[]arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.Write($"{arr[arr.Length-1]}");
    Console.Write("]");
}

int QuantityDigit(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0) count ++;
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int M=Convert.ToInt32(Console.ReadLine());
int[] array= FillArray(M);
PrintArray(array);
Console.WriteLine();
int quantityDigit=QuantityDigit(array);
Console.WriteLine($"Колличество чисел больше ноля {quantityDigit}");
