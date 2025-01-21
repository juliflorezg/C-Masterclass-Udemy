// .dll -> DLL = dynamic link library
// ctrl + R + R -> rename a variable

// alt + drag with the mouse -> select multiple lines

Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs!");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]remove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();
Console.WriteLine("User input: " + userChoice);

//userChoice = "AEIOU";

if (userChoice == "S")
{
    PrintSelectedOption("See all TODOs"); // arguments
} else if (userChoice == "A")
{ 
    PrintSelectedOption("Add a TODO");
} else if (userChoice == "R")
{ 
    PrintSelectedOption("Remove a TODO");
} else if (userChoice == "E")
{ 
    PrintSelectedOption("Exit");
}


void PrintSelectedOption(string selectedOption) // parameteres
{
    Console.WriteLine("selected option:" + selectedOption);
}


Console.ReadKey();  