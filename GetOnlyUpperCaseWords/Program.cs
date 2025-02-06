/*
    Implement the GetOnlyUpperCaseWords method, which given a collection of strings, returns a List with only those strings which contain only uppercase letters.

The result collection should not contain duplicates.
 */

Console.WriteLine(string.Join(", ", GetOnlyUpperCaseWords(new List<string> { "one", "TWO", "THREE", "four" })));
Console.WriteLine(string.Join(", ", GetOnlyUpperCaseWords(new List<string> { "one", "TWO", "THREE", "four", "TWO" })));
Console.WriteLine(string.Join(", ", GetOnlyUpperCaseWords(new List<string> { "one", "TWO123", "THREE!&^", "four" })));


List<string> GetOnlyUpperCaseWords(List<string> words)
{
    List<string> result = new List<string>();

    foreach (var word in words)
    {
        //var shouldIcludeThisWord = true;
        //foreach (char character in word)
        //{
        //    if (!char.IsUpper(character)) shouldIncludeThisWord = false;
        //}
        if (ShouldIcludeThisWord(word) && !result.Contains(word)) {
            result.Add(word);
        }
    }

    return result;

}

bool ShouldIcludeThisWord(string word)
{

    foreach (char character in word)
    {
        if (!char.IsUpper(character)) { return false; }
    }
    return true;
}

Console.ReadKey();