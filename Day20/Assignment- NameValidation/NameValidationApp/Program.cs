using System;

class Program
{
    static void Main()
    {
        string name;
        bool isValid;

        do
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            isValid = IsValidName(ref name); // Passing by reference
            DisplayMessage(isValid);
        } while (!isValid);
    }

    static bool IsValidName(ref string name)
    {
        foreach (char c in name)
        {
            if (!IsLetter(c))
            {
                name = "Invalid name! Special characters, spaces, or numbers are not allowed.";
                return false;
            }
        }
        name = "Valid name!";
        return true;
    }

    static bool IsLetter(char c)
    {
        // ASCII values for uppercase letters: 65-90
        // ASCII values for lowercase letters: 97-122
        return (c >= 65 && c <= 90) || (c >= 97 && c <= 122);
    }

    static void DisplayMessage(bool isValid)
    {
        Console.WriteLine(isValid ? "Valid name!" : "Invalid name! Special characters, spaces, or numbers are not allowed.");
    }
}
