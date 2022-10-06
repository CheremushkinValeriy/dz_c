//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


while(true)
{
    Console.Write("Введите число: ");
    string userInput = Console.ReadLine() ??"";
    int number = int.Parse(userInput);

    if (number >= 100 & number < 1000) 
        {
            Console.WriteLine($"Число = {number}");
            int a1 = number / 10;
            int a2 = a1 % 10;
            Console.WriteLine($"Вротая цифра в числе {number} -> {a2}");
            break;
        }
    else
    {
        Console.Write("Введено не корректное число --> ");
    }



}

    

 