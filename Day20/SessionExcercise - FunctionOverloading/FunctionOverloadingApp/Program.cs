using System;

class Program
{


    static void Main()
    {

        //PrintInfo("Akhilesh");
        //PrintInfo('@');
        //PrintInfo(10);
        //PrintInfo(10.5f);
        //PrintInfo(10.5d);
        //PrintInfo(10.5M);



        PrintInfo(10);
        PrintInfo(10.55f);
        PrintInfo(10.55d);
        PrintInfo(10.55M);
        PrintInfo('a');
        PrintInfo('A');

    }

    static void PrintInfo(int input)
    {
        Console.WriteLine("Overload int  #1");
        Console.WriteLine(sizeof(int));
        Console.WriteLine("input value  is " + input + " and size is " + sizeof(int));
        Console.WriteLine("input value  is : {0} and size is {1}", input, sizeof(int));
        Console.WriteLine($"intput is value i {input} and int size is {sizeof(int)}");
    }

    static void PrintInfo(float input)
    {
        Console.WriteLine("Overload float #2");
        Console.WriteLine($"intput is value i {input} and float size is {sizeof(float)}");
    }

    static void PrintInfo(double input)
    {
        Console.WriteLine("Overload double #3");
        Console.WriteLine($"intput is value i {input} and double size is {sizeof(double)}");
    }

    static void PrintInfo(decimal input)
    {
        Console.WriteLine("Overload decimal #4");
        Console.WriteLine($"intput is value i {input} and decimal size is {sizeof(decimal)}");
    }

    static void PrintInfo(char input)
    {
        //ascii value of char

        Console.WriteLine("Overload char #5");
        Console.WriteLine($"intput is value i {input} and char size is {sizeof(char)} ");
        Console.WriteLine($"ascii value is {(int)input} ");
    }


    //static char PrintInfo(char input)//not an overload
    //{
    //    //ascii value of char

    //    Console.WriteLine("Overload char #5");
    //    Console.WriteLine($"intput is value i {input} and char size is {sizeof(char)} ");
    //    Console.WriteLine($"ascii value is {(int)input} ");

    //    return input;
    //}



}