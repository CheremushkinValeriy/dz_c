Console.Clear();
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);

int i = 0;

while (i < number)
{
    if (i % 2 == 0)
    {
        i += 1;
    }
    else
    {
        i += 1;
        Console.Write(i +",");
    }
}



