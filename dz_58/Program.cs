// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();
int n = userInput("Введите колличество строк первой матрицы: ");
int m = userInput("Введите колличество столбцов первой матрицы: ");
int x = userInput("Введите колличество строк второй матрицы: ");
int y = userInput("Введите колличество столбцов второй матрицы: ");
Console.WriteLine();

if (n == y & m == x)
{
    int[,] array1 = new int[n, m];
    GetArray(array1);
    Console.WriteLine($"\nПервая матрица:");
    PrintArray(array1);

    int[,] array2 = new int[x, y];
    GetArray(array2);
    Console.WriteLine($"\nВтораая матрица:");
    PrintArray(array2);

    int[,] array3 = new int[n, y];
    WorkArray(array1, array2, array3);
    Console.WriteLine($"\nПроизведение первой и второй матриц:");
    PrintArray(array3);
}
else
    Console.WriteLine("Невозможно выполнить перемножение матриц");

int userInput(string message)
{
    while (true)
    {
        Console.Write(message + " ");
        if (int.TryParse(Console.ReadLine(), out int number)) ;
            return number;
        Console.WriteLine($"Ошибка ввода данных");
    }
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void WorkArray(int[,] array1, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int work = 0;
            for (int z = 0; z < array1.GetLength(1); z++)
                work += array1[i, z] * array2[z, j];
            array3[i, j] = work;
        }
    }
}















