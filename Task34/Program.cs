// задайте массив заполненный случайными положительными трёхзначными числами. Напишите прогорамму, которая покажет количество чётных чисел в массиве
int[] CreateArray (int length, int min, int max) 
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
void PrintArray (int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void col (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)  
        count++;
    }
    Console.Write($"Количество чётных чисел в массиве - {count}");
}
int[] myArr = CreateArray(12,100,999);
PrintArray(myArr);
col(myArr);









