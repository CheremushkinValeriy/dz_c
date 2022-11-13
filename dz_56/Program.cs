// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int n = userInput("Введите колличество строк массива");
int m = userInput("Введите колличество столбцов массива");
Console.WriteLine();
int[,] array = GetArray(n,m);
PrintArray(array);
ChangeArray(array);
 
int userInput(string message)
{
  while (true)
  {
      Console.WriteLine(message);
      if(int.TryParse(Console.ReadLine(), out int number));
        return number;
      Console.WriteLine($"Ошибка ввода данных");
  }
}
 
int[,] GetArray(int n, int m)
{
    int[,] result = new int [n,m];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
            result[i,j] = new Random().Next(0,10);
    }
    return result;
 
}
 
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}
 
void ChangeArray(int[,] array)
{
  int index = 0, minSum = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i,j];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма {i+1}-й строки = {sum}");
    if (i == 0)
      minSum = sum;
    else if (sum <= minSum)
    {
      sum = minSum;
      index = i;
    }
  }
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: = {index + 1}"); 
}
