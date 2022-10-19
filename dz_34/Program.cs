// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
 
// [345, 897, 568, 234] -> 2
  
int[] array = GetArray (4, 100, 999);
int EvenNumbers = GetEvenNumbers(array);
PrintEvenNumbers(array);
Console.WriteLine("-> " + EvenNumbers);
//------------------------------------------------
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
        res[i] = new Random().Next(minValue, maxValue +1);
    return res;
}
//-----------------------------------------------------
int GetEvenNumbers(int[] array)
{
    int EvenNumbers = 0;
    foreach(int element in array)
    {
        if (element % 2 == 0)  
        EvenNumbers ++;
    }
    return EvenNumbers;
}
//-----------------------------------------------------
void PrintEvenNumbers(int[] arrey)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}