Console.Clear();
Console.Write("Введите первое число: ");
string userInput_1 = Console.ReadLine() ??"";
double number1 = double.Parse(userInput_1);

Console.Write("Введите второе число: ");
string userInput_2 = Console.ReadLine() ??"";
double number2 = double.Parse(userInput_2);

if (number1 > number2)
{
    Console.WriteLine("max = "+ number1);
    Console.WriteLine("min = "+ number2);
}
else
{
    Console.WriteLine("max = "+ number2);
    Console.WriteLine("min = "+ number1);
}

