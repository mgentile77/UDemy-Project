using System;

Console.WriteLine("Hello");
Console.WriteLine();
Console.WriteLine("What Would You Like To Do Today?");
Console.WriteLine();
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");
Console.WriteLine();

//reads line from console and assigns it to variable
var userChoice = Console.ReadLine().ToUpper();
//bool isLong = IsLong(userChoice);
switch (userChoice)
{
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}
//bool IsLong(string input)
//{
//    return input.Length >10;
//}

//Console.WriteLine("User input: " + userChoice);
//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs");
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

//todo: handle user input
Console.ReadKey();//preventing window from closing



void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}
