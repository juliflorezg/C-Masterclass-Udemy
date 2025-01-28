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

var number = 0;

while (number < 10)
{

    Console.WriteLine($"NUMBER IS {number}");
    //number = number + 1;
    //number += 1;
    number++;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"hello from the loop {i}");
}


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



Console.ReadKey();