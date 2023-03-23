Console.Write("numberA = ");
string numberA = Console.ReadLine();
double number1 = double.Parse(numberA);

Console.Write("enter action: ");
string action = Console.ReadLine();

Console.Write("numberB = ");
string numberB = Console.ReadLine();
double number2 = double.Parse(numberB);

if (action.ToLower() == "+")
{
    Console.WriteLine(number1 + number2);
}
else 
{
    if (action.ToLower() == "-")
    {
        Console.WriteLine(number1 - number2);
    }
    else
    {
        if (action.ToLower() == "*")
        {
            Console.WriteLine(number1 * number2);
        }
        else
        {
            Console.WriteLine(number1 / number2);
        }
    }
}




