
Console.WriteLine("Hello!");
Console.WriteLine("Please enter the first number:");

string inputStr1 = Console.ReadLine();
int number1 = int.Parse(inputStr1);


Console.WriteLine("Please enter the second number:");
string inputStr2 = Console.ReadLine();
int number2 = int.Parse(inputStr2);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string operationChosen = Console.ReadLine();
Console.WriteLine("option chosen: {0}", operationChosen);

if (operationChosen != "A" && operationChosen != "a" && operationChosen != "S" && operationChosen != "s" && operationChosen != "M" && operationChosen != "m")
{
    Console.WriteLine("Invalid option!");
    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
}

int result;

if (EqualsCaseInsensitive(operationChosen, "A"))
{
    result = number1 + number2;
    Console.WriteLine("{0} + {1} = {2}", number1, number2, result);
    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
    return;

}
else if (EqualsCaseInsensitive(operationChosen, "S"))
{
    result = number1 - number2;
    Console.WriteLine("{0} - {1} = {2}", number1, number2, result);
    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
    return;

}
else if (EqualsCaseInsensitive(operationChosen, "M"))
{
    result = number1 * number2;
    Console.WriteLine("{0} * {1} = {2}", number1, number2, result);
    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
    return;

}

Console.ReadKey();

bool EqualsCaseInsensitive(string s1, string s2)
{
    //return s1.ToUpper().Equals(s2.ToUpper());
    return s1.ToUpper() == s2.ToUpper();
}