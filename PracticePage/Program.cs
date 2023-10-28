using System;

//var number = 0;

//while (number < 10)
//{
//    number ++;
//    Console.WriteLine($"Number is {number}");
//}
//Console.WriteLine("The Loop is finished.");

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Loop run {i}!");
//}

//for(var i = 0; i < 100;i++)
//{
//    Console.WriteLine($"i is {i}");
//    if (i > 25) { break; }
//}
//int userNumber;
//do
//{
//    Console.WriteLine("Enter a number Larger Than 10: ");
//    var userInput = Console.ReadLine();
//    if (userInput == "stop")
//    {
//        break;
//    }
//    bool isParseableToInt = userInput.All(char.IsDigit);
//    if (isParseableToInt)
//    {
//        userNumber = 0;
//        continue;
//    }
//    userNumber = int.Parse(userInput);
//} while (userNumber < 10);

//for(var i = 0; i < 20; i++)
//{
//    if (i % 3 == 0)
//    {
//        continue;
//    }
//    Console.WriteLine($"i is {i}");
//}


//for (int i = 0; i < 4; i++)
//{
//    for(int j = 0; j < 3; j++)
//    {
//        for(int k = 0; k < 2; k++)
//        {
//            Console.WriteLine($"i is {i} and j is {j} and k is {k}");
//        }
//    }
//}

//int[] numbers = new int[3];

//numbers[0] = 5;
//numbers[1] = 6;
//numbers[2] = 7;

//Console.WriteLine();
//Console.WriteLine($"Element at index 0 is {numbers[0]}");
//Console.WriteLine($"Element at index 1 is {numbers[1]}");
//Console.WriteLine($"Element at index 2 is {numbers[2]}");

//var sum = 0;
//int[] newNumbers = new [] {2,3,1,6,19};
//for(var i = 0; i < newNumbers.Length; i++)
//{
//    sum += newNumbers[i];
//    Console.WriteLine($"the current sum of this loop is {sum}");
//}
//Console.WriteLine($"sum of elements is {sum}");



//var words = new[] { "one", "two", "three", "four" };

//for (int i = 0; i < words.Length; i++)
//{
//    Console.WriteLine(words[i]);
//}

//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}


List<string> words = new List<string>();
Console.WriteLine($"Count of elements is {words.Count}");
words.Add("hello");//Add an item to a list
Console.WriteLine($"Count of elements is {words.Count}");


List<string> words2 = new List<string>
{
    "one",
    "two"
};
Console.WriteLine($"Count of elements is {words2.Count}");
foreach(var  word in words2)
{
    Console.WriteLine(word);
}
Console.WriteLine("Adding elements to a list");
Console.WriteLine();
words2.Add("twenty-two");
Console.WriteLine($"Count of elements is {words2.Count}");
foreach (var word in words2)
{
    Console.WriteLine(word);
}
Console.WriteLine();
Console.WriteLine("Removing an item from a list.");
words2.Remove("two");
Console.WriteLine($"Count of elements is {words2.Count}");
foreach (var word in words2)
{
    Console.WriteLine(word);
}
words.AddRange(new[] { "three", "five", "sixty" });
Console.WriteLine($"Count of elements is {words2.Count}");
foreach (var word in words2)
{
    Console.WriteLine(word);
}
words.RemoveAt(0);
Console.WriteLine($"Count of elements is {words2.Count}");
foreach (var word in words2)
{
    Console.WriteLine(word);
}
Console.WriteLine($"Index of of element sixty is {words.IndexOf("sixty")}");
Console.WriteLine($"Count of elements is {words2.Count}");
foreach (var word in words2)
{
    Console.WriteLine(word);
}
Console.WriteLine($"Contains 'three'?: {words.Contains("three")}");








Console.WriteLine("The Loop is finished.");
Console.ReadKey();//preventing window from closing

