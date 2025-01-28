// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(Factorial(0));
Console.WriteLine(Factorial(1));
Console.WriteLine(Factorial(4));
Console.WriteLine(Factorial(5));

static int Factorial(int number)
{
    if (number == 0 || number == 1)
    {
        return 1;
    }

    int result = 1;

    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;

}

Console.ReadKey();