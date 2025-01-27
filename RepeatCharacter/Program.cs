// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(RepeatCharacter('a', 4));
Console.WriteLine(RepeatCharacter('!', 0));
Console.WriteLine(RepeatCharacter('b', 1));
Console.WriteLine(RepeatCharacter('c', -1));


static string RepeatCharacter(char character, int targetLength)
{
    //your code goes here

    string result = "";
    do
    {
        result += character.ToString();
    } while (result.Length < targetLength);

    return result;
}
Console.ReadKey();