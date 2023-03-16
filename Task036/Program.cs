//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int min, int max)
{
    int[] arr= new int[size];
    Random rnd= new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i]=rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

int SumOddIndex(int []arr)
{
    int sum=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2!=0) sum= sum+ arr[i];
    }
    return sum;
}

int [] array= FillArray(5,-10,10);
PrintArray(array);
Console.WriteLine();
int sumOddIndex=SumOddIndex(array);
Console.WriteLine(sumOddIndex);
