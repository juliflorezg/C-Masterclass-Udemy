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
    
if (userChoice?.Length  == 0)
{
    Console.WriteLine("empty choice");
    int number = 3;
    Console.WriteLine(number);
} else
{
    Console.WriteLine("non-empy value");
    //Console.WriteLine(number); //! not valid, number variables is not present in this scope

}


Console.ReadKey(); 