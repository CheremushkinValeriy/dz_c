/*Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();
Console.WriteLine("Введите размеры трехмерного массива:");
int x = userInput("Введите X: ");
int y = userInput("Введите Y: ");
int z = userInput("Введите Z: ");
int[,,] array = new int[x, y, z];
GetArray(array);
Console.WriteLine();
PrintArray(array);


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

void GetArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    for (int i = 0; i < temp.GetLength(0); i++)
    temp[i] = new Random().Next(10, 100);
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}{(i, j, k)} ");
            Console.WriteLine();
        }
    }
}
