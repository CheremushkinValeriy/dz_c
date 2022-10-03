Console.Clear();
Console.Write("Введите число: ");
string userInput_1 = Console.ReadLine() ??"";
double number1 = double.Parse(userInput_1);
 
if (number1 %2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}