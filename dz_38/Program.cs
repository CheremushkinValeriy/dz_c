// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 
// [3 7 22 2 78] -> 76
 
int size = userInput("Введите размер массива: ");
int[] array = GetArray(size);
PrintArray(array);
int max = maxNumber(array);
int min = minNumber(array);
PtintDifference(max, min);
//-----------------------------------------------
int userInput(string message)
{
    Console.Write(message);
    string userInput = Console.ReadLine() ?? "";
    int size = int.Parse(userInput);
    return size;
}
//-----------------------------------------------------
int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        string numberInput = Console.ReadLine() ?? "";
        int number = int.Parse(numberInput);
        res[i] = number;
    }
    return res;
}
//------------------------------------------------------
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}  
//-----------------------------------------------------
int maxNumber(int[] array)
{
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
        if (max <= array[i])
        max = array[i];
    return max;
}
 //-----------------------------------------------------
int minNumber(int[] array) 
{
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
        if (min >= array[i])
        min = array[i];
        return min;
}
//-------------------------------------------------------   
void PtintDifference(int max, int min)
{
    int difference = max - min;
    Console.Write("-> " + difference);
}
