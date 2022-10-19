// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 
// 0, 7, 8, -2, -2 -> 2
 
// 1, -7, 567, 89, 223-> 3
 
// 1. запросить  упользователя значение переменной М
// 2. создать массив из М чисел
// 3. организовать цикл ввода значений с консоли для заполнения массива
// 4. метод по значениям массива с получением количества значений больше ноля
 
int size = userInput("Введите размер массива: ");
int[] array = GetArray(size);
int positiveNumber = GetPositiveNumber(array);
Console.WriteLine("Колличество положительных чисел введенных пользователем: " + positiveNumber);
//////////////////////////////////////////////////////
int userInput(string message)
{
    Console.Write(message);
    string userInput = Console.ReadLine() ?? "";
    int size = int.Parse(userInput);
    return size;
}
///////////////////////////////////////////////////////
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
////////////////////////////////////////////////////////
int GetPositiveNumber(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        if (element > 0)  
        count ++;
    }
    return count;
}
