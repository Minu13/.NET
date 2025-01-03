using System;
class Hello
{


    static void Main(string[] userNames)
    {

        if (userNames.Length == 0)
        {
            Console.WriteLine("No arguments passed,pls pass argments");
            return;
        }
        foreach (string userName in userNames)
        {
            Console.WriteLine("Hello, " + userName + "! changed");
        }



    }
}