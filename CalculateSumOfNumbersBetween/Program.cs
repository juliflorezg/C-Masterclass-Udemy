// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine(CalculateSumOfNumbersBetween(5, 10));
Console.WriteLine(CalculateSumOfNumbersBetween(-5, 5));
Console.WriteLine(CalculateSumOfNumbersBetween(10, 10));



static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
{
    //your code goes here
    if (lastNumber < firstNumber) return 0;
    //if (firstNumber == lastNumber) return firstNumber;

    int result = 0;

    int counter = firstNumber;

    while (counter <= lastNumber)
    {
        result += counter;
        counter++;
    }

    //Console.WriteLine(result);
    return result;

}

Console.ReadKey();