using System;

class Program
{
    static void Main()
    {
        string name = "minu";
        int iterations = 5;
                
        PrintNameIteratively(name, iterations);

        Console.WriteLine(); 

        PrintNameRecursively(name, iterations);
    }

    // Iterative approach to print the name
    static void PrintNameIteratively(string userName, int iterations)
    {
        // Loop from 1 to the number of iterations
        for (int iteration = 1; iteration <= iterations; iteration++)
        {
            Console.WriteLine($"Hello {userName.ToUpper()}! {iteration}");
        }
    }

    // Recursive approach to print the name
    static void PrintNameRecursively(string userName, int iterations)
    {
        // Base case: if iterations is 0, stop the recursion
        if (iterations > 0)
        {
            Console.WriteLine($"Hello {userName.ToUpper()}! {iterations}");

            // Recursively call the method with iterations - 1
            PrintNameRecursively(userName, iterations - 1);
        }
    }
}
