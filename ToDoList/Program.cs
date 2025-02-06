// .dll -> DLL = dynamic link library
// ctrl + R + R -> rename a variable

// alt + drag with the mouse -> select multiple lines

//Console.WriteLine("please provide a number");

//string input = Console.ReadLine();
//int number = int.Parse(input);
//Console.ReadKey();


Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs!");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]remove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();
Console.WriteLine("User input: " + userChoice);

//var result = Add(10, 5);
//Console.WriteLine("10 + 5 => " + result);

//var isLong = IsStringLong(userChoice);

//bool IsStringLong(string input)
//{
//    return input.Length > 10;
//}

//Console.WriteLine("abs sum:" + AbsoluteSum(10, 5));
//Console.WriteLine("abs sum: {0}", AbsoluteSum(-10, 5));

////userChoice = "AEIOU";
///
switch (userChoice)
{
    case "s":
    case "S":
        PrintSelectedOption("See all TODOs"); // arguments
        break;
    case "a":
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "r":
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "e":
    case "E":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;
}

//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs"); // arguments
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}

//var number = 0;

//while (number < 10)
//{

//    Console.WriteLine($"NUMBER IS {number}");
//    //number = number + 1;
//    //number += 1;
//    number++;
//}

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"hello from the loop {i}");
//}



// ARRAYS 

int[] numbers = new int[3]; // array of size 3

Console.WriteLine($"element at 0 position: {numbers[0]}");
Console.WriteLine($"element at 1 position: {numbers[1]}");
Console.WriteLine($"element at 2 position: {numbers[2]}");

Console.WriteLine("");

// to get the elements from the end use the ^ symbol:::
//int[] numbers1 = new int[5];
//numbers1[0] = 1;
//numbers1[1] = 3;
//numbers1[2] = 5;
//numbers1[3] = 7;
//numbers1[4] = 9;

//int[] numbers1 = new int[] {1, 3, 5, 7, 9};
int[] numbers1 = [1, 3, 5, 7, 9];

Console.WriteLine($"first element from the end: {numbers1[^1]}");
Console.WriteLine($"second element from the end: {numbers1[^2]}");

var sum = 0;
for (int i = 0; i < numbers1.Length; i++)
{
    Console.WriteLine(numbers1[i]);
    sum += numbers1[i];
}

Console.WriteLine($"sum is: {sum}");

void PrintSelectedOption(string selectedOption) // parameteres
{
    Console.WriteLine("selected option:" + selectedOption);
}

//int Add(int a, int b)
//{
//    return a + b;
//}

//int AbsoluteSum(int a, int b)
//{
//    return Math.Abs(a + b);
//}


// Multi-dimensional arrays

char[,] letters = new char[2, 3];

letters[0, 0] = 'a';
letters[0, 1] = 'b';
letters[0, 2] = 'c';
letters[1, 0] = 'd';
letters[1, 1] = 'e';
letters[1, 2] = 'f';

// declaring the values on array definition

var letters2 = new char[,]
{
    {'A', 'B', 'C' },
    {'D', 'E', 'F' },
};

// looping into an multi-dimensional array 
var height = letters.GetLength(0); // get first dimension
var width = letters.GetLength(1); // get second dimension

for (int i = 0; i < height; i++)
{
    Console.WriteLine($"First Dimension: {i}");
    for (int j = 0; j < width; j++)
    {
        Console.WriteLine($"Second Dimension: {j}");
        Console.WriteLine($"Position: {i},{j} | Element: {letters[i, j]}");

    }
}


// FOR-EACH LOOP

//string[] words = new string[] { "one", "two", "three", "four" };
string[] words = ["one", "two", "three", "four"];

//for (int i = 0;i < words.Length; i++)
//{
//    Console.WriteLine(words[i] );
//}

foreach (string word in words)
{
    Console.WriteLine(word);
}


// LISTS

List<string> words2 = new List<string>();

Console.WriteLine($"the count of elements in words2 list is: {words2.Count}");
words2.Add("one"); // use .Add to add items to the list
Console.WriteLine($"the count of elements in words2 list is: {words2.Count}");

//List<string> words3 = new List<string> {
//    "lol", "banana"
//};

var words3 = new List<string> {
    "lol", "banana"
};

foreach (string word in words3)
{
    Console.WriteLine(word);
}

Console.WriteLine("removing an item from words3");
words3.Remove("lol");
//words3.Add("strawberry");
//words3.Add("blueberry");
//words3.Add("watermelon");
words3.AddRange(["strawberry", "blueberry", "watermelon"]);
Console.WriteLine($"Index of element 'strawberry' is: {words3.IndexOf("strawberry")}");
Console.WriteLine($"Index of element 'kiwi' is: {words3.IndexOf("kiwi")}"); // -1
Console.WriteLine($"Contains 'blueberry'? {words3.Contains("blueberry")}"); // True
Console.WriteLine($"Contains 'kiwi'? {words3.Contains("kiwi")}"); // False


words3.RemoveAt(0); // Remove item at position 0

Console.ReadKey();