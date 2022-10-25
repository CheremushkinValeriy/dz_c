// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 

Console.Clear();
 
int n = userInput("Введите колличество строк массива: ");
int m = userInput("Введите колличество столбцов массива: ");

int[,] array = GetArray(n,m);
PrintArray(array);
Average(array);
 
int userInput(string message)
{
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
            break;
        }
        Console.WriteLine($"Ошибка ввода");
    }
}
 
int[,] GetArray (int n, int m)
{
    int[,] result = new int [n,m];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
            result[i,j] = new Random().Next(0, 10);
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
 
void Average(int[,] array)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for(int i = 0; i < array.GetLength(0); i++)
          average += array[i,j];
        double res = Math.Round((double)average / n, 1);
        Console.WriteLine("-> " + res);
    } 
}
