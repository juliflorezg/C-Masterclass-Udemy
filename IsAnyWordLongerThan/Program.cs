/*
    Using the foreach loop, implement the IsAnyWordLongerThan method, 
    which given a length and an array of words, returns true if 
    any of those words is longer than the given length, and false otherwise.
 */

Console.WriteLine(IsAnyWordLongerThan(4, new string[]{ "aaa", "bbbb", "ccccc"}));
Console.WriteLine(IsAnyWordLongerThan(5, ["aaa", "bbbb", "ccccc"]));
Console.WriteLine(IsAnyWordLongerThan(5, []));

bool IsAnyWordLongerThan(int length, string[] words)
{
    foreach(var word in words)
    {
        if (word.Length > length) return true;
    }

    return false;
}

Console.ReadKey();