
class Hello
{
    static void Main(string[] userNames)
    {
        if (userNames.Length == 0)
        {
            Console.WriteLine("No arguments passed, pls pass arguments");
            return;
        }

        foreach (string userName in userNames)
        
        { 
            Console.WriteLine("Hello, " + userName ); 
        }

        Console.WriteLine();

        for (int index = userNames.Length - 1; index >= 0; index--)
        {
            Console.WriteLine("Hello, " + userNames[index].ToUpper());
        }
    }
}


