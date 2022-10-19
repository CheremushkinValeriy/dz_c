// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetArray (4, 0, 99);
PrintArray(array);
int SumNumbers = GetSumNumbers(array);
Console.WriteLine("-> " + SumNumbers);
//--------------------------------------------------------- 
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
        res[i] = new Random().Next(minValue, maxValue +1);
    return res;
}
//---------------------------------------------------------
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
//---------------------------------------------------------
int GetSumNumbers(int[] array)
{
    int SumNumbers = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if (index % 2 != 0)
            SumNumbers += array[index];
    }
    return SumNumbers;
}

