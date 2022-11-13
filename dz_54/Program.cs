// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int n = userInput("Введите колличество строк массива");
int m = userInput("Введите колличество столбцов массива");
int[,] array = GetArray(n,m);
PrintArray(array);
ChangeArray(array);
Console.WriteLine();
PrintArray(array);

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
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}