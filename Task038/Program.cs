// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] FillArray(int size, int min, int max)
{
    double[] arr= new double[size];
    Random rnd= new Random();
    for (int i = 0; i < size; i++)
    {
        double num=rnd.NextDouble()*(max-min)+min;
        arr[i]=Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double []arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

double MinDigit(double[]arr)
{
    double minPosition=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i]<minPosition) minPosition=arr[i];
    }
    return minPosition;
}

double MaxDigit(double[]arr)
{
    double maxPosition=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i]>maxPosition) maxPosition=arr[i];
    }
    return maxPosition;
}

double [] array= FillArray(5,0,10);
PrintArray(array);
Console.WriteLine();
double difference= Math.Round(MaxDigit(array)-MinDigit(array), 1);
Console.WriteLine(difference);
