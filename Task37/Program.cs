// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве
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
void newMassiveIncrease (int[] array)
{
    if (array.Length % 2 = 0) 
        int[] newMassive = new Array(array.Length/2);
    else 
        int[] newMassive = new Array(array.Length/2+1);
    for (int i = 0; i < newMassive.Length; i++)
    {
        for (int j = newMassive.Length; j < newMassive.Length/2; j--)
        {
            newMassive[i] = array[i]*array[j];
        }
    }
    return Console.WriteLine(newMassive);
}
int[] myArr = CreateArray(9,1,8);
PrintArray(myArr);
newMassiveIncrease(myArr);
