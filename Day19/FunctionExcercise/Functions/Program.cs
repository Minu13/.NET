using System;

class Program
{
    static void Main()
    {

        PrintName("Venkat", 5);
        bool result1 = CheckIsEvenNoV2(10);
        Console.WriteLine($"CheckIsEvennoV1 result is {result1}");

        Console.WriteLine(CheckIsEvenNoV1(13));

        //  Console.WriteLine(PrintName("Sachin",10));

        PrintTodayDate();

        string[] rrdFolks = GetAllRrdFolksNames();
        foreach (string name in rrdFolks)
        {
            Console.WriteLine(name);
        }

    }

    static string[] GetAllRrdFolksNames()
    {
        //string[] folks = new string[5];
        //folks[0] = "Venkat";
        //folks[1] = "Sachin";
        //folks[2] = "Minu";
        //folks[3] = "Markonda";
        //folks[4] = "Deepa";

        string[] folks = {
          "Venkat","Sachin","Minu","Markonda","Deepa"
        };
        return folks;


    }
    static void PrintTodayDate()
    {
        Console.WriteLine(DateTime.Now.ToString("HH:mm"));
    }

    static bool CheckIsEvenNoV1(int number)
    {
        if (number % 2 == 0)//modulus operator
        {
            return true;
        }
        return false;

    }

    static bool CheckIsEvenNoV2(int number)
    {
        return (number % 2 == 0);

    }
    static string CheckIsEvenNoV3(int number)
    {
        return (number % 2 == 0 ? "Its an Even" : "Its an Odd");

    }

    static void PrintName(string userName, int iterations)
    {

        for (int iteration = 1; iteration <= iterations; iteration++)
        {
            Console.WriteLine($"Hello {userName.ToUpper()}! {iteration}");
        }





    }

}