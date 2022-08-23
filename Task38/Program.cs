// Задайте массив вещественных чисел. Найдите разницу между макимальным и минимальным элементом массива
double[] newArray (int length)
{
    double[] array = new double[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble();
    }
    return array;
}
void PrintArray (double[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
double searchMax (double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
    }
    return max;
}
double searchMin (double[] array)
{
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min) min = array[i];
    }
    return min;
}
double difference (double min, double max)
{
    double diff = max - min;
    return diff;
}
double[] myArr = newArray(5);
PrintArray(myArr);
double max = searchMax(myArr);
double min = searchMin(myArr);
double diff = difference(min,max);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным - {diff}");