//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 
//14212 -> нет
//12821 -> да
//23432 -> да
 

int number;  
    
while (true)
{
  Console.Write("Введите число: ");
  if (int.TryParse(Console.ReadLine(), out number))
      break;
  Console.WriteLine($"Ошибка ввода!");
}
 
while (true)
{
  if (number >= 10000 & number < 100000)
  {
    int number1;
    int number2;
    number1 = number / 1000;
    number2 = number % 100;
    if ((number1 + 9) == number2)
    {
      Console.WriteLine ("--> Число является палиндромом" );
      break;
    }
    else
    {
      Console.WriteLine ("--> Число не является палиндромом" );
      break;
    }
  }
else
  {
    Console.WriteLine("Введено не корректное число");
    while (true)
    {
      Console.Write("Введите число: ");
      if (int.TryParse(Console.ReadLine(), out number))
          break;
      Console.WriteLine($"Ошибка ввода!");
    }
  }
}
