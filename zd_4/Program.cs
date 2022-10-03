Console.Clear();

Console.Write("Введите первое число: ");
string userInput_1 = Console.ReadLine() ??"";
double number1 = double.Parse(userInput_1);

Console.Write("Введите второе число: ");
string userInput_2 = Console.ReadLine() ??"";
double number2 = double.Parse(userInput_2);
 
Console.Write("Введите третье число: ");
string userInput_3 = Console.ReadLine() ??"";
double number3 = double.Parse(userInput_3);

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine("max = "+ number1);
}
else
{
    if (number2 > number3)
    {
        Console.WriteLine("max = "+ number2); 
    }
    else
    {
        Console.WriteLine("max = "+ number3); 
    }
}
 
