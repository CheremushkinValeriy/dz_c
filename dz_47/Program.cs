// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введите колличество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов массива: ");
int coluns = Convert.ToInt32(Console.ReadLine());

double[,] result = new double[rows,coluns];

double [,] array = GetArray(rows, coluns, -100, 100);
PrintArray(array);

double[,] GetArray (int rows, int coluns, int minValue, int maxValue)
{
    for(int i = 0; i < rows; i++)
    {
        for(int j =0; j < coluns; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);  
            result[i,j] = result[i,j]/10;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}














