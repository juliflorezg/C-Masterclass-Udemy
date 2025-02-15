
using System.Threading.Channels;

List<string> todoList = new List<string>();

//var userInput = PrintOptionsAndGetChoice();
//Console.WriteLine($"usr input: {userInput}");

PrintOptionsAndGetChoice();

//if ( userInput != null )
//{
//    Console.
//}

//switch (userInput)
//{
//    case "S":
//    case "s":
//        ShowAllTodos();
//        break;
//    case "A":
//    case "a":
//        todoList = AddTodo(todoList);
//        break;
//    case "R":
//    case "r":
//        ShowAllTodos();
//        break;
//    case "E":
//    case "e":
//        ShowAllTodos();
//        break;
//    default:
//        Console.WriteLine("no case for default! "); ;
//        break;
//}

void PrintOptionsAndGetChoice()
{
    string userChoice = "";
    do
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[S]ee all TODOs!");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]remove a TODO");
        Console.WriteLine("[E]xit");

        userChoice = Console.ReadLine();
        Console.WriteLine();
        //Console.WriteLine("User input: " + userChoice);
        //Console.WriteLine(userChoice == null);
        //Console.WriteLine(userChoice == "");


        if (userChoice == null || userChoice == "" || (
            !(userChoice == "S") && !(userChoice == "s") && !(userChoice == "A") && !(userChoice == "a") && !(userChoice == "R") && !(userChoice == "r") && !(userChoice == "E") && !(userChoice == "e")))
        {
            Console.WriteLine("Incorrect input.");
        }
    }
    while (!(userChoice == "S") && !(userChoice == "s") && !(userChoice == "A") && !(userChoice == "a") && !(userChoice == "R") && !(userChoice == "r") && !(userChoice == "E") && !(userChoice == "e"));


    //Console.WriteLine("User input: " + userChoice);

    //return userChoice;

    switch (userChoice)
    {
        case "S":
        case "s":
            ShowAllTodos("", 'S');
            break;
        case "A":
        case "a":
            todoList = AddTodo(todoList);
            break;
        case "R":
        case "r":
            RemoveATodo(todoList);
            break;
        case "E":
        case "e":
            ShowAllTodos("- See all Todos -", 'E');
            break;
        default:
            Console.WriteLine("no case for default! "); ;
            break;
    }
}

void ShowAllTodos(string message, char option)
{
    Console.WriteLine(message);

    if (todoList.Count == 0)
    {
        Console.WriteLine("No TODOS have been added yet. \n");
        PrintOptionsAndGetChoice();
    }
    else
    {
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoList[i]}.");
        }
        Console.WriteLine();
        if (option == 'R') return;
        PrintOptionsAndGetChoice();
    }
}

List<string> AddTodo(List<string> todoList)
{

    bool isDescriptionValid = false;

    string todoDescription = "";

    do
    {
        Console.WriteLine("Enter the TODO description:");
        todoDescription = Console.ReadLine();

        if (todoDescription == null || todoDescription == "")
        {
            Console.WriteLine("The description cannot be empty.");
        }
        else if (todoList.Contains(todoDescription))
        {
            Console.WriteLine("The description must be unique.");
        }

        if ((todoDescription != null || todoDescription != "") && !todoList.Contains(todoDescription))
        {
            isDescriptionValid = true;
        }

    } while (!isDescriptionValid);

    todoList.Add(todoDescription);
    Console.WriteLine($"TODO successfully added: {todoDescription}");
    PrintOptionsAndGetChoice();

    return todoList;
}
void RemoveATodo(List<string> todoList)
{
    
    if (todoList.Count == 0)
    {
        return;
    }

    bool isIndexANumber;
    int indexNumber;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        ShowAllTodos("", 'R');

        var todoIndexInput = Console.ReadLine();
        isIndexANumber = int.TryParse(todoIndexInput, out indexNumber);
        if (!isIndexANumber)
        {
            Console.WriteLine("The index you wrote is not a number, please try again.");
        }else if (!(indexNumber > 0 && indexNumber <= todoList.Count))
        {
            Console.WriteLine("The index is out of range, please try again.");
        }

    } while (!isIndexANumber || !(indexNumber > 0 && indexNumber <= todoList.Count));

    Console.WriteLine($"TODO removed: {todoList[indexNumber-1]}");
    todoList.RemoveAt(indexNumber - 1);

    PrintOptionsAndGetChoice();
    //return todoList;
}



Console.ReadKey();
