using System;
using System.Collections.Generic;

namespace SimpleFunctionApp
{
    class Program
    {
        static void Main()
        {
            string[] inputArray = { "abc.edu", "pqr.com", "oop.str" };
            List<string> outputList = SplitAfterDot(inputArray);

            foreach (string str in outputList)
            {
                Console.WriteLine(str);
            }
        }

        static List<string> SplitAfterDot(string[] inputArray)
        {
            List<string> result = new List<string>();

            foreach (string str in inputArray)
            {

                int dotPosition = -1;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '.')
                    {
                        dotPosition = i;
                        break;
                    }
                }

                if (dotPosition != -1)
                {
                    result.Add(str.Substring(dotPosition + 1));
                }
            }

            return result;
        }
    }
}
