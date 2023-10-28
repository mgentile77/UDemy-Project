using System;

Console.WriteLine("Hello!");
Console.WriteLine();
do {
    Console.WriteLine("What would you like to do");
    Console.WriteLine("[A]dd numbers");
    Console.WriteLine("[S]ubtract numbers");
    Console.WriteLine("[M]ultiply numbers");
    Console.WriteLine("[D]ivide numbers");
    Console.WriteLine("[E]xit");
    var userMathRequested = Console.ReadLine();
    var input = userMathRequested.ToUpper();
    if (input == "E")
    {
        break;
    }
    else if (input is "A" or "S" or "M" or "D")
    {
        Console.WriteLine("Input first number: ");
        var userInput1 = Console.ReadLine();
        var number1 = int.Parse(userInput1);
        Console.WriteLine("Input second number: ");
        var userInput2 = Console.ReadLine();
        var number2 = int.Parse(userInput2);
        string outputToUser = OutputToUser(number1, number2, input);
        Console.WriteLine(outputToUser);
    }
    else
    {
        Console.WriteLine("Input is invalid!");
    }
} while (true);
string OutputToUser(int num1, int num2, string typeMath)
{
    if (typeMath == "A")
    {
        var sum = num1 + num2;
        return num1 + "+" + num2 + "=" + sum;
    }
    else if (typeMath == "S")
    {
        var sum = num1 - num2;
        return num1 + "-" + num2 + "=" + sum;
    }
    else if (typeMath == "M")
    {
        var sum = num1 * num2;
        return num1 + "X" + num2 + "=" + sum;
    }
    else
    {
        var sum = num1 / num2;
        var remainder = num1 % num2;
        return num1 + "/" + num2 + "=" + sum + " R" + remainder;
    }
}

 
