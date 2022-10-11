// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number; 
int count = 1;
    
while (true)
{
  Console.Write("Введите число: ");
  if (int.TryParse(Console.ReadLine(), out number))
      break;
  Console.WriteLine($"Ошибка ввода!");
}
Console.Write($"N= {number} -> ");
 
while (count <= number)
{
  double number1 = Math.Pow(count, 3);
  Console.Write(number1 + ", ");
  count ++;
}