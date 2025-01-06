using System;

class Program
{
    static void Main(string[] userNames)
    {
        if (userNames.Length == 0)
        {
            Console.WriteLine("No arguments passed, please pass arguments.");
            return;
        }
        PrintNamesStraight(userNames);

        Console.WriteLine();

        PrintNamesReverse(userNames);
    }

    // Function to print names in straight order
    static void PrintNamesStraight(string[] userNames)
    {
        foreach (string userName in userNames)
        {
            Console.WriteLine("Hello, " + userName);
        }
    }

    // Function to print names in reverse order
    static void PrintNamesReverse(string[] userNames)
    {
        for (int index = userNames.Length - 1; index >= 0; index--)
        {
            Console.WriteLine("Hello, " + userNames[index].ToUpper());
        }
    }
}
