//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int varA;
int varB; 

while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine($"Ошибка ввода!");
}
Console.WriteLine($"A= {varA}");

if (varA > 100)
{
    while (varA > 1000)
    {
        varA = varA / 10; 
    }
varB = varA % 10;
Console.WriteLine("Третья цифра в числе: " + varB);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}




