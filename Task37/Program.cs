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
        Console.WriteLine($"{array[i]} ");
    }
}
int[] newMassive (int[] array)
{
    if (array.Length % 2 == 0) 
    {
        int len = array.Length/2;
        int[] newMass = new int[len];
        return newMass;
    }
    else
    {
        int len = array.Length/2+1;
        int[] newMass = new int[len];
        return newMass;
    }
}

 int[] increase (int[] array, int[] newMassive) //Сижу уже третий час над этой задачей и не понимаю, почему с какими то цифрами код работает, а с какими то нет =(
 {
    int j = array.Length-1;
    
        if (newMassive.Length%2-1==0)
        {
            for (int i = 0; i < newMassive.Length; i++)
            {
                newMassive[i] = array[i]*array[j];
                j--;
            }
            return newMassive;
        }    
       else 
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                newMassive[i] = array[i]*array[j];
                j--;
            }
            newMassive[newMassive.Length-1] = array[array.Length/2];
            return newMassive;
        }
    
 }
int[] myArr = CreateArray(5,1,8);
PrintArray(myArr);
int[] newM = newMassive(myArr);
increase(myArr, newM);
Console.WriteLine();
PrintArray(newM);

