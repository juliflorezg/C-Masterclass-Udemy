/*
 Implement the IsWordPresentInCollection method, which
 given an array of words and a wordToBeChecked, returns
 true if wordToBeChecked is present in this collection and
 false otherwise.
 */

static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
{

    //foreach (string word in words) { 
    //    if (wordToBeChecked.Contains(word)) return true; 
    //}

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i] == wordToBeChecked)
        {
            return true;
        }
    }
    return false;
}