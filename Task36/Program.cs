// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях
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
void findSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array[i];
        }
    }
    Console.Write($"Сумма элементов нечётных позиций - {sum}");
}
int[] myArr = CreateArray(5,1,8);
PrintArray (myArr);
findSum(myArr);