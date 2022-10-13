// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
 

Console.Write("Введите размер массива: ");
string userInput = Console.ReadLine() ??"";
int size = int.Parse(userInput);
//--------------------------------------------
int[] Arrey = InputRandom(size);
Console.Write("[");
for (int i = 0; i < size; i++)
{
  Console.Write(Arrey[i] + ",");
} 
Console.Write("]");
//---------------------------------------------
int[] InputRandom (int size)
{
  int[] arrey = new int[size];
  for (int i = 0; i < size; i++)
  {
    arrey[i] = new Random().Next(0, 100);
    //можно добавить еще ввод начал/конц рандомного выбора чисел и три переменной передавать методу.
  }
  return arrey;
} 
