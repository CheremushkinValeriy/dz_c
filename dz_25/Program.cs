//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
  
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
 
int numberA, numberB, number;  
double result;
//-----------------------------------------------    
numberA = userInput("Введите число A:");
numberB = userInput("Введите число B:");
result = Pow(numberA, numberB);
Console.Write("-> " + result);  
//----------------------------------------------- 
int userInput(string message)
{
  while (true)
  {
    Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out number))
    {
      return number;
      break;    
    }
    Console.WriteLine($"Ошибка ввода!");
  }
}
//----------
double Pow(int numberA, int numberB)
{
  double result = Math.Pow(numberA, numberB);
  return result;
}

