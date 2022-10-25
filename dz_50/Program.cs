// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int rows = userInput("Введите колличество строк массива: ");
int coluns = userInput("Введите колличество столбцов массива: ");
int x = userInput("Введите строку элемента массива: ");
int y = userInput("Введите столбец элемнта массива: ");
int[,] array = GetArray(rows, coluns);
PrintArray(array);
GetNumber(x,y);

int userInput(string message)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
            break;    
        }
        Console.WriteLine($"Ошибка ввода!");
    }
}

int[,] GetArray (int rows, int coluns)
{
    int[,] result = new int[rows,coluns];
    for(int i = 0; i < rows; i++)
    {
        for(int j =0; j < coluns; j++)
            result[i,j] = new Random().Next(0, 10);  
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            Console.Write($"{inArray[i, j]} ");
        Console.WriteLine();
    }
}

void GetNumber (int x, int y)
{
    if(x > rows && y > coluns)
        Console.WriteLine("Такого числа нет в массиве");
    else
    {
        object value = array.GetValue(x,y);
        Console.WriteLine("Значение элемента массива -> " + value);
    }
}










