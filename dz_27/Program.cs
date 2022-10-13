// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 
// 452 -> 11
// 82 -> 10
// 9012 -> 12
 
using System;
 
class Program 
{
  static void Main (string[] args) 
  {
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Sum(number);
Console.Write("-> " + result);
//------------------------------------------------
int Sum (int number)
{
int sum = 0;
while(number > 10)
{
  int x = number % 10;
  sum = sum + x;
  number = number / 10;
}
sum = sum + number;
return sum;
}
  }
}