// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
using System;
 
class Program {
  static void Main (string[] args) 
  {
  while(true)
  {
    
    Console.Write("Введите целое число от 1 до 7: ");
    string userInput = Console.ReadLine() ??"";
    int number = int.Parse(userInput);
 
    if (number >=1 & number <=7) 
    {
      if (number == 1)
      {
        Console.Write ("Понедельник");        
      }
      if (number == 2)
      {
        Console.Write ("Вторник");
      }
      if (number == 3)
      {
        Console.Write ("Среда");
      }
      if (number == 4)
      {
        Console.Write ("Четверг");          
      }
      if (number == 5)
      {
        Console.Write ("Пятница");          
      }
      if (number == 6)
      {
        Console.Write ("Субота - выходной");          
      }
          if (number == 7)
      {
        Console.Write ("Воскресенье - выходной");          
      }      
      break;
    }
    else
    {
      Console.WriteLine ("Ошибка ввода числа");
    }
  }

  }
}  